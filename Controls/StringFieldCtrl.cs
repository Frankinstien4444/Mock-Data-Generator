using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MockDataGenerator.Utility;
using MockDataGenerator.SpecialObjects;
using MockDataGenerator.Interfaces;

namespace MockDataGenerator.Controls
{
    public partial class StringFieldCtrl : AbstractRuleControl
    {        
        public StringFieldCtrl()
            :base()
        {
            InitializeComponent();
            Properties.GeneralType = Enums.FieldTypes.String;
        }        
        public override void EditRule(IDataRule aRule)
        {
            base.EditRule(aRule);
            StringRule sRule = (StringRule)aRule;
            rbRandomCharacters.Checked = sRule.IsRandom;
            rbRandomPosition.Checked = sRule.RandomPosition;
            if (sRule.Entries.Count > 0)
            {
                lstEntries.Items.AddRange(sRule.Entries.ToArray());
                if (!rbRandomPosition.Checked)
                    rbStringList.Checked = true;
            }

            txtStringLength.Text = sRule.StringLength.ToString();
        }
        
        public override bool ApplyDataToRuleSet()
        {
            bool valid = true;
            InitializeCommonRule();
            try
            {
                string[] entries = new string[lstEntries.Items.Count];
                lstEntries.Items.CopyTo(entries, 0);
                BuildRules.Buildrule((StringRule)Properties.Result, rbRandomPosition.Checked, txtStringLength.Text, entries);
            }
            catch (Exception e)
            {
                valid = ErrorMessage(e);
            }
            return valid;
        }        

        private void txtEntry_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                lstEntries.Items.Add(txtEntry.Text);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstEntries.Items.Add(txtEntry.Text);
        }

        private void ctxEdit_Click(object sender, EventArgs e)
        {
            if(lstEntries.SelectedIndex != -1)
            {
                lstEntries.SelectedItem = InputBox.frmInput.InputBox("Edit");
            }
        }

        private void ctxDelete_Click(object sender, EventArgs e)
        {
            if (lstEntries.SelectedIndex != -1)
            {
                lstEntries.Items.Remove(lstEntries.SelectedItem);
            }
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            grpStringList.Enabled = !rbRandomCharacters.Checked;
            Properties.Random = rbRandomCharacters.Checked;
            label7.Enabled = Properties.Random;
            txtStringLength.Enabled = Properties.Random;
        }
    }
}
