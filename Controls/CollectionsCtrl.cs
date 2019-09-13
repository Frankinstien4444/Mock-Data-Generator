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
    public partial class CollectionsCtrl : AbstractRuleControl
    {        
        public String Assemblyname { set; get; }
        public String AssemblyPath { set; get; }

        public EventHandler SelectCollection
        {
            set
            {
                this.collectionTypes.SelectedIndexChanged += value;
            }
        }

        private IDataRule valueRule;
        private IDataRule keyRule;
        public CollectionsCtrl()
            :base()
        {
            InitializeComponent();
            Properties.GeneralType = Enums.FieldTypes.Collection;
        }
        
        public override void EditRule(IDataRule aRule)
        {
            base.EditRule(aRule);
            CollectionRule cRule = (CollectionRule)aRule;
            keyRule = cRule.KeyRule;
            valueRule = cRule.ValueRule;
            int idx = collectionTypes.Items.IndexOf(cRule.Generic.ToString());
            if(idx != -1)
                collectionTypes.SelectedIndex = idx;
        }

        public void SetRule(IDataRule collectionRule, bool key)
        {
            if (!key)
                valueRule = collectionRule;
            else
                keyRule = collectionRule;
        }

        public override bool ApplyDataToRuleSet()
        {
            bool valid = true;
            InitializeCommonRule();
            try
            {
                BuildRules.Buildrule((CollectionRule)Properties.Result, collectionTypes.SelectedItem.ToString(), valueRule, keyRule, Assemblyname, AssemblyPath);
            }
            catch (Exception e)
            {
                valid = ErrorMessage(e);
            }
            return valid;
        }       
    }
}
