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
using MockDataGenerator.SpecialObjects.Rules;

namespace MockDataGenerator.Controls
{
    public partial class TupleCtrl : AbstractRuleControl
    {
        public ExportEvents.exportControlEventHandler TupleRuleSelected { set; get; }
        public TupleCtrl()
            :base()
        {
            InitializeComponent();
            Properties.GeneralType = Enums.FieldTypes.Tuple;
        }

        public override void EditRule(IDataRule aRule)
        {
            base.EditRule(aRule);
            TupleRule tRule = (TupleRule)aRule;
            foreach(IDataRule lstRule in tRule.Types)
            {
                AddRule(lstRule);
            }
        }

        public override bool ApplyDataToRuleSet()
        {
            bool valid = true;
            InitializeCommonRule();
            try
            {
                List<IDataRule> rules = new List<IDataRule>();
                foreach(ListViewItem aItem in lstTupleSet.Items)
                {
                    rules.Add((IDataRule)aItem.Tag);
                }
                BuildRules.Buildrule((TupleRule)Properties.Result, rules);
            }
            catch (Exception e)
            {
                valid = ErrorMessage(e);
            }
            return valid;
        }

        public void AddRule(IDataRule aRule)
        {
            ListViewItem aItem = lstTupleSet.Items.Add(aRule.RuleType.ToString());
            aItem.Tag = aRule;
        }

        public void EditARule(IDataRule oldRule, IDataRule newRule)
        {
            foreach (ListViewItem aItem in lstTupleSet.Items)
            {
                if (((IDataRule)aItem.Tag).RuleId.Equals(oldRule.RuleId))
                {
                    aItem.Tag = newRule;
                    break;
                }
            }
        }

        private void lstTupleSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TupleRuleSelected != null && lstTupleSet.SelectedItems.Count > 0)
                TupleRuleSelected(null, new ExportEvents.exportControlEventArgs(lstTupleSet.SelectedItems[0].Tag));
        }

        public void MoveRuleUp(Object send, EventArgs e)
        {
            ListViewItem anItem = lstTupleSet.SelectedItems[0];
            int idx = lstTupleSet.SelectedItems[0].Index;
            if (idx > 0)
            {
                lstTupleSet.SelectedItems[0].Remove();
                lstTupleSet.Items.Insert(idx-1, anItem);
            }
            
        }
        public void MoveRuleDown(Object send, EventArgs e)
        {
            ListViewItem anItem = lstTupleSet.SelectedItems[0];
            int idx = lstTupleSet.SelectedItems[0].Index;
            if (idx + 1 < lstTupleSet.Items.Count)
            {
                lstTupleSet.SelectedItems[0].Remove();
                lstTupleSet.Items.Insert(idx + 1, anItem);
            }
        }

        public void DeleteRule(Object send, EventArgs e)
        {
            lstTupleSet.SelectedItems[0].Remove();
        }

    }
}
