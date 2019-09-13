namespace MockDataGenerator
{
    partial class CollectionDialog
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
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.collectionsCtrl = new MockDataGenerator.Controls.CollectionsCtrl();
            this.standardDataTypesCtrl = new MockDataGenerator.Controls.StandardDataTypesCtrl();
            this.descriptionCtrl = new MockDataGenerator.Controls.DescriptionCtrl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSet = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.ruleContainer = new System.Windows.Forms.TableLayoutPanel();
            this.rbKey = new System.Windows.Forms.RadioButton();
            this.rbValue = new System.Windows.Forms.RadioButton();
            this.lblKeyRule = new System.Windows.Forms.Label();
            this.lblValueRule = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.ruleContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.ColumnCount = 3;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 174F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanel.Controls.Add(this.collectionsCtrl, 0, 0);
            this.mainPanel.Controls.Add(this.standardDataTypesCtrl, 1, 0);
            this.mainPanel.Controls.Add(this.descriptionCtrl, 0, 1);
            this.mainPanel.Controls.Add(this.menuStrip1, 0, 2);
            this.mainPanel.Controls.Add(this.ruleContainer, 2, 0);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 3;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.mainPanel.Size = new System.Drawing.Size(762, 552);
            this.mainPanel.TabIndex = 0;
            // 
            // collectionsCtrl
            // 
            this.collectionsCtrl.Assemblyname = null;
            this.collectionsCtrl.AssemblyPath = null;
            this.collectionsCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.collectionsCtrl.Location = new System.Drawing.Point(3, 3);
            this.collectionsCtrl.Name = "collectionsCtrl";           
            this.collectionsCtrl.Size = new System.Drawing.Size(168, 252);
            this.collectionsCtrl.TabIndex = 0;
            // 
            // standardDataTypesCtrl
            // 
            this.standardDataTypesCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.standardDataTypesCtrl.Enabled = false;
            this.standardDataTypesCtrl.Location = new System.Drawing.Point(177, 3);
            this.standardDataTypesCtrl.Name = "standardDataTypesCtrl";
            this.standardDataTypesCtrl.Size = new System.Drawing.Size(162, 252);
            this.standardDataTypesCtrl.TabIndex = 1;
            // 
            // descriptionCtrl
            // 
            this.mainPanel.SetColumnSpan(this.descriptionCtrl, 2);
            this.descriptionCtrl.Description = "";
            this.descriptionCtrl.DescriptionChange = null;
            this.descriptionCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionCtrl.FieldDisplay = "No Field Displayed";
            this.descriptionCtrl.Location = new System.Drawing.Point(3, 261);
            this.descriptionCtrl.Name = "descriptionCtrl";
            this.descriptionCtrl.Size = new System.Drawing.Size(336, 252);
            this.descriptionCtrl.TabIndex = 2;
            this.descriptionCtrl.TypeDisplay = "No Type Displayed";
            // 
            // menuStrip1
            // 
            this.mainPanel.SetColumnSpan(this.menuStrip1, 3);
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCancel,
            this.mnuSet,
            this.mnuAdd});
            this.menuStrip1.Location = new System.Drawing.Point(0, 516);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(762, 36);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuCancel
            // 
            this.mnuCancel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuCancel.Name = "mnuCancel";
            this.mnuCancel.Size = new System.Drawing.Size(66, 32);
            this.mnuCancel.Text = "Cancel";
            this.mnuCancel.Click += new System.EventHandler(this.mnuCancel_Click);
            // 
            // mnuSet
            // 
            this.mnuSet.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuSet.Enabled = false;
            this.mnuSet.Name = "mnuSet";
            this.mnuSet.Size = new System.Drawing.Size(42, 32);
            this.mnuSet.Text = "Set";
            this.mnuSet.Click += new System.EventHandler(this.mnuSet_Click);
            // 
            // mnuAdd
            // 
            this.mnuAdd.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuAdd.Name = "mnuAdd";
            this.mnuAdd.Size = new System.Drawing.Size(79, 32);
            this.mnuAdd.Text = "Add Rule";
            this.mnuAdd.Click += new System.EventHandler(this.mnuAdd_Click);
            // 
            // ruleContainer
            // 
            this.ruleContainer.ColumnCount = 2;
            this.ruleContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ruleContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ruleContainer.Controls.Add(this.rbKey, 0, 0);
            this.ruleContainer.Controls.Add(this.rbValue, 1, 0);
            this.ruleContainer.Controls.Add(this.lblKeyRule, 0, 1);
            this.ruleContainer.Controls.Add(this.lblValueRule, 1, 1);
            this.ruleContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ruleContainer.Location = new System.Drawing.Point(345, 3);
            this.ruleContainer.Name = "ruleContainer";
            this.ruleContainer.RowCount = 3;
            this.mainPanel.SetRowSpan(this.ruleContainer, 2);
            this.ruleContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ruleContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ruleContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ruleContainer.Size = new System.Drawing.Size(414, 510);
            this.ruleContainer.TabIndex = 4;
            // 
            // rbKey
            // 
            this.rbKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rbKey.AutoSize = true;
            this.rbKey.Enabled = false;
            this.rbKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKey.Location = new System.Drawing.Point(78, 3);
            this.rbKey.Name = "rbKey";
            this.rbKey.Size = new System.Drawing.Size(51, 24);
            this.rbKey.TabIndex = 0;
            this.rbKey.Text = "Key";
            this.rbKey.UseVisualStyleBackColor = true;
            // 
            // rbValue
            // 
            this.rbValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rbValue.AutoSize = true;
            this.rbValue.Checked = true;
            this.rbValue.Enabled = false;
            this.rbValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbValue.Location = new System.Drawing.Point(279, 3);
            this.rbValue.Name = "rbValue";
            this.rbValue.Size = new System.Drawing.Size(62, 24);
            this.rbValue.TabIndex = 1;
            this.rbValue.TabStop = true;
            this.rbValue.Text = "Value";
            this.rbValue.UseVisualStyleBackColor = true;
            // 
            // lblKeyRule
            // 
            this.lblKeyRule.BackColor = System.Drawing.Color.Cornsilk;
            this.lblKeyRule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKeyRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyRule.Location = new System.Drawing.Point(3, 30);
            this.lblKeyRule.Name = "lblKeyRule";
            this.lblKeyRule.Size = new System.Drawing.Size(201, 30);
            this.lblKeyRule.TabIndex = 2;
            this.lblKeyRule.Text = "NA";
            this.lblKeyRule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValueRule
            // 
            this.lblValueRule.BackColor = System.Drawing.Color.Cornsilk;
            this.lblValueRule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValueRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueRule.Location = new System.Drawing.Point(210, 30);
            this.lblValueRule.Name = "lblValueRule";
            this.lblValueRule.Size = new System.Drawing.Size(201, 30);
            this.lblValueRule.TabIndex = 3;
            this.lblValueRule.Text = "NA";
            this.lblValueRule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CollectionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 552);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CollectionDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Collections";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ruleContainer.ResumeLayout(false);
            this.ruleContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private Controls.CollectionsCtrl collectionsCtrl;
        private Controls.StandardDataTypesCtrl standardDataTypesCtrl;
        private Controls.DescriptionCtrl descriptionCtrl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuCancel;
        private System.Windows.Forms.ToolStripMenuItem mnuSet;
        private System.Windows.Forms.TableLayoutPanel ruleContainer;
        private System.Windows.Forms.RadioButton rbKey;
        private System.Windows.Forms.RadioButton rbValue;
        private System.Windows.Forms.Label lblKeyRule;
        private System.Windows.Forms.Label lblValueRule;
        private System.Windows.Forms.ToolStripMenuItem mnuAdd;
    }
}