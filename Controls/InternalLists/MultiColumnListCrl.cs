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
using MockDataGenerator.Utility;
using MockDataGenerator.Interfaces;
using MockDataGenerator.Enums;
using MockDataGenerator.SpecialObjects;
using ExportEvents;

namespace MockDataGenerator.Controls.InternalLists
{
    public partial class MultiColumnListCrl : BaseListCtrl
    {       
        public exportControlEventHandler ColumnSelection { set; get; }
        public MultiColumnListCrl()
        {
            InitializeComponent();
            tbPageSize.Text = pageSize.ToString();
            rangeCtrl.CheckState = ChangeRegexMode;
            regularExpressionCtrl.CheckState = ChangeRangeMode;
            selectionCtrl.Title = "Select Column(s)";
            selectionCtrl.AllTitle = "Columns";
            selectionCtrl.ExportIsRandom = SetRandom;
            selectionCtrl.ExportRange = SetRange;
            selectionCtrl.ExportRegularExpression = SetExpression;
            selectionCtrl.ExportPanelStates = SetPanelStates;
            regularExpressionCtrl.ExportExpression = UpdateRegularExpression;
            rangeCtrl.ExportEnd = UpdateEndRange;
            rangeCtrl.ExportStart = UpdateStartRange;
            rangeCtrl.ExportRandom = UpdateRandom;
            
        }        
        
        public override void LoadControl()
        {
            base.LoadControl();
            lblTotalPages.Text = lblTotalPages.Text.Replace("#", (fileLines.Length/pageSize).ToString());
            LoadRecords();
        }

        private void SetRandom(Object sender, exportControlEventArgs e)
        {
            rangeCtrl.Random = (bool)e.getData;
        }

        private void SetRange(Object sender, exportControlEventArgs e)
        {
            Tuple<String, String> rangeData = (Tuple<String, String>)e.getData;
            if (rangeData.Item1 != null && rangeData.Item2 != null)
            {
                rangeCtrl.Start = rangeData.Item1;
                rangeCtrl.End = rangeData.Item2;
                rangeCtrl.CheckRangeButton(true);
            }
            else
            {
                rangeCtrl.Start = String.Empty;
                rangeCtrl.End = String.Empty;
                rangeCtrl.CheckRangeButton(false);
            }
        }

        private void SetPanelStates(Object sender, exportControlEventArgs e)
        {
            bool state = (bool)e.getData;
            rangeCtrl.Enabled = state;
            regularExpressionCtrl.Enabled = state;
        }
        private void SetExpression(Object sender, exportControlEventArgs e)
        {
            if (e.getData != null)
            {
                regularExpressionCtrl.RegularExpression = e.getData.ToString();
                regularExpressionCtrl.CheckRegexButton(true);
            }
            else
            {
                regularExpressionCtrl.RegularExpression = "";
                regularExpressionCtrl.CheckRegexButton(false);
            }
        }

        private void UpdateRandom(Object sender, exportControlEventArgs e)
        {
            selectionCtrl.UpdateIsRandom((bool)e.getData);
        }
        private void UpdateEndRange(Object sender, exportControlEventArgs e)
        {
            selectionCtrl.UpdateEndRange(e.getData.ToString());
        }

        private void UpdateStartRange(Object sender, exportControlEventArgs e)
        {
            selectionCtrl.UpdateStartRange(e.getData.ToString());
        }

        private void UpdateRegularExpression(Object sender, exportControlEventArgs e)
        {
            selectionCtrl.UpdateRegularExpression(e.getData.ToString());
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

        protected override void LoadRecords()
        {
            dataGridView.Rows.Clear();
            selectionCtrl.Clear();
            long idx = 0;
            for (idx = currentPosition; idx < currentPosition + pageSize && idx < fileLines.Length; idx++)
            { 
                        if (idx == 0 && dataGridView.Columns.Count == 0)
                        {                            
                           BuildColumns(fileLines[idx]);                                                                    
                        }
                        else
                        {
                           
                            string[] aRow = fileLines[idx].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                            dataGridView.Rows.Add(aRow);
                        }         
            }
            lblCurrentPage.Text = String.Format("Page: {0}", idx / pageSize);
            currentPosition = idx;
        }

        private void BuildColumns(string columnRec)
        {
            string[] columns = new string[0];
            if (SourceType == DataResources.US_PostalCodes)
                columns = columnRec.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            else if (SourceType == DataResources.List_Of_US_States)
                columns = new string[] { "State Name", "Abbreviation" };
            foreach (string colHdr in columns)
            {
                dataGridView.Columns.Add(colHdr, colHdr);
                //selectionCtrl.AddItem(colHdr);
            }
        }       

        private void mnuBack_Click(object sender, EventArgs e)
        {
            if (currentPosition > pageSize)
            {
                currentPosition -= 2* pageSize;
                LoadRecords();
            }
        }        
        
        private void mnuForward_Click(object sender, EventArgs e)
        {
                LoadRecords();
        }

        private void tbPageSize_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
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
            MultiFieldDataSourceRule iRule = (MultiFieldDataSourceRule)aRule;
            LoadFile(iRule.TypeofInternalSource);
            SourceType = iRule.TypeofInternalSource;            
            rangeCtrl.Random = iRule.IsRandom;
            selectionCtrl.EditRule(iRule.SearchFields, iRule.FieldColumnMap);            
            txtMaxRecords.Text = iRule.MaxRecords.ToString();
        }

        public override bool ApplyDataToRuleSet()
        {
            bool valid = true;            
            Properties.GeneralType = FieldTypes.MultiColumn;
            InitializeCommonRule();
            try
            {
                BuildRules.Buildrule((MultiFieldDataSourceRule)Properties.Result, SourceType, int.Parse(txtMaxRecords.Text), selectionCtrl.SearchFields, selectionCtrl.DataFields, ListCtrlType.Grid);
            }
            catch (Exception e)
            {
                valid = ErrorMessage(e);
            }

            return valid;
        }

        private void dataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
                selectionCtrl.AddColumn(dataGridView.Columns[e.ColumnIndex].HeaderText);
        }
    }
}
