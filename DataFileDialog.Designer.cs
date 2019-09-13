namespace MockDataGenerator
{
    partial class DataFileDialog
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
            this.descriptionCtrl = new MockDataGenerator.Controls.DescriptionCtrl();
            this.lstSources = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSet = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.ColumnCount = 2;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 268F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanel.Controls.Add(this.descriptionCtrl, 0, 1);
            this.mainPanel.Controls.Add(this.lstSources, 0, 0);
            this.mainPanel.Controls.Add(this.menuStrip1, 0, 2);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 3;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.mainPanel.Size = new System.Drawing.Size(1279, 739);
            this.mainPanel.TabIndex = 0;
            // 
            // descriptionCtrl
            // 
            this.descriptionCtrl.Description = "";
            this.descriptionCtrl.DescriptionChange = null;
            this.descriptionCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionCtrl.FieldDisplay = "No Field Displayed";
            this.descriptionCtrl.Location = new System.Drawing.Point(4, 356);
            this.descriptionCtrl.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionCtrl.Name = "descriptionCtrl";
            this.descriptionCtrl.Size = new System.Drawing.Size(260, 344);
            this.descriptionCtrl.TabIndex = 0;
            this.descriptionCtrl.TypeDisplay = "No Type Displayed";
            // 
            // lstSources
            // 
            this.lstSources.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSources.FormattingEnabled = true;
            this.lstSources.ItemHeight = 17;
            this.lstSources.Location = new System.Drawing.Point(3, 3);
            this.lstSources.Name = "lstSources";
            this.lstSources.Size = new System.Drawing.Size(262, 346);
            this.lstSources.TabIndex = 1;
            this.lstSources.SelectedIndexChanged += new System.EventHandler(this.lstSources_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.mainPanel.SetColumnSpan(this.menuStrip1, 2);
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCancel,
            this.mnuSet});
            this.menuStrip1.Location = new System.Drawing.Point(0, 704);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1279, 35);
            this.menuStrip1.TabIndex = 6;
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
            this.mnuSet.Name = "mnuSet";
            this.mnuSet.Size = new System.Drawing.Size(42, 31);
            this.mnuSet.Text = "Set";
            this.mnuSet.Click += new System.EventHandler(this.mnuSet_Click);
            // 
            // DataFileDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 739);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DataFileDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data File";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private Controls.DescriptionCtrl descriptionCtrl;
        private System.Windows.Forms.ListBox lstSources;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuCancel;
        private System.Windows.Forms.ToolStripMenuItem mnuSet;
    }
}