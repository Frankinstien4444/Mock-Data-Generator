namespace MockDataGenerator.Controls.InternalLists
{
    partial class SingleColumnListCtrl
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuBack = new System.Windows.Forms.ToolStripButton();
            this.mnuForward = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblCurrentPage = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.lblTotalPages = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tbPageSize = new System.Windows.Forms.ToolStripTextBox();
            this.maxRecPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaxRecords = new System.Windows.Forms.TextBox();
            this.lstColumn = new System.Windows.Forms.ListBox();
            this.rangeCtrl = new MockDataGenerator.Controls.InternalLists.SupportControls.Range();
            this.regularExpressionCtrl = new MockDataGenerator.Controls.InternalLists.SupportControls.RegularExpressionCtrl();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.maxRecPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.maxRecPanel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lstColumn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rangeCtrl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.regularExpressionCtrl, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(504, 536);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.toolStrip1, 2);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.mnuBack,
            this.mnuForward,
            this.toolStripSeparator2,
            this.lblCurrentPage,
            this.toolStripSeparator3,
            this.lblTotalPages,
            this.toolStripSeparator4,
            this.toolStripLabel1,
            this.tbPageSize});
            this.toolStrip1.Location = new System.Drawing.Point(0, 510);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(504, 25);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // mnuBack
            // 
            this.mnuBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuBack.Image = global::MockDataGenerator.Properties.Resources.Back_arrow_icon;
            this.mnuBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(23, 22);
            this.mnuBack.Text = "toolStripButton1";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // mnuForward
            // 
            this.mnuForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuForward.Image = global::MockDataGenerator.Properties.Resources.ForeWard;
            this.mnuForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuForward.Name = "mnuForward";
            this.mnuForward.Size = new System.Drawing.Size(23, 22);
            this.mnuForward.Text = "toolStripButton2";
            this.mnuForward.Click += new System.EventHandler(this.mnuForward_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // lblCurrentPage
            // 
            this.lblCurrentPage.Name = "lblCurrentPage";
            this.lblCurrentPage.Size = new System.Drawing.Size(43, 22);
            this.lblCurrentPage.Text = "Page:#";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // lblTotalPages
            // 
            this.lblTotalPages.Name = "lblTotalPages";
            this.lblTotalPages.Size = new System.Drawing.Size(64, 22);
            this.lblTotalPages.Text = "Of # Pages";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel1.Text = "Page Size:";
            // 
            // tbPageSize
            // 
            this.tbPageSize.Name = "tbPageSize";
            this.tbPageSize.Size = new System.Drawing.Size(132, 25);
            this.tbPageSize.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbPageSize_KeyUp);
            // 
            // maxRecPanel
            // 
            this.maxRecPanel.ColumnCount = 2;
            this.maxRecPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.maxRecPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.maxRecPanel.Controls.Add(this.label2, 0, 0);
            this.maxRecPanel.Controls.Add(this.txtMaxRecords, 1, 0);
            this.maxRecPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maxRecPanel.Location = new System.Drawing.Point(256, 468);
            this.maxRecPanel.Margin = new System.Windows.Forms.Padding(4);
            this.maxRecPanel.Name = "maxRecPanel";
            this.maxRecPanel.RowCount = 1;
            this.maxRecPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.maxRecPanel.Size = new System.Drawing.Size(244, 38);
            this.maxRecPanel.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Max Records";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaxRecords
            // 
            this.txtMaxRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaxRecords.Location = new System.Drawing.Point(126, 4);
            this.txtMaxRecords.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaxRecords.Name = "txtMaxRecords";
            this.txtMaxRecords.Size = new System.Drawing.Size(114, 24);
            this.txtMaxRecords.TabIndex = 0;
            // 
            // lstColumn
            // 
            this.lstColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstColumn.FormattingEnabled = true;
            this.lstColumn.ItemHeight = 18;
            this.lstColumn.Location = new System.Drawing.Point(4, 4);
            this.lstColumn.Margin = new System.Windows.Forms.Padding(4);
            this.lstColumn.Name = "lstColumn";
            this.tableLayoutPanel1.SetRowSpan(this.lstColumn, 3);
            this.lstColumn.Size = new System.Drawing.Size(244, 502);
            this.lstColumn.Sorted = true;
            this.lstColumn.TabIndex = 0;
            // 
            // rangeCtrl
            // 
            this.rangeCtrl.CheckState = null;
            this.rangeCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rangeCtrl.End = "";
            this.rangeCtrl.ExportEnd = null;
            this.rangeCtrl.ExportRandom = null;
            this.rangeCtrl.ExportStart = null;
            this.rangeCtrl.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rangeCtrl.Location = new System.Drawing.Point(257, 5);
            this.rangeCtrl.Margin = new System.Windows.Forms.Padding(5);
            this.rangeCtrl.Name = "rangeCtrl";
            this.rangeCtrl.Random = false;
            this.rangeCtrl.Size = new System.Drawing.Size(242, 120);
            this.rangeCtrl.Start = "";
            this.rangeCtrl.TabIndex = 14;
            // 
            // regularExpressionCtrl
            // 
            this.regularExpressionCtrl.CheckState = null;
            this.regularExpressionCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.regularExpressionCtrl.ExportExpression = null;
            this.regularExpressionCtrl.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regularExpressionCtrl.Location = new System.Drawing.Point(257, 135);
            this.regularExpressionCtrl.Margin = new System.Windows.Forms.Padding(5);
            this.regularExpressionCtrl.Name = "regularExpressionCtrl";
            this.regularExpressionCtrl.RegularExpression = "";
            this.regularExpressionCtrl.Size = new System.Drawing.Size(242, 324);
            this.regularExpressionCtrl.TabIndex = 15;
            // 
            // SingleColumnListCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SingleColumnListCtrl";
            this.Size = new System.Drawing.Size(504, 536);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.maxRecPanel.ResumeLayout(false);
            this.maxRecPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel maxRecPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaxRecords;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton mnuBack;
        private System.Windows.Forms.ToolStripButton mnuForward;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel lblCurrentPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel lblTotalPages;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tbPageSize;
        private System.Windows.Forms.ListBox lstColumn;
        private SupportControls.Range rangeCtrl;
        private SupportControls.RegularExpressionCtrl regularExpressionCtrl;
    }
}
