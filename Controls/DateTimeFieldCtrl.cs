using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MockDataGenerator.Interfaces;
using MockDataGenerator.SpecialObjects;
using MockDataGenerator.Utility;
using MockDataGenerator.Enums;

namespace MockDataGenerator.Controls
{
    public partial class DateTimeFieldCtrl : AbstractRuleControl
    {        
        public DateTimeFieldCtrl()
            :base()
        {
            InitializeComponent();            
        }

        public override void EditRule(IDataRule aRule)
        {
            base.EditRule(aRule);
            chkConvertToString.Checked = aRule.ConvertToString;
            rbRandomDateTime.Checked = aRule.IsRandom;
            rbDateTimeInc.Checked = !aRule.IsRandom;         
            string inc = String.Empty;
            int idx = -1;
            if (aRule.RuleType == FieldTypes.Time)
            {
                TimeRule tRule = (TimeRule)aRule;
                startDatePicker.Value = tRule.Start;
                endDatePicker.Value = tRule.End;
                idx = cboRate.Items.IndexOf(tRule.RateType.ToString());                
                inc = tRule.Increment.ToString();
            }
            else
            {
                DateRule dRule = (DateRule)aRule;
                startDatePicker.Value = dRule.Start;
                endDatePicker.Value = dRule.End;
                idx = cboRate.Items.IndexOf(dRule.RateType.ToString());
                inc = dRule.Increment.ToString();
            }
            cboRate.SelectedIndex = idx;
            txtTimeDateIncrement.Text = inc;
        }

        private void SetCBOSelection(DateTimeRateTypes rateType)
        {
            int idx = cboRate.Items.IndexOf(rateType);
            if(idx > -1)
            {
                cboRate.SelectedIndex = idx;
            }
        }

        public void SetRuleDateTimeType(FieldTypes ruleType)
        {
            if (ruleType == FieldTypes.Time)
            {
                startDatePicker.Format = DateTimePickerFormat.Time;
                endDatePicker.Format = DateTimePickerFormat.Time;
            }

            Properties.GeneralType = ruleType; ;
        }

        public override bool ApplyDataToRuleSet()
        {
            bool valid = true;
            InitializeCommonRule();
            try
            {
                switch (Properties.GeneralType)
                {
                    case FieldTypes.Date:
                        BuildRules.Buildrule((DateRule)Properties.Result, startDatePicker.Value, endDatePicker.Value, txtTimeDateIncrement.Text, BoxUtl.CboBoxItem(cboRate));
                        break;

                    case FieldTypes.Time:
                        BuildRules.Buildrule((TimeRule)Properties.Result, startDatePicker.Value, endDatePicker.Value, txtTimeDateIncrement.Text, BoxUtl.CboBoxItem(cboRate));
                        break;
                }
            }
            catch (Exception e)
            {
                valid = ErrorMessage(e);
            }
            return valid;
        }

        private void cboRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRate.SelectedIndex > 0 && rbDateTimeInc.Checked)
            {
                txtTimeDateIncrement.Enabled = true;
            }
        }

        private void rbDateTimeInc_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDateTimeInc.Checked)
                cboRate.Enabled = true;
            else
            {
                cboRate.Enabled = false;
                txtTimeDateIncrement.Enabled = false;
                txtTimeDateIncrement.Text = String.Empty;
            }
        }

        private void rbRandomDateTime_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Random = rbRandomDateTime.Checked;
            cboRate.Enabled = rbRandomDateTime.Checked;
        }
    }
}
