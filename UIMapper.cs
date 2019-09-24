using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuildObjects.Enums;
using BuildObjects.MapObjects;
using MockDataGenerator.Enums;
using MockDataGenerator.Interfaces;
using MockDataGenerator.SpecialObjects;
using MockDataGenerator.UIServices;
using MockDataGenerator.Utility;

namespace MockDataGenerator
{
    public partial class UIMapper : Form
    {
        bool _autoMap = false;
        public MethodParameterMap MethodMap { private set; get; }
        private string _className;
        private MapedObject _aMap;
        public static List<IDataRule> RuleSets { set; get; }
        public static MapedObject Result { set; get; }         
        private DataMapType currentMode = DataMapType.None;        
        bool allowSwitching = false;
        bool blockSwitching = false;

        public bool AutoMap
        {
            set
            {
                _autoMap = value;
                if (value)
                    AutoMapping();
            }

            get
            {
                return _autoMap;
            }
        }

        public UIMapper()
        {
            RuleSets = new List<IDataRule>();
            Result = null;
        }

        public UIMapper(MapedObject review, MethodParameterMap methodMap, DataMapType mode)
            :this()
        {
            UIMappEdit(review, methodMap, mode);
        }
        /// <summary>
        /// This allows for an existing map to be edited
        /// </summary>
        /// <param name="review"></param>
        /// <param name="_rules"></param>
        /// <param name="methodName"></param>
        /// <param name="paramCount"></param>
        /// <param name="mode"></param>
        public UIMapper(MapedObject review, List<IDataRule> _rules, MethodParameterMap methodMap, DataMapType mode)
            : this()
        {
            
            if (_rules.Count > 0)
            {
                _aMap = review;
                MethodMap = methodMap;
                lblMethodName.Text = methodMap.MethodName;
                lblClassName.Text = review.ClassName;
                //var aMethod = review.MethodParameters.Where(x => x.MethodName.Equals(methodName) && x.ID == id).FirstOrDefault();
                LoadParameterMaps(methodMap.ParameterMaps, _rules);
                SetDisplayMode(mode);
            }           
        }

        private void UIMappEdit(MapedObject review, MethodParameterMap methodMap, DataMapType mode)
        {
            InitializeComponent();
            _aMap = review;
            MethodMap = methodMap;
            if(methodMap != null)
                lblMethodName.Text = methodMap.MethodName;
            lblClassName.Text = review.ClassName;

            switch (mode)
            {
                case DataMapType.PropertyColumnMap:

                    LoadColumnsFromMap(review.PropMaps);
                    break;

                case DataMapType.FieldColumnMap:
                    LoadColumnsFromMap(review.FieldMaps);
                    break;

                case DataMapType.MethodParameterMap:

                    //var method = review.MethodParameters.Where(x => x.MethodName.Equals(methodName) && x.ID == id).FirstOrDefault();
                    if (methodMap != null)
                    {
                        if (methodMap.ParameterMaps.Any())
                        {
                            //LoadParameterMaps(method.ParameterMaps)
                        }
                        else if (methodMap.ColumnParameterMaps.Any())
                            LoadColumnsFromMap(methodMap.ColumnParameterMaps);
                    }
                    break;
            }

            allowSwitching = true;
            SetDisplayMode(mode);
        }

        public UIMapper(MapedObject aMap, ListView.SelectedListViewItemCollection objectView, DataGridViewSelectedRowCollection  dataRows, DataMapType displayMode)
            : this()
        {
            InitializeComponent();
            _aMap = aMap;            
            lblClassName.Text = aMap.ClassName;
            LoadFromDataGrid(dataRows);
            LoadTargetFieldsOrProperties(objectView);            
            Result = null;
            SetDisplayMode(displayMode);
        }
        
        public UIMapper(MapedObject aMap, string methodName, List<Parameters> objectView, DataGridViewSelectedRowCollection dataRows, DataMapType displayMode)
            : this()
        {
            InitializeComponent();
            lblMethodName.Text = methodName;
            lblClassName.Text = aMap.ClassName;
            LoadFromDataGrid(dataRows);            
            LoadTargetParameters(objectView);
            _aMap = aMap;            
           Result = null;           
           SetDisplayMode(displayMode);
        }
        
