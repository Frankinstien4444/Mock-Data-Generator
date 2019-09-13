using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MockDataGenerator.SpecialObjects;
using MockDataGenerator.Utility;
using MockDataGenerator.Interfaces;

namespace MockDataGenerator.Controls
{
    public partial class NumberFieldCtrl : AbstractRuleControl
    {        
        public NumberFieldCtrl()
            :base()
        {
            InitializeComponent();
            Properties.GeneralType = Enums.FieldTypes.Number;
        }

        public override void EditRule(IDataRule aRule)
        {
            base.EditRule(aRule);
            NumberRule nRule = (NumberRule)aRule;
            chkConvertToString.Checked = nRule.ConvertToString;
            rbRandomNumber.Checked = nRule.IsRandom;
            rbNumberIncrement.Checked = !nRule.IsRandom;
            txtStart.Text = nRule.Start.ToString();
            txtEnd.Text = nRule.End.ToString();
            txtNumIncrement.Text = nRule.Increment.ToString();
        }

        public override bool ApplyDataToRuleSet()
        {
            bool valid = true;
            InitializeCommonRule();
            try
            {
                BuildRules.Buildrule((NumberRule)Properties.Result, txtStart.Text, txtEnd.Text, txtNumIncrement.Text);
            }
            catch (Exception e)
            {
                valid = ErrorMessage(e);
            }
            return valid;
        }

        private void rbNumberIncrement_CheckedChanged(object sender, EventArgs e)
        {
            txtNumIncrement.Enabled = rbNumberIncrement.Checked;
        }

        private void rbRandomNumber_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Random = rbRandomNumber.Checked;
        }
    }
}
