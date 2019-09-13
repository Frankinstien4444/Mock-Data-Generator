namespace MockDataGenerator
{
    partial class RuleGeneratedData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RuleGeneratedData));
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dgDataView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mppedObjectsTree = new System.Windows.Forms.TreeView();
            this.grpMapDetails = new System.Windows.Forms.GroupBox();
            this.lstMapDetails = new System.Windows.Forms.ListView();
            this.ctxParameterMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxViewRule = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxEditRule = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mnuCancel = new System.Windows.Forms.ToolStripButton();
            this.mnuSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuGenerate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuTxtMaxRows = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDataView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpMapDetails.SuspendLayout();
            this.ctxParameterMenu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.ColumnCount = 2;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanel.Controls.Add(this.dgDataView, 0, 1);
            this.mainPanel.Controls.Add(this.groupBox1, 0, 0);
            this.mainPanel.Controls.Add(this.grpMapDetails, 1, 0);
            this.mainPanel.Controls.Add(this.toolStrip1, 0, 2);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 3;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.mainPanel.Size = new System.Drawing.Size(889, 639);
            this.mainPanel.TabIndex = 0;
            // 
            // dgDataView
            // 
            this.dgDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainPanel.SetColumnSpan(this.dgDataView, 2);
            this.dgDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDataView.Location = new System.Drawing.Point(4, 306);
            this.dgDataView.Margin = new System.Windows.Forms.Padding(4);
            this.dgDataView.Name = "dgDataView";
            this.dgDataView.Size = new System.Drawing.Size(881, 294);
            this.dgDataView.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mppedObjectsTree);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(436, 294);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rule Mapped Object";
            // 
            // mppedObjectsTree
            // 
            this.mppedObjectsTree.BackColor = System.Drawing.SystemColors.Info;
            this.mppedObjectsTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mppedObjectsTree.FullRowSelect = true;
            this.mppedObjectsTree.HideSelection = false;
            this.mppedObjectsTree.Location = new System.Drawing.Point(4, 22);
            this.mppedObjectsTree.Name = "mppedObjectsTree";
            this.mppedObjectsTree.Size = new System.Drawing.Size(428, 268);
            this.mppedObjectsTree.TabIndex = 0;
            this.mppedObjectsTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.mppedObjectsTree_NodeMouseClick);
            // 
            // grpMapDetails
            // 
            this.grpMapDetails.Controls.Add(this.lstMapDetails);
            this.grpMapDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMapDetails.Location = new System.Drawing.Point(448, 4);
            this.grpMapDetails.Margin = new System.Windows.Forms.Padding(4);
            this.grpMapDetails.Name = "grpMapDetails";
            this.grpMapDetails.Padding = new System.Windows.Forms.Padding(4);
            this.grpMapDetails.Size = new System.Drawing.Size(437, 294);
            this.grpMapDetails.TabIndex = 2;
            this.grpMapDetails.TabStop = false;
            this.grpMapDetails.Text = "Map Details";
            // 
            // lstMapDetails
            // 
            this.lstMapDetails.BackColor = System.Drawing.SystemColors.Info;
            this.lstMapDetails.ContextMenuStrip = this.ctxParameterMenu;
            this.lstMapDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMapDetails.FullRowSelect = true;
            this.lstMapDetails.Location = new System.Drawing.Point(4, 22);
            this.lstMapDetails.Name = "lstMapDetails";
            this.lstMapDetails.Size = new System.Drawing.Size(429, 268);
            this.lstMapDetails.TabIndex = 0;
            this.lstMapDetails.UseCompatibleStateImageBehavior = false;
            this.lstMapDetails.View = System.Windows.Forms.View.Details;
            // 
            // ctxParameterMenu
            // 
            this.ctxParameterMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxViewRule,
            this.ctxEditRule});
            this.ctxParameterMenu.Name = "ctxParameterMenu";
            this.ctxParameterMenu.Size = new System.Drawing.Size(126, 48);
            // 
            // ctxViewRule
            // 
            this.ctxViewRule.Name = "ctxViewRule";
            this.ctxViewRule.Size = new System.Drawing.Size(125, 22);
            this.ctxViewRule.Text = "View Rule";
            this.ctxViewRule.Click += new System.EventHandler(this.ctxViewRule_Click);
            // 
            // ctxEditRule
            // 
            this.ctxEditRule.Name = "ctxEditRule";
            this.ctxEditRule.Size = new System.Drawing.Size(125, 22);
            this.ctxEditRule.Text = "Edit Rule";
            // 
            // toolStrip1
            // 
            this.mainPanel.SetColumnSpan(this.toolStrip1, 2);
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCancel,
            this.mnuSave,
            this.toolStripSeparator1,
            this.mnuGenerate,
            this.toolStripSeparator2,
            this.mnuTxtMaxRows,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 604);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(889, 35);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // mnuCancel
            // 
            this.mnuCancel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuCancel.Image = ((System.Drawing.Image)(resources.GetObject("mnuCancel.Image")));
            this.mnuCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuCancel.Name = "mnuCancel";
            this.mnuCancel.Size = new System.Drawing.Size(47, 32);
            this.mnuCancel.Text = "Cancel";
            // 
            // mnuSave
            // 
            this.mnuSave.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuSave.Image = ((System.Drawing.Image)(resources.GetObject("mnuSave.Image")));
            this.mnuSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(79, 32);
            this.mnuSave.Text = "Save and Exit";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // mnuGenerate
            // 
            this.mnuGenerate.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuGenerate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuGenerate.Image = ((System.Drawing.Image)(resources.GetObject("mnuGenerate.Image")));
            this.mnuGenerate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuGenerate.Name = "mnuGenerate";
            this.mnuGenerate.Size = new System.Drawing.Size(85, 32);
            this.mnuGenerate.Text = "Generate Data";
            this.mnuGenerate.Click += new System.EventHandler(this.mnuGenerate_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // mnuTxtMaxRows
            // 
            this.mnuTxtMaxRows.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuTxtMaxRows.Name = "mnuTxtMaxRows";
            this.mnuTxtMaxRows.Size = new System.Drawing.Size(100, 35);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(63, 32);
            this.toolStripLabel1.Text = "Max Rows:";
            // 
            // RuleGeneratedData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 639);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RuleGeneratedData";
            this.Text = "Rule Generated Data";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDataView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.grpMapDetails.ResumeLayout(false);
            this.ctxParameterMenu.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.DataGridView dgDataView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpMapDetails;
        private System.Windows.Forms.TreeView mppedObjectsTree;
        private System.Windows.Forms.ListView lstMapDetails;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton mnuCancel;
        private System.Windows.Forms.ToolStripButton mnuSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton mnuGenerate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox mnuTxtMaxRows;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ContextMenuStrip ctxParameterMenu;
        private System.Windows.Forms.ToolStripMenuItem ctxViewRule;
        private System.Windows.Forms.ToolStripMenuItem ctxEditRule;
    }
}