        private void AutoMapping()
        {            
            var datasource = lstDataSource.Items.Cast<ListViewItem>();
            foreach (ListViewItem aItem in lstObjectTarget.Items)
            {
                var found = datasource.Where(x=>x.SubItems[1].Text.ToLower().Equals(aItem.SubItems[1].Text.ToLower())).FirstOrDefault();
                if (found != null)
                    lstMappedPairs.Items.Add(new ListViewItem(new string[] { found.SubItems[1].Text, aItem.SubItems[1].Text, found.SubItems[0].Text, found.SubItems[2].Text, aItem.SubItems[0].Text.Contains("Nullable").ToString() }));
                else
                    aItem.BackColor = Color.Red;
            }

            lblTotalMapped.Text = lstMappedPairs.Items.Count.ToString();
        }

        private void SetDisplayMode(DataMapType displayMode)
        {
            switch(displayMode)
            {
                case DataMapType.FieldColumnMap:
                    rbModeFields.Checked = true;
                    break;

                //case ObjectModes.RuleBased:
                case DataMapType.MethodParameterMap:
                    rbModeParameters.Checked = true;
                    break;

                case DataMapType.PropertyColumnMap:
                    rbModeProp.Checked = true;
                    break;
            }

            currentMode = displayMode;
        }        

        private void LoadTargetParameters(List<Parameters> ObjectView)
        {
            foreach(Parameters aSet in ObjectView)
            {
                ListViewItem newItem = new ListViewItem(new string[] { aSet.DataTypeName, aSet.ParameterName });
                lstObjectTarget.Items.Add(newItem);
            }

            lblTargetTotal.Text = ObjectView.Count.ToString();
        }

        private void LoadTargetFieldsOrProperties(ListView.SelectedListViewItemCollection ObjectView)
        {
            foreach (ListViewItem anItem in ObjectView)
            {
                var details = (PropertyInfo)anItem.Tag;               
                ListViewItem newItem = new ListViewItem(new string[] { anItem.SubItems[1].Text, anItem.SubItems[0].Text });
                lstObjectTarget.Items.Add(newItem);
            }

            lblTargetTotal.Text = ObjectView.Count.ToString();
        }

        private void LoadColumnsFromMap(List<PropertyColumnMap> loadBoth)
        {
            foreach(PropertyColumnMap aMap in loadBoth)
            {
                AddToDataSourceList(aMap);
                AddToTargetObjectList(aMap.PropertyName, aMap.DataType);
                AddToMapList(aMap);
            }

            Totals(loadBoth.Count);
        }

        private void LoadColumnsFromMap(List<FieldColumnMap> loadBoth)
        {
            foreach (FieldColumnMap aMap in loadBoth)
            {
                AddToDataSourceList(aMap);
                AddToTargetObjectList(aMap.FieldName, aMap.DataType);
                AddToMapList(aMap);
            }

            Totals(loadBoth.Count);
        }

        private void LoadParameterMaps(List<ParameterMap> parameters, List<IDataRule> _rules)
        {
            foreach(ParameterMap aMap in parameters)
            {
                IDataRule aRule = _rules.Where(x => x.FieldName.Equals(aMap.ParameterName)).FirstOrDefault();
                AddToTargetObjectList(aMap.ParameterName, aMap.DataType);
                AddToDataSourceList(aMap);
                AddToMapList(aMap);
            }

            Totals(parameters.Count);
        }

        private void LoadColumnsFromMap(List<ParameterColumnMap> loadBoth)
        {
            foreach (ParameterColumnMap aMap in loadBoth)
            {
                AddToDataSourceList(aMap);
                AddToTargetObjectList(aMap.ParameterName, aMap.DataType);
                AddToMapList(aMap);
            }

            Totals(loadBoth.Count);
        }

        private void Totals(int count)
        {
            lblTargetTotal.Text = count.ToString();
            lblTotalMapped.Text =count.ToString();
        }

        private void AddToMapList(FieldColumnMap aMap)
        {
            var newPair = new ListViewItem(new string[] { aMap.ColumnName, aMap.FieldName, aMap.DataType, aMap.IsNullable.ToString(), aMap.IsNullable.ToString() });
            lstMappedPairs.Items.Add(newPair);
        }

