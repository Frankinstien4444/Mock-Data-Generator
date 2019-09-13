namespace AtlasWorkFlow.Search
{
    partial class SearchBar
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.RightLabelPic = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolNotessearch = new System.Windows.Forms.ToolStripLabel();
            this.toolNotesSearchText = new System.Windows.Forms.ToolStripTextBox();
            this.toolNotesBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RightLabelPic,
            this.toolStripSeparator1,
            this.toolNotessearch,
            this.toolNotesSearchText,
            this.toolNotesBtn,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(314, 48);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolSearch";
            // 
            // RightLabelPic
            // 
            this.RightLabelPic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RightLabelPic.Image = global::MockDataGenerator.Properties.Resources.binoculars;
            this.RightLabelPic.ImageTransparentColor = System.Drawing.Color.Black;
            this.RightLabelPic.Name = "RightLabelPic";
            this.RightLabelPic.Size = new System.Drawing.Size(40, 45);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 48);
            // 
            // toolNotessearch
            // 
            this.toolNotessearch.Name = "toolNotessearch";
            this.toolNotessearch.Size = new System.Drawing.Size(42, 45);
            this.toolNotessearch.Text = "Search";
            // 
            // toolNotesSearchText
            // 
            this.toolNotesSearchText.BackColor = System.Drawing.Color.White;
            this.toolNotesSearchText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolNotesSearchText.Name = "toolNotesSearchText";
            this.toolNotesSearchText.Size = new System.Drawing.Size(152, 48);
            this.toolNotesSearchText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchText_KeyUp);
            // 
            // toolNotesBtn
            // 
            this.toolNotesBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolNotesBtn.Image = global::MockDataGenerator.Properties.Resources.viewer;
            this.toolNotesBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNotesBtn.Name = "toolNotesBtn";
            this.toolNotesBtn.Size = new System.Drawing.Size(44, 45);
            this.toolNotesBtn.Text = "toolBtnSearch";
            this.toolNotesBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 48);
            // 
            // SearchBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Name = "SearchBar";
            this.Size = new System.Drawing.Size(314, 48);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolNotessearch;
        private System.Windows.Forms.ToolStripTextBox toolNotesSearchText;
        private System.Windows.Forms.ToolStripButton toolNotesBtn;
        private System.Windows.Forms.ToolStripLabel RightLabelPic;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}
