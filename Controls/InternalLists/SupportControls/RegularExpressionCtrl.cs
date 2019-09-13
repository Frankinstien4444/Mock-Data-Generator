using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExportEvents;

namespace MockDataGenerator.Controls.InternalLists.SupportControls
{
    public partial class RegularExpressionCtrl : UserControl
    {
        public exportControlEventHandler CheckState { set; get; }
        public exportControlEventHandler ExportExpression { set; get; }
        public void CheckRegexButton(bool state)
        {
            rbRegEx.Checked = state;
        }
        public RegularExpressionCtrl()
        {
            InitializeComponent();
        }

        public String RegularExpression
        {
            set
            {
                txtRegEx.Text = value;
            }

            get
            {
                return txtRegEx.Text;
            }
        }

        private void rbRegEx_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRegEx.Checked)
            {
                EnableCtrls(true);
                if (CheckState != null)
                {
                    CheckState(this, new ExportEvents.exportControlEventArgs(true));
                }
            }
            else
                EnableCtrls(false);
        }

        private void EnableCtrls(bool state)
        {
            txtRegEx.Enabled = state;
            testRegEx.Enabled = state;
        }

        private void txtRegEx_TextChanged(object sender, EventArgs e)
        {
            if (ExportExpression != null)
                ExportExpression(this, new exportControlEventArgs(txtRegEx.Text));
        }
    }
}