        private void AddToMapList(PropertyColumnMap aMap)
        {
            var newPair = new ListViewItem(new string[] { aMap.ColumnName, aMap.PropertyName, aMap.DataType, aMap.IsNullable.ToString(), aMap.IsNullable.ToString() });
            lstMappedPairs.Items.Add(newPair);
        }

        private void AddToMapList(ParameterColumnMap aMap)
        {
            var newPair = new ListViewItem(new string[] { aMap.ColumnName, aMap.ParameterName, aMap.DataType, aMap.IsNullable.ToString(), aMap.IsNullable.ToString() });
            lstMappedPairs.Items.Add(newPair);
        }

        private void AddToMapList(ParameterMap aMap)
        {
            var newPair = new ListViewItem(new string[] { aMap.ParameterName, aMap.ParameterName, aMap.DataType, aMap.IsNullable.ToString(), aMap.IsNullable.ToString() });
            lstMappedPairs.Items.Add(newPair);
        }

        private void AddToTargetObjectList(string label, string dataType)
        {
            ListViewItem newItem = new ListViewItem(new string[] { dataType, label });
            lstObjectTarget.Items.Add(newItem);
        }
        private void AddToDataSourceList(ColumnMap aMap)
        {
            ListViewItem newItem = new ListViewItem(new string[] { aMap.DataType, aMap.ColumnName, aMap.IsNullable.ToString()});
            lstDataSource.Items.Add(newItem);
        }

        private void AddToDataSourceList(ParameterMap aMap)
        {
            ListViewItem newItem = new ListViewItem(new string[] { aMap.DataType, aMap.ParameterName, aMap.IsNullable.ToString() });
            lstDataSource.Items.Add(newItem);
        }

        private void LoadFromDataGrid(DataGridViewSelectedRowCollection dataRows)
        {
            if (dataRows.Count > 0)
            {
                int typeIndex = -1;
                int nullIndex = -1;
                foreach (DataGridViewCell aCell in dataRows[0].Cells)
                {
                    if (aCell.DataGridView.Columns[aCell.ColumnIndex].Name.ToLower().Contains("type"))
                    {
                        typeIndex = aCell.ColumnIndex;                        
                    }
                    else if(aCell.DataGridView.Columns[aCell.ColumnIndex].Name.ToLower().Contains("null"))
                    {
                        nullIndex = aCell.ColumnIndex;
                    }
                }
                foreach (DataGridViewRow aRow in dataRows)
                {
                    ListViewItem newItem = new ListViewItem(new string[] { aRow.Cells[typeIndex].Value.ToString(), aRow.Cells[0].Value.ToString(), aRow.Cells[nullIndex].Value.ToString() });
                    lstDataSource.Items.Add(newItem);
                }
            }
            else
            {                
                groupBox1.Text = "Rule Based Dataset";
                lstDataSource.Columns[0].Text = "DataType";
                lstDataSource.Columns[1].Text = "RuleType";
                lstDataSource.Columns[2].Text = "Description";
                lstMappedPairs.Columns[0].Text = "RuleType";
                lstMappedPairs.Columns.Add("Description");
                lstMappedPairs.Columns[4].Text = "Description"; 
            }
        }

        private void ResizeListViewColumns(ListView lv)
        {
            foreach (ColumnHeader column in lv.Columns)
            {
                column.Width = -2;
            }
        }
        private void Initialize()
        {
            ResizeListViewColumns(this.lstObjectTarget);
            ResizeListViewColumns(this.lstDataSource);
            ResizeListViewColumns(this.lstMappedPairs);            
        }

        private void lstObjectTarget_ItemDrag(object sender, ItemDragEventArgs e)
        {
            lstObjectTarget.DoDragDrop(e.Item, DragDropEffects.Copy);
        }

        private void lstObjectTarget_DragDrop(object sender, DragEventArgs e)
        {
            LoadPairs(lstObjectTarget, e, DragedFrom.DataSource);
        }

        private void lstDataSource_DragDrop(object sender, DragEventArgs e)
        {
            LoadPairs(lstDataSource, e, DragedFrom.ObjectTarget);
        }

