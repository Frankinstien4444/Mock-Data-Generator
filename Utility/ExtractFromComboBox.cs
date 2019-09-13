using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MockDataGenerator.Utility
{
    public static class BoxUtl
    {
        public static String CboBoxItem(ComboBox cboBox)
        {
            string result = String.Empty;
            if (cboBox.SelectedItem != null)
                result = cboBox.SelectedItem.ToString();
            return result;
        }

        public static String CboBoxValue(ComboBox cboBox)
        {
            string result = String.Empty;
            if (cboBox.SelectedValue != null)
                result = cboBox.SelectedValue.ToString();
            return result;
        }

        public static String ListBoxItem(ListBox lstBox)
        {
            string result = String.Empty;
            if (lstBox.SelectedItem != null)
                result = lstBox.SelectedItem.ToString();

            return result;
        }

        public static String ListBoxValue(ListBox lstBox)
        {
            string result = String.Empty;
            if (lstBox.SelectedValue != null)
                result = lstBox.SelectedValue.ToString();
            return result;
        }
    }
}
