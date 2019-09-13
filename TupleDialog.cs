using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MockDataGenerator.Controls;
using MockDataGenerator.Interfaces;

namespace MockDataGenerator
{
    public partial class TupleDialog : Form
    {
        public static IDataRule Result;
        private IRuleControl aRuleCtrl;

        public bool ViewOnly
        {
            set
            {
                this.mnuAdd.Enabled = value;
                this.mnuSet.Enabled = value;
                this.mnuEditRule.Enabled = value;
            }

        }

        public TupleDialog()
        {
            InitializeComponent();
            descriptionCtrl.DescriptionChange = DescriptionChange;
            standardDataTypesCtrl.SelectedType = StandardSelectChange;
            tupleCtrl.TupleRuleSelected = SelectTupleRule;
        }

        public TupleDialog(IDataRule editRule)
            : this()
        {
            tupleCtrl.EditRule(editRule);
            descriptionCtrl.Description = editRule.Description;
            descriptionCtrl.TypeDisplay = editRule.FieldDataType;
            descriptionCtrl.FieldDisplay = editRule.FieldName;
        }

        private void SelectTupleRule(Object sender, ExportEvents.exportControlEventArgs e)
        {
            IDataRule aRule = (IDataRule)e.getData;
            if(aRuleCtrl != null && aRuleCtrl.Properties.Result != null && aRuleCtrl.Properties.Result.RuleId.Equals(aRule.RuleId))
                aRuleCtrl.EditRule(aRule);
            else
            {
                standardDataTypesCtrl.CreateIRuleControl(aRule.FieldDataType);
                aRuleCtrl.EditRule(aRule);
            }

            mnuAdd.Enabled = false;
            mnuEditRule.Enabled = true;          

        }

        private void DescriptionChange(Object sender, ExportEvents.exportControlEventArgs e)
        {
            tupleCtrl.Properties.Description = e.getData.ToString();
        }
        private void StandardSelectChange(Object sender, ExportEvents.exportControlEventArgs e)
        {
            if(aRuleCtrl != null)
                this.ruleContainer.Controls.Remove((UserControl)aRuleCtrl);
            aRuleCtrl = (IRuleControl)e.getData;
            this.ruleContainer.Controls.Add((UserControl)aRuleCtrl, 2, 0);
            ((UserControl)aRuleCtrl).Dock = DockStyle.Fill;
            this.ruleContainer.SetRowSpan((UserControl)aRuleCtrl, 2);
            mnuAdd.Enabled = true;
            mnuEditRule.Enabled = false;
        }

        private void mnuAdd_Click(object sender, EventArgs e)
        {
            if (aRuleCtrl.ApplyDataToRuleSet())
            {
                tupleCtrl.AddRule(aRuleCtrl.Properties.Result);
                mnuSet.Enabled = true;
            }
        }

        private void mnuCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void mnuEditRule_Click(object sender, EventArgs e)
        {
           IDataRule oldRule =  aRuleCtrl.Properties.Result;
            if(aRuleCtrl.ApplyDataToRuleSet())
            {
                tupleCtrl.EditARule(oldRule, aRuleCtrl.Properties.Result);
            }
        }

        private void mnuSet_Click(object sender, EventArgs e)
        {
            tupleCtrl.Properties.GeneralType = Enums.FieldTypes.Tuple;
            tupleCtrl.Properties.TypeDisplay = Enums.FieldTypes.Tuple.ToString();            
            tupleCtrl.Properties.TypeDisplay = descriptionCtrl.TypeDisplay;
            tupleCtrl.Properties.FieldDisplay = descriptionCtrl.FieldDisplay;

            if (tupleCtrl.ApplyDataToRuleSet())
            {
                Result = tupleCtrl.Properties.Result;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
