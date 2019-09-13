using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace AtlasWorkFlow.Search
{
    [ToolboxBitmap(typeof(SearchBar)),
    TypeConverter(typeof(SearchBar))]
    public partial class SearchBar : UserControl
    {
        private Control searchobject = null;
        private String CriteriaString = "";
        public ExportEvents.exportControlEventHandler SearchUsingExternalSource { get; set; }
        public EventHandler ActOnSelection { get; set; }
        public TreeNodeMouseClickEventHandler ActOnTreeNodeSelection { get; set; }
        public DataGridViewCellEventHandler ActOnCellSelection { get; set; }
        private delegate void InvokeListViewSearch(ListView obj);
        private delegate void InvokeListBoxSearch(ListBox obj);
        private delegate bool InvokeTreeSearch(TreeNode obj);
        private delegate void InvokeGridSearch(DataGridView obj);

        [CategoryAttribute("Images")]
        public Image RightLabel
        {
            set
            {
                RightLabelPic.Image = value;
            }
            get
            {
                return RightLabelPic.Image;
            }
        }

        [CategoryAttribute("Common Properties")]
        public Control SearchableObject
        {
            set
            {
                searchobject = value;
            }
            get
            {
                return searchobject;
            }
        }


        public SearchBar()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            Thread thrd = new Thread(searchNow);
            thrd.Start();

        }

        private void searchText_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Thread thrd = new Thread(searchNow);
                thrd.Start();
            }
        }

        private void searchNow()
        {
            CriteriaString = toolNotesSearchText.Text.ToLower();

            switch (searchobject.GetType().Name)
            {
                case "ListView":
                    InvokeListViewSearch isd = new InvokeListViewSearch(searchView);
                    ListView lstView = (ListView)searchobject;
                    lstView.Invoke(isd, new Object[] { lstView });
                    //searchView();
                    break;

                case "TreeView":
                    TreeView aTree = (TreeView)SearchableObject;
                    InvokeTreeSearch intrs = new InvokeTreeSearch(searchTree);
                    SendMessage((bool)aTree.Invoke(intrs, new Object[] { aTree.Nodes[0] }));
                    break;

                case "CheckedListBox":
                case "ListBox":

                    InvokeListBoxSearch invlst = new InvokeListBoxSearch(searchListbox);
                    ListBox lstBox = (ListBox)SearchableObject;
                    lstBox.Invoke(invlst, new Object[] { lstBox });
                    break;

                case "DataGrid":
                    DataGridView dg = (DataGridView)searchobject;
                    InvokeGridSearch ingsrch = new InvokeGridSearch(searchDatagrid);
                    dg.Invoke(ingsrch, new Object[] { dg }); ;
                    break;
            }
        }

        private void searchView(ListView lstView)
        {
            lstView.SelectedItems.Clear();
            lstView.Focus();
            int lastPosition = 0;
            if (lstView.Tag != null)
                lastPosition = Convert.ToInt32(lstView.Tag) + 1;

            if (lastPosition >= lstView.Items.Count)
                lastPosition = 0;

            for (int i=lastPosition;i<lstView.Items.Count; i++)
            {
                ListViewItem lstvi = lstView.Items[i];
                foreach (ListViewItem.ListViewSubItem lstvsubi in lstvi.SubItems)
                {
                    if (lstvsubi.Text.ToLower().Contains(CriteriaString))
                    {
                        lstvi.Selected = true;
                        lstvi.Focused = true;                        
                        lstView.Tag = i;
                        if (ActOnSelection != null)
                            ActOnSelection(lstView, new EventArgs());
                        break;
                    }
                }
                if (lstvi.Selected)
                    break;
            }
            if (lstView.SelectedItems.Count == 0)
                SendMessage(false);
        }

        private bool searchTree(TreeNode aNode)
        {
            bool test = false;
            if (aNode.Text.ToLower().Contains(CriteriaString))
            {
                aNode.TreeView.SelectedNode = aNode;
                if (ActOnTreeNodeSelection != null)
                    ActOnTreeNodeSelection(this, new TreeNodeMouseClickEventArgs(aNode, System.Windows.Forms.MouseButtons.Left, 1, 0,0));
                test = true;
            }
            else if (aNode.Nodes.Count > 0)
                test = searchTree(aNode.Nodes[0]);
            if (!test && aNode.NextNode != null)
                test = searchTree(aNode.NextNode);

            return test;
        }

        private void searchListbox(ListBox lstBox)
        {

            bool test = false;
            for (int i = 0; i < lstBox.Items.Count; i++)
                if (lstBox.Items[i].ToString().ToLower().Contains(CriteriaString))
                {
                    lstBox.SelectedItem = lstBox.Items[i];
                    if (ActOnSelection != null)
                        ActOnSelection(lstBox, new EventArgs());
                    test = true;
                    break;
                }
            SendMessage(test);
        }

        private void searchDatagrid(DataGridView dg)
        {

            bool test = false;
            foreach (DataGridViewRow oRow in dg.Rows)
            {
                foreach (DataGridViewCell oCell in oRow.Cells)
                {
                    if (oCell.Value.ToString().ToLower().Contains(CriteriaString))
                    {
                        dg.CurrentCell = oCell;
                        test = true;
                        if (ActOnCellSelection != null)
                            ActOnCellSelection(this, new DataGridViewCellEventArgs(oCell.ColumnIndex, oCell.RowIndex));
                        break;
                    }
                }
                if (test)
                    break;
            }

            SendMessage(test);
        }

        private void SendMessage(bool test)
        {
            if (!test)
                MessageBox.Show(toolNotesSearchText.Text + " Not found.");
        }
    }
}
