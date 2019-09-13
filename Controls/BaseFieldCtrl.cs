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
using MockDataGenerator.Enums;

namespace MockDataGenerator.Controls
{
    public partial class BaseFieldCtrl : AbstractRuleControl
    {
        
        public void SetTitle(StandardTypes standardType)
        {
            label1.Text = standardType.ToString();
        }
        public BaseFieldCtrl()
        {
            InitializeComponent();
        }

        public override void EditRule(IDataRule aRule)
        {
            base.EditRule(aRule);
        }
        public override bool ApplyDataToRuleSet()
        {
            bool valid = true;
            InitializeCommonRule();
            try
            {

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Not all fields have been filled", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;
            }
            return valid;
        }
    }
}
