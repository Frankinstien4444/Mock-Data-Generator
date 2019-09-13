using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MockDataGenerator.Enums;
using MockDataGenerator.Interfaces;
using MockDataGenerator.Utility;
using MockDataGenerator.SpecialObjects;

namespace MockDataGenerator.Controls.InternalLists
{
    public partial class TreeListCtrl : BaseListCtrl
    {
        
        public TreeListCtrl()
        {
            InitializeComponent();
            rangeCtrl.CheckState = ChangeRegexMode;
            regularExpressionCtrl.CheckState = ChangeRangeMode;
            selectionCtrl.Title = "Parent Node Selection";
            selectionCtrl.AllTitle = "Parent Nodes";
        }

        public override void LoadControl()
        {
            using (loadedSource)
            {
                using (StreamReader readFile = new StreamReader(loadedSource))
                {
                    if (SourceType == DataResources.Industry_Sectors)
                        ReadIndustry(readFile);
                    else if (SourceType == DataResources.US_Cities)
                        ReadUSCities(readFile);
                }
            }
            treeView.Nodes[0].Expand();
        }

        public void ChangeRegexMode(Object sender, ExportEvents.exportControlEventArgs e)
        {
            bool result = (bool)e.getData;
            regularExpressionCtrl.CheckRegexButton(!result);
        }

        public void ChangeRangeMode(Object sender, ExportEvents.exportControlEventArgs e)
        {
            bool result = (bool)e.getData;
            rangeCtrl.CheckRangeButton(!result);
        }

        public void Clear()
        {
            treeView.Nodes[0].Nodes.Clear();
            selectionCtrl.Clear();
        }
        private void ReadUSCities(StreamReader readFile)
        {
            Clear();
            TreeNode stateNode = null;
            while (!readFile.EndOfStream)
            {
                string[] aNode = readFile.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                string state = aNode[1].Trim();
                string city = aNode[0].Trim();
                if (!FindStateNode(state, stateNode))
                {
                    stateNode = new TreeNode(state);
                    treeView.Nodes.Add(stateNode);
                    //selectionCtrl.AddItem(state);
                }
                stateNode.Nodes.Add(city);
            }
        }

        private bool FindStateNode(string state, TreeNode stateNode)
        {
            bool result = false;
            foreach(TreeNode aState in treeView.Nodes)
            {
                if(aState.Text.Equals(state))
                {
                    stateNode = aState;
                    result = true;
                    break;
                }
            }

            return result;
        }
        private void ReadIndustry(StreamReader readFile)
        {
            Clear();
            TreeNode industryNode = null;
            while (!readFile.EndOfStream)
            {
                string aNode = readFile.ReadLine();
                if (aNode.Contains("##"))
                {
                    industryNode = treeView.Nodes[0].Nodes.Add(aNode.Replace("##", ""));
                    industryNode.Tag = "parent";
                    //selectionCtrl.AddItem(industryNode.Text);
                }
                else
                    industryNode.Nodes.Add(aNode);
            }
        }

        public override void EditRule(IDataRule aRule)
        {
            base.EditRule(aRule);
            MultiFieldDataSourceRule iRule = (MultiFieldDataSourceRule)aRule;
            LoadFile(iRule.TypeofInternalSource);
            SourceType = iRule.TypeofInternalSource;
            //rangeCtrl.Start = iRule.RangeStart;
            //rangeCtrl.End = iRule.RangeEnd;
            rangeCtrl.Random = iRule.IsRandom;
            selectionCtrl.EditRule(iRule.SearchFields, iRule.FieldColumnMap);            
            //regularExpressionCtrl.RegularExpression = iRule.RegularExpression;
            //selectionCtrl.SelectItems(iRule.Selected.ToArray());
            txtMaxRecords.Text = iRule.MaxRecords.ToString();
        }

        public override bool ApplyDataToRuleSet()
        {
            bool valid = true;
            Properties.Random = rangeCtrl.Random;
            Properties.GeneralType = FieldTypes.MultiColumn;
            InitializeCommonRule();
            try
            {
                BuildRules.Buildrule((MultiFieldDataSourceRule)Properties.Result, SourceType, int.Parse(txtMaxRecords.Text), selectionCtrl.SearchFields, selectionCtrl.DataFields, ListCtrlType.TreeView);
            }
            catch (Exception e)
            {
                valid = ErrorMessage(e);
            }

            return valid;
        }
    }
}
