namespace MockDataGenerator.Controls.InternalLists
{
    partial class TreeListCtrl
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
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Entire List");
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.treeView = new System.Windows.Forms.TreeView();
            this.maxRecPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaxRecords = new System.Windows.Forms.TextBox();
            this.selectionCtrl = new MockDataGenerator.Controls.InternalLists.SupportControls.SelectionCtrl();
            this.rangeCtrl = new MockDataGenerator.Controls.InternalLists.SupportControls.Range();
            this.regularExpressionCtrl = new MockDataGenerator.Controls.InternalLists.SupportControls.RegularExpressionCtrl();
            this.tableLayoutPanel1.SuspendLayout();
            this.maxRecPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.treeView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.maxRecPanel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.selectionCtrl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.rangeCtrl, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.regularExpressionCtrl, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.99999F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.00002F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(462, 493);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Location = new System.Drawing.Point(3, 3);
            this.treeView.Name = "treeView";
            treeNode2.Name = "entireListNode";
            treeNode2.Text = "Entire List";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.tableLayoutPanel1.SetRowSpan(this.treeView, 4);
            this.treeView.Size = new System.Drawing.Size(225, 487);
            this.treeView.TabIndex = 9;
            // 
            // maxRecPanel
            // 
            this.maxRecPanel.ColumnCount = 2;
            this.maxRecPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.maxRecPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.maxRecPanel.Controls.Add(this.label2, 0, 0);
            this.maxRecPanel.Controls.Add(this.txtMaxRecords, 1, 0);
            this.maxRecPanel.Location = new System.Drawing.Point(234, 460);
            this.maxRecPanel.Name = "maxRecPanel";
            this.maxRecPanel.RowCount = 1;
            this.maxRecPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.maxRecPanel.Size = new System.Drawing.Size(225, 30);
            this.maxRecPanel.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Max Records";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaxRecords
            // 
            this.txtMaxRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaxRecords.Location = new System.Drawing.Point(115, 3);
            this.txtMaxRecords.Name = "txtMaxRecords";
            this.txtMaxRecords.Size = new System.Drawing.Size(107, 24);
            this.txtMaxRecords.TabIndex = 0;
            // 
            // selectionCtrl
            // 
            this.selectionCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectionCtrl.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectionCtrl.Location = new System.Drawing.Point(235, 4);
            this.selectionCtrl.Margin = new System.Windows.Forms.Padding(4);
            this.selectionCtrl.Name = "selectionCtrl";
            this.selectionCtrl.Size = new System.Drawing.Size(223, 155);
            this.selectionCtrl.TabIndex = 11;
            // 
            // rangeCtrl
            // 
            this.rangeCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rangeCtrl.End = "";
            this.rangeCtrl.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rangeCtrl.Location = new System.Drawing.Point(235, 167);
            this.rangeCtrl.Margin = new System.Windows.Forms.Padding(4);
            this.rangeCtrl.Name = "rangeCtrl";
            this.rangeCtrl.Random = false;
            this.rangeCtrl.Size = new System.Drawing.Size(223, 122);
            this.rangeCtrl.Start = "";
            this.rangeCtrl.TabIndex = 12;
            // 
            // regularExpressionCtrl
            // 
            this.regularExpressionCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.regularExpressionCtrl.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regularExpressionCtrl.Location = new System.Drawing.Point(235, 297);
            this.regularExpressionCtrl.Margin = new System.Windows.Forms.Padding(4);
            this.regularExpressionCtrl.Name = "regularExpressionCtrl";
            this.regularExpressionCtrl.RegularExpression = "";
            this.regularExpressionCtrl.Size = new System.Drawing.Size(223, 156);
            this.regularExpressionCtrl.TabIndex = 13;
            // 
            // TreeListCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TreeListCtrl";
            this.Size = new System.Drawing.Size(462, 493);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.maxRecPanel.ResumeLayout(false);
            this.maxRecPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.TableLayoutPanel maxRecPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaxRecords;
        private SupportControls.SelectionCtrl selectionCtrl;
        private SupportControls.Range rangeCtrl;
        private SupportControls.RegularExpressionCtrl regularExpressionCtrl;
    }
}
