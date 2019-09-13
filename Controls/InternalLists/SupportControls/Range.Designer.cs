namespace MockDataGenerator.Controls.InternalLists.SupportControls
{
    partial class Range
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
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.chkRandom = new System.Windows.Forms.CheckBox();
            this.rbRange = new System.Windows.Forms.RadioButton();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.ColumnCount = 2;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanel.Controls.Add(this.chkRandom, 0, 3);
            this.mainPanel.Controls.Add(this.rbRange, 0, 0);
            this.mainPanel.Controls.Add(this.lblStart, 0, 1);
            this.mainPanel.Controls.Add(this.lblEnd, 0, 2);
            this.mainPanel.Controls.Add(this.txtStart, 1, 1);
            this.mainPanel.Controls.Add(this.txtEnd, 1, 2);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 4;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainPanel.Size = new System.Drawing.Size(200, 116);
            this.mainPanel.TabIndex = 0;
            // 
            // chkRandom
            // 
            this.chkRandom.AutoSize = true;
            this.mainPanel.SetColumnSpan(this.chkRandom, 2);
            this.chkRandom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkRandom.Enabled = false;
            this.chkRandom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkRandom.Location = new System.Drawing.Point(3, 93);
            this.chkRandom.Name = "chkRandom";
            this.chkRandom.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.chkRandom.Size = new System.Drawing.Size(194, 24);
            this.chkRandom.TabIndex = 8;
            this.chkRandom.Text = "Random";
            this.chkRandom.UseVisualStyleBackColor = true;
            this.chkRandom.CheckedChanged += new System.EventHandler(this.chkRandom_CheckedChanged);
            // 
            // rbRange
            // 
            this.rbRange.AutoSize = true;
            this.mainPanel.SetColumnSpan(this.rbRange, 2);
            this.rbRange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbRange.Location = new System.Drawing.Point(4, 4);
            this.rbRange.Margin = new System.Windows.Forms.Padding(4);
            this.rbRange.Name = "rbRange";
            this.rbRange.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.rbRange.Size = new System.Drawing.Size(192, 22);
            this.rbRange.TabIndex = 5;
            this.rbRange.TabStop = true;
            this.rbRange.Text = "Range";
            this.rbRange.UseVisualStyleBackColor = true;
            this.rbRange.CheckedChanged += new System.EventHandler(this.rbRange_CheckedChanged);
            // 
            // lblStart
            // 
            this.lblStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStart.Enabled = false;
            this.lblStart.Location = new System.Drawing.Point(3, 30);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(94, 30);
            this.lblStart.TabIndex = 6;
            this.lblStart.Text = "Start A-Z:";
            this.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnd
            // 
            this.lblEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEnd.Enabled = false;
            this.lblEnd.Location = new System.Drawing.Point(3, 60);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(94, 30);
            this.lblEnd.TabIndex = 7;
            this.lblEnd.Text = "End A-Z:";
            this.lblEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtStart
            // 
            this.txtStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStart.Enabled = false;
            this.txtStart.Location = new System.Drawing.Point(103, 33);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(94, 25);
            this.txtStart.TabIndex = 9;
            this.txtStart.TextChanged += new System.EventHandler(this.txtStart_TextChanged);
            // 
            // txtEnd
            // 
            this.txtEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEnd.Enabled = false;
            this.txtEnd.Location = new System.Drawing.Point(103, 63);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(94, 25);
            this.txtEnd.TabIndex = 10;
            this.txtEnd.TextChanged += new System.EventHandler(this.txtEnd_TextChanged);
            // 
            // Range
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Range";
            this.Size = new System.Drawing.Size(200, 116);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.RadioButton rbRange;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.CheckBox chkRandom;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.TextBox txtEnd;
    }
}
