using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversalDataBase;
using UniversalDataBase.AutomatedSQL;
using UniversalDataBase.DatabaseManager;
using UniversalDataBase.Enums;
using UniversalDataBase.Utilities;

namespace MockDataGenerator.UIServices
{
    public static class DatabaseUtilities
    {
        
        public static void LoadDatabase(TreeView projectView, ref DataBaseObjectClass aDataObject, ListView lstVwDatabaseTables)
        {
            DataBaseSelection openDatabase = new DataBaseSelection();
            openDatabase.IntitialFolderPath = Application.StartupPath;
            if (openDatabase.ShowDialog() == DialogResult.OK)
            {
                projectView.Nodes[0].Nodes[0].Nodes.Clear();
                DataLogin dataLogin = openDatabase.Connection;
                aDataObject = new DataBaseObjectClass(dataLogin.FromDatabase.DataBaseType);
                aDataObject.Connection(dataLogin.FromDatabase.ServerFile, dataLogin.FromDatabase.DatabaseName, dataLogin.FromDatabase.UserID, dataLogin.FromDatabase.Password, dataLogin.FromDatabase.Integrated);
                DataTable dt = aDataObject.GetSchemaData(SchemaRestrictions.Tables, null);
                lstVwDatabaseTables.Items.Clear();
                if (dt != null)
                {

                    foreach (DataRow aRow in dt.Rows)
                    {
                        lstVwDatabaseTables.Items.Add(aRow["TABLE_NAME"].ToString());
                    }
                    projectView.Nodes[0].Nodes[0].Nodes.Add("Server: " + dataLogin.FromDatabase.ServerFile);
                    projectView.Nodes[0].Nodes[0].Nodes.Add("Database Name: " + dataLogin.FromDatabase.DatabaseName);
                }
                else
                    MessageBox.Show("Restriction not valid");
            }
        }

        public static void LoadToSQLEditor(CheckedListBox chckList, SchemaRestrictions restriction, String tableName, String extractField, DataBaseObjectClass aDataObject)
        {
            DataTable dt = aDataObject.GetSchemaData(restriction, tableName);
            chckList.Items.Clear();
            if (dt != null)
            {

                foreach (DataRow aRow in dt.Rows)
                {
                    chckList.Items.Add(aRow[extractField].ToString());
                }
            }
            else
                MessageBox.Show("Restriction not valid");
        }

        public static List<String> LoadToList(SchemaRestrictions restriction, String tableName, String extractField, DataBaseObjectClass aDataObject)
        {
            List<String> result = new List<string>();
            DataTable dt = aDataObject.GetSchemaData(restriction, tableName);

            if (dt != null)
            {

                foreach (DataRow aRow in dt.Rows)
                {
                    result.Add(aRow[extractField].ToString());
                }
            }
            else
                MessageBox.Show("Restriction not valid");

            return result;
        }

        public static List<String> LoadToList(String strSql, String extractField, DataBaseObjectClass aDataObject)
        {
            List<String> result = new List<string>();
            DataTable dt = aDataObject.DoSelect(strSql);
           
            if (dt != null)
            {

                foreach (DataRow aRow in dt.Rows)
                {
                    result.Add(aRow[extractField].ToString());
                }
            }
            else
                MessageBox.Show("Restriction not valid");

            return result;
        }

        public static List<ForeignKey> LoadToList(String strSql, DataBaseObjectClass aDataObject)
        {
            string[] fields = new string[] { "Referencing Column", "Referenced Column", "Referenced Table" };
            List<ForeignKey> result = new List<ForeignKey>();
            DataTable dt = aDataObject.DoSelect(strSql);

            if (dt != null)
            {

                foreach (DataRow aRow in dt.Rows)
                {
                    result.Add(new ForeignKey(aRow[fields[0]].ToString(), aRow[fields[1]].ToString(), aRow[fields[2]].ToString()));
                }
            }
            else
                MessageBox.Show("Restriction not valid");

            return result;
        }

        public static List<String> LoadConstraintsToList(String strSql, String extractField, DataBaseObjectClass aDataObject)
        {
            List<String> result = new List<string>();
            DataTable dt = aDataObject.DoSelect(strSql);
            foreach(Constraint aConst in dt.Constraints)
            {
                
            }
            if (dt != null)
            {

                foreach (DataRow aRow in dt.Rows)
                {
                    result.Add(aRow[extractField].ToString());
                }
            }
            else
                MessageBox.Show("Restriction not valid");

            return result;
        }

        public static void LoadToSQLEditor(ComboBox chckList, SchemaRestrictions restriction, String extractField, DataBaseObjectClass aDataObject)
        {
            DataTable dt = aDataObject.GetSchemaData(restriction, null);
            chckList.Items.Clear();
            if (dt != null)
            {

                foreach (DataRow aRow in dt.Rows)
                {
                    chckList.Items.Add(aRow[extractField].ToString());
                }
            }
            else
                MessageBox.Show("Restriction not valid");
        }
    }
}
