namespace MockDataGenerator
{
    partial class TupleDialog
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
            this.ruleContainer = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSet = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditRule = new System.Windows.Forms.ToolStripMenuItem();
            this.descriptionCtrl = new MockDataGenerator.Controls.DescriptionCtrl();
            this.standardDataTypesCtrl = new MockDataGenerator.Controls.StandardDataTypesCtrl();
            this.tupleCtrl = new MockDataGenerator.Controls.TupleCtrl();
            this.ruleContainer.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ruleContainer
            // 
            this.ruleContainer.ColumnCount = 3;
            this.ruleContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 174F));
            this.ruleContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 174F));
            this.ruleContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ruleContainer.Controls.Add(this.menuStrip1, 0, 2);
            this.ruleContainer.Controls.Add(this.descriptionCtrl, 0, 1);
            this.ruleContainer.Controls.Add(this.standardDataTypesCtrl, 0, 0);
            this.ruleContainer.Controls.Add(this.tupleCtrl, 1, 0);
            this.ruleContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ruleContainer.Location = new System.Drawing.Point(0, 0);
            this.ruleContainer.Name = "ruleContainer";
            this.ruleContainer.RowCount = 3;
            this.ruleContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ruleContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ruleContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.ruleContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ruleContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ruleContainer.Size = new System.Drawing.Size(817, 499);
            this.ruleContainer.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.ruleContainer.SetColumnSpan(this.menuStrip1, 3);
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCancel,
            this.mnuSet,
            this.mnuAdd,
            this.mnuEditRule});
            this.menuStrip1.Location = new System.Drawing.Point(0, 464);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(817, 35);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuCancel
            // 
            this.mnuCancel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuCancel.Name = "mnuCancel";
            this.mnuCancel.Size = new System.Drawing.Size(66, 31);
            this.mnuCancel.Text = "Cancel";
            this.mnuCancel.Click += new System.EventHandler(this.mnuCancel_Click);
            // 
            // mnuSet
            // 
            this.mnuSet.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuSet.Enabled = false;
            this.mnuSet.Name = "mnuSet";
            this.mnuSet.Size = new System.Drawing.Size(42, 31);
            this.mnuSet.Text = "Set";
            this.mnuSet.Click += new System.EventHandler(this.mnuSet_Click);
            // 
            // mnuAdd
            // 
            this.mnuAdd.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuAdd.Name = "mnuAdd";
            this.mnuAdd.Size = new System.Drawing.Size(79, 31);
            this.mnuAdd.Text = "Add Rule";
            this.mnuAdd.Click += new System.EventHandler(this.mnuAdd_Click);
            // 
            // mnuEditRule
            // 
            this.mnuEditRule.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuEditRule.Enabled = false;
            this.mnuEditRule.Name = "mnuEditRule";
            this.mnuEditRule.Size = new System.Drawing.Size(79, 31);
            this.mnuEditRule.Text = "Edit Rule";
            this.mnuEditRule.Click += new System.EventHandler(this.mnuEditRule_Click);
            // 
            // descriptionCtrl
            // 
            this.ruleContainer.SetColumnSpan(this.descriptionCtrl, 2);
            this.descriptionCtrl.Description = "";
            this.descriptionCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionCtrl.FieldDisplay = "No Field Displayed";
            this.descriptionCtrl.Location = new System.Drawing.Point(4, 236);
            this.descriptionCtrl.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionCtrl.Name = "descriptionCtrl";
            this.descriptionCtrl.Size = new System.Drawing.Size(340, 224);
            this.descriptionCtrl.TabIndex = 3;
            this.descriptionCtrl.TypeDisplay = "No Type Displayed";
            // 
            // standardDataTypesCtrl
            // 
            this.standardDataTypesCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.standardDataTypesCtrl.Location = new System.Drawing.Point(4, 4);
            this.standardDataTypesCtrl.Margin = new System.Windows.Forms.Padding(4);
            this.standardDataTypesCtrl.Name = "standardDataTypesCtrl";
            this.standardDataTypesCtrl.Size = new System.Drawing.Size(166, 224);
            this.standardDataTypesCtrl.TabIndex = 4;
            // 
            // tupleCtrl
            // 
            this.tupleCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tupleCtrl.Location = new System.Drawing.Point(178, 4);
            this.tupleCtrl.Margin = new System.Windows.Forms.Padding(4);
            this.tupleCtrl.Name = "tupleCtrl";            
            this.tupleCtrl.Size = new System.Drawing.Size(166, 224);
            this.tupleCtrl.TabIndex = 6;
            this.tupleCtrl.TupleRuleSelected = null;
            // 
            // TupleDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 499);
            this.Controls.Add(this.ruleContainer);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TupleDialog";
            this.Text = "Tuple";
            this.ruleContainer.ResumeLayout(false);
            this.ruleContainer.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ruleContainer;
        private Controls.DescriptionCtrl descriptionCtrl;
        private Controls.StandardDataTypesCtrl standardDataTypesCtrl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuCancel;
        private System.Windows.Forms.ToolStripMenuItem mnuSet;
        private System.Windows.Forms.ToolStripMenuItem mnuAdd;
        private Controls.TupleCtrl tupleCtrl;
        private System.Windows.Forms.ToolStripMenuItem mnuEditRule;
    }
}