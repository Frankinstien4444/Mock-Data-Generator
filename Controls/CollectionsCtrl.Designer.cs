﻿namespace MockDataGenerator.Controls
{
    partial class CollectionsCtrl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.collectionTypes = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.collectionTypes);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 135);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Collection Types";
            // 
            // collectionTypes
            // 
            this.collectionTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.collectionTypes.FormattingEnabled = true;
            this.collectionTypes.Items.AddRange(new object[] {
            "Array",
            "Collection",
            "ConcurentDictionary",
            "Dictionary",
            "HashSet",
            "IEnumerable",
            "LinkedList",
            "List",
            "Queue",
            "SortedDictionary",
            "SortedList",
            "SortedSet",
            "Stack"});
            this.collectionTypes.Location = new System.Drawing.Point(3, 21);
            this.collectionTypes.Margin = new System.Windows.Forms.Padding(4);
            this.collectionTypes.Name = "collectionTypes";
            this.collectionTypes.Size = new System.Drawing.Size(201, 111);
            this.collectionTypes.Sorted = true;
            this.collectionTypes.TabIndex = 19;
            
            // 
            // CollectionsCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "CollectionsCtrl";
            this.Size = new System.Drawing.Size(207, 135);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox collectionTypes;
    }
}