        private void LoadPairs(ListView parent, DragEventArgs e, DragedFrom whoDidIt)
        {
            ListViewHitTestInfo hitItem = parent.HitTest(parent.PointToClient(new Point(e.X, e.Y)));
            ListViewItem dragedItem = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
            ListViewItem newPair = null;
            bool duplicate = false;
            string fieldName = String.Empty;
            string fieldNullable = String.Empty;
            if (parent.Equals(dragedItem.ListView) || hitItem.Item == null) return;
            switch(whoDidIt)
            {
                case DragedFrom.DataSource:
                    fieldName = hitItem.Item.SubItems[1].Text;
                    fieldNullable = hitItem.Item.SubItems[0].Text.Contains("Nullable").ToString();
                    duplicate = DuplicateEntry(fieldName);                    
                    if (!duplicate)
                    {
                        //if (dragedItem.Tag.GetType().BaseType.Equals(typeof(BaseRule)))
                        if(ValidateIfRuleType(dragedItem.Tag))
                        {
                            newPair = new ListViewItem(new string[] { dragedItem.SubItems[1].Text, fieldName, hitItem.Item.SubItems[0].Text, "false", dragedItem.SubItems[2].Text, fieldNullable });
                            newPair.Tag = ((BaseRule)dragedItem.Tag).Clone();
                            ((BaseRule)newPair.Tag).FieldName = fieldName;
                            ((BaseRule)newPair.Tag).FieldDataType = hitItem.Item.SubItems[0].Text;
                            if (newPair.Tag.GetType().Name.Equals("MultiFieldDataSourceRule"))
                            {
                                DisplayColumnsToMap((MultiFieldDataSourceRule)newPair.Tag, fieldName);
                            }
                        }
                        else
                            newPair = new ListViewItem(new string[] { dragedItem.SubItems[1].Text, fieldName, dragedItem.SubItems[0].Text, dragedItem.SubItems[2].Text, fieldNullable });
                    }
                    break;

                case DragedFrom.ObjectTarget:
                    fieldName = dragedItem.SubItems[1].Text;
                    fieldNullable = dragedItem.SubItems[0].Text.Contains("Nullable").ToString();
                    duplicate = DuplicateEntry(fieldName);
                    if (!duplicate)
                    {
                        //if (hitItem.Item.Tag.GetType().BaseType.Equals(typeof(BaseRule)))
                        if (ValidateIfRuleType(hitItem.Item.Tag))
                        {
                            newPair = new ListViewItem(new string[] { hitItem.Item.SubItems[1].Text, fieldName, dragedItem.SubItems[0].Text, "false", hitItem.Item.SubItems[2].Text, fieldNullable });
                            newPair.Tag = ((BaseRule)hitItem.Item.Tag).Clone();
                            ((BaseRule)newPair.Tag).FieldName = fieldName;
                            ((BaseRule)newPair.Tag).FieldDataType = dragedItem.SubItems[0].Text;
                            if(newPair.Tag.GetType().Name.Equals("MultiFieldDataSourceRule"))
                            {
                                DisplayColumnsToMap((MultiFieldDataSourceRule)newPair.Tag, fieldName);
                            }
                        }
                        else
                            newPair = new ListViewItem(new string[] { hitItem.Item.SubItems[1].Text, fieldName, hitItem.Item.SubItems[0].Text, hitItem.Item.SubItems[2].Text, fieldNullable });
                    }                  
                    break;
            }            
            
            if(duplicate)
                MessageBox.Show(String.Format("A field named {0} already exists in the mapping grid.", fieldName));
            else
                lstMappedPairs.Items.Add(newPair);

            lblTotalMapped.Text = lstMappedPairs.Items.Count.ToString();
        }

        private bool DisplayColumnsToMap(MultiFieldDataSourceRule mapRule, string fieldName)
        {
            bool result = false;
            RuleSourceMapDialog mappIt = new RuleSourceMapDialog();
            mappIt.RuleDescription = mapRule.Description;
            mappIt.LoadDataFields(mapRule.FieldColumnMap, fieldName);
            result = mappIt.ShowDialog() == DialogResult.OK;
            return result;
        }

        private bool ValidateIfRuleType(Object tag)
        {
            return tag != null ? tag.GetType().BaseType.Name.Contains("Rule") : false;
        }

