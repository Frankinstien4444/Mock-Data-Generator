using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MockDataGenerator.UIServices
{
    public static class ListObjectDetails
    {
        public static void LoadFields(Type selectedType, ListView lstVwObjectView)
        {
            lstVwObjectView.MultiSelect = true;
            lstVwObjectView.CheckBoxes = true;
            lstVwObjectView.Columns.Clear();
            ColumnHeader lstHeader = new ColumnHeader();
            lstHeader.Width = 150;
            lstHeader.Text = "Field Name";
            lstVwObjectView.Columns.Add(lstHeader);
            lstHeader = new ColumnHeader();
            lstHeader.Width = 150;
            lstHeader.Text = "Type";
            lstVwObjectView.Columns.Add(lstHeader);
            foreach (FieldInfo field in selectedType.GetFields())
            {
                ListViewItem lstItem = new ListViewItem(new string[] { field.Name, field.FieldType.Name });
                lstVwObjectView.Items.Add(lstItem);
            }
        }

        public static void LoadProperties(Type selectedType, ListView lstVwObjectView)
        {
            lstVwObjectView.MultiSelect = true;
            lstVwObjectView.CheckBoxes = true;
            lstVwObjectView.Columns.Clear();
            ColumnHeader lstHeader = new ColumnHeader();
            lstHeader.Width = 150;
            lstHeader.Text = "Field Name";
            lstVwObjectView.Columns.Add(lstHeader);
            lstHeader = new ColumnHeader();
            lstHeader.Width = 150;
            lstHeader.Text = "Type";
            lstVwObjectView.Columns.Add(lstHeader);
            foreach (PropertyInfo prop in selectedType.GetProperties())
            {
                ListViewItem lstItem = new ListViewItem(new string[] { prop.Name, prop.PropertyType.Name });
                lstVwObjectView.Items.Add(lstItem);
            }
        }

        public static void LoadMethods(Type selectedType, ListView lstVwObjectView)
        {
            lstVwObjectView.MultiSelect = false;
            lstVwObjectView.CheckBoxes = false;
            lstVwObjectView.Columns.Clear();
            ColumnHeader lstHeader = new ColumnHeader();
            lstHeader.Width = 150;
            lstHeader.Text = "Method Name";
            lstVwObjectView.Columns.Add(lstHeader);
            lstHeader = new ColumnHeader();
            lstHeader.Width = 100;
            lstHeader.Text = "Return Type";
            lstVwObjectView.Columns.Add(lstHeader);
            lstHeader = new ColumnHeader();
            lstHeader.Width = 1000;
            lstHeader.Text = "Parameters";
            lstVwObjectView.Columns.Add(lstHeader);
            foreach (MethodInfo method in selectedType.GetMethods())
            {
                List<String> parameters = method.GetParameters().Select(x => x.ParameterType.Name + " " + x.Name + ", ").ToList();
                List<String> description = new List<string>();
                description.Add(method.Name);
                description.Add(method.ReturnType.Name);
                if (parameters.Count > 0)
                    description.Add(string.Concat(parameters.ToArray()));
                else
                    description.Add("NA");
                ListViewItem lstItem = new ListViewItem(description.ToArray());
                lstVwObjectView.Items.Add(lstItem);
            }
        }

        public static void LoadConstuctors(Type selectedType, ListView lstVwObjectView)
        {
            lstVwObjectView.Columns.Clear();
            ColumnHeader lstHeader = new ColumnHeader();
            lstHeader.Width = 150;
            lstHeader.Text = "Method Name";
            lstVwObjectView.Columns.Add(lstHeader);
            lstHeader = new ColumnHeader();
            lstHeader.Width = 1000;
            lstHeader.Text = "Parameters";
            lstVwObjectView.Columns.Add(lstHeader);
            foreach (ConstructorInfo aConstructor in selectedType.GetConstructors())
            {
                List<String> parameters = aConstructor.GetParameters().Select(x => x.ParameterType.Name + " " + x.Name + ", ").ToList();
                List<String> description = new List<string>();
                description.Add(aConstructor.Name);
                if (parameters.Count > 0)
                    description.Add(string.Concat(parameters.ToArray()));
                else
                    description.Add("NA");
                ListViewItem lstItem = new ListViewItem(description.ToArray());                 
                lstVwObjectView.Items.Add(lstItem);
            }
        }
    }
}
