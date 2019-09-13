using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MockDataGenerator.Enums;
using MockDataGenerator.Interfaces;
using MockDataGenerator.SpecialObjects;

namespace MockDataGenerator
{
    public partial class CollectionDialog : Form
    {
        public static IDataRule Result;
        private IRuleControl aRuleCtrl;
        private GenericCollections aCollection;

        public bool ViewOnly
        {
            set
            {
                this.mnuAdd.Enabled = value;
                this.mnuSet.Enabled = value;
            }

        }
        public CollectionDialog()
        {
            InitializeComponent();
            standardDataTypesCtrl.SelectedType = StandardSelectChange;
            collectionsCtrl.SelectCollection = SelectCollection;
            descriptionCtrl.DescriptionChange = DescriptionChange;
        }

        public CollectionDialog(IDataRule editRule) : this()              
        {
            collectionsCtrl.EditRule(editRule);            
            descriptionCtrl.Description = editRule.Description;
            descriptionCtrl.TypeDisplay = editRule.FieldDataType;
            descriptionCtrl.FieldDisplay = editRule.FieldName;
            EditRules(editRule);
            SetCollectionType();
        }
        private void EditRules(IDataRule aRule)
        {
            CollectionRule cRule = (CollectionRule)aRule;
            if (cRule.KeyRule != null)
            {
                collectionsCtrl.SetRule(cRule.KeyRule, true);
                lblKeyRule.Text = SetType(cRule.KeyRule);
                lblKeyRule.Tag = cRule.KeyRule;
            }
            collectionsCtrl.SetRule(cRule.ValueRule, false);
            lblValueRule.Text = SetType(cRule.ValueRule);
            lblValueRule.Tag = cRule.ValueRule;
            aCollection = cRule.Generic;
        }

        private string SetType(IDataRule aRule)
        {
            String result = aRule.RuleType.ToString();
            if(aRule.RuleType == FieldTypes.Number)
            {
                result = String.Format("Number:{0}", aRule.FieldDataType);
            }

            return result;
        }

        private void SelectCollection(Object sender, EventArgs e)
        {
            CheckedListBox cbList = (CheckedListBox)sender;
            aCollection = (GenericCollections)Enum.Parse(typeof(GenericCollections), cbList.SelectedItem.ToString());
            SetCollectionType();
        }

        private void SetCollectionType()
        {
            switch (aCollection)
            {
                case GenericCollections.ConcurentDictionary:
                case GenericCollections.Dictionary:
                case GenericCollections.SortedDictionary:
                    rbKey.Enabled = true;
                    rbValue.Enabled = true;
                    rbKey.Checked = true;
                    break;

                default:
                    rbKey.Enabled = false;
                    rbValue.Enabled = false;
                    rbValue.Checked = true;
                    break;
            }

            if (aCollection != GenericCollections.None)
                standardDataTypesCtrl.Enabled = true;
        }
        private void mnuCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StandardSelectChange(Object sender, ExportEvents.exportControlEventArgs e)
        {
            if(aRuleCtrl != null)
                this.ruleContainer.Controls.Remove((UserControl)aRuleCtrl);
            aRuleCtrl = (IRuleControl)e.getData;            
            this.ruleContainer.Controls.Add((UserControl)aRuleCtrl, 0, 2);
            ((UserControl)aRuleCtrl).Dock = DockStyle.Fill;
            this.ruleContainer.SetColumnSpan((UserControl)aRuleCtrl, 2);
            CheckIfEdit(aRuleCtrl);
        }

        private void CheckIfEdit(IRuleControl aRuleCtrl)
        {
            if(rbKey.Checked && lblKeyRule.Text.Contains(aRuleCtrl.Properties.GeneralType.ToString()))
            {
                aRuleCtrl.EditRule((IDataRule)lblKeyRule.Tag);
            }
            else if(lblValueRule.Text.Contains(aRuleCtrl.Properties.GeneralType.ToString()))
            {
                aRuleCtrl.EditRule((IDataRule)lblValueRule.Tag);
            }
        }

        private void DescriptionChange(Object sender, ExportEvents.exportControlEventArgs e)
        {
            collectionsCtrl.Properties.Description = e.getData.ToString();
        }
        private void mnuSet_Click(object sender, EventArgs e)
        {
                                  
                collectionsCtrl.Properties.TypeDisplay = descriptionCtrl.TypeDisplay;
                collectionsCtrl.Properties.FieldDisplay = descriptionCtrl.FieldDisplay;
                
                if (collectionsCtrl.ApplyDataToRuleSet())
                {
                    Result = collectionsCtrl.Properties.Result;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
           
        }

        private void mnuAdd_Click(object sender, EventArgs e)
        {
            switch (aCollection)
            {
                case GenericCollections.ConcurentDictionary:
                case GenericCollections.Dictionary:
                case GenericCollections.SortedDictionary:
                    if (rbKey.Checked)
                    {
                        lblKeyRule.Text = aRuleCtrl.Properties.GeneralType.ToString();
                        lblKeyRule.Tag = aRuleCtrl.Properties.Result;
                    }
                    else
                    {
                        lblValueRule.Text = aRuleCtrl.Properties.GeneralType.ToString();
                        lblValueRule.Tag = aRuleCtrl.Properties.Result;
                    }
                    if (!lblValueRule.Text.Equals("NA") && !lblKeyRule.Text.Equals("NA"))
                        mnuSet.Enabled = true;
                    break;

                default:
                    lblValueRule.Text = aRuleCtrl.Properties.GeneralType.ToString();
                    mnuSet.Enabled = true;
                    break;
            }

            if (aRuleCtrl.ApplyDataToRuleSet())
                collectionsCtrl.SetRule(aRuleCtrl.Properties.Result, rbKey.Checked);

        }

        private void standardDataTypesCtrl_Load(object sender, EventArgs e)
        {

        }
    }
}