        private bool DuplicateEntry(String fieldName)
        {
            bool result = false;
            foreach(ListViewItem anItem in lstMappedPairs.Items)
            {
                if(anItem.SubItems[1].Text.Equals(fieldName))
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        private void lstDataSource_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void lstObjectTarget_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void lstDataSource_ItemDrag(object sender, ItemDragEventArgs e)
        {
            lstDataSource.DoDragDrop(e.Item, DragDropEffects.Copy);
        }

        private string FindFieldTypes(FieldTypes aField)
        {
            int count = 1;
            foreach(ListViewItem aItem in lstDataSource.Items)
            {
                if (aItem.SubItems[1].Text.Equals(aField.ToString()))
                    count++;
            }

            return count.ToString();
        }
        private void AddRule(FieldTypes aField)
        {
            
            switch(aField)
            {
                default:
                    FieldSettings setAField = new FieldSettings(aField);

                    if (setAField.ShowDialog() == DialogResult.OK)
                    {
                        AddRule(FieldSettings.Result);
                    }
                    break;

                //case FieldTypes.MappedSource:
                 //   break;

                case FieldTypes.Collection:
                    CollectionDialog collections = new CollectionDialog();

                    if (collections.ShowDialog() == DialogResult.OK)
                    {
                        AddRule(CollectionDialog.Result);
                    }
                    break;

                case FieldTypes.Imported:
                case FieldTypes.MultiColumn:
                    DataFileDialog dataFile = new DataFileDialog();
                    if(dataFile.ShowDialog() == DialogResult.OK)
                    {
                        AddRule(DataFileDialog.Result);
                    }
                    break;

                case FieldTypes.Tuple:
                    TupleDialog tuple = new TupleDialog();
                    if(tuple.ShowDialog() == DialogResult.OK)
                    {
                        AddRule(TupleDialog.Result);
                    }
                    break;
            }            
        }

        private void EditRule(IDataRule aRule, ListViewItem source)
        {
            
            switch (aRule.RuleType)
            {
                default:
                    FieldSettings setAField = new FieldSettings(aRule);

                    if (setAField.ShowDialog() == DialogResult.OK)
                    {
                        source.Tag = FieldSettings.Result;
                    }
                    break;

                //case FieldTypes.MappedSource:
                 //   break;

                case FieldTypes.Collection:
                    CollectionDialog collections = new CollectionDialog(aRule);

                    if (collections.ShowDialog() == DialogResult.OK)
                    {
                        source.Tag =  CollectionDialog.Result;
                    }
                    break;

                case FieldTypes.Imported:
                case FieldTypes.MultiColumn:
                    DataFileDialog dataFile = new DataFileDialog(aRule);
                    if (dataFile.ShowDialog() == DialogResult.OK)
                    {
                        source.Tag = DataFileDialog.Result;
                    }
                    break;

                case FieldTypes.Tuple:
                    TupleDialog tuple = new TupleDialog(aRule);
                    if (tuple.ShowDialog() == DialogResult.OK)
                    {
                        source.Tag = TupleDialog.Result;
                    }
                    break;
            }
        }
    

        private void EditRuleOnMap()
        {
            IDataRule aRule = null;
            if (lstMappedPairs.SelectedItems != null && lstMappedPairs.SelectedItems.Count > 0)
            {                
                aRule = (IDataRule)lstMappedPairs.SelectedItems[0].Tag;
            }
           
            if(aRule != null)
            {
                EditRule(aRule, lstMappedPairs.SelectedItems[0]);
            }
        }

        private void numberRangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRule(FieldTypes.Number);
        }        
        

        private void guidToolStripMenuItem_Click(object sender, EventArgs e)
        {
           IDataRule aGuid = BuildRules.InitializeBase(FieldTypes.GUID, false, "NA", "NA", false);
            aGuid.Description = "Guid-1";
            AddRule(aGuid);
        }

        private void AddRule(IDataRule aRule)
        {
            string[] info = new string[3];
            info[0] = aRule.FieldDataType;
            info[1] = Enum.GetName(typeof(FieldTypes), aRule.RuleType);
            info[2] = aRule.Description;
            ListViewItem aItem = new ListViewItem(info);
            lstDataSource.Items.Add(aItem).Tag = aRule;
        }

        private void stringFormatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRule(FieldTypes.String);
        }

        private void internalDataListsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRule(FieldTypes.MultiColumn);
        }

