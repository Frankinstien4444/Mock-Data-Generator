namespace MockDataGenerator
{
    partial class FieldSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FieldSettings));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrpClose = new System.Windows.Forms.ToolStripButton();
            this.mnuSet = new System.Windows.Forms.ToolStripButton();
            this.descriptionCtrl = new MockDataGenerator.Controls.DescriptionCtrl();
            this.controlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrpClose,
            this.mnuSet});
            this.toolStrip1.Location = new System.Drawing.Point(0, 616);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(381, 25);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStrpClose
            // 
            this.toolStrpClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStrpClose.AutoSize = false;
            this.toolStrpClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStrpClose.Font = new System.Drawing.Font("Arial", 12F);
            this.toolStrpClose.Image = ((System.Drawing.Image)(resources.GetObject("toolStrpClose.Image")));
            this.toolStrpClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrpClose.Name = "toolStrpClose";
            this.toolStrpClose.Size = new System.Drawing.Size(75, 22);
            this.toolStrpClose.Text = "Close";
            this.toolStrpClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // mnuSet
            // 
            this.mnuSet.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuSet.AutoSize = false;
            this.mnuSet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuSet.Font = new System.Drawing.Font("Arial", 12F);
            this.mnuSet.Image = ((System.Drawing.Image)(resources.GetObject("mnuSet.Image")));
            this.mnuSet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuSet.Name = "mnuSet";
            this.mnuSet.Size = new System.Drawing.Size(75, 22);
            this.mnuSet.Text = "Set";
            this.mnuSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // descriptionCtrl
            // 
            this.descriptionCtrl.Description = "";
            this.descriptionCtrl.DescriptionChange = null;
            this.descriptionCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionCtrl.FieldDisplay = "No Field Displayed";
            this.descriptionCtrl.Location = new System.Drawing.Point(4, 4);
            this.descriptionCtrl.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionCtrl.Name = "descriptionCtrl";
            this.descriptionCtrl.Size = new System.Drawing.Size(373, 192);
            this.descriptionCtrl.TabIndex = 16;
            this.descriptionCtrl.TypeDisplay = "No Type Displayed";
            // 
            // controlPanel
            // 
            this.controlPanel.ColumnCount = 1;
            this.controlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.controlPanel.Controls.Add(this.descriptionCtrl, 0, 0);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.RowCount = 2;
            this.controlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.controlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.controlPanel.Size = new System.Drawing.Size(381, 616);
            this.controlPanel.TabIndex = 17;
            // 
            // FieldSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 641);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FieldSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Field Settings";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.controlPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStrpClose;
        private System.Windows.Forms.ToolStripButton mnuSet;
        private Controls.DescriptionCtrl descriptionCtrl;
        private System.Windows.Forms.TableLayoutPanel controlPanel;
    }
}