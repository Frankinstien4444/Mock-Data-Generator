using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuildObjects;
using BuildObjects.Enums;
using BuildObjects.MapObjects;
using ExportEvents;
using MockDataGenerator.Enums;
using MockDataGenerator.SpecialObjects;
using MockDataGenerator.UIServices;
using MockDataGenerator.Utility;
using Thyme.Utilities;
using UniversalDataBase;
using UniversalDataBase.DatabaseManager;

namespace MockDataGenerator
{
    public partial class MainForm : Form
    {
        AssemblyDescriptor SampleAssembly;
        DataBaseObjectClass aDataObject;
        DataMapType currentMode = DataMapType.MethodParameterMap;
        static MainForm Me;
        Thyme.UI viewSql;

        public MainForm()
        {
            InitializeComponent();
            assemblySearch.SearchableObject = lstVwAssemblies;
            tableSearch.SearchableObject = lstVwDatabaseTables;
            TreeNodeUtilities.InitializeTreeView(projectView, ctxTreeMenu);
            Thyme.UI.ExitWithData += StoreDataTable;
            Me = this;
        }

        private void StoreDataTable(Object sender, ExportEvents.exportControlEventArgs e)
        {
            string assemblyName = "";
            if (lstVwAssemblies.SelectedItems.Count == 0)
            {
                if (projectView.SelectedNode == null)
                {
                    MessageBox.Show("No Assembly Selected.");
                    return;
                }
                else if (projectView.SelectedNode == null || !projectView.SelectedNode.Parent.Text.Trim().Equals("Mapped Objects"))
                {
                    MessageBox.Show("Select a Mapped Object.");
                    return;
                }
                else if (projectView.SelectedNode != null)
                    assemblyName = projectView.SelectedNode.ToolTipText;
            }
            else
                assemblyName = lstVwAssemblies.SelectedItems[0].SubItems[2].Text;

            if(!Mapped.LoadDataTableToMapNode(projectView, assemblyName, (ReturnData)e.getData, currentMode))
            {
                dgTableView.DataSource = Mapped.GetQueryColumnDef((ReturnData)e.getData);
                dgTableView.Tag = e;
            }
        }

        private void mnuFindAssembly_Click(object sender, EventArgs e)
        {
            try
            {
                UIServices.AssemblyUtilities.AddAssembly(projectView, dlgOpenAssembly, ctxAssemblyNode);
                SampleAssembly = (AssemblyDescriptor)projectView.SelectedNode.Tag;
                UIServices.AssemblyUtilities.LoadAssemblyToList(SampleAssembly.Assembly, lstVwAssemblies);
            }
            catch { }
        }

        private void lstVwAssemblies_Click(object sender, EventArgs e)
        {
            if (SampleAssembly == null || lstVwAssemblies.SelectedItems.Count < 1) return;
            lstVwObjectView.Items.Clear();
            Type selectedType = SampleAssembly.Assembly.GetType(lstVwAssemblies.SelectedItems[0].SubItems[2].Text);
            if (rbFields.Checked)
            {
                currentMode = DataMapType.FieldColumnMap;
                ListObjectDetails.LoadFields(selectedType, lstVwObjectView);
            }
            else if(rbProperties.Checked)
            {
                currentMode = DataMapType.PropertyColumnMap;
                ListObjectDetails.LoadProperties(selectedType, lstVwObjectView);
            }
            else if(rbMethods.Checked)
            {
                currentMode = DataMapType.MethodParameterMap;
                ListObjectDetails.LoadMethods(selectedType, lstVwObjectView);
            }
            else if(rbConstructors.Checked)
            {
                currentMode = DataMapType.MethodParameterMap;
                ListObjectDetails.LoadConstuctors(selectedType, lstVwObjectView);
            }
        }       

        private void mnuChooseDatabase_Click(object sender, EventArgs e)
        {
            DatabaseUtilities.LoadDatabase(projectView, ref aDataObject, lstVwDatabaseTables);
        }

        private void lstVwDatabaseTables_ItemActivate(object sender, EventArgs e)
        {
           
        }

        private void lstVwDatabaseTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (aDataObject != null && lstVwDatabaseTables.SelectedIndices.Count > 0)
            {
                DataBaseTable testing = new DataBaseTable(aDataObject, lstVwDatabaseTables.SelectedItems[0].Text);

                testing.TransType(true);
                dgTableView.DataSource = testing.Columns;
            }
        }

