namespace MockDataGenerator.Controls
{
    partial class MappedSourceCtrl
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
            this.lstMappedSources = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstMappedSources
            // 
            this.lstMappedSources.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMappedSources.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMappedSources.FullRowSelect = true;
            this.lstMappedSources.HideSelection = false;
            this.lstMappedSources.Location = new System.Drawing.Point(4, 22);
            this.lstMappedSources.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstMappedSources.MultiSelect = false;
            this.lstMappedSources.Name = "lstMappedSources";
            this.lstMappedSources.Size = new System.Drawing.Size(467, 463);
            this.lstMappedSources.TabIndex = 0;
            this.lstMappedSources.UseCompatibleStateImageBehavior = false;
            this.lstMappedSources.View = System.Windows.Forms.View.Details;
            this.lstMappedSources.SelectedIndexChanged += new System.EventHandler(this.lstMappedSources_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstMappedSources);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(475, 489);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mapped Sources";
            // 
            // MappedSourceCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MappedSourceCtrl";
            this.Size = new System.Drawing.Size(475, 489);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstMappedSources;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
