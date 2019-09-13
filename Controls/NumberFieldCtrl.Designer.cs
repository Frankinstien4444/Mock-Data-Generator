namespace MockDataGenerator.Controls
{
    partial class NumberFieldCtrl
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
            this.grpNumbers = new System.Windows.Forms.GroupBox();
            this.txtNumIncrement = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.rbNumberIncrement = new System.Windows.Forms.RadioButton();
            this.rbRandomNumber = new System.Windows.Forms.RadioButton();
            this.chkConvertToString = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpNumbers.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.grpNumbers, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkConvertToString, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(345, 170);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // grpNumbers
            // 
            this.grpNumbers.Controls.Add(this.txtNumIncrement);
            this.grpNumbers.Controls.Add(this.label8);
            this.grpNumbers.Controls.Add(this.label2);
            this.grpNumbers.Controls.Add(this.txtEnd);
            this.grpNumbers.Controls.Add(this.label1);
            this.grpNumbers.Controls.Add(this.txtStart);
            this.grpNumbers.Controls.Add(this.rbNumberIncrement);
            this.grpNumbers.Controls.Add(this.rbRandomNumber);
            this.grpNumbers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpNumbers.Location = new System.Drawing.Point(4, 34);
            this.grpNumbers.Margin = new System.Windows.Forms.Padding(4);
            this.grpNumbers.Name = "grpNumbers";
            this.grpNumbers.Padding = new System.Windows.Forms.Padding(4);
            this.grpNumbers.Size = new System.Drawing.Size(337, 132);
            this.grpNumbers.TabIndex = 20;
            this.grpNumbers.TabStop = false;
            this.grpNumbers.Text = "Number";
            // 
            // txtNumIncrement
            // 
            this.txtNumIncrement.Enabled = false;
            this.txtNumIncrement.Location = new System.Drawing.Point(218, 85);
            this.txtNumIncrement.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumIncrement.Name = "txtNumIncrement";
            this.txtNumIncrement.Size = new System.Drawing.Size(99, 20);
            this.txtNumIncrement.TabIndex = 7;
            this.txtNumIncrement.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 88);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Rate of Increment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "End";
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(219, 57);
            this.txtEnd.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(99, 20);
            this.txtEnd.TabIndex = 4;
            this.txtEnd.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Start";
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(219, 22);
            this.txtStart.Margin = new System.Windows.Forms.Padding(4);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(99, 20);
            this.txtStart.TabIndex = 2;
            this.txtStart.Text = "0";
            // 
            // rbNumberIncrement
            // 
            this.rbNumberIncrement.AutoSize = true;
            this.rbNumberIncrement.Location = new System.Drawing.Point(33, 56);
            this.rbNumberIncrement.Margin = new System.Windows.Forms.Padding(4);
            this.rbNumberIncrement.Name = "rbNumberIncrement";
            this.rbNumberIncrement.Size = new System.Drawing.Size(72, 17);
            this.rbNumberIncrement.TabIndex = 1;
            this.rbNumberIncrement.TabStop = true;
            this.rbNumberIncrement.Text = "Increment";
            this.rbNumberIncrement.UseVisualStyleBackColor = true;
            this.rbNumberIncrement.CheckedChanged += new System.EventHandler(this.rbNumberIncrement_CheckedChanged);
            // 
            // rbRandomNumber
            // 
            this.rbRandomNumber.AutoSize = true;
            this.rbRandomNumber.Location = new System.Drawing.Point(33, 26);
            this.rbRandomNumber.Margin = new System.Windows.Forms.Padding(4);
            this.rbRandomNumber.Name = "rbRandomNumber";
            this.rbRandomNumber.Size = new System.Drawing.Size(65, 17);
            this.rbRandomNumber.TabIndex = 0;
            this.rbRandomNumber.TabStop = true;
            this.rbRandomNumber.Text = "Random";
            this.rbRandomNumber.UseVisualStyleBackColor = true;
            this.rbRandomNumber.CheckedChanged += new System.EventHandler(this.rbRandomNumber_CheckedChanged);
            // 
            // chkConvertToString
            // 
            this.chkConvertToString.AutoSize = true;
            this.chkConvertToString.Location = new System.Drawing.Point(3, 3);
            this.chkConvertToString.Name = "chkConvertToString";
            this.chkConvertToString.Size = new System.Drawing.Size(109, 17);
            this.chkConvertToString.TabIndex = 19;
            this.chkConvertToString.Text = "Convert To String";
            this.chkConvertToString.UseVisualStyleBackColor = true;
            // 
            // NumberFieldCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NumberFieldCtrl";
            this.Size = new System.Drawing.Size(345, 170);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.grpNumbers.ResumeLayout(false);
            this.grpNumbers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox chkConvertToString;
        private System.Windows.Forms.GroupBox grpNumbers;
        private System.Windows.Forms.TextBox txtNumIncrement;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.RadioButton rbNumberIncrement;
        private System.Windows.Forms.RadioButton rbRandomNumber;
    }
}
