namespace MockDataGenerator.Controls
{
    partial class DateTimeFieldCtrl
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
            this.grpDate = new System.Windows.Forms.GroupBox();
            this.txtTimeDateIncrement = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboRate = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rbDateTimeInc = new System.Windows.Forms.RadioButton();
            this.rbRandomDateTime = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.chkConvertToString = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.grpDate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkConvertToString, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(281, 197);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // grpDate
            // 
            this.grpDate.Controls.Add(this.txtTimeDateIncrement);
            this.grpDate.Controls.Add(this.label10);
            this.grpDate.Controls.Add(this.cboRate);
            this.grpDate.Controls.Add(this.label9);
            this.grpDate.Controls.Add(this.rbDateTimeInc);
            this.grpDate.Controls.Add(this.rbRandomDateTime);
            this.grpDate.Controls.Add(this.label5);
            this.grpDate.Controls.Add(this.endDatePicker);
            this.grpDate.Controls.Add(this.label4);
            this.grpDate.Controls.Add(this.startDatePicker);
            this.grpDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDate.Location = new System.Drawing.Point(3, 38);
            this.grpDate.Name = "grpDate";
            this.grpDate.Size = new System.Drawing.Size(275, 156);
            this.grpDate.TabIndex = 20;
            this.grpDate.TabStop = false;
            this.grpDate.Text = "Date or Time";
            // 
            // txtTimeDateIncrement
            // 
            this.txtTimeDateIncrement.Enabled = false;
            this.txtTimeDateIncrement.Location = new System.Drawing.Point(222, 121);
            this.txtTimeDateIncrement.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimeDateIncrement.Name = "txtTimeDateIncrement";
            this.txtTimeDateIncrement.Size = new System.Drawing.Size(42, 20);
            this.txtTimeDateIncrement.TabIndex = 13;
            this.txtTimeDateIncrement.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(90, 125);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Rate of Increment";
            // 
            // cboRate
            // 
            this.cboRate.Enabled = false;
            this.cboRate.FormattingEnabled = true;
            this.cboRate.Items.AddRange(new object[] {
            "[Choose]",
            "Seconds",
            "Minutes",
            "Hours",
            "Days",
            "Weeks",
            "Months",
            "Years"});
            this.cboRate.Location = new System.Drawing.Point(171, 93);
            this.cboRate.Name = "cboRate";
            this.cboRate.Size = new System.Drawing.Size(94, 21);
            this.cboRate.TabIndex = 11;
            this.cboRate.SelectedIndexChanged += new System.EventHandler(this.cboRate_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(90, 97);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Rate Type";
            // 
            // rbDateTimeInc
            // 
            this.rbDateTimeInc.AutoSize = true;
            this.rbDateTimeInc.Location = new System.Drawing.Point(16, 122);
            this.rbDateTimeInc.Margin = new System.Windows.Forms.Padding(4);
            this.rbDateTimeInc.Name = "rbDateTimeInc";
            this.rbDateTimeInc.Size = new System.Drawing.Size(72, 17);
            this.rbDateTimeInc.TabIndex = 8;
            this.rbDateTimeInc.TabStop = true;
            this.rbDateTimeInc.Text = "Increment";
            this.rbDateTimeInc.UseVisualStyleBackColor = true;
            this.rbDateTimeInc.CheckedChanged += new System.EventHandler(this.rbDateTimeInc_CheckedChanged);
            // 
            // rbRandomDateTime
            // 
            this.rbRandomDateTime.AutoSize = true;
            this.rbRandomDateTime.Location = new System.Drawing.Point(16, 95);
            this.rbRandomDateTime.Margin = new System.Windows.Forms.Padding(4);
            this.rbRandomDateTime.Name = "rbRandomDateTime";
            this.rbRandomDateTime.Size = new System.Drawing.Size(65, 17);
            this.rbRandomDateTime.TabIndex = 7;
            this.rbRandomDateTime.TabStop = true;
            this.rbRandomDateTime.Text = "Random";
            this.rbRandomDateTime.UseVisualStyleBackColor = true;
            this.rbRandomDateTime.CheckedChanged += new System.EventHandler(this.rbRandomDateTime_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "End";
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(64, 56);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(200, 20);
            this.endDatePicker.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Start";
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(64, 25);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(200, 20);
            this.startDatePicker.TabIndex = 0;
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
            // DateTimeFieldCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DateTimeFieldCtrl";
            this.Size = new System.Drawing.Size(281, 197);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.grpDate.ResumeLayout(false);
            this.grpDate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox chkConvertToString;
        private System.Windows.Forms.GroupBox grpDate;
        private System.Windows.Forms.TextBox txtTimeDateIncrement;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboRate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbDateTimeInc;
        private System.Windows.Forms.RadioButton rbRandomDateTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker startDatePicker;
    }
}
