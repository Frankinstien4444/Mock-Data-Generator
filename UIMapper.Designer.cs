namespace MockDataGenerator
{
    partial class UIMapper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIMapper));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstMappedPairs = new System.Windows.Forms.ListView();
            this.tableField = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.objectField = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IsNullable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctxMapMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxEditRule = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxDeleteMappingRow = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstObjectTarget = new System.Windows.Forms.ListView();
            this.objectFieldType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.objectFieldName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstDataSource = new System.Windows.Forms.ListView();
            this.fieldType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fieldName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IsNullableRow = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctxDataRules = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataRulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxBool = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCollection = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxDate = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxEnumerator = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxGuid = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxInternalDataLists = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMappedSources = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxNumberRange = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxStringFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxTime = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxTuple = new System.Windows.Forms.ToolStripMenuItem();
            this.editRuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteRuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.btnOK = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.rbModeProp = new System.Windows.Forms.RadioButton();
            this.rbModeParameters = new System.Windows.Forms.RadioButton();
            this.rbModeFields = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuSaveMap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSelectDataRule = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBool = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCollection = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEnumerator = new System.Windows.Forms.ToolStripMenuItem();
            this.guidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInternalDataLists = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMappedSources = new System.Windows.Forms.ToolStripMenuItem();
            this.numberRangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuTime = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTuple = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.lblClassName = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.lblMethodName = new System.Windows.Forms.ToolStripLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.ctxMapMenu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ctxDataRules.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(769, 459);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox3, 2);
            this.groupBox3.Controls.Add(this.lstMappedPairs);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 237);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(763, 198);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mapped Pairs";
            // 
            // lstMappedPairs
            // 
            this.lstMappedPairs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tableField,
            this.objectField,
            this.dataType,
            this.IsNullable});
            this.lstMappedPairs.ContextMenuStrip = this.ctxMapMenu;
            this.lstMappedPairs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMappedPairs.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMappedPairs.FullRowSelect = true;
            this.lstMappedPairs.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstMappedPairs.HideSelection = false;
            this.lstMappedPairs.Location = new System.Drawing.Point(3, 21);
            this.lstMappedPairs.MultiSelect = false;
            this.lstMappedPairs.Name = "lstMappedPairs";
            this.lstMappedPairs.Size = new System.Drawing.Size(757, 174);
            this.lstMappedPairs.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstMappedPairs.TabIndex = 2;
            this.lstMappedPairs.UseCompatibleStateImageBehavior = false;
            this.lstMappedPairs.View = System.Windows.Forms.View.Details;
            // 
            // tableField
            // 
            this.tableField.Text = "Data Field";
            this.tableField.Width = 108;
            // 
            // objectField
            // 
            this.objectField.Text = "Object Field";
            this.objectField.Width = 110;
            // 
            // dataType
            // 
            this.dataType.Text = "DataType";
            this.dataType.Width = 85;
            // 
            // IsNullable
            // 
            this.IsNullable.Text = "Is Nullable";
            this.IsNullable.Width = 80;
            // 
            // ctxMapMenu
            // 
            this.ctxMapMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxEditRule,
            this.ctxDeleteMappingRow});
            this.ctxMapMenu.Name = "ctxMapMenu";
            this.ctxMapMenu.Size = new System.Drawing.Size(185, 48);
            // 
            // ctxEditRule
            // 
            this.ctxEditRule.Name = "ctxEditRule";
            this.ctxEditRule.Size = new System.Drawing.Size(184, 22);
            this.ctxEditRule.Text = "Edit Rule";
            this.ctxEditRule.Click += new System.EventHandler(this.ctxEditRule_Click);
            // 
            // ctxDeleteMappingRow
            // 
            this.ctxDeleteMappingRow.Name = "ctxDeleteMappingRow";
            this.ctxDeleteMappingRow.Size = new System.Drawing.Size(184, 22);
            this.ctxDeleteMappingRow.Text = "Delete Mapping Row";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstObjectTarget);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(387, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 198);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Traget Object";
            // 
            // lstObjectTarget
            // 
            this.lstObjectTarget.AllowDrop = true;
            this.lstObjectTarget.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.objectFieldType,
            this.objectFieldName});
            this.lstObjectTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstObjectTarget.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstObjectTarget.FullRowSelect = true;
            this.lstObjectTarget.HideSelection = false;
            this.lstObjectTarget.Location = new System.Drawing.Point(3, 21);
            this.lstObjectTarget.MultiSelect = false;
            this.lstObjectTarget.Name = "lstObjectTarget";
            this.lstObjectTarget.Size = new System.Drawing.Size(373, 174);
            this.lstObjectTarget.TabIndex = 1;
            this.lstObjectTarget.UseCompatibleStateImageBehavior = false;
            this.lstObjectTarget.View = System.Windows.Forms.View.Details;
            this.lstObjectTarget.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lstObjectTarget_ItemDrag);
            this.lstObjectTarget.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstObjectTarget_DragDrop);
            this.lstObjectTarget.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstObjectTarget_DragEnter);
            this.lstObjectTarget.DoubleClick += new System.EventHandler(this.lstObjectTarget_DoubleClick);
            // 
            // objectFieldType
            // 
            this.objectFieldType.Text = "Field Type";
            this.objectFieldType.Width = 93;
            // 
            // objectFieldName
            // 
            this.objectFieldName.Text = "Field Name";
            this.objectFieldName.Width = 102;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstDataSource);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 198);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Source";
            // 
            // lstDataSource
            // 
            this.lstDataSource.AllowDrop = true;
            this.lstDataSource.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fieldType,
            this.fieldName,
            this.IsNullableRow});
            this.lstDataSource.ContextMenuStrip = this.ctxDataRules;
            this.lstDataSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDataSource.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDataSource.FullRowSelect = true;
            this.lstDataSource.HideSelection = false;
            this.lstDataSource.Location = new System.Drawing.Point(3, 21);
            this.lstDataSource.MultiSelect = false;
            this.lstDataSource.Name = "lstDataSource";
            this.lstDataSource.Size = new System.Drawing.Size(372, 174);
            this.lstDataSource.TabIndex = 0;
            this.lstDataSource.UseCompatibleStateImageBehavior = false;
            this.lstDataSource.View = System.Windows.Forms.View.Details;
            this.lstDataSource.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lstDataSource_ItemDrag);
            this.lstDataSource.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstDataSource_DragDrop);
            this.lstDataSource.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstDataSource_DragEnter);
            // 
            // fieldType
            // 
            this.fieldType.Text = "Field Type";
            this.fieldType.Width = 91;
            // 
            // fieldName
            // 
            this.fieldName.Text = "Field Name";
            this.fieldName.Width = 97;
            // 
            // IsNullableRow
            // 
            this.IsNullableRow.Text = "Is Nullable";
            this.IsNullableRow.Width = 80;
            // 
            // ctxDataRules
            // 
            this.ctxDataRules.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataRulesToolStripMenuItem,
            this.editRuleToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteRuleToolStripMenuItem});
            this.ctxDataRules.Name = "ctxDataRules";
            this.ctxDataRules.Size = new System.Drawing.Size(134, 76);
            // 
            // dataRulesToolStripMenuItem
            // 
            this.dataRulesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxBool,
            this.ctxCollection,
            this.ctxDate,
            this.ctxEnumerator,
            this.ctxGuid,
            this.ctxInternalDataLists,
            this.ctxMappedSources,
            this.ctxNumberRange,
            this.ctxStringFormat,
            this.ctxTime,
            this.ctxTuple});
            this.dataRulesToolStripMenuItem.Name = "dataRulesToolStripMenuItem";
            this.dataRulesToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.dataRulesToolStripMenuItem.Text = "Data Rules";
            // 
            // ctxBool
            // 
            this.ctxBool.Name = "ctxBool";
            this.ctxBool.Size = new System.Drawing.Size(167, 22);
            this.ctxBool.Text = "Bool";
            this.ctxBool.Click += new System.EventHandler(this.mnuBool_Click);
            // 
            // ctxCollection
            // 
            this.ctxCollection.Name = "ctxCollection";
            this.ctxCollection.Size = new System.Drawing.Size(167, 22);
            this.ctxCollection.Text = "Collection";
            this.ctxCollection.Click += new System.EventHandler(this.mnuCollection_Click);
            // 
            // ctxDate
            // 
            this.ctxDate.Name = "ctxDate";
            this.ctxDate.Size = new System.Drawing.Size(167, 22);
            this.ctxDate.Text = "Date";
            this.ctxDate.Click += new System.EventHandler(this.mnuDate_Click);
            // 
            // ctxEnumerator
            // 
            this.ctxEnumerator.Name = "ctxEnumerator";
            this.ctxEnumerator.Size = new System.Drawing.Size(167, 22);
            this.ctxEnumerator.Text = "Enumerator";
            this.ctxEnumerator.Click += new System.EventHandler(this.ctxEnumerator_Click);
            // 
            // ctxGuid
            // 
            this.ctxGuid.Name = "ctxGuid";
            this.ctxGuid.Size = new System.Drawing.Size(167, 22);
            this.ctxGuid.Text = "Guid";
            this.ctxGuid.Click += new System.EventHandler(this.guidToolStripMenuItem_Click);
            // 
            // ctxInternalDataLists
            // 
            this.ctxInternalDataLists.Name = "ctxInternalDataLists";
            this.ctxInternalDataLists.Size = new System.Drawing.Size(167, 22);
            this.ctxInternalDataLists.Text = "Internal Data Lists";
            this.ctxInternalDataLists.Click += new System.EventHandler(this.internalDataListsToolStripMenuItem_Click);
            // 
            // ctxMappedSources
            // 
            this.ctxMappedSources.Name = "ctxMappedSources";
            this.ctxMappedSources.Size = new System.Drawing.Size(167, 22);
            this.ctxMappedSources.Text = "Mapped Sources";
            this.ctxMappedSources.Click += new System.EventHandler(this.ctxMappedSources_Click);
            // 
            // ctxNumberRange
            // 
            this.ctxNumberRange.Name = "ctxNumberRange";
            this.ctxNumberRange.Size = new System.Drawing.Size(167, 22);
            this.ctxNumberRange.Text = "Number Range";
            this.ctxNumberRange.Click += new System.EventHandler(this.numberRangeToolStripMenuItem_Click);
            // 
            // ctxStringFormat
            // 
            this.ctxStringFormat.Name = "ctxStringFormat";
            this.ctxStringFormat.Size = new System.Drawing.Size(167, 22);
            this.ctxStringFormat.Text = "String";
            this.ctxStringFormat.Click += new System.EventHandler(this.stringFormatToolStripMenuItem_Click);
            // 
            // ctxTime
            // 
            this.ctxTime.Name = "ctxTime";
            this.ctxTime.Size = new System.Drawing.Size(167, 22);
            this.ctxTime.Text = "Time";
            this.ctxTime.Click += new System.EventHandler(this.MnuTime_Click);
            // 
            // ctxTuple
            // 
            this.ctxTuple.Name = "ctxTuple";
            this.ctxTuple.Size = new System.Drawing.Size(167, 22);
            this.ctxTuple.Text = "Tuple";
            this.ctxTuple.Click += new System.EventHandler(this.ctxTuple_Click);
            // 
            // editRuleToolStripMenuItem
            // 
            this.editRuleToolStripMenuItem.Name = "editRuleToolStripMenuItem";
            this.editRuleToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.editRuleToolStripMenuItem.Text = "Edit Rule";
            this.editRuleToolStripMenuItem.Click += new System.EventHandler(this.editRuleToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(130, 6);
            // 
            // deleteRuleToolStripMenuItem
            // 
            this.deleteRuleToolStripMenuItem.Name = "deleteRuleToolStripMenuItem";
            this.deleteRuleToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.deleteRuleToolStripMenuItem.Text = "Delete Rule";
            // 
            // toolStrip1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.toolStrip1, 2);
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCancel,
            this.btnOK,
            this.toolStripLabel1,
            this.lblClassName,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.lblMethodName});
            this.toolStrip1.Location = new System.Drawing.Point(0, 438);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(769, 21);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCancel
            // 
            this.btnCancel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(47, 18);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnOK.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(27, 18);
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.rbModeProp, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.rbModeParameters, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.rbModeFields, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(763, 24);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // rbModeProp
            // 
            this.rbModeProp.AutoSize = true;
            this.rbModeProp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbModeProp.Location = new System.Drawing.Point(3, 3);
            this.rbModeProp.Name = "rbModeProp";
            this.rbModeProp.Size = new System.Drawing.Size(248, 18);
            this.rbModeProp.TabIndex = 2;
            this.rbModeProp.TabStop = true;
            this.rbModeProp.Text = "Properties";
            this.rbModeProp.UseVisualStyleBackColor = true;
            this.rbModeProp.CheckedChanged += new System.EventHandler(this.rbCheckedChanged);
            // 
            // rbModeParameters
            // 
            this.rbModeParameters.AutoSize = true;
            this.rbModeParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbModeParameters.Location = new System.Drawing.Point(511, 3);
            this.rbModeParameters.Name = "rbModeParameters";
            this.rbModeParameters.Size = new System.Drawing.Size(249, 18);
            this.rbModeParameters.TabIndex = 0;
            this.rbModeParameters.TabStop = true;
            this.rbModeParameters.Text = "Parameters";
            this.rbModeParameters.UseVisualStyleBackColor = true;
            // 
            // rbModeFields
            // 
            this.rbModeFields.AutoSize = true;
            this.rbModeFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbModeFields.Location = new System.Drawing.Point(257, 3);
            this.rbModeFields.Name = "rbModeFields";
            this.rbModeFields.Size = new System.Drawing.Size(248, 18);
            this.rbModeFields.TabIndex = 1;
            this.rbModeFields.TabStop = true;
            this.rbModeFields.Text = "Fields";
            this.rbModeFields.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSaveMap,
            this.mnuSelectDataRule});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(769, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuSaveMap
            // 
            this.mnuSaveMap.BackColor = System.Drawing.Color.Red;
            this.mnuSaveMap.Name = "mnuSaveMap";
            this.mnuSaveMap.Size = new System.Drawing.Size(70, 20);
            this.mnuSaveMap.Text = "Save Map";
            this.mnuSaveMap.Click += new System.EventHandler(this.mnuSaveMap_Click);
            // 
            // mnuSelectDataRule
            // 
            this.mnuSelectDataRule.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBool,
            this.mnuCollection,
            this.mnuDate,
            this.mnuEnumerator,
            this.guidToolStripMenuItem,
            this.mnuInternalDataLists,
            this.mnuMappedSources,
            this.numberRangeToolStripMenuItem,
            this.randomStringToolStripMenuItem,
            this.MnuTime,
            this.mnuTuple});
            this.mnuSelectDataRule.Name = "mnuSelectDataRule";
            this.mnuSelectDataRule.Size = new System.Drawing.Size(94, 20);
            this.mnuSelectDataRule.Text = "Add Data Rule";
            // 
            // mnuBool
            // 
            this.mnuBool.Name = "mnuBool";
            this.mnuBool.Size = new System.Drawing.Size(167, 22);
            this.mnuBool.Text = "Bool";
            this.mnuBool.Click += new System.EventHandler(this.mnuBool_Click);
            // 
            // mnuCollection
            // 
            this.mnuCollection.Name = "mnuCollection";
            this.mnuCollection.Size = new System.Drawing.Size(167, 22);
            this.mnuCollection.Text = "Collection";
            this.mnuCollection.Click += new System.EventHandler(this.mnuCollection_Click);
            // 
            // mnuDate
            // 
            this.mnuDate.Name = "mnuDate";
            this.mnuDate.Size = new System.Drawing.Size(167, 22);
            this.mnuDate.Text = "Date";
            this.mnuDate.Click += new System.EventHandler(this.mnuDate_Click);
            // 
            // mnuEnumerator
            // 
            this.mnuEnumerator.Name = "mnuEnumerator";
            this.mnuEnumerator.Size = new System.Drawing.Size(167, 22);
            this.mnuEnumerator.Text = "Enumerator";
            // 
            // guidToolStripMenuItem
            // 
            this.guidToolStripMenuItem.Name = "guidToolStripMenuItem";
            this.guidToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.guidToolStripMenuItem.Text = "Guid";
            this.guidToolStripMenuItem.Click += new System.EventHandler(this.guidToolStripMenuItem_Click);
            // 
            // mnuInternalDataLists
            // 
            this.mnuInternalDataLists.Name = "mnuInternalDataLists";
            this.mnuInternalDataLists.Size = new System.Drawing.Size(167, 22);
            this.mnuInternalDataLists.Text = "Internal Data Lists";
            this.mnuInternalDataLists.Click += new System.EventHandler(this.internalDataListsToolStripMenuItem_Click);
            // 
            // mnuMappedSources
            // 
            this.mnuMappedSources.Name = "mnuMappedSources";
            this.mnuMappedSources.Size = new System.Drawing.Size(167, 22);
            this.mnuMappedSources.Text = "Mapped Sources";
            // 
            // numberRangeToolStripMenuItem
            // 
            this.numberRangeToolStripMenuItem.Name = "numberRangeToolStripMenuItem";
            this.numberRangeToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.numberRangeToolStripMenuItem.Text = "Number Range";
            this.numberRangeToolStripMenuItem.Click += new System.EventHandler(this.numberRangeToolStripMenuItem_Click);
            // 
            // randomStringToolStripMenuItem
            // 
            this.randomStringToolStripMenuItem.Name = "randomStringToolStripMenuItem";
            this.randomStringToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.randomStringToolStripMenuItem.Text = "String";
            // 
            // MnuTime
            // 
            this.MnuTime.Name = "MnuTime";
            this.MnuTime.Size = new System.Drawing.Size(167, 22);
            this.MnuTime.Text = "Time";
            this.MnuTime.Click += new System.EventHandler(this.MnuTime_Click);
            // 
            // mnuTuple
            // 
            this.mnuTuple.Name = "mnuTuple";
            this.mnuTuple.Size = new System.Drawing.Size(167, 22);
            this.mnuTuple.Text = "Tuple";
            this.mnuTuple.Click += new System.EventHandler(this.ctxTuple_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(72, 18);
            this.toolStripLabel1.Text = "Class Name:";
            // 
            // lblClassName
            // 
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(24, 18);
            this.lblClassName.Text = "NA";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 21);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(52, 18);
            this.toolStripLabel2.Text = "Method:";
            // 
            // lblMethodName
            // 
            this.lblMethodName.Name = "lblMethodName";
            this.lblMethodName.Size = new System.Drawing.Size(24, 18);
            this.lblMethodName.Text = "NA";
            // 
            // UIMapper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 483);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UIMapper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mapper";
            this.Activated += new System.EventHandler(this.UIMapper_Activated);
            this.Load += new System.EventHandler(this.UIMapper_Load);
            this.Resize += new System.EventHandler(this.UIMapper_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ctxMapMenu.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ctxDataRules.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView lstObjectTarget;
        private System.Windows.Forms.ColumnHeader objectFieldType;
        private System.Windows.Forms.ColumnHeader objectFieldName;
        private System.Windows.Forms.ListView lstDataSource;
        private System.Windows.Forms.ColumnHeader fieldType;
        private System.Windows.Forms.ColumnHeader fieldName;
        private System.Windows.Forms.ListView lstMappedPairs;
        private System.Windows.Forms.ColumnHeader tableField;
        private System.Windows.Forms.ColumnHeader objectField;
        private System.Windows.Forms.ColumnHeader dataType;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveMap;
        private System.Windows.Forms.ToolStripMenuItem mnuSelectDataRule;
        private System.Windows.Forms.ToolStripMenuItem numberRangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomStringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuInternalDataLists;
        private System.Windows.Forms.ContextMenuStrip ctxDataRules;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripButton btnOK;
        private System.Windows.Forms.ColumnHeader IsNullable;
        private System.Windows.Forms.ColumnHeader IsNullableRow;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton rbModeProp;
        private System.Windows.Forms.RadioButton rbModeParameters;
        private System.Windows.Forms.RadioButton rbModeFields;
        private System.Windows.Forms.ToolStripMenuItem mnuDate;
        private System.Windows.Forms.ToolStripMenuItem MnuTime;
        private System.Windows.Forms.ToolStripMenuItem dataRulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ctxNumberRange;
        private System.Windows.Forms.ToolStripMenuItem ctxGuid;
        private System.Windows.Forms.ToolStripMenuItem ctxStringFormat;
        private System.Windows.Forms.ToolStripMenuItem ctxDate;
        private System.Windows.Forms.ToolStripMenuItem ctxTime;
        private System.Windows.Forms.ToolStripMenuItem ctxInternalDataLists;
        private System.Windows.Forms.ToolStripMenuItem editRuleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deleteRuleToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ctxMapMenu;
        private System.Windows.Forms.ToolStripMenuItem ctxEditRule;
        private System.Windows.Forms.ToolStripMenuItem ctxDeleteMappingRow;
        private System.Windows.Forms.ToolStripMenuItem mnuCollection;
        private System.Windows.Forms.ToolStripMenuItem ctxCollection;
        private System.Windows.Forms.ToolStripMenuItem ctxBool;
        private System.Windows.Forms.ToolStripMenuItem mnuBool;
        private System.Windows.Forms.ToolStripMenuItem mnuTuple;
        private System.Windows.Forms.ToolStripMenuItem ctxTuple;
        private System.Windows.Forms.ToolStripMenuItem mnuEnumerator;
        private System.Windows.Forms.ToolStripMenuItem mnuMappedSources;
        private System.Windows.Forms.ToolStripMenuItem ctxEnumerator;
        private System.Windows.Forms.ToolStripMenuItem ctxMappedSources;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel lblClassName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel lblMethodName;
    }
}