        private void ObjectSelections_Activated(object sender, EventArgs e)
        {
            
        }

        private void ObjectSelections_Resize(object sender, EventArgs e)
        {
           // picBoxLogo.Left = menuStrip1.Left + menuStrip1.Width - picBoxLogo.Width;
           // picBoxLogo.Top = menuStrip1.Top;
        }

        private void projectView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Parent == null) return;
            string clicked = e.Node.Parent.Text.Trim();
            if (clicked.Equals("Assemblies"))
            {
                SampleAssembly = (AssemblyDescriptor)e.Node.Tag;
                UIServices.AssemblyUtilities.LoadAssemblyToList(SampleAssembly.Assembly, lstVwAssemblies);
            }
            else if(clicked.Equals("Mapped Objects"))
            {
                MapReferences select = (MapReferences)e.Node.Tag;
                ctxMapForMethods.DropDownItems.Clear();
                ctxDataForMethods.DropDownItems.Clear();
                foreach (MethodParameterMap aMap in select.ViableInfo.TheMap.MethodParameters)
                {
                    string method = Parameters.FormParameterMethod(aMap);
                    var aMenuItem = ctxMapForMethods.DropDownItems.Add(method);
                    aMenuItem.Click += mnuMapWindow_Click;
                    aMenuItem.Tag = aMap;

                    aMenuItem = ctxDataForMethods.DropDownItems.Add(method);
                    aMenuItem.Click += mnuQueryWindow_Click;
                    aMenuItem.Tag = aMap;
                }
            }
        }

        private void projectView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            switch (e.Node.Text.Trim())
            {
                case "Database":
                    mnuChooseDatabase_Click(this, new EventArgs());
                    break;

                case "Imported Data":
                    mnuImportData_Click(this, new EventArgs());
                    break;

                case "Assemblies":
                    mnuFindAssembly_Click(this, new EventArgs());
                    break;

                case "Mapped Objects":
                    break;

            }
        }

        private void mnuImportData_Click(object sender, EventArgs e)
        {
            
            if (dlgOpenAssembly.ShowDialog() == DialogResult.OK)
            {
                projectView.Nodes[0].Nodes[1].Nodes.Add(System.IO.Path.GetFileName(dlgOpenAssembly.FileName)).Tag = dlgOpenAssembly.FileName;
            }
        }

        private void rbFields_CheckedChanged(object sender, EventArgs e)
        {
            lstVwAssemblies_Click(this, new EventArgs());
        }

        private void mnuCustomMap_Click(object sender, EventArgs e)
        {
            UIMapper manualMapping = null;
            
            MapedObject aMapObject = null;
            MapManager.FindOrCreateMap(projectView, lstVwAssemblies.SelectedItems[0].SubItems[2].Text, ref aMapObject);
            if ((rbFields.Checked || rbProperties.Checked) && lstVwObjectView.SelectedItems.Count > 0)
            {
                //MapManager.FindOrCreateMap(projectView, lstVwAssemblies.SelectedItems[0].SubItems[2].Text, ref aMapObject);

                manualMapping = new UIMapper(aMapObject, lstVwObjectView.SelectedItems, dgTableView.SelectedRows, currentMode);
            }
            else if (lstVwObjectView.SelectedItems.Count > 0)
            {
                //MapManager.FindOrCreateMap(projectView, lstVwAssemblies.SelectedItems[0].SubItems[2].Text, ref aMapObject);
                //string theparams = String.Empty;
                //if (rbConstructors.Checked)
                //    theparams = lstVwObjectView.SelectedItems[0].SubItems[1].Text;
                //else
                //    theparams = lstVwObjectView.SelectedItems[0].SubItems[2].Text;
                //string[] parameters = theparams.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                //manualMapping = new UIMapper(aMapObject, lstVwObjectView.SelectedItems[0].SubItems[0].Text, Parameters.ParseString(parameters), dgTableView.SelectedRows, currentMode);
                manualMapping = CreateParamsMapper(aMapObject);
            }

            ApplyField(manualMapping);
            if (dgTableView.Tag != null)
                StoreDataTable(this, (exportControlEventArgs)dgTableView.Tag);

        }

        private UIMapper CreateParamsMapper(MapedObject aMapObject)
        {
            string theparams = String.Empty;
            if (rbConstructors.Checked)
                theparams = lstVwObjectView.SelectedItems[0].SubItems[1].Text;
            else
                theparams = lstVwObjectView.SelectedItems[0].SubItems[2].Text;
            string[] parameters = theparams.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            return new UIMapper(aMapObject, lstVwObjectView.SelectedItems[0].SubItems[0].Text, Parameters.ParseString(parameters), dgTableView.SelectedRows, currentMode);
        }

        private void ApplyField(UIMapper aMapper)
        {
            if (aMapper != null && aMapper.ShowDialog() == DialogResult.OK)
            {
                MapReferences mapRef =  Mapped.LoadMapToTree(projectView, UIMapper.Result, ctxTreeMenu);
                mapRef.LastMap = currentMode;
                mapRef.LastMethodMap = aMapper.MethodMap;
                if (UIMapper.RuleSets.Count > 0)
                {
                    string storeName = currentMode.ToString();
                    Guid anId = Guid.Empty;
                    if (currentMode == DataMapType.MethodParameterMap)
                    {
                        anId = aMapper.MethodMap.ID;
                        storeName = mapRef.LastMethodMap.MethodName;
                    }
                    MapManager.FindRuleAndUpdate(storeName, mapRef.ReferenceInfo, UIMapper.RuleSets, currentMode, anId);
                }
            }
        }

        private void mnuFromDatabase_Click(object sender, EventArgs e)
        {
            if (aDataObject != null)
            {
                if (viewSql == null)
                {
                    viewSql = new Thyme.UI(aDataObject);
                    this.AddOwnedForm(viewSql);
                    viewSql.Show();
                }
                else
                {
                    viewSql.ApplyDataObject(aDataObject);
                    viewSql.WindowState = FormWindowState.Maximized;
                }
                
            }
            else
                MessageBox.Show("Select a database to connect to.", "Problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void mnuRandomGenerated_Click(object sender, EventArgs e)
        {
            if (projectView.SelectedNode != null && projectView.SelectedNode.Parent.Text.Trim().Equals("Mapped Objects"))
            {
                MapReferences maps = (MapReferences)projectView.SelectedNode.Tag;
                RuleGeneratedData ruleDataGen = new RuleGeneratedData(maps);
                if (ruleDataGen.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void mnuAutoMap_Click(object sender, EventArgs e)
        {
            if (currentMode != DataMapType.None && lstVwObjectView.SelectedItems.Count > 0 && dgTableView.SelectedRows.Count > 0)
            {
                UIMapper autoMapIt = null;
                MapedObject aMapObject = null;
                MapManager.FindOrCreateMap(projectView, lstVwAssemblies.SelectedItems[0].SubItems[2].Text, ref aMapObject);
                if ((rbFields.Checked || rbProperties.Checked))
                    autoMapIt = new UIMapper(aMapObject, lstVwObjectView.SelectedItems, dgTableView.SelectedRows, currentMode);
                else
                {
                    autoMapIt = CreateParamsMapper(aMapObject);
                }
                autoMapIt.AutoMap = true;
                ApplyField(autoMapIt);
                if (dgTableView.Tag != null)
                    StoreDataTable(this, (exportControlEventArgs)dgTableView.Tag);
            }
        }       
        

        private void mnuSaveMapAndData_Click(object sender, EventArgs e)
        {
            if (projectView.SelectedNode != null && projectView.SelectedNode.Parent.Text.Trim().Equals("Mapped Objects"))
            {
                SaveMapNode();
            }
        }

        private void SaveMapNode()
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.AddExtension = true;
            saveFile.Filter = "References |*.ref";
            saveFile.FileName = projectView.SelectedNode.Text.Trim();
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                MapReferences aRef = (MapReferences)projectView.SelectedNode.Tag;
                aRef.ReferenceInfo.RefreshFile = saveFile.FileName.Replace(".ref", ".all");
                Store.StoreMapAndData(aRef.ReferenceInfo, saveFile.FileName);
                Store.StoreMapAndData(aRef.ViableInfo, aRef.ReferenceInfo.RefreshFile);

            }
        }

        private void mnuQueryWindow_Click(object sender, EventArgs e)
        {
            if (projectView.SelectedNode.Parent.Text.Trim().Equals("Mapped Objects"))
            {
                if (aDataObject != null)
                {
                    dgTableView.Tag = null;
                    MapReferences aRef = (MapReferences)projectView.SelectedNode.Tag;
                    ToolStripMenuItem sentIt = (ToolStripMenuItem)sender;
                    Tuple<String, int> parsed = ParseTextLabel(sentIt.Text);
                    aRef.LastMap = ConvertMenuToMapType(parsed.Item1);
                    currentMode = aRef.LastMap;
                    //aRef.MethodName = parsed.Item1;
                    if (viewSql == null)
                    {
                        viewSql = new Thyme.UI(aDataObject);
                        this.AddOwnedForm(viewSql);
                        viewSql.Show();
                    }
                    else
                    {
                        viewSql.ApplyDataObject(aDataObject);
                        viewSql.WindowState = FormWindowState.Maximized;
                    }

                    ReturnData editing = new ReturnData();
                    string storeName = String.Empty;
                    Guid mapGuid = Guid.Empty;
                    if (aRef.LastMap == DataMapType.MethodParameterMap)
                    {
                        aRef.LastMethodMap = (MethodParameterMap)sentIt.Tag;
                        mapGuid = aRef.LastMethodMap.ID;
                        editing.QueryResult = MapManager.FindQueryInfo(aRef.ViableInfo.StoredData, aRef.LastMethodMap.MethodName, currentMode, mapGuid, out storeName);            
                    }
                    else
                    {
                        editing.QueryResult = MapManager.FindQueryInfo(aRef.ViableInfo.StoredData, null, currentMode, Guid.Empty, out storeName);
                    }


                    //editing.QueryResult = MapManager.FindQueryInfo(aRef.ViableInfo.StoredData, null, currentMode, parsed.Item2, out storeName);
                    switch(currentMode)
                    {
                        case DataMapType.FieldColumnMap:
                        case DataMapType.PropertyColumnMap:
                            editing.SQLText = MapManager.GetSQL(storeName, Guid.Empty, aRef.ReferenceInfo);
                            break;

                        case DataMapType.MethodParameterMap:
                            editing.SQLText = MapManager.GetSQL(storeName, mapGuid, aRef.ReferenceInfo);
                            break;
                    }
                    
                    viewSql.SetEditData(editing);
                    
                }
                else
                    MessageBox.Show("Select a database to connect to.", "Problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

       

        private void mnuMapWindow_Click(object sender, EventArgs e)
        {
            try
            {
                if (projectView.SelectedNode.Parent.Text.Trim().Equals("Mapped Objects"))
                {
                    ToolStripMenuItem sentIt = (ToolStripMenuItem)sender;
                    MapReferences aRef = (MapReferences)projectView.SelectedNode.Tag;
                    Tuple<String, int> parsed = ParseTextLabel(sentIt.Text);
                    BaseStore store = null;
                    Guid mapGuid = Guid.Empty;
                    aRef.LastMap = ConvertMenuToMapType(parsed.Item1);
                    currentMode = aRef.LastMap;
                    if (aRef.LastMap == DataMapType.MethodParameterMap)
                    {
                        aRef.LastMethodMap = (MethodParameterMap)sentIt.Tag;
                        mapGuid = aRef.LastMethodMap.ID;
                        store = MapManager.FindStore(aRef.LastMethodMap.MethodName, mapGuid, aRef.ReferenceInfo);
                    }
                    else
                    {
                        store = MapManager.FindStore(aRef.LastMap.ToString(), mapGuid, aRef.ReferenceInfo);
                    }
                    UIMapper autoMapIt = null;

                    
                    if (store != null && store.GetType().Equals(typeof(RuleStore)))
                    {
                        autoMapIt = new UIMapper(aRef.ViableInfo.TheMap, ((RuleStore)store).Rules, aRef.LastMethodMap, currentMode);
                    }
                    else
                        autoMapIt = new UIMapper(aRef.ViableInfo.TheMap, aRef.LastMethodMap, currentMode);

                    autoMapIt.AutoMap = true;
                    if (autoMapIt.ShowDialog() == DialogResult.OK)
                    {
                        aRef.ViableInfo.TheMap = UIMapper.Result;
                        if (store.GetType().Equals(typeof(RuleStore)))
                            ((RuleStore)store).Rules = UIMapper.RuleSets;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private DataMapType ConvertMenuToMapType(string text)
        {
            DataMapType result = DataMapType.None;
            switch(text)
            {
                case "Map for Properties":
                case "Data for Properties":
                    result = DataMapType.PropertyColumnMap;
                    break;

                case "Data For Fields":
                case "Map For Fields":
                    result = DataMapType.FieldColumnMap;
                    break;

                default:
                    result = DataMapType.MethodParameterMap;
                    break;
            }

            return result;
        }

        private Tuple<String, int> ParseTextLabel(string text)
        {
            string[] parsed = text.Split(new char[] { '(' }, StringSplitOptions.RemoveEmptyEntries);

            string[] parameters = new string[0];
            if(parsed.Length > 1)
                parameters = parsed[1].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            Tuple<String, int> result = new Tuple<string, int>(parsed[0], parameters.Length);
            return result;
        }

        private void SetCurrentMode(String menuText)
        {
            switch(menuText)
            {
                case "Data for Properties":
                case "Map for Properties":
                    currentMode = DataMapType.PropertyColumnMap;
                    break;

                case "Data For Fields":
                case "Map For Fields":
                    currentMode = DataMapType.FieldColumnMap;
                    break;

                case "Data for Methods":
                case "Map for Methods":
                    currentMode = DataMapType.MethodParameterMap;
                    break;
            }
        }

        private void ctxCreateLoadTemplate_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Text | *.txt";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                MapReferences aRef = (MapReferences)projectView.SelectedNode.Tag;
                if (aRef.ViableInfo.TheMap.MethodParameters.Count == 0)
                {
                    Store.SaveTextOutput(OutputTemplate.CreateTemplateNoParams(aRef.ViableInfo), saveFile.FileName);
                }
                else
                {
                    Store.SaveTextOutput(OutputTemplate.CreateTemplateParams(aRef.ViableInfo), saveFile.FileName);
                }
            }
        }

        private void ctxLoadMap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "References |*.ref";            
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                MapReferences newRef = new MapReferences();
                newRef.ReferenceInfo = ReadReferenceFiles.ReadFile(openFile.FileName);
                newRef.ViableInfo = ReadReferenceFiles.LoadMap(newRef.ReferenceInfo.RefreshFile); 
                Mapped.LoadReferencesToTree(projectView, newRef, ctxTreeMenu);
            }
        }

        private void mnuViewGeneratedData_Click(object sender, EventArgs e)
        {

        }

        private void ctxDeleteMap_Click(object sender, EventArgs e)
        {
            if (projectView.SelectedNode.Parent.Text.Trim().Equals("Mapped Objects"))
            {
                projectView.SelectedNode.Remove();
            }
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            AboutBox about = new MockDataGenerator.AboutBox();
            about.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (projectView.SelectedNode.Parent.Text.Trim().Equals("Assemblies"))
            {
                projectView.SelectedNode.Remove();
            }
        }

        private void basicWorkFlowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(String.Format("{0}//Documentation//BasicWorkflow.html", Application.StartupPath));
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(String.Format("{0}//Documentation//MainMenu.html", Application.StartupPath));
        }

        private void ObjectSelections_Load(object sender, EventArgs e)
        {
            //if(!File.Exists(String.Format(@"{0}\RadMonster\License.lic", Application.StartupPath)))
            //{
            //    frmRegister warning = new Utility.frmRegister();
            //    warning.ShowDialog();
            //}
        }

        private void ObjectSelections_Shown(object sender, EventArgs e)
        {
            for (int i = 0; i < lstVwAssemblies.Columns.Count; i++)
            {
                if (i == 1)
                    lstVwAssemblies.Columns[i].Width = 75;
                else
                    lstVwAssemblies.Columns[i].Width = -2;
            }
        }

        public static List<ViableMapAndData> GetMappedSoruces()
        {
            List<ViableMapAndData> result = new List<ViableMapAndData>();
            foreach(TreeNode aNode in Me.projectView.Nodes[0].Nodes)
            {
                if(aNode.Text.Equals("Mapped Objects"))
                {
                    foreach(TreeNode mappedNode in aNode.Nodes)
                    {
                        result.Add((ViableMapAndData)mappedNode.Tag);
                    }
                }
            }
            return result;
        }

        public static Tuple<String, List<Type>> GetAssemblyEnumerators()
        {
            List<Type> result = new List<System.Type>();
            if (Me.SampleAssembly.Enums.Any())
                result =  Me.SampleAssembly.Enums.ToList();
            return new Tuple<String, List<Type>>(Me.SampleAssembly.Assembly.GetName().Name, result);
        }

        private void ctxClearTableGrid_Click(object sender, EventArgs e)
        {
            dgTableView.DataSource = null;
        }

        private void btnMapFromQuery_Click(object sender, EventArgs e)
        {

        }
    }
}
