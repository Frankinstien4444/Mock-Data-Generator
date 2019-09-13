namespace MockDataGenerator.Controls.InternalLists.SupportControls
{
    partial class SelectionCtrl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.chkSelection = new System.Windows.Forms.CheckedListBox();
            this.rbSearchField = new System.Windows.Forms.RadioButton();
            this.rbDataFields = new System.Windows.Forms.RadioButton();
            this.logicPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.rbAnnd = new System.Windows.Forms.RadioButton();
            this.rbOR = new System.Windows.Forms.RadioButton();
            this.rbXOR = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.logicPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chkSelection, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rbSearchField, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.rbDataFields, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.logicPanel, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(364, 306);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblTitle, 2);
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(358, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // chkSelection
            // 
            this.chkSelection.AllowDrop = true;
            this.tableLayoutPanel1.SetColumnSpan(this.chkSelection, 2);
            this.chkSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkSelection.FormattingEnabled = true;
            this.chkSelection.Location = new System.Drawing.Point(3, 33);
            this.chkSelection.Name = "chkSelection";
            this.chkSelection.Size = new System.Drawing.Size(358, 210);
            this.chkSelection.TabIndex = 1;
            this.chkSelection.SelectedIndexChanged += new System.EventHandler(this.chkSelection_SelectedIndexChanged);
            // 
            // rbSearchField
            // 
            this.rbSearchField.AutoSize = true;
            this.rbSearchField.Checked = true;
            this.rbSearchField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbSearchField.Location = new System.Drawing.Point(3, 249);
            this.rbSearchField.Name = "rbSearchField";
            this.rbSearchField.Size = new System.Drawing.Size(176, 24);
            this.rbSearchField.TabIndex = 2;
            this.rbSearchField.TabStop = true;
            this.rbSearchField.Text = "Search Fields";
            this.rbSearchField.UseVisualStyleBackColor = true;
            this.rbSearchField.CheckedChanged += new System.EventHandler(this.rbField_CheckedChanged);
            // 
            // rbDataFields
            // 
            this.rbDataFields.AutoSize = true;
            this.rbDataFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbDataFields.Location = new System.Drawing.Point(185, 249);
            this.rbDataFields.Name = "rbDataFields";
            this.rbDataFields.Size = new System.Drawing.Size(176, 24);
            this.rbDataFields.TabIndex = 3;
            this.rbDataFields.Text = "Data Fields";
            this.rbDataFields.UseVisualStyleBackColor = true;
            this.rbDataFields.CheckedChanged += new System.EventHandler(this.rbField_CheckedChanged);
            // 
            // logicPanel
            // 
            this.logicPanel.ColumnCount = 4;
            this.tableLayoutPanel1.SetColumnSpan(this.logicPanel, 2);
            this.logicPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.logicPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.logicPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.logicPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.logicPanel.Controls.Add(this.label1, 0, 0);
            this.logicPanel.Controls.Add(this.rbAnnd, 1, 0);
            this.logicPanel.Controls.Add(this.rbOR, 2, 0);
            this.logicPanel.Controls.Add(this.rbXOR, 3, 0);
            this.logicPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logicPanel.Enabled = false;
            this.logicPanel.Location = new System.Drawing.Point(3, 279);
            this.logicPanel.Name = "logicPanel";
            this.logicPanel.RowCount = 1;
            this.logicPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.logicPanel.Size = new System.Drawing.Size(358, 24);
            this.logicPanel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Field Logic";
            // 
            // rbAnnd
            // 
            this.rbAnnd.AutoSize = true;
            this.rbAnnd.Checked = true;
            this.rbAnnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbAnnd.Location = new System.Drawing.Point(88, 3);
            this.rbAnnd.Name = "rbAnnd";
            this.rbAnnd.Size = new System.Drawing.Size(84, 18);
            this.rbAnnd.TabIndex = 1;
            this.rbAnnd.TabStop = true;
            this.rbAnnd.Text = "AND";
            this.rbAnnd.UseVisualStyleBackColor = true;
            this.rbAnnd.CheckedChanged += new System.EventHandler(this.rbLogic_CheckedChanged);
            // 
            // rbOR
            // 
            this.rbOR.AutoSize = true;
            this.rbOR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbOR.Location = new System.Drawing.Point(178, 3);
            this.rbOR.Name = "rbOR";
            this.rbOR.Size = new System.Drawing.Size(84, 18);
            this.rbOR.TabIndex = 2;
            this.rbOR.TabStop = true;
            this.rbOR.Text = "OR";
            this.rbOR.UseVisualStyleBackColor = true;
            // 
            // rbXOR
            // 
            this.rbXOR.AutoSize = true;
            this.rbXOR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbXOR.Location = new System.Drawing.Point(268, 3);
            this.rbXOR.Name = "rbXOR";
            this.rbXOR.Size = new System.Drawing.Size(87, 18);
            this.rbXOR.TabIndex = 3;
            this.rbXOR.TabStop = true;
            this.rbXOR.Text = "XOR";
            this.rbXOR.UseVisualStyleBackColor = true;
            this.rbXOR.CheckedChanged += new System.EventHandler(this.rbLogic_CheckedChanged);
            // 
            // SelectionCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SelectionCtrl";
            this.Size = new System.Drawing.Size(364, 306);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.logicPanel.ResumeLayout(false);
            this.logicPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.CheckedListBox chkSelection;
        private System.Windows.Forms.RadioButton rbSearchField;
        private System.Windows.Forms.RadioButton rbDataFields;
        private System.Windows.Forms.TableLayoutPanel logicPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbAnnd;
        private System.Windows.Forms.RadioButton rbOR;
        private System.Windows.Forms.RadioButton rbXOR;
    }
}
