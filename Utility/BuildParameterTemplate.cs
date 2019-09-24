using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuildObjects.Enums;
using BuildObjects.MapObjects;
using BuildObjects.Utility;
using MockDataGenerator.Enums;
using MockDataGenerator.Interfaces;
using MockDataGenerator.SpecialObjects;

namespace MockDataGenerator
{
    public partial class RuleGeneratedData : Form
    {
        private const string className = "ClassName: {0}";
        private const string fields = "Fields";
        private const string parameters = "Parameters";
        private const string properties = "Properties";
        public MapReferences Result { private set; get; }
        public RuleGeneratedData(MapReferences aMap)
        {
            Result = aMap;
            InitializeComponent();
            LoadObjectToTree();
            mppedObjectsTree.Nodes[0].Expand();
        }

        private void LoadObjectToTree()
        {
            mppedObjectsTree.Nodes.Clear();
            TreeNode newNode = mppedObjectsTree.Nodes.Add(String.Format(className, Result.ViableInfo.TheMap.ClassName));
            TreeNode categoryNode = newNode.Nodes.Add(fields);
            AddObjectItemsToNode(categoryNode);
            categoryNode = newNode.Nodes.Add(parameters);
            AddObjectItemsToNode(categoryNode);
            categoryNode = newNode.Nodes.Add(properties);
            AddObjectItemsToNode(categoryNode);
        }

        private void AddObjectItemsToNode(TreeNode aNode)
        {
            switch(aNode.Text)
            {
                case fields:
                    foreach (FieldColumnMap aField in Result.ViableInfo.TheMap.FieldMaps)
                        aNode.Nodes.Add(aField.FieldName).Tag = aField;
                    break;

                case properties:
                    foreach (PropertyColumnMap aProp in Result.ViableInfo.TheMap.PropMaps)
                        aNode.Nodes.Add(aProp.PropertyName).Tag = aProp;
                    break;

                case parameters:
                    foreach (MethodParameterMap method in Result.ViableInfo.TheMap.MethodParameters)
                    {
                        int foundCount = 1;
                        foreach (TreeNode subNode in aNode.Nodes)
                            if (TestIfMethodOverload(subNode.Text.Trim(),method.MethodName))
                                foundCount++;

                        if(foundCount == 1)
                            aNode.Nodes.Add(method.MethodName).Tag = method;
                        else
                            aNode.Nodes.Add(String.Format("{0}: - {1}", method.MethodName, foundCount)).Tag = method;
                    }
                    break;
            }
            
        }

        private bool TestIfMethodOverload(string nodeText, string methodName)
        {
            string[] parsed = nodeText.Split(new char[] { ':' });
            return parsed[0].Equals(methodName);
        }

        private void mppedObjectsTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Parent == null) return;
            switch (e.Node.Parent.Text)
            {
                case fields:
                    BuildFieldOrPropertyColumns("FieldName");
                    AddMapRows(Result.ViableInfo.TheMap.FieldMaps);
                    break;

                case properties:
                    BuildFieldOrPropertyColumns("PropertyName");
                    AddMapRows(Result.ViableInfo.TheMap.PropMaps);
                    break;

                case parameters:
                    BuildParameterColumns();
                    AddMapRows((MethodParameterMap)e.Node.Tag);
                    break;
            }
        }

        private void BuildFieldOrPropertyColumns(string name)
        {           
            lstMapDetails.Columns.Clear();
            lstMapDetails.Columns.Add(name);
            lstMapDetails.Columns.Add("ColumnName");
            lstMapDetails.Columns.Add("DataType");
            lstMapDetails.Columns.Add("IsNullable");
            SetColumnWidth();
        }
        private void AddMapRows(List<FieldColumnMap> map)
        {
            lstMapDetails.Items.Clear();
            foreach (FieldColumnMap aMap in map)
            {
                ListViewItem anItem = new ListViewItem(aMap.FieldName);
                anItem.SubItems.Add(new ListViewItem.ListViewSubItem(anItem, aMap.ColumnName));
                anItem.SubItems.Add(new ListViewItem.ListViewSubItem(anItem, aMap.DataType));
                anItem.SubItems.Add(new ListViewItem.ListViewSubItem(anItem, aMap.IsNullable.ToString()));
            }
        }        
        private void AddMapRows(List<PropertyColumnMap> map)
        {
            lstMapDetails.Items.Clear();
            foreach (PropertyColumnMap aMap in map)
            {
                ListViewItem anItem = new ListViewItem(aMap.PropertyName);
                anItem.SubItems.Add(new ListViewItem.ListViewSubItem(anItem, aMap.ColumnName));
                anItem.SubItems.Add(new ListViewItem.ListViewSubItem(anItem, aMap.DataType));
                anItem.SubItems.Add(new ListViewItem.ListViewSubItem(anItem, aMap.IsNullable.ToString()));
            }
        }

        private void BuildParameterColumns()
        {
            lstMapDetails.Columns.Clear();
            lstMapDetails.Columns.Add("ParameterName");           
            lstMapDetails.Columns.Add("DataType");
            lstMapDetails.Columns.Add("IsNullable");
            SetColumnWidth();
        }
        private void AddMapRows(MethodParameterMap map)
        {
            lstMapDetails.Items.Clear();
            foreach (ParameterMap aMap in map.ParameterMaps)
            {
                ListViewItem anItem = new ListViewItem(aMap.ParameterName);                
                anItem.SubItems.Add(new ListViewItem.ListViewSubItem(anItem, aMap.DataType));
                anItem.SubItems.Add(new ListViewItem.ListViewSubItem(anItem, aMap.IsNullable.ToString()));
                lstMapDetails.Items.Add(anItem);
            }
        }

        private void SetColumnWidth()
        {
            for(int i=0;i<lstMapDetails.Columns.Count;i++)
            {
                lstMapDetails.Columns[i].Width = -2;
            }
        }

        private void ctxViewRule_Click(object sender, EventArgs e)
        {
            DataMapType theType = EnumPlus.ConvertString(typeof(DataMapType), mppedObjectsTree.SelectedNode.Tag.GetType().Name);
            var store = Result.ReferenceInfo.StoreReferences.Where(x => x.MapType == theType);
           
            if (store != null)
            {                
                IDataRule storeRule = null;
                switch (theType)
                {
                    case DataMapType.FieldColumnMap:
                    case DataMapType.PropertyColumnMap:
                        RuleStore rStore = (RuleStore)store.First();
                        storeRule = rStore.Rules.Where(x => x.FieldName.Equals(mppedObjectsTree.SelectedNode.Text.Trim())).FirstOrDefault();
                        break;

                    case DataMapType.MethodParameterMap:
                        RuleStore rpStore = (RuleStore)store.Where(x => x.DataStoreName.Equals(mppedObjectsTree.SelectedNode.Text.Trim()) && x.ParamterCount.Equals(lstMapDetails.Items.Count)).First();
                        storeRule = rpStore.Rules.Where(x => x.FieldName.Equals(lstMapDetails.SelectedItems[0].SubItems[0].Text.Trim())).First();
                        break;
                }
                DisplayRule(storeRule, false);
            }
        }

        private void DisplayRule(IDataRule aRule, bool edit)
        {

            switch (aRule.RuleType)
            {
                default:
                    FieldSettings setAField = new FieldSettings(aRule);
                    setAField.ViewOnly = edit;
                    if (setAField.ShowDialog() == DialogResult.OK)
                    {
                        //source.Tag = FieldSettings.Result;
                    }
                    break;

                //case FieldTypes.MappedSource:
                //   break;

                case FieldTypes.Collection:
                    CollectionDialog collections = new CollectionDialog(aRule);
                    collections.ViewOnly = edit;
                    if (collections.ShowDialog() == DialogResult.OK)
                    {
                        //source.Tag = CollectionDialog.Result;
                    }
                    break;

                case FieldTypes.Imported:
                case FieldTypes.MultiColumn:
                    DataFileDialog dataFile = new DataFileDialog(aRule);
                    dataFile.ViewOnly = edit;
                    if (dataFile.ShowDialog() == DialogResult.OK)
                    {
                        //source.Tag = DataFileDialog.Result;
                    }
                    break;

                case FieldTypes.Tuple:
                    TupleDialog tuple = new TupleDialog(aRule);
                    tuple.ViewOnly = edit;
                    if (tuple.ShowDialog() == DialogResult.OK)
                    {
                        //source.Tag = TupleDialog.Result;
                    }
                    break;
            }
        }

        private void mnuGenerate_Click(object sender, EventArgs e)
        {

        }
    }
}
