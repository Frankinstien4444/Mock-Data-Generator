namespace MockDataGenerator.Controls
{
    partial class StringFieldCtrl
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
            this.components = new System.ComponentModel.Container();
            this.grpStrings = new System.Windows.Forms.GroupBox();
            this.rbStringList = new System.Windows.Forms.RadioButton();
            this.rbRandomPosition = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStringLength = new System.Windows.Forms.TextBox();
            this.rbRandomCharacters = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grpStringList = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtEntry = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstEntries = new System.Windows.Forms.ListBox();
            this.ctxEntries = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.grpStrings.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpStringList.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.ctxEntries.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpStrings
            // 
            this.grpStrings.Controls.Add(this.rbStringList);
            this.grpStrings.Controls.Add(this.rbRandomPosition);
            this.grpStrings.Controls.Add(this.label7);
            this.grpStrings.Controls.Add(this.txtStringLength);
            this.grpStrings.Controls.Add(this.rbRandomCharacters);
            this.grpStrings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpStrings.Location = new System.Drawing.Point(3, 3);
            this.grpStrings.Name = "grpStrings";
            this.grpStrings.Size = new System.Drawing.Size(317, 94);
            this.grpStrings.TabIndex = 17;
            this.grpStrings.TabStop = false;
            this.grpStrings.Text = "String";
            // 
            // rbStringList
            // 
            this.rbStringList.AutoSize = true;
            this.rbStringList.Location = new System.Drawing.Point(13, 73);
            this.rbStringList.Margin = new System.Windows.Forms.Padding(4);
            this.rbStringList.Name = "rbStringList";
            this.rbStringList.Size = new System.Drawing.Size(71, 17);
            this.rbStringList.TabIndex = 11;
            this.rbStringList.TabStop = true;
            this.rbStringList.Text = "String List";
            this.rbStringList.UseVisualStyleBackColor = true;
            this.rbStringList.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // rbRandomPosition
            // 
            this.rbRandomPosition.AutoSize = true;
            this.rbRandomPosition.Location = new System.Drawing.Point(13, 47);
            this.rbRandomPosition.Margin = new System.Windows.Forms.Padding(4);
            this.rbRandomPosition.Name = "rbRandomPosition";
            this.rbRandomPosition.Size = new System.Drawing.Size(177, 17);
            this.rbRandomPosition.TabIndex = 7;
            this.rbRandomPosition.TabStop = true;
            this.rbRandomPosition.Text = "Single Entry Randomize Position";
            this.rbRandomPosition.UseVisualStyleBackColor = true;
            this.rbRandomPosition.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(131, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "String Length";
            // 
            // txtStringLength
            // 
            this.txtStringLength.Enabled = false;
            this.txtStringLength.Location = new System.Drawing.Point(208, 25);
            this.txtStringLength.Margin = new System.Windows.Forms.Padding(4);
            this.txtStringLength.Name = "txtStringLength";
            this.txtStringLength.Size = new System.Drawing.Size(45, 20);
            this.txtStringLength.TabIndex = 5;
            this.txtStringLength.Text = "10";
            // 
            // rbRandomCharacters
            // 
            this.rbRandomCharacters.AutoSize = true;
            this.rbRandomCharacters.Location = new System.Drawing.Point(13, 23);
            this.rbRandomCharacters.Margin = new System.Windows.Forms.Padding(4);
            this.rbRandomCharacters.Name = "rbRandomCharacters";
            this.rbRandomCharacters.Size = new System.Drawing.Size(119, 17);
            this.rbRandomCharacters.TabIndex = 1;
            this.rbRandomCharacters.TabStop = true;
            this.rbRandomCharacters.Text = "Random Characters";
            this.rbRandomCharacters.UseVisualStyleBackColor = true;
            this.rbRandomCharacters.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.grpStrings, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grpStringList, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(323, 445);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // grpStringList
            // 
            this.grpStringList.Controls.Add(this.tableLayoutPanel2);
            this.grpStringList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpStringList.Enabled = false;
            this.grpStringList.Location = new System.Drawing.Point(3, 103);
            this.grpStringList.Name = "grpStringList";
            this.grpStringList.Size = new System.Drawing.Size(317, 339);
            this.grpStringList.TabIndex = 18;
            this.grpStringList.TabStop = false;
            this.grpStringList.Text = "String Entries";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Controls.Add(this.txtEntry, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAdd, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lstEntries, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(311, 320);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // txtEntry
            // 
            this.txtEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEntry.Location = new System.Drawing.Point(3, 3);
            this.txtEntry.Name = "txtEntry";
            this.txtEntry.Size = new System.Drawing.Size(255, 20);
            this.txtEntry.TabIndex = 0;
            this.txtEntry.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEntry_KeyUp);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Location = new System.Drawing.Point(264, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(44, 29);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstEntries
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.lstEntries, 2);
            this.lstEntries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstEntries.FormattingEnabled = true;
            this.lstEntries.Location = new System.Drawing.Point(3, 38);
            this.lstEntries.Name = "lstEntries";
            this.lstEntries.Size = new System.Drawing.Size(305, 279);
            this.lstEntries.TabIndex = 2;
            // 
            // ctxEntries
            // 
            this.ctxEntries.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxEdit,
            this.ctxDelete});
            this.ctxEntries.Name = "ctxEntries";
            this.ctxEntries.Size = new System.Drawing.Size(108, 48);
            // 
            // ctxEdit
            // 
            this.ctxEdit.Name = "ctxEdit";
            this.ctxEdit.Size = new System.Drawing.Size(107, 22);
            this.ctxEdit.Text = "Edit";
            this.ctxEdit.Click += new System.EventHandler(this.ctxEdit_Click);
            // 
            // ctxDelete
            // 
            this.ctxDelete.Name = "ctxDelete";
            this.ctxDelete.Size = new System.Drawing.Size(107, 22);
            this.ctxDelete.Text = "Delete";
            this.ctxDelete.Click += new System.EventHandler(this.ctxDelete_Click);
            // 
            // StringFieldCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StringFieldCtrl";
            this.Size = new System.Drawing.Size(323, 445);
            this.grpStrings.ResumeLayout(false);
            this.grpStrings.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpStringList.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ctxEntries.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpStrings;
        private System.Windows.Forms.RadioButton rbRandomPosition;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStringLength;
        private System.Windows.Forms.RadioButton rbRandomCharacters;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grpStringList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtEntry;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstEntries;
        private System.Windows.Forms.RadioButton rbStringList;
        private System.Windows.Forms.ContextMenuStrip ctxEntries;
        private System.Windows.Forms.ToolStripMenuItem ctxEdit;
        private System.Windows.Forms.ToolStripMenuItem ctxDelete;
    }
}
