using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuildObjects.Enums;
using BuildObjects.MapObjects;
using MockDataGenerator.Enums;
using MockDataGenerator.Interfaces;
using MockDataGenerator.SpecialObjects;
using MockDataGenerator.Utility;
using Thyme.Utilities;

namespace MockDataGenerator.UIServices
{
    public class Mapped
    {
        public static void LoadReferencesToTree(TreeView projectView, MapReferences newRef, ContextMenuStrip mapMenu)
        {
            MapReferences pseudoRef = null;
            if (!FindMap(projectView, newRef.ViableInfo.TheMap.ClassName, out pseudoRef))
            {
                TreeNode aNode = projectView.Nodes[0].Nodes[3].Nodes.Add(NameSpaceManager.RemoveNameSpace(newRef.ViableInfo.TheMap.ClassName));
                aNode.Tag = newRef;
                aNode.ToolTipText = newRef.ViableInfo.TheMap.ClassName;
                aNode.ContextMenuStrip = mapMenu;
                projectView.SelectedNode = aNode;
            }
            else
            {
                projectView.SelectedNode.Tag = newRef;
                projectView.SelectedNode.ToolTipText = newRef.ViableInfo.TheMap.ClassName;
            }
        }

        public static MapReferences LoadMapToTree(TreeView projectView, MapedObject aMap, ContextMenuStrip mapMenu)
        {
            MapReferences newRef = null;            

            if (!FindMap(projectView, aMap.ClassName, out newRef))
            {
                newRef = new MapReferences();
                
                newRef.ViableInfo = new ViableMapAndData();
                newRef.ViableInfo.TheMap = aMap;                
                TreeNode aNode = projectView.Nodes[0].Nodes[3].Nodes.Add(NameSpaceManager.RemoveNameSpace(aMap.ClassName));
                        
                aNode.Tag = newRef;
                aNode.ToolTipText = aMap.ClassName;
                aNode.ContextMenuStrip = mapMenu;
                projectView.SelectedNode = aNode;
            }

            return newRef;    
        }

        public static bool LoadDataTableToMapNode(TreeView projectView, String className, ReturnData data, DataMapType mode)
        {
            MapReferences newRef = null;

            if (!FindMap(projectView, className, out newRef))
            {
               return false;
            }
            Guid anId = Guid.Empty;
            string methodName = mode.ToString();
            if (mode == DataMapType.MethodParameterMap)
            {
                methodName = newRef.LastMethodMap.MethodName;
                anId = newRef.LastMethodMap.ID;
            }
            if (MapManager.FindStoreAndUpdate(newRef.ViableInfo.StoredData, mode, methodName, data.QueryResult, anId))            
            {               
                MapManager.FindSQLAndUpdate(methodName, anId, data.QueryResult.Columns.Count, newRef.ReferenceInfo, data.SQLText);
            }

            return true;
        }


        public static DataTable GetQueryColumnDef(ReturnData data)
        {
            DataTable queryResult = new DataTable();
            queryResult.Columns.Add("ColumnName", typeof(String));
            queryResult.Columns.Add("IsPrimary", typeof(bool));
            queryResult.Columns.Add("AutoInc", typeof(bool));
            queryResult.Columns.Add("AutoIncRate", typeof(int));
            queryResult.Columns.Add("IncStart", typeof(int));
            queryResult.Columns.Add("FieldLength", typeof(int));
            queryResult.Columns.Add("AllowNulls", typeof(bool));
            queryResult.Columns.Add("DataType", typeof(String));
            queryResult.Columns.Add("Precision", typeof(int));
            queryResult.Columns.Add("Scale", typeof(int));
            foreach (DataColumn aColumn in data.QueryResult.Columns)
            {
                queryResult.Rows.Add(new object[] { aColumn.ColumnName, false, aColumn.AutoIncrement, aColumn.AutoIncrementStep, 0, aColumn.MaxLength, aColumn.AllowDBNull, aColumn.DataType.Name, 0, 0 });
            }

            return queryResult;
        }
        public static bool FindMap(TreeView projectView, string className, out MapReferences refInfo)
        {
            bool result = false;
            refInfo = null;

            foreach (TreeNode aNode in projectView.Nodes[0].Nodes[3].Nodes)
            {
                if (aNode.ToolTipText.Trim().Equals(className))
                {
                    refInfo = (MapReferences)aNode.Tag;
                    projectView.SelectedNode = aNode;
                    result = true;
                    break;
                }
            }

            return result;
        }

        public static bool FindMap(TreeView projectView, string className)
        {
            bool result = false;            

            foreach (TreeNode aNode in projectView.Nodes[0].Nodes[3].Nodes)
            {
                if (aNode.ToolTipText.Trim().Equals(className))
                {
                    projectView.SelectedNode = aNode;
                    result = true;
                    break;
                }
            }

            return result;
        }
    }
}
