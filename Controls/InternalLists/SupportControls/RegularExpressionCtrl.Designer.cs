namespace MockDataGenerator.Controls.InternalLists.SupportControls
{
    partial class RegularExpressionCtrl
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
            this.testRegEx = new System.Windows.Forms.Button();
            this.txtRegEx = new System.Windows.Forms.TextBox();
            this.rbRegEx = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.testRegEx, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtRegEx, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rbRegEx, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 196);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // testRegEx
            // 
            this.testRegEx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testRegEx.Enabled = false;
            this.testRegEx.Location = new System.Drawing.Point(4, 161);
            this.testRegEx.Margin = new System.Windows.Forms.Padding(4);
            this.testRegEx.Name = "testRegEx";
            this.testRegEx.Size = new System.Drawing.Size(192, 31);
            this.testRegEx.TabIndex = 14;
            this.testRegEx.Text = "Test Expression";
            this.testRegEx.UseVisualStyleBackColor = true;
            // 
            // txtRegEx
            // 
            this.txtRegEx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRegEx.Enabled = false;
            this.txtRegEx.Location = new System.Drawing.Point(4, 33);
            this.txtRegEx.Margin = new System.Windows.Forms.Padding(4);
            this.txtRegEx.Multiline = true;
            this.txtRegEx.Name = "txtRegEx";
            this.txtRegEx.Size = new System.Drawing.Size(192, 120);
            this.txtRegEx.TabIndex = 9;
            this.txtRegEx.TextChanged += new System.EventHandler(this.txtRegEx_TextChanged);
            // 
            // rbRegEx
            // 
            this.rbRegEx.AutoSize = true;
            this.rbRegEx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbRegEx.Location = new System.Drawing.Point(4, 4);
            this.rbRegEx.Margin = new System.Windows.Forms.Padding(4);
            this.rbRegEx.Name = "rbRegEx";
            this.rbRegEx.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.rbRegEx.Size = new System.Drawing.Size(192, 21);
            this.rbRegEx.TabIndex = 10;
            this.rbRegEx.TabStop = true;
            this.rbRegEx.Text = "Regular Expression";
            this.rbRegEx.UseVisualStyleBackColor = true;
            this.rbRegEx.CheckedChanged += new System.EventHandler(this.rbRegEx_CheckedChanged);
            // 
            // RegularExpressionCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegularExpressionCtrl";
            this.Size = new System.Drawing.Size(200, 196);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtRegEx;
        private System.Windows.Forms.RadioButton rbRegEx;
        private System.Windows.Forms.Button testRegEx;
    }
}
