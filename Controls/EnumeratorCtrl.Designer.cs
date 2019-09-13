namespace MockDataGenerator.Controls
{
    partial class EnumeratorCtrl
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
            this.chkConvertToString = new System.Windows.Forms.CheckBox();
            this.enumeratorList = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbRandom = new System.Windows.Forms.RadioButton();
            this.rbIterate = new System.Windows.Forms.RadioButton();
            this.lblAssemblyName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.chkConvertToString, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.enumeratorList, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblAssemblyName, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(398, 528);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // chkConvertToString
            // 
            this.chkConvertToString.AutoSize = true;
            this.chkConvertToString.Location = new System.Drawing.Point(3, 33);
            this.chkConvertToString.Name = "chkConvertToString";
            this.chkConvertToString.Size = new System.Drawing.Size(139, 21);
            this.chkConvertToString.TabIndex = 26;
            this.chkConvertToString.Text = "Convert To String";
            this.chkConvertToString.UseVisualStyleBackColor = true;
            // 
            // enumeratorList
            // 
            this.enumeratorList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enumeratorList.FormattingEnabled = true;
            this.enumeratorList.Location = new System.Drawing.Point(6, 66);
            this.enumeratorList.Margin = new System.Windows.Forms.Padding(6);
            this.enumeratorList.Name = "enumeratorList";
            this.enumeratorList.Size = new System.Drawing.Size(386, 381);
            this.enumeratorList.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbRandom);
            this.groupBox1.Controls.Add(this.rbIterate);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(4, 457);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(390, 67);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rule Mode";
            // 
            // rbRandom
            // 
            this.rbRandom.AutoSize = true;
            this.rbRandom.Location = new System.Drawing.Point(90, 32);
            this.rbRandom.Margin = new System.Windows.Forms.Padding(4);
            this.rbRandom.Name = "rbRandom";
            this.rbRandom.Size = new System.Drawing.Size(82, 21);
            this.rbRandom.TabIndex = 24;
            this.rbRandom.TabStop = true;
            this.rbRandom.Text = "Random";
            this.rbRandom.UseVisualStyleBackColor = true;
            // 
            // rbIterate
            // 
            this.rbIterate.AutoSize = true;
            this.rbIterate.Location = new System.Drawing.Point(183, 32);
            this.rbIterate.Margin = new System.Windows.Forms.Padding(4);
            this.rbIterate.Name = "rbIterate";
            this.rbIterate.Size = new System.Drawing.Size(66, 21);
            this.rbIterate.TabIndex = 25;
            this.rbIterate.TabStop = true;
            this.rbIterate.Text = "Iterate";
            this.rbIterate.UseVisualStyleBackColor = true;
            // 
            // lblAssemblyName
            // 
            this.lblAssemblyName.AutoSize = true;
            this.lblAssemblyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAssemblyName.Location = new System.Drawing.Point(3, 0);
            this.lblAssemblyName.Name = "lblAssemblyName";
            this.lblAssemblyName.Size = new System.Drawing.Size(392, 30);
            this.lblAssemblyName.TabIndex = 28;
            this.lblAssemblyName.Text = "NA";
            // 
            // EnumeratorCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EnumeratorCtrl";
            this.Size = new System.Drawing.Size(398, 528);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckedListBox enumeratorList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbRandom;
        private System.Windows.Forms.RadioButton rbIterate;
        private System.Windows.Forms.CheckBox chkConvertToString;
        private System.Windows.Forms.Label lblAssemblyName;
    }
}