        private void lstObjectTarget_DoubleClick(object sender, EventArgs e)
        {
            //IEnumerable<Form> forms = this.OwnedForms.Where(x => x.Text.Equals("Field Settings"));
            //if (!forms.Any())
            //{
            //    FieldSettings showSettings = new FieldSettings();
            //    this.AddOwnedForm(showSettings);
            //    showSettings.Show();
            //}
            //else
            //    forms.First().Show();
        }

        private void mnuSaveMap_Click(object sender, EventArgs e)
        {
            int paramCount = lstMappedPairs.Items.Count;
            foreach (ListViewItem aItem in lstMappedPairs.Items)
            {
                switch(currentMode)
                {
                    case DataMapType.FieldColumnMap:
                        MapTo.MapToFields(aItem, _aMap, aItem.Tag != null);
                        break;

                    case DataMapType.PropertyColumnMap:
                        MapTo.MapToProperties(aItem, _aMap, aItem.Tag != null);
                        break;

                    case DataMapType.MethodParameterMap:
                        string methodName = lblMethodName.Text;
                        Guid anId = Guid.Empty;
                        if(MethodMap != null)
                        {
                            anId = MethodMap.ID;
                            methodName = MethodMap.MethodName;
                        }
                        if(aItem.Tag != null && aItem.Tag.GetType().BaseType.Equals(typeof(BaseRule)))
                            MethodMap = MapTo.MapToParameters(aItem, _aMap, methodName, paramCount, anId, true);
                        else
                            MethodMap = MapTo.MapToParameterColumnMap(aItem, _aMap, methodName, paramCount, false, anId);
                        break;           
                }

                if(aItem.Tag != null)
                    RuleSets.Add((IDataRule)aItem.Tag);
            }

            Result = _aMap;

            mnuSaveMap.BackColor = Color.Green;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void rbCheckedChanged(object sender, EventArgs e)
        {
            if (blockSwitching) return;

            if(!allowSwitching)
            {
                blockSwitching = true;
                SetDisplayMode(currentMode);
                blockSwitching = false;
            }
        }

        private void mnuDate_Click(object sender, EventArgs e)
        {
            AddRule(FieldTypes.Date);
        }

        private void MnuTime_Click(object sender, EventArgs e)
        {
            AddRule(FieldTypes.Time);
        }

        private void ctxEditRule_Click(object sender, EventArgs e)
        {
            if (lstMappedPairs.SelectedItems.Count > 0)
            {
                IDataRule aRule = (IDataRule)lstMappedPairs.SelectedItems[0].Tag;
                if (aRule != null)
                    EditRule(aRule, lstMappedPairs.SelectedItems[0]);
            }
        }

        private void mnuCollection_Click(object sender, EventArgs e)
        {
            AddRule(FieldTypes.Collection);
        }

        private void UIMapper_Load(object sender, EventArgs e)
        {

        }

        private void UIMapper_Resize(object sender, EventArgs e)
        {
            Initialize();
        }

        private void UIMapper_Activated(object sender, EventArgs e)
        {
            Initialize();
        }

        private void mnuBool_Click(object sender, EventArgs e)
        {
            IDataRule aBool = BuildRules.InitializeBase(FieldTypes.Bool, false, "NA", "NA", false);
            aBool.Description = "Bool-1";
            AddRule(aBool);
        }

        private void mnuType_Click(object sender, EventArgs e)
        {
            AddRule(FieldTypes.Type);
        }

        private void ctxTuple_Click(object sender, EventArgs e)
        {
            AddRule(FieldTypes.Tuple);
        }

        private void ctxEnumerator_Click(object sender, EventArgs e)
        {
            AddRule(FieldTypes.Enumerator);
        }

        private void editRuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstDataSource.SelectedItems.Count > 0)
            {
                IDataRule aRule = (IDataRule)lstDataSource.SelectedItems[0].Tag;
                if (aRule != null)
                    EditRule(aRule, lstDataSource.SelectedItems[0]);
            }

        }

        private void ctxMappedSources_Click(object sender, EventArgs e)
        {
            AddRule(FieldTypes.MappedSource);
        }
    }

    public enum DragedFrom
    {
        DataSource,
        ObjectTarget
    }
}
