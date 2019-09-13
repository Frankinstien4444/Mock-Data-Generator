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

namespace MockDataGenerator.Controls
{
    public partial class BooleanCtrl : AbstractRuleControl
    {
        public BooleanCtrl()
            :base()
        {
            InitializeComponent();
            Properties.GeneralType = Enums.FieldTypes.Bool;
        }

        public override void EditRule(IDataRule aRule)
        {
            base.EditRule(aRule);
            chkConvertToString.Checked = aRule.ConvertToString;
            if (aRule.IsRandom)
                rbRandom.Checked = true;
            else if (((BoolRule)aRule).AlwaysFalse)
                rbFalse.Checked = true;
            else
                rbTrue.Checked = true;
        }

        public override bool ApplyDataToRuleSet()
        {
            bool valid = true;
            InitializeCommonRule();
            try
            {
                BuildRules.Buildrule((BoolRule)Properties.Result, rbTrue.Checked, rbFalse.Checked);
            }
            catch (Exception e)
            {
                valid = ErrorMessage(e);
            }
            return valid;
        }

        private void rbRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRandom.Checked)
                Properties.Random = true;
            else
                Properties.Random = false;
        }
    }
}
