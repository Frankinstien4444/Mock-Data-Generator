using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MockDataGenerator.UIServices
{
    public static class TreeNodeUtilities
    {
        public static void InitializeTreeView(TreeView projectView, ContextMenuStrip mapMenu)
        {
            TreeNode prjNode = projectView.Nodes.Add("Project   ");
            prjNode.NodeFont = new Font("Arial", 11.5f, FontStyle.Bold);
            TreeNode aNode = prjNode.Nodes.Add("Database   ");
            aNode.NodeFont = new Font("Arial", 11.5f, FontStyle.Bold);
            aNode = prjNode.Nodes.Add("Imported Data   ");
            aNode.NodeFont = new Font("Arial", 11.5f, FontStyle.Bold);
            aNode = prjNode.Nodes.Add("Assemblies   ");
            aNode.NodeFont = new Font("Arial", 11.5f, FontStyle.Bold);
            aNode = prjNode.Nodes.Add("Mapped Objects   ");
            aNode.NodeFont = new Font("Arial", 11.5f, FontStyle.Bold);
            aNode.ContextMenuStrip = mapMenu;
            prjNode.Expand();
        }
    }
}
