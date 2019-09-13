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
using MockDataGenerator.Interfaces;
using MockDataGenerator.Utility;
using MockDataGenerator.SpecialObjects.Rules;
using BuildObjects.MapObjects;

namespace MockDataGenerator.Controls
{
    public partial class MappedSourceCtrl : AbstractRuleControl
    {
        private ViableMapAndData currentMappedSource;        
        public MappedSourceCtrl()
            :base()
        {
            InitializeComponent();
            Properties.GeneralType = Enums.FieldTypes.MappedSource;
            if (!this.DesignMode)
                LoadSources();
        }
        
        private void LoadSources()
        {
           foreach(ViableMapAndData mappedNode in MainForm.GetMappedSoruces())
           {
                ListViewItem anItem = lstMappedSources.Items.Add(mappedNode.TheMap.ClassName);
                anItem.Tag = mappedNode;
           }
        }        

        public override void EditRule(IDataRule aRule)
        {
            base.EditRule(aRule);
        }

        public override bool ApplyDataToRuleSet()
        {
            bool valid = true;
            Properties.GeneralType = Enums.FieldTypes.MappedSource;
            InitializeCommonRule();
            try
            {
                BuildRules.Buildrule((MappedSourceRule)Properties.Result, currentMappedSource);
            }
            catch (Exception e)
            {
                valid = ErrorMessage(e);
            }
            return valid;
        }


        private void lstMappedSources_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentMappedSource = (ViableMapAndData)lstMappedSources.SelectedItems[0].Tag;
        }
    }
}
