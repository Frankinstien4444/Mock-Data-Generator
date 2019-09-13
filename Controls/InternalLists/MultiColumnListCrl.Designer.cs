using MockDataGenerator.SpecialObjects.Rules.RuleSupport;

namespace MockDataGenerator.Controls.InternalLists
{
    partial class MultiColumnListCrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiColumnListCrl));
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.maxRecPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaxRecords = new System.Windows.Forms.TextBox();
            this.regularExpressionCtrl = new MockDataGenerator.Controls.InternalLists.SupportControls.RegularExpressionCtrl();
            this.rangeCtrl = new MockDataGenerator.Controls.InternalLists.SupportControls.Range();
            this.selectionCtrl = new MockDataGenerator.Controls.InternalLists.SupportControls.SelectionCtrl();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.maxRecPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.maxRecPanel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.regularExpressionCtrl, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.rangeCtrl, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.selectionCtrl, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.99998F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.00002F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(859, 555);
            this.tableLayoutPanel1.TabIndex = 2;
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
            this.toolStrip1.Location = new System.Drawing.Point(0, 534);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(859, 21);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 21);
            // 
            // mnuBack
            // 
            this.mnuBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuBack.Image = global::MockDataGenerator.Properties.Resources.Back_arrow_icon;
            this.mnuBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(23, 18);
            this.mnuBack.Text = "toolStripButton1";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // mnuForward
            // 
            this.mnuForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuForward.Image = global::MockDataGenerator.Properties.Resources.ForeWard;
            this.mnuForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuForward.Name = "mnuForward";
            this.mnuForward.Size = new System.Drawing.Size(23, 18);
            this.mnuForward.Text = "toolStripButton2";
            this.mnuForward.Click += new System.EventHandler(this.mnuForward_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 21);
            // 
            // lblCurrentPage
            // 
            this.lblCurrentPage.Name = "lblCurrentPage";
            this.lblCurrentPage.Size = new System.Drawing.Size(43, 18);
            this.lblCurrentPage.Text = "Page:#";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 21);
            // 
            // lblTotalPages
            // 
            this.lblTotalPages.Name = "lblTotalPages";
            this.lblTotalPages.Size = new System.Drawing.Size(64, 18);
            this.lblTotalPages.Text = "Of # Pages";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 21);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(59, 18);
            this.toolStripLabel1.Text = "Page Size:";
            // 
            // tbPageSize
            // 
            this.tbPageSize.Name = "tbPageSize";
            this.tbPageSize.Size = new System.Drawing.Size(100, 21);
            this.tbPageSize.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbPageSize_KeyUp);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.tableLayoutPanel1.SetRowSpan(this.dataGridView, 4);
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(553, 528);
            this.dataGridView.TabIndex = 9;
            this.dataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_ColumnHeaderMouseClick);
            // 
            // maxRecPanel
            // 
            this.maxRecPanel.ColumnCount = 2;
            this.maxRecPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.maxRecPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.maxRecPanel.Controls.Add(this.label2, 0, 0);
            this.maxRecPanel.Controls.Add(this.txtMaxRecords, 1, 0);
            this.maxRecPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maxRecPanel.Location = new System.Drawing.Point(562, 502);
            this.maxRecPanel.Name = "maxRecPanel";
            this.maxRecPanel.RowCount = 1;
            this.maxRecPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.maxRecPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.maxRecPanel.Size = new System.Drawing.Size(294, 29);
            this.maxRecPanel.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Max Records";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaxRecords
            // 
            this.txtMaxRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaxRecords.Location = new System.Drawing.Point(150, 3);
            this.txtMaxRecords.Name = "txtMaxRecords";
            this.txtMaxRecords.Size = new System.Drawing.Size(141, 24);
            this.txtMaxRecords.TabIndex = 0;
            this.txtMaxRecords.Text = "100";
            // 
            // regularExpressionCtrl
            // 
            this.regularExpressionCtrl.CheckState = null;
            this.regularExpressionCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.regularExpressionCtrl.ExportExpression = null;
            this.regularExpressionCtrl.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regularExpressionCtrl.Location = new System.Drawing.Point(563, 318);
            this.regularExpressionCtrl.Margin = new System.Windows.Forms.Padding(4);
            this.regularExpressionCtrl.Name = "regularExpressionCtrl";
            this.regularExpressionCtrl.RegularExpression = "";
            this.regularExpressionCtrl.Size = new System.Drawing.Size(292, 177);
            this.regularExpressionCtrl.TabIndex = 13;
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
            this.rangeCtrl.Location = new System.Drawing.Point(563, 188);
            this.rangeCtrl.Margin = new System.Windows.Forms.Padding(4);
            this.rangeCtrl.Name = "rangeCtrl";
            this.rangeCtrl.Random = false;
            this.rangeCtrl.Size = new System.Drawing.Size(292, 122);
            this.rangeCtrl.Start = "";
            this.rangeCtrl.TabIndex = 12;
            // 
            // selectionCtrl
            // 
            this.selectionCtrl.AllowDrop = true;            
            this.selectionCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectionCtrl.ExportIsRandom = null;
            this.selectionCtrl.ExportPanelStates = null;
            this.selectionCtrl.ExportRange = null;
            this.selectionCtrl.ExportRegularExpression = null;
            this.selectionCtrl.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectionCtrl.Location = new System.Drawing.Point(563, 4);
            this.selectionCtrl.Margin = new System.Windows.Forms.Padding(4);
            this.selectionCtrl.Name = "selectionCtrl";            
            this.selectionCtrl.Size = new System.Drawing.Size(292, 176);
            this.selectionCtrl.TabIndex = 14;
            // 
            // MultiColumnListCrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MultiColumnListCrl";
            this.Size = new System.Drawing.Size(859, 555);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.maxRecPanel.ResumeLayout(false);
            this.maxRecPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TableLayoutPanel maxRecPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaxRecords;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton mnuBack;
        private System.Windows.Forms.ToolStripButton mnuForward;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel lblCurrentPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel lblTotalPages;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tbPageSize;
        private SupportControls.Range rangeCtrl;
        private SupportControls.RegularExpressionCtrl regularExpressionCtrl;
        private SupportControls.SelectionCtrl selectionCtrl;
    }
}
