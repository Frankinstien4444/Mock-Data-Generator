namespace MockDataGenerator.Controls
{
    partial class TupleCtrl
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
            this.grpSelected = new System.Windows.Forms.GroupBox();
            this.lstTupleSet = new System.Windows.Forms.ListView();
            this.Rule = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctxTupleSelect = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxDeleteRule = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMoveRuleUp = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMoveRuleDown = new System.Windows.Forms.ToolStripMenuItem();
            this.grpSelected.SuspendLayout();
            this.ctxTupleSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSelected
            // 
            this.grpSelected.Controls.Add(this.lstTupleSet);
            this.grpSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSelected.Location = new System.Drawing.Point(0, 0);
            this.grpSelected.Name = "grpSelected";
            this.grpSelected.Size = new System.Drawing.Size(314, 327);
            this.grpSelected.TabIndex = 7;
            this.grpSelected.TabStop = false;
            this.grpSelected.Text = "Tuple Set";
            // 
            // lstTupleSet
            // 
            this.lstTupleSet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Rule});
            this.lstTupleSet.ContextMenuStrip = this.ctxTupleSelect;
            this.lstTupleSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTupleSet.FullRowSelect = true;
            this.lstTupleSet.HideSelection = false;
            this.lstTupleSet.Location = new System.Drawing.Point(3, 16);
            this.lstTupleSet.MultiSelect = false;
            this.lstTupleSet.Name = "lstTupleSet";
            this.lstTupleSet.Size = new System.Drawing.Size(308, 308);
            this.lstTupleSet.TabIndex = 0;
            this.lstTupleSet.UseCompatibleStateImageBehavior = false;
            this.lstTupleSet.View = System.Windows.Forms.View.Details;
            this.lstTupleSet.SelectedIndexChanged += new System.EventHandler(this.lstTupleSet_SelectedIndexChanged);
            // 
            // Rule
            // 
            this.Rule.Text = "Rule";
            this.Rule.Width = 304;
            // 
            // ctxTupleSelect
            // 
            this.ctxTupleSelect.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxDeleteRule,
            this.ctxMoveRuleUp,
            this.ctxMoveRuleDown});
            this.ctxTupleSelect.Name = "ctxTupleSelect";
            this.ctxTupleSelect.Size = new System.Drawing.Size(165, 70);
            // 
            // ctxDeleteRule
            // 
            this.ctxDeleteRule.Name = "ctxDeleteRule";
            this.ctxDeleteRule.Size = new System.Drawing.Size(164, 22);
            this.ctxDeleteRule.Text = "Delete Rule";
            this.ctxDeleteRule.Click += new System.EventHandler(this.DeleteRule);
            // 
            // ctxMoveRuleUp
            // 
            this.ctxMoveRuleUp.Name = "ctxMoveRuleUp";
            this.ctxMoveRuleUp.Size = new System.Drawing.Size(164, 22);
            this.ctxMoveRuleUp.Text = "Move Rule Up";
            this.ctxMoveRuleUp.Click += new System.EventHandler(this.MoveRuleUp);
            // 
            // ctxMoveRuleDown
            // 
            this.ctxMoveRuleDown.Name = "ctxMoveRuleDown";
            this.ctxMoveRuleDown.Size = new System.Drawing.Size(164, 22);
            this.ctxMoveRuleDown.Text = "Move Rule Down";
            this.ctxMoveRuleDown.Click += new System.EventHandler(this.MoveRuleDown);
            // 
            // TupleCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpSelected);
            this.Name = "TupleCtrl";
            this.Size = new System.Drawing.Size(314, 327);
            this.grpSelected.ResumeLayout(false);
            this.ctxTupleSelect.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSelected;
        private System.Windows.Forms.ListView lstTupleSet;
        private System.Windows.Forms.ContextMenuStrip ctxTupleSelect;
        private System.Windows.Forms.ToolStripMenuItem ctxDeleteRule;
        private System.Windows.Forms.ToolStripMenuItem ctxMoveRuleUp;
        private System.Windows.Forms.ToolStripMenuItem ctxMoveRuleDown;
        private System.Windows.Forms.ColumnHeader Rule;
    }
}
