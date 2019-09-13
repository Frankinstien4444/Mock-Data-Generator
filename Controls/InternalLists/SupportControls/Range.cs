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
    public partial class Range : UserControl
    {
        public exportControlEventHandler CheckState { set; get; }
        public exportControlEventHandler ExportStart { set; get; }

        public exportControlEventHandler ExportEnd { set; get; }

        public exportControlEventHandler ExportRandom { set; get; }
        public void CheckRangeButton(bool state)
        {
            rbRange.Checked = state;
        }
        
        public String Start
        {
            set
            {
                txtStart.Text = value;
            }

            get
            {
                return txtStart.Text;
            }
        }

        public String End
        {
            set
            {
                txtEnd.Text = value;
            }

            get
            {
                return txtEnd.Text;
            }
        }

        public bool Random
        {
            set
            {
                chkRandom.Checked = value;
            }

            get
            {
                return chkRandom.Checked;
            }
        }
        public Range()
        {
            InitializeComponent();
        }

        private void rbRange_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRange.Checked)
            {
                EnableCtrls(true);
                if(CheckState != null)
                {
                    CheckState(this, new ExportEvents.exportControlEventArgs(true));
                }
            }
            else
                EnableCtrls(false);
        }

        private void EnableCtrls(bool state)
        {
            txtEnd.Enabled = state;
            txtStart.Enabled = state;
            chkRandom.Enabled = state;
            lblStart.Enabled = state;
            lblEnd.Enabled = state;
        }

        private void txtStart_TextChanged(object sender, EventArgs e)
        {
            if (ExportStart != null)
                ExportStart(this, new exportControlEventArgs(txtStart.Text));
        }

        private void txtEnd_TextChanged(object sender, EventArgs e)
        {
            if (ExportEnd != null)
                ExportEnd(this, new exportControlEventArgs(txtEnd.Text));
        }

        private void chkRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (ExportRandom != null)
                ExportRandom(this, new exportControlEventArgs(chkRandom.Checked));
        }
    }
}
