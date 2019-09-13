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
    public partial class AbstractRuleControl : UserControl, IRuleControl
    {
        public CommonCtrlProperies Properties { set; get; }
        public AbstractRuleControl()
        {
            Properties = new CommonCtrlProperies();
            InitializeComponent();
        }

        public void DescriptionChange(String newText)
        {
            Properties.Description = newText;
        }
        public virtual bool ApplyDataToRuleSet()
        {
            bool valid = true;
            throw new Exception("Not implemented in the astract control.");
            return valid;
        }

        public virtual void EditRule(IDataRule aRule)
        {
            Properties.Result = aRule;
            Properties.TypeDisplay = aRule.FieldDataType;
            Properties.FieldDisplay = aRule.FieldName;
            Properties.Description = aRule.Description;
            Properties.Random = aRule.IsRandom;
            Properties.GeneralType = aRule.RuleType;            
        }
        protected void InitializeCommonRule()
        {
            Properties.Result = BuildRules.InitializeBase(Properties.GeneralType, Properties.Random, Properties.FieldDisplay, Properties.TypeDisplay, false);
            Properties.Result.Description = Properties.Description;           
        }

        protected bool ErrorMessage(Exception e)
        {
            MessageBox.Show(e.Message, "Not all fields have been filled", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
}
