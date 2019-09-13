using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MockDataGenerator.SpecialObjects;

namespace MockDataGenerator.UIServices
{
    public static class AssemblyUtilities
    {
        public static void AddAssembly(TreeView projectView, OpenFileDialog dlgOpenAssembly, ContextMenuStrip menu)
        {
            try
            {
                if (dlgOpenAssembly.ShowDialog() == DialogResult.OK)
                {
                    Assembly loadedAssm = Assembly.LoadFrom(dlgOpenAssembly.FileName);
                    AssemblyDescriptor aDescriptor = new AssemblyDescriptor();
                    aDescriptor.Assembly = loadedAssm;
                    aDescriptor.Enums = loadedAssm.GetTypes().Where(x => x.IsEnum);
                    aDescriptor.AbstractClasses = loadedAssm.GetTypes().Where(x => x.IsAbstract);
                    aDescriptor.Interfaces = loadedAssm.GetTypes().Where(x => x.IsInterface);
                    TreeNode aNode = projectView.Nodes[0].Nodes[2].Nodes.Add(System.IO.Path.GetFileName(dlgOpenAssembly.FileName));
                    aNode.ToolTipText = dlgOpenAssembly.FileName;
                    aNode.Tag = aDescriptor;
                    aNode.ContextMenuStrip = menu;
                    projectView.SelectedNode = aNode;
                }
            }
            catch
            {
                MessageBox.Show("Unable to load assembly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void LoadAssemblyToList(Assembly sampleAssembly, ListView lstVwAssemblies)
        {
            if (sampleAssembly == null) return;
            lstVwAssemblies.Items.Clear();
            foreach (Type anObject in sampleAssembly.GetTypes())
            {
                ListViewItem lstItem = new ListViewItem(new string[] { Acessibility(anObject), AssemblyType(anObject), anObject.FullName });
                lstItem.Tag = anObject;
                lstVwAssemblies.Items.Add(lstItem);                
            }
        }

        private static string Acessibility(Type checkType)
        {
            string result = "public";
            if (checkType.IsSealed)
                result = "sealed";
            else if (checkType.IsNotPublic)
                result = "private";

            return result;
        }
        private static String AssemblyType(Type checkType)
        {
            string result = "Class";
            if (checkType.IsInterface)
                result = "Interface";
            else if (checkType.IsAbstract)
                result = "Abstract";

            return result;
        }
    }
}
