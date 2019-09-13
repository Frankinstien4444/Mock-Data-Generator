using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MockDataGenerator.Controls.InternalLists;
using MockDataGenerator.Enums;
using MockDataGenerator.Interfaces;
using MockDataGenerator.SpecialObjects;
using MockDataGenerator.SpecialObjects.Rules;

namespace MockDataGenerator
{
    public partial class DataFileDialog : Form
    {
        public static IDataRule Result;
        BaseListCtrl lastCtrl;
        bool editMode = false;

        public bool ViewOnly
        {
            set
            {
                this.mnuSet.Enabled = value;                
            }

        }
        public DataFileDialog()
        {
            InitializeComponent();
            descriptionCtrl.DescriptionChange = DescriptionChange;
            foreach (string aSource in Enum.GetNames(typeof(DataResources)))
            {
                lstSources.Items.Add(aSource.Replace("_", " "));
            }
        }

        public DataFileDialog(IDataRule editRule)
               : this()    
        {
            EditRule(editRule);                        
            descriptionCtrl.Description = editRule.Description;
            descriptionCtrl.TypeDisplay = editRule.FieldDataType;
            descriptionCtrl.FieldDisplay = editRule.FieldName;

        }

        private void DescriptionChange(Object sender, ExportEvents.exportControlEventArgs e)
        {
            lastCtrl.Properties.Description = e.getData.ToString();
        }
        private void EditRule(IDataRule oldRule)
        {
            
            int idx = lstSources.Items.IndexOf(((DataSourceRule)oldRule).TypeofInternalSource.ToString().Replace("_", " "));
            if (idx != -1)
            {
                Result = oldRule;
                editMode = true;
                lstSources.SetSelected(idx, true);
                lastCtrl.EditRule(oldRule);
            }
           
        }

        private void lstSources_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataResources aSource = (DataResources)Enum.Parse(typeof(DataResources), lstSources.SelectedItem.ToString().Replace(" ", "_"));
            if (lastCtrl != null)
            {
                this.mainPanel.Controls.Remove((UserControl)lastCtrl);
            }
            switch (aSource)
            {
                case DataResources.Occupations:
                case DataResources.US_Companies:
                case DataResources.LastNames:
                case DataResources.List_Of_Streets:
                case DataResources.List_Of_Countires:
                case DataResources.Male_Names:
                case DataResources.Female_Names:
                case DataResources.European_Companies:
                    lastCtrl = new SingleColumnListCtrl();
                    break;

                case DataResources.US_Cities:
                case DataResources.Industry_Sectors:
                    lastCtrl = new TreeListCtrl();                    
                    break;

                case DataResources.List_Of_US_States:
                case DataResources.US_PostalCodes:
                    lastCtrl = new MultiColumnListCrl();
                    break;
            }

            lastCtrl.SourceType = aSource;
            this.mainPanel.Controls.Add(lastCtrl, 1, 0);
            this.mainPanel.SetRowSpan(lastCtrl, 2);            
            lastCtrl.Dock = DockStyle.Fill;
            lastCtrl.LoadFile(aSource);
            if (editMode)
            {
                lastCtrl.EditRule(Result);
                editMode = false;
            }
        }
        
        private void mnuSet_Click(object sender, EventArgs e)
        {
            if (lastCtrl.ApplyDataToRuleSet())
            {
                Result = lastCtrl.Properties.Result;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void mnuCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
