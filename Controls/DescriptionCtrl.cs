using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MockDataGenerator.Controls
{
    public partial class DescriptionCtrl : UserControl
    {
        public ExportEvents.exportControlEventHandler DescriptionChange { set; get; }
        public String Description {
            set
            {
                if (!String.IsNullOrEmpty(value))
                    txtDescription.Text = value;
            }
            get
            {
                return txtDescription.Text;
            }
        }
        public String FieldDisplay
        {
            set
            {
                if (!String.IsNullOrEmpty(value))
                    lblFieldDisplay.Text = value;
            }
            get
            {
                return lblFieldDisplay.Text;
            }
        }
        public String TypeDisplay
        {
            set
            {
                if (!String.IsNullOrEmpty(value))
                    lblTypeDisplay.Text = value;
            }
            get
            {
                return lblTypeDisplay.Text;
            }
        }
        public DescriptionCtrl()
        {
            InitializeComponent();
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            DescriptionChange?.Invoke(sender, new ExportEvents.exportControlEventArgs(txtDescription.Text));
        }
    }
}
