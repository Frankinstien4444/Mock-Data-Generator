namespace MockDataGenerator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFindAssembly = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuImportData = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuOpenMockup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChooseDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMapData = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAutoMap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCustomMap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGenerateData = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFromDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRandomGenerated = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManualCreatedData = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManual = new System.Windows.Forms.ToolStripMenuItem();
            this.basicWorkFlowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.lstVwDatabaseTables = new System.Windows.Forms.ListView();
            this.lstVwAssemblies = new System.Windows.Forms.ListView();
            this.colAcessibility = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colObject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgTableView = new System.Windows.Forms.DataGridView();
            this.ctxMap = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxAutoMap = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCustomMap = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxClearTableGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.lstVwObjectView = new System.Windows.Forms.ListView();
            this.FieldName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.rbConstructors = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rbFields = new System.Windows.Forms.RadioButton();
            this.rbMethods = new System.Windows.Forms.RadioButton();
            this.rbProperties = new System.Windows.Forms.RadioButton();
            this.projectView = new System.Windows.Forms.TreeView();
            this.ctxTreeMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxDeleteMap = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSaveMapAndData = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxLoadMap = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuQueryWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxDataForProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxDataForFields = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxDataForMethods = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMapWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMapForProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMapForFields = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMapForMethods = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxCreateLoadTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgOpenAssembly = new System.Windows.Forms.OpenFileDialog();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.ctxAssemblyNode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableSearch = new AtlasWorkFlow.Search.SearchBar();
            this.assemblySearch = new AtlasWorkFlow.Search.SearchBar();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTableView)).BeginInit();
            this.ctxMap.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.ctxTreeMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.ctxAssemblyNode.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.mnuChooseDatabase,
            this.mnuMapData,
            this.mnuGenerateData,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1483, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFindAssembly,
            this.toolStripSeparator1,
            this.mnuImportData,
            this.toolStripSeparator2,
            this.mnuOpenMockup,
            this.mnuSave,
            this.mnuSaveAs});
            this.filesToolStripMenuItem.Image = global::MockDataGenerator.Properties.Resources.mini_open_folder_full;
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(83, 36);
            this.filesToolStripMenuItem.Text = "Files";
            // 
            // mnuFindAssembly
            // 
            this.mnuFindAssembly.Image = global::MockDataGenerator.Properties.Resources.atom__elementary_particle_pic;
            this.mnuFindAssembly.Name = "mnuFindAssembly";
            this.mnuFindAssembly.Size = new System.Drawing.Size(187, 38);
            this.mnuFindAssembly.Text = "Find Assembly";
            this.mnuFindAssembly.Click += new System.EventHandler(this.mnuFindAssembly_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(184, 6);
            // 
            // mnuImportData
            // 
            this.mnuImportData.Image = global::MockDataGenerator.Properties.Resources.Associate2;
            this.mnuImportData.Name = "mnuImportData";
            this.mnuImportData.Size = new System.Drawing.Size(187, 38);
            this.mnuImportData.Text = "Import Data";
            this.mnuImportData.Click += new System.EventHandler(this.mnuImportData_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(184, 6);
            // 
            // mnuOpenMockup
            // 
            this.mnuOpenMockup.Image = global::MockDataGenerator.Properties.Resources.Open;
            this.mnuOpenMockup.Name = "mnuOpenMockup";
            this.mnuOpenMockup.Size = new System.Drawing.Size(187, 38);
            this.mnuOpenMockup.Text = "Open Mockup";
            // 
            // mnuSave
            // 
            this.mnuSave.Image = global::MockDataGenerator.Properties.Resources.Save2;
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(187, 38);
            this.mnuSave.Text = "Save";
            // 
            // mnuSaveAs
            // 
            this.mnuSaveAs.Image = global::MockDataGenerator.Properties.Resources.save_as2;
            this.mnuSaveAs.Name = "mnuSaveAs";
            this.mnuSaveAs.Size = new System.Drawing.Size(187, 38);
            this.mnuSaveAs.Text = "Save As";
            // 
            // mnuChooseDatabase
            // 
            this.mnuChooseDatabase.Image = global::MockDataGenerator.Properties.Resources.Universal_DatabaseMedium;
            this.mnuChooseDatabase.Name = "mnuChooseDatabase";
            this.mnuChooseDatabase.Size = new System.Drawing.Size(170, 36);
            this.mnuChooseDatabase.Text = "Choose Database";
            this.mnuChooseDatabase.Click += new System.EventHandler(this.mnuChooseDatabase_Click);
            // 
            // mnuMapData
            // 
            this.mnuMapData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAutoMap,
            this.mnuCustomMap});
            this.mnuMapData.Image = global::MockDataGenerator.Properties.Resources.NetIcon_web_design_edinburgh_hosting_png_300x263;
            this.mnuMapData.Name = "mnuMapData";
            this.mnuMapData.Size = new System.Drawing.Size(114, 36);
            this.mnuMapData.Text = "Map Data";
            // 
            // mnuAutoMap
            // 
            this.mnuAutoMap.Image = global::MockDataGenerator.Properties.Resources.automator_icon;
            this.mnuAutoMap.Name = "mnuAutoMap";
            this.mnuAutoMap.Size = new System.Drawing.Size(196, 38);
            this.mnuAutoMap.Text = "Auto Map";
            this.mnuAutoMap.Click += new System.EventHandler(this.mnuAutoMap_Click);
            // 
            // mnuCustomMap
            // 
            this.mnuCustomMap.Image = global::MockDataGenerator.Properties.Resources.update;
            this.mnuCustomMap.Name = "mnuCustomMap";
            this.mnuCustomMap.Size = new System.Drawing.Size(196, 38);
            this.mnuCustomMap.Text = "Custom Map";
            this.mnuCustomMap.Click += new System.EventHandler(this.mnuCustomMap_Click);
            // 
            // mnuGenerateData
            // 
            this.mnuGenerateData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFromDatabase,
            this.mnuRandomGenerated,
            this.mnuManualCreatedData});
            this.mnuGenerateData.Name = "mnuGenerateData";
            this.mnuGenerateData.Size = new System.Drawing.Size(110, 36);
            this.mnuGenerateData.Text = "Data Sources";
            // 
            // mnuFromDatabase
            // 
            this.mnuFromDatabase.Image = ((System.Drawing.Image)(resources.GetObject("mnuFromDatabase.Image")));
            this.mnuFromDatabase.Name = "mnuFromDatabase";
            this.mnuFromDatabase.Size = new System.Drawing.Size(239, 38);
            this.mnuFromDatabase.Text = "From Database";
            this.mnuFromDatabase.Click += new System.EventHandler(this.mnuFromDatabase_Click);
            // 
            // mnuRandomGenerated
            // 
            this.mnuRandomGenerated.Image = global::MockDataGenerator.Properties.Resources.QA;
            this.mnuRandomGenerated.Name = "mnuRandomGenerated";
            this.mnuRandomGenerated.Size = new System.Drawing.Size(239, 38);
            this.mnuRandomGenerated.Text = "Rule Generated Data";
            this.mnuRandomGenerated.Click += new System.EventHandler(this.mnuRandomGenerated_Click);
            // 
            // mnuManualCreatedData
            // 
            this.mnuManualCreatedData.Image = global::MockDataGenerator.Properties.Resources.NewProject;
            this.mnuManualCreatedData.Name = "mnuManualCreatedData";
            this.mnuManualCreatedData.Size = new System.Drawing.Size(239, 38);
            this.mnuManualCreatedData.Text = "Manually Created Data";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuManual,
            this.mnuAbout});
            this.helpToolStripMenuItem.Image = global::MockDataGenerator.Properties.Resources.help;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(81, 36);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // mnuManual
            // 
            this.mnuManual.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicWorkFlowToolStripMenuItem,
            this.mainMenuToolStripMenuItem});
            this.mnuManual.Name = "mnuManual";
            this.mnuManual.Size = new System.Drawing.Size(122, 22);
            this.mnuManual.Text = "Manual";
            // 
            // basicWorkFlowToolStripMenuItem
            // 
            this.basicWorkFlowToolStripMenuItem.Name = "basicWorkFlowToolStripMenuItem";
            this.basicWorkFlowToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.basicWorkFlowToolStripMenuItem.Text = "Basic WorkFlow";
            this.basicWorkFlowToolStripMenuItem.Click += new System.EventHandler(this.basicWorkFlowToolStripMenuItem_Click);
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(122, 22);
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lstVwDatabaseTables, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lstVwAssemblies, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.projectView, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 42);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1483, 706);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 353F));
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableSearch, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(353, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(560, 42);
            this.tableLayoutPanel4.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 42);
            this.label4.TabIndex = 6;
            this.label4.Text = "Database Tables";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstVwDatabaseTables
            // 
            this.lstVwDatabaseTables.BackColor = System.Drawing.SystemColors.Info;
            this.lstVwDatabaseTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstVwDatabaseTables.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVwDatabaseTables.HideSelection = false;
            this.lstVwDatabaseTables.Location = new System.Drawing.Point(354, 52);
            this.lstVwDatabaseTables.Margin = new System.Windows.Forms.Padding(4);
            this.lstVwDatabaseTables.MultiSelect = false;
            this.lstVwDatabaseTables.Name = "lstVwDatabaseTables";
            this.lstVwDatabaseTables.Size = new System.Drawing.Size(558, 321);
            this.lstVwDatabaseTables.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstVwDatabaseTables.TabIndex = 0;
            this.lstVwDatabaseTables.UseCompatibleStateImageBehavior = false;
            this.lstVwDatabaseTables.View = System.Windows.Forms.View.List;
            this.lstVwDatabaseTables.ItemActivate += new System.EventHandler(this.lstVwDatabaseTables_ItemActivate);
            this.lstVwDatabaseTables.SelectedIndexChanged += new System.EventHandler(this.lstVwDatabaseTables_SelectedIndexChanged);
            // 
            // lstVwAssemblies
            // 
            this.lstVwAssemblies.BackColor = System.Drawing.SystemColors.Info;
            this.lstVwAssemblies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colAcessibility,
            this.colType,
            this.colObject});
            this.lstVwAssemblies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstVwAssemblies.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVwAssemblies.FullRowSelect = true;
            this.lstVwAssemblies.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstVwAssemblies.HideSelection = false;
            this.lstVwAssemblies.Location = new System.Drawing.Point(920, 52);
            this.lstVwAssemblies.Margin = new System.Windows.Forms.Padding(4);
            this.lstVwAssemblies.MultiSelect = false;
            this.lstVwAssemblies.Name = "lstVwAssemblies";
            this.lstVwAssemblies.Size = new System.Drawing.Size(559, 321);
            this.lstVwAssemblies.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstVwAssemblies.TabIndex = 1;
            this.lstVwAssemblies.UseCompatibleStateImageBehavior = false;
            this.lstVwAssemblies.View = System.Windows.Forms.View.Details;
            this.lstVwAssemblies.Click += new System.EventHandler(this.lstVwAssemblies_Click);
            // 
            // colAcessibility
            // 
            this.colAcessibility.Text = "Acessibility";
            this.colAcessibility.Width = 144;
            // 
            // colType
            // 
            this.colType.Text = "Type";
            this.colType.Width = 99;
            // 
            // colObject
            // 
            this.colObject.Text = "Name";
            this.colObject.Width = 137;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 353F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.assemblySearch, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(919, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(561, 42);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Assembly Objects";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 3);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.dgTableView, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lstVwObjectView, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 380);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1477, 323);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // dgTableView
            // 
            this.dgTableView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTableView.ContextMenuStrip = this.ctxMap;
            this.dgTableView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgTableView.Location = new System.Drawing.Point(4, 36);
            this.dgTableView.Margin = new System.Windows.Forms.Padding(4);
            this.dgTableView.Name = "dgTableView";
            this.dgTableView.ReadOnly = true;
            this.dgTableView.RowHeadersVisible = false;
            this.dgTableView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTableView.Size = new System.Drawing.Size(976, 283);
            this.dgTableView.TabIndex = 3;
            // 
            // ctxMap
            // 
            this.ctxMap.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxAutoMap,
            this.ctxCustomMap,
            this.ctxClearTableGrid});
            this.ctxMap.Name = "ctxMap";
            this.ctxMap.Size = new System.Drawing.Size(157, 70);
            // 
            // ctxAutoMap
            // 
            this.ctxAutoMap.Name = "ctxAutoMap";
            this.ctxAutoMap.Size = new System.Drawing.Size(156, 22);
            this.ctxAutoMap.Text = "Auto Map";
            this.ctxAutoMap.Click += new System.EventHandler(this.mnuAutoMap_Click);
            // 
            // ctxCustomMap
            // 
            this.ctxCustomMap.Name = "ctxCustomMap";
            this.ctxCustomMap.Size = new System.Drawing.Size(156, 22);
            this.ctxCustomMap.Text = "Custom Map";
            this.ctxCustomMap.Click += new System.EventHandler(this.mnuCustomMap_Click);
            // 
            // ctxClearTableGrid
            // 
            this.ctxClearTableGrid.Name = "ctxClearTableGrid";
            this.ctxClearTableGrid.Size = new System.Drawing.Size(156, 22);
            this.ctxClearTableGrid.Text = "Clear Table Grid";
            this.ctxClearTableGrid.Click += new System.EventHandler(this.ctxClearTableGrid_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(976, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Table View";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstVwObjectView
            // 
            this.lstVwObjectView.BackColor = System.Drawing.SystemColors.Info;
            this.lstVwObjectView.CheckBoxes = true;
            this.lstVwObjectView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FieldName,
            this.Type});
            this.lstVwObjectView.ContextMenuStrip = this.ctxMap;
            this.lstVwObjectView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstVwObjectView.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVwObjectView.FullRowSelect = true;
            this.lstVwObjectView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstVwObjectView.HideSelection = false;
            this.lstVwObjectView.Location = new System.Drawing.Point(988, 36);
            this.lstVwObjectView.Margin = new System.Windows.Forms.Padding(4);
            this.lstVwObjectView.Name = "lstVwObjectView";
            this.lstVwObjectView.ShowItemToolTips = true;
            this.lstVwObjectView.Size = new System.Drawing.Size(485, 283);
            this.lstVwObjectView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstVwObjectView.TabIndex = 3;
            this.lstVwObjectView.UseCompatibleStateImageBehavior = false;
            this.lstVwObjectView.View = System.Windows.Forms.View.Details;
            // 
            // FieldName
            // 
            this.FieldName.Text = "Field Name";
            this.FieldName.Width = 198;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 116;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.Controls.Add(this.rbConstructors, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.rbFields, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.rbMethods, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.rbProperties, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(987, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(487, 26);
            this.tableLayoutPanel5.TabIndex = 7;
            // 
            // rbConstructors
            // 
            this.rbConstructors.AutoSize = true;
            this.rbConstructors.Checked = true;
            this.rbConstructors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbConstructors.Location = new System.Drawing.Point(100, 3);
            this.rbConstructors.Name = "rbConstructors";
            this.rbConstructors.Size = new System.Drawing.Size(91, 20);
            this.rbConstructors.TabIndex = 11;
            this.rbConstructors.TabStop = true;
            this.rbConstructors.Text = "Constructors";
            this.rbConstructors.UseVisualStyleBackColor = true;
            this.rbConstructors.CheckedChanged += new System.EventHandler(this.rbFields_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Object Details";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbFields
            // 
            this.rbFields.AutoSize = true;
            this.rbFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbFields.Location = new System.Drawing.Point(197, 3);
            this.rbFields.Name = "rbFields";
            this.rbFields.Size = new System.Drawing.Size(91, 20);
            this.rbFields.TabIndex = 8;
            this.rbFields.Text = "Fields";
            this.rbFields.UseVisualStyleBackColor = true;
            this.rbFields.CheckedChanged += new System.EventHandler(this.rbFields_CheckedChanged);
            // 
            // rbMethods
            // 
            this.rbMethods.AutoSize = true;
            this.rbMethods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbMethods.Location = new System.Drawing.Point(391, 3);
            this.rbMethods.Name = "rbMethods";
            this.rbMethods.Size = new System.Drawing.Size(93, 20);
            this.rbMethods.TabIndex = 9;
            this.rbMethods.Text = "Methods";
            this.rbMethods.UseVisualStyleBackColor = true;
            this.rbMethods.CheckedChanged += new System.EventHandler(this.rbFields_CheckedChanged);
            // 
            // rbProperties
            // 
            this.rbProperties.AutoSize = true;
            this.rbProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbProperties.Location = new System.Drawing.Point(294, 3);
            this.rbProperties.Name = "rbProperties";
            this.rbProperties.Size = new System.Drawing.Size(91, 20);
            this.rbProperties.TabIndex = 10;
            this.rbProperties.Text = "Properties";
            this.rbProperties.UseVisualStyleBackColor = true;
            this.rbProperties.CheckedChanged += new System.EventHandler(this.rbFields_CheckedChanged);
            // 
            // projectView
            // 
            this.projectView.BackColor = System.Drawing.SystemColors.Info;
            this.projectView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectView.FullRowSelect = true;
            this.projectView.HideSelection = false;
            this.projectView.Location = new System.Drawing.Point(3, 3);
            this.projectView.Name = "projectView";
            this.tableLayoutPanel1.SetRowSpan(this.projectView, 2);
            this.projectView.Size = new System.Drawing.Size(344, 371);
            this.projectView.TabIndex = 11;
            this.projectView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.projectView_NodeMouseClick);
            this.projectView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.projectView_NodeMouseDoubleClick);
            // 
            // ctxTreeMenu
            // 
            this.ctxTreeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxDeleteMap,
            this.toolStripSeparator5,
            this.mnuSaveMapAndData,
            this.ctxLoadMap,
            this.toolStripSeparator3,
            this.mnuQueryWindow,
            this.mnuMapWindow,
            this.toolStripSeparator4,
            this.ctxCreateLoadTemplate});
            this.ctxTreeMenu.Name = "ctxTreeMenu";
            this.ctxTreeMenu.Size = new System.Drawing.Size(203, 154);
            // 
            // ctxDeleteMap
            // 
            this.ctxDeleteMap.Name = "ctxDeleteMap";
            this.ctxDeleteMap.Size = new System.Drawing.Size(202, 22);
            this.ctxDeleteMap.Text = "Remove Mapped Object";
            this.ctxDeleteMap.Click += new System.EventHandler(this.ctxDeleteMap_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(199, 6);
            // 
            // mnuSaveMapAndData
            // 
            this.mnuSaveMapAndData.Name = "mnuSaveMapAndData";
            this.mnuSaveMapAndData.Size = new System.Drawing.Size(202, 22);
            this.mnuSaveMapAndData.Text = "Save Mapped Object";
            this.mnuSaveMapAndData.Click += new System.EventHandler(this.mnuSaveMapAndData_Click);
            // 
            // ctxLoadMap
            // 
            this.ctxLoadMap.Name = "ctxLoadMap";
            this.ctxLoadMap.Size = new System.Drawing.Size(202, 22);
            this.ctxLoadMap.Text = "Load Mapped Object";
            this.ctxLoadMap.Click += new System.EventHandler(this.ctxLoadMap_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(199, 6);
            // 
            // mnuQueryWindow
            // 
            this.mnuQueryWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxDataForProperties,
            this.ctxDataForFields,
            this.ctxDataForMethods});
            this.mnuQueryWindow.Name = "mnuQueryWindow";
            this.mnuQueryWindow.Size = new System.Drawing.Size(202, 22);
            this.mnuQueryWindow.Text = "Data Query Window";
            // 
            // ctxDataForProperties
            // 
            this.ctxDataForProperties.Name = "ctxDataForProperties";
            this.ctxDataForProperties.Size = new System.Drawing.Size(172, 22);
            this.ctxDataForProperties.Text = "Data for Properties";
            this.ctxDataForProperties.Click += new System.EventHandler(this.mnuQueryWindow_Click);
            // 
            // ctxDataForFields
            // 
            this.ctxDataForFields.Name = "ctxDataForFields";
            this.ctxDataForFields.Size = new System.Drawing.Size(172, 22);
            this.ctxDataForFields.Text = "Data For Fields";
            this.ctxDataForFields.Click += new System.EventHandler(this.mnuQueryWindow_Click);
            // 
            // ctxDataForMethods
            // 
            this.ctxDataForMethods.Name = "ctxDataForMethods";
            this.ctxDataForMethods.Size = new System.Drawing.Size(172, 22);
            this.ctxDataForMethods.Text = "Data for Methods";
            // 
            // mnuMapWindow
            // 
            this.mnuMapWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxMapForProperties,
            this.ctxMapForFields,
            this.ctxMapForMethods});
            this.mnuMapWindow.Name = "mnuMapWindow";
            this.mnuMapWindow.Size = new System.Drawing.Size(202, 22);
            this.mnuMapWindow.Text = "Map Window";
            // 
            // ctxMapForProperties
            // 
            this.ctxMapForProperties.Name = "ctxMapForProperties";
            this.ctxMapForProperties.Size = new System.Drawing.Size(172, 22);
            this.ctxMapForProperties.Text = "Map for Properties";
            this.ctxMapForProperties.Click += new System.EventHandler(this.mnuMapWindow_Click);
            // 
            // ctxMapForFields
            // 
            this.ctxMapForFields.Name = "ctxMapForFields";
            this.ctxMapForFields.Size = new System.Drawing.Size(172, 22);
            this.ctxMapForFields.Text = "Map For Fields";
            this.ctxMapForFields.Click += new System.EventHandler(this.mnuMapWindow_Click);
            // 
            // ctxMapForMethods
            // 
            this.ctxMapForMethods.Name = "ctxMapForMethods";
            this.ctxMapForMethods.Size = new System.Drawing.Size(172, 22);
            this.ctxMapForMethods.Text = "Map for Methods";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(199, 6);
            // 
            // ctxCreateLoadTemplate
            // 
            this.ctxCreateLoadTemplate.Name = "ctxCreateLoadTemplate";
            this.ctxCreateLoadTemplate.Size = new System.Drawing.Size(202, 22);
            this.ctxCreateLoadTemplate.Text = "Create LoadTemplate";
            this.ctxCreateLoadTemplate.Click += new System.EventHandler(this.ctxCreateLoadTemplate_Click);
            // 
            // dlgOpenAssembly
            // 
            this.dlgOpenAssembly.FileName = "Assembly";
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.picBoxLogo.Image = global::MockDataGenerator.Properties.Resources.colorfuldragon3pm2;
            this.picBoxLogo.InitialImage = null;
            this.picBoxLogo.Location = new System.Drawing.Point(554, 0);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(69, 39);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogo.TabIndex = 2;
            this.picBoxLogo.TabStop = false;
            // 
            // ctxAssemblyNode
            // 
            this.ctxAssemblyNode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.ctxAssemblyNode.Name = "ctxAssemblyNode";
            this.ctxAssemblyNode.Size = new System.Drawing.Size(118, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.deleteToolStripMenuItem.Text = "Remove";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // tableSearch
            // 
            this.tableSearch.ActOnCellSelection = null;
            this.tableSearch.ActOnSelection = null;
            this.tableSearch.ActOnTreeNodeSelection = null;
            this.tableSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableSearch.Location = new System.Drawing.Point(211, 4);
            this.tableSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tableSearch.Name = "tableSearch";
            this.tableSearch.RightLabel = ((System.Drawing.Image)(resources.GetObject("tableSearch.RightLabel")));
            this.tableSearch.SearchableObject = null;
            this.tableSearch.SearchUsingExternalSource = null;
            this.tableSearch.Size = new System.Drawing.Size(345, 34);
            this.tableSearch.TabIndex = 7;
            // 
            // assemblySearch
            // 
            this.assemblySearch.ActOnCellSelection = null;
            this.assemblySearch.ActOnSelection = null;
            this.assemblySearch.ActOnTreeNodeSelection = null;
            this.assemblySearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assemblySearch.Location = new System.Drawing.Point(212, 4);
            this.assemblySearch.Margin = new System.Windows.Forms.Padding(4);
            this.assemblySearch.Name = "assemblySearch";
            this.assemblySearch.RightLabel = ((System.Drawing.Image)(resources.GetObject("assemblySearch.RightLabel")));
            this.assemblySearch.SearchableObject = null;
            this.assemblySearch.SearchUsingExternalSource = null;
            this.assemblySearch.Size = new System.Drawing.Size(345, 34);
            this.assemblySearch.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 748);
            this.Controls.Add(this.picBoxLogo);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mockup Data Generator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.ObjectSelections_Activated);
            this.Load += new System.EventHandler(this.ObjectSelections_Load);
            this.Shown += new System.EventHandler(this.ObjectSelections_Shown);
            this.Resize += new System.EventHandler(this.ObjectSelections_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTableView)).EndInit();
            this.ctxMap.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ctxTreeMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.ctxAssemblyNode.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuImportData;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveAs;
        private System.Windows.Forms.ToolStripMenuItem mnuChooseDatabase;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView lstVwDatabaseTables;
        private System.Windows.Forms.ListView lstVwAssemblies;
        private System.Windows.Forms.OpenFileDialog dlgOpenAssembly;
        private System.Windows.Forms.ToolStripMenuItem mnuFindAssembly;
        private System.Windows.Forms.ToolStripMenuItem mnuGenerateData;
        private System.Windows.Forms.ToolStripMenuItem mnuFromDatabase;
        private System.Windows.Forms.ToolStripMenuItem mnuRandomGenerated;
        private System.Windows.Forms.ToolStripMenuItem mnuManualCreatedData;
        private System.Windows.Forms.ToolStripMenuItem mnuMapData;
        private System.Windows.Forms.ToolStripMenuItem mnuAutoMap;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomMap;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuManual;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private AtlasWorkFlow.Search.SearchBar assemblySearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label4;
        private AtlasWorkFlow.Search.SearchBar tableSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenMockup;
        private System.Windows.Forms.TreeView projectView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgTableView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lstVwObjectView;
        private System.Windows.Forms.ColumnHeader FieldName;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbFields;
        private System.Windows.Forms.RadioButton rbMethods;
        private System.Windows.Forms.RadioButton rbProperties;
        private System.Windows.Forms.ContextMenuStrip ctxTreeMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveMapAndData;
        private System.Windows.Forms.ToolStripMenuItem mnuQueryWindow;
        private System.Windows.Forms.ToolStripMenuItem mnuMapWindow;
        private System.Windows.Forms.ToolStripMenuItem ctxCreateLoadTemplate;
        private System.Windows.Forms.ToolStripMenuItem ctxLoadMap;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem ctxDeleteMap;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem ctxDataForProperties;
        private System.Windows.Forms.ToolStripMenuItem ctxDataForFields;
        private System.Windows.Forms.ToolStripMenuItem ctxDataForMethods;
        private System.Windows.Forms.ToolStripMenuItem ctxMapForProperties;
        private System.Windows.Forms.ToolStripMenuItem ctxMapForFields;
        private System.Windows.Forms.ToolStripMenuItem ctxMapForMethods;
        private System.Windows.Forms.ContextMenuStrip ctxAssemblyNode;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicWorkFlowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.RadioButton rbConstructors;
        private System.Windows.Forms.ColumnHeader colObject;
        private System.Windows.Forms.ColumnHeader colType;
        private System.Windows.Forms.ColumnHeader colAcessibility;
        private System.Windows.Forms.ContextMenuStrip ctxMap;
        private System.Windows.Forms.ToolStripMenuItem ctxAutoMap;
        private System.Windows.Forms.ToolStripMenuItem ctxCustomMap;
        private System.Windows.Forms.ToolStripMenuItem ctxClearTableGrid;
    }
}

