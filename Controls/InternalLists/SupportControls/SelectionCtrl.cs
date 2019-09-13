using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MockDataGenerator.SpecialObjects.Rules.RuleSupport;
using MockDataGenerator.Enums;
using ExportEvents;

namespace MockDataGenerator.Controls.InternalLists.SupportControls
{
    public partial class SelectionCtrl : UserControl
    {
        public exportControlEventHandler ExportRegularExpression { set; get; }
        public exportControlEventHandler ExportRange { set; get; }
        public exportControlEventHandler ExportPanelStates { set; get; }
        public exportControlEventHandler ExportIsRandom { set; get; }
        public String AllTitle { set; private get; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public List<SearchField> SearchFields { private set; get; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public List<DataField> DataFields { private set; get; }

        private SearchField currentSearchField;        
        public String Title
        {
            set
            {
                lblTitle.Text = value;
            }
        }

        public void Clear()
        {
            chkSelection.Items.Clear();            
        }        

        public List<String> GetSelected()
        {
            List<String> result = new List<string>();
            for(int i=0;i< chkSelection.SelectedItems.Count; i++)
            {
                result.Add(chkSelection.SelectedItems[i].ToString());
            }

            return result;
        }

        public void SelectAnItem(string item)
        {
            int idx = chkSelection.Items.IndexOf(item);
            if (idx != -1)
                chkSelection.SetItemChecked(idx, true);
        }

        public void SelectItems(string[] items)
        {
            foreach (string item in items)
                SelectAnItem(item);
        }       
        public SelectionCtrl()
        {
            InitializeComponent();
            if (!this.DesignMode)
            {
                SearchFields = new List<SearchField>();
                DataFields = new List<DataField>();
                logicPanel.Enabled = true;
            }
        }

        public void EditRule(List<SearchField> editSearch, List<DataField> editData)
        {                   
            SearchFields = editSearch ;
            DataFields = editData ;
            logicPanel.Enabled = true;            
        }

        private void rbField_CheckedChanged(object sender, EventArgs e)
        {
            chkSelection.Items.Clear();
            if (rbSearchField.Checked)
            {
                logicPanel.Enabled = true;                
                foreach(SearchField aField in SearchFields)
                    chkSelection.Items.Add(aField.ColumnName);
            }
            else
            {
                foreach (DataField aField in DataFields)
                    chkSelection.Items.Add(aField.ColumnName);

                logicPanel.Enabled = false;
                ClearPanels();
            }
        }

        public void UpdateRegularExpression(string expression)
        {
            currentSearchField.RegularExpression = expression;
        }

        public void UpdateIsRandom(bool state)
        {
            currentSearchField.IsRandom = state;
        }

        public void UpdateRange(String start, String end)
        {
            currentSearchField.RangeStart = start;
            currentSearchField.RangeEnd = end;
        }

        public void UpdateStartRange(String start)
        {
            currentSearchField.RangeStart = start;            
        }

        public void UpdateEndRange(String end)
        {            
            currentSearchField.RangeEnd = end;
        }       
        public void AddColumn(string column)
        {
            
            bool addIt = false;
            if (rbDataFields.Checked)
            {
                if (!DataFields.Any(x => x.ColumnName.Equals(column)))
                {
                    DataFields.Add(new DataField(column));
                    addIt = true;
                }
            }
            else
            {
                if (!SearchFields.Any(x => x.Equals(column)))
                {
                    SearchFields.Add(new SearchField(column, GetCurrentLogic()));
                    addIt = true;
                }
            }
            
            if(addIt)           
                chkSelection.Items.Add(column);               
           
        }

        private LogicTypes GetCurrentLogic()
        {
            if (rbAnnd.Checked)
                return LogicTypes.AND;
            else if (rbOR.Checked)
                return LogicTypes.OR;
            else if (rbXOR.Checked)
                return LogicTypes.ExclusiveOR;

            return LogicTypes.none;
        }

        private void SetLogic(LogicTypes logic)
        {
            switch(logic)
            {
                case LogicTypes.AND:
                    rbAnnd.Checked = true;
                    break;

                case LogicTypes.OR:
                    rbOR.Checked = true;
                    break;

                case LogicTypes.ExclusiveOR:
                    rbXOR.Checked = true;
                    break;
            }
        }

        private void rbLogic_CheckedChanged(object sender, EventArgs e)
        {
            currentSearchField.Logic = GetCurrentLogic();
        }

        private void chkSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbSearchField.Checked)
            {
                currentSearchField = SearchFields[chkSelection.SelectedIndex];
                SetLogic(currentSearchField.Logic);
                ExportData();
            }           
        }

        private void ClearPanels()
        {
            if (ExportRegularExpression != null)
                ExportRegularExpression(this, new exportControlEventArgs(String.Empty));
            if (ExportRange != null)
                ExportRange(this, new exportControlEventArgs(new Tuple<String, String>(String.Empty, String.Empty)));
            if (ExportIsRandom != null)
                ExportIsRandom(this, new exportControlEventArgs(false));
            if (ExportPanelStates != null)
                ExportPanelStates(this, new exportControlEventArgs(false));
        }

        private void ExportData()
        {
            if (ExportRegularExpression != null)
                ExportRegularExpression(this, new exportControlEventArgs(currentSearchField.RegularExpression));
            if (ExportRange != null)
                ExportRange(this, new exportControlEventArgs(new Tuple<String, String>(currentSearchField.RangeStart, currentSearchField.RangeEnd)));
            if (ExportIsRandom != null)
                ExportIsRandom(this, new exportControlEventArgs(currentSearchField.IsRandom));
            if (ExportPanelStates != null)
                ExportPanelStates(this, new exportControlEventArgs(true));
        }
    }
}
