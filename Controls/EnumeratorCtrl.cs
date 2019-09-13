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
using MockDataGenerator.Utility;
using MockDataGenerator.SpecialObjects;
using MockDataGenerator.SpecialObjects.Rules;

namespace MockDataGenerator.Controls
{
    public partial class EnumeratorCtrl : AbstractRuleControl
    {
        public EnumeratorCtrl()
            :base()
        {
            InitializeComponent();
            Properties.GeneralType = Enums.FieldTypes.Enumerator;
            Tuple<String, List<Type>> enums = MainForm.GetAssemblyEnumerators();
            lblAssemblyName.Text = "Assembly Name: " + enums.Item1;
            foreach (Type anEnum in enums.Item2)
            {
                int idx = enumeratorList.Items.Add(anEnum.Name);
            }
        }

        public override void EditRule(IDataRule aRule)
        {
            base.EditRule(aRule);
            int idx = enumeratorList.Items.IndexOf(((EnumeratorRule)aRule).Enumerator);
            if(idx != -1)
            {
                enumeratorList.SetItemChecked(idx, true);
                rbRandom.Checked = aRule.IsRandom;
                rbIterate.Checked = !aRule.IsRandom;
                lblAssemblyName.Text = "Assembly Name: " + ((EnumeratorRule)aRule).Assembly;
            }
            
        }
        public override bool ApplyDataToRuleSet()
        {
            bool valid = true;
            Properties.GeneralType = Enums.FieldTypes.Enumerator;
            InitializeCommonRule();
            try
            {
                BuildRules.Buildrule((EnumeratorRule)Properties.Result, rbRandom.Checked, enumeratorList.SelectedItem.ToString(), lblAssemblyName.Text);
            }
            catch (Exception e)
            {
                valid = ErrorMessage(e);
            }
            return valid;
        }
    }
}
