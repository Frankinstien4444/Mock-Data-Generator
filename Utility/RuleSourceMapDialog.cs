using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MockDataGenerator.SpecialObjects.Rules.RuleSupport;

namespace MockDataGenerator.Utility
{
    public partial class RuleSourceMapDialog : Form
    {
        string mappedField;
        List<DataField> columns;
        public RuleSourceMapDialog()
        {
            InitializeComponent();
        }

        public String RuleDescription
        {
            set
            {
                txtDescription.Text = value;
            }
        }
        public void LoadDataFields(List<DataField> fields, string mapToField)
        {
            groupBox1.Text = groupBox1.Text + ": " + mapToField;
            foreach (DataField aField in fields)
            {
                lstDataFields.Items.Add(aField.ColumnName);
            }
            mappedField = mapToField;
            columns = fields;
        }

        private void mnuCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuOK_Click(object sender, EventArgs e)
        {
            if (lstDataFields.CheckedItems.Count > 0)
            {
                var dataField = columns.Where(x => x.ColumnName.Equals(lstDataFields.CheckedItems[0].ToString())).FirstOrDefault();
                if (dataField != null)
                    dataField.FieldName = mappedField;

                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("A column must be selected, or click on cancel button to exit");
        }

        private void lstDataFields_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (lstDataFields.CheckedItems.Count >= 1)
            {
                MessageBox.Show("More than one column was checked, only one column per field can be checked.");
                e.NewValue = CheckState.Unchecked;
            }
            
        }
    }
}
