using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MockDataGenerator.Interfaces;
using MockDataGenerator.SpecialObjects;
using MockDataGenerator.Utility;
using MockDataGenerator.Enums;
using MockDataGenerator.SpecialObjects.Rules.RuleSupport;
using MockDataGenerator.SpecialObjects.Rules;

namespace MockDataGenerator.Controls.InternalLists
{
    public partial class SingleColumnListCtrl : BaseListCtrl
    {
        public SingleColumnListCtrl()
        {
            InitializeComponent();
            tbPageSize.Text = pageSize.ToString();
            rangeCtrl.CheckState = ChangeRegexMode;
            regularExpressionCtrl.CheckState = ChangeRangeMode;
        }

        public override void LoadControl()
        {
            base.LoadControl();
            lblTotalPages.Text = lblTotalPages.Text.Replace("#", (fileLines.Length / pageSize).ToString());
            LoadRecords();
        }

        public void ChangeRegexMode(Object sender, ExportEvents.exportControlEventArgs e)
        {
            bool result = (bool)e.getData;
            regularExpressionCtrl.CheckRegexButton(!result);
        }

        public void ChangeRangeMode(Object sender, ExportEvents.exportControlEventArgs e)
        {
            bool result = (bool)e.getData;
            rangeCtrl.CheckRangeButton(!result);
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            if (currentPosition > pageSize)
            {
                currentPosition -= 2 * pageSize;
                LoadRecords();
            }
        }

        private void mnuForward_Click(object sender, EventArgs e)
        {
            LoadRecords();
        }

        protected override void LoadRecords()
        {
            lstColumn.Items.Clear();
            long idx = 0;
            for (idx = currentPosition; idx < currentPosition + pageSize && idx < fileLines.Length; idx++)
            {
                string loadIt = fileLines[idx].Trim();
                if(!String.IsNullOrEmpty(loadIt))
                    lstColumn.Items.Add(loadIt);
            }
            lblCurrentPage.Text = String.Format("Page: {0}", idx / pageSize);
            currentPosition = idx;
        }

        private void tbPageSize_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                int result = -1;
                if (int.TryParse(tbPageSize.Text, out result) && result > 0)
                {
                    currentPosition -= pageSize;
                    pageSize = result;
                    lblTotalPages.Text = lblTotalPages.Text.Replace("#", (fileLines.Length / pageSize).ToString());
                    LoadRecords();
                }
            }
        }

        public override void EditRule(IDataRule aRule)
        {
            base.EditRule(aRule);
           SingleFieldDataSourceRule iRule = (SingleFieldDataSourceRule)aRule;
            LoadFile(iRule.TypeofInternalSource);            
            SourceType = iRule.TypeofInternalSource;
            rangeCtrl.Start = iRule.RangeStart; 
            rangeCtrl.End = iRule.RangeEnd;
            rangeCtrl.Random = iRule.IsRandom;
            regularExpressionCtrl.RegularExpression = iRule.RegularExpression;            
            txtMaxRecords.Text = iRule.MaxRecords.ToString();
        }

        public override bool ApplyDataToRuleSet()
        {
            bool valid = true;
            Properties.Random = rangeCtrl.Random;
            Properties.GeneralType = FieldTypes.SingleColumn;
            InitializeCommonRule();
            try
            {               
                BuildRules.Buildrule((SingleFieldDataSourceRule)Properties.Result, SourceType, int.Parse(txtMaxRecords.Text), rangeCtrl.Start, rangeCtrl.End, regularExpressionCtrl.RegularExpression);
            }
            catch (Exception e)
            {
                valid = ErrorMessage(e);
            }

            return valid;
        }
    }
}
