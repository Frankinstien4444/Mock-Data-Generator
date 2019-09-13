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
using MockDataGenerator.Enums;
using MockDataGenerator.Interfaces;
using MockDataGenerator.SpecialObjects;
using MockDataGenerator.Utility;

namespace MockDataGenerator
{
    public partial class FieldSettings : Form
    {
        public ExportEvents.exportEventHandlerWithReturn Navigation { set; get; }
        public static IDataRule Result;
        public bool ViewOnly
        {
            set
            {
                this.mnuSet.Enabled = value;                
            }

        }

        private IRuleControl fieldRuleCtrl;
        public FieldSettings(IDataRule editRule) : this(editRule.RuleType)
        {
            fieldRuleCtrl.EditRule(editRule);
            Result = editRule;
            descriptionCtrl.Description = editRule.Description;
            descriptionCtrl.TypeDisplay = editRule.FieldDataType;
            descriptionCtrl.FieldDisplay = editRule.FieldName;                     
        }
        public FieldSettings(FieldTypes generalType)
        {
            InitializeComponent();
            descriptionCtrl.DescriptionChange = DescriptionChange;
            EnablePanel(generalType);
            Result = null;            
        }

        private void DescriptionChange(Object sender, ExportEvents.exportControlEventArgs e)
        {
            fieldRuleCtrl.Properties.Description = e.getData.ToString();
        }

        private void EnablePanel(FieldTypes generalType)
        {
            switch (generalType)
            {
                case FieldTypes.Number:
                    fieldRuleCtrl = new NumberFieldCtrl();
                    break;

                case FieldTypes.String:
                    fieldRuleCtrl = new StringFieldCtrl();
                    break;

                case FieldTypes.Date:
                case FieldTypes.Time:
                    fieldRuleCtrl = new DateTimeFieldCtrl();
                    ((DateTimeFieldCtrl)fieldRuleCtrl).SetRuleDateTimeType(generalType);
                    break;

                case FieldTypes.Enumerator:
                    fieldRuleCtrl = new EnumeratorCtrl();
                    break;

                case FieldTypes.MappedSource:
                    fieldRuleCtrl = new MappedSourceCtrl();
                    break;
            }            

            this.controlPanel.Controls.Add((UserControl)this.fieldRuleCtrl, 0, 1);
           ((UserControl)this.fieldRuleCtrl).Dock = DockStyle.Fill;            
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Navigation != null)
            {
                Object result = Navigation(sender, new ExportEvents.exportControlEventArgs(NavigateFields.Next));
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (Navigation != null)
            {
                Object result = Navigation(sender, new ExportEvents.exportControlEventArgs(NavigateFields.Previous));
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            if (fieldRuleCtrl.ApplyDataToRuleSet())
            {
                Result = fieldRuleCtrl.Properties.Result;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }       
    }
}
