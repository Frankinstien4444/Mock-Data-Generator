using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MockDataGenerator.Utility
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://radmonster.com/purchase-mockdata-generator");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
