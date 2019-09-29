using Bookmarks.Components;
using Bookmarks.ConcreteComponents;
using Bookmarks.Custom;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bookmarks
{
    public partial class FrmBookmark : Form
    {
        public FrmBookmark()
        {
            InitializeComponent();
        }

        private Dictionary<int, Component> _rootComponents = new Dictionary<int, Component>();
        private int _currentComponentId = 0;
        

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            FrmAddFolder frmAddFolder = new FrmAddFolder()
                        .SetFormBookmark(this);
            frmAddFolder.ShowDialog();
        }

        public void AddFolder(string folderName)
        {
            TreeNode selectedNode = tvBookmark.SelectedNode;
            Component component = new Folder(_currentComponentId, folderName);
            CustomTreeNode treeNode = new CustomTreeNode(component);
            if (selectedNode == null)
            {
                tvBookmark.Nodes.Add(treeNode);
                _rootComponents[_currentComponentId] = component;
            }
            else
            {
                Component parentComponent = ((CustomTreeNode)selectedNode).Component;
                parentComponent?.Add(component);
                selectedNode.Nodes.Add(treeNode);
            }
            _currentComponentId++;
        }

        public void AddPage(string pageName, string link)
        {
            TreeNode selectedNode = tvBookmark.SelectedNode;
            Component component = new Page(_currentComponentId, pageName, link);
            CustomTreeNode treeNode = new CustomTreeNode(component);
            if (selectedNode == null)
            {
                tvBookmark.Nodes.Add(treeNode);
                _rootComponents[_currentComponentId] = component;
            }
            else
            {
                Component parentComponent = ((CustomTreeNode)selectedNode).Component;
                parentComponent?.Add(component);
                selectedNode.Nodes.Add(treeNode);
            }
            _currentComponentId++;
        }

        private void tvBookmark_MouseDown(object sender, MouseEventArgs e)
        {
            TreeView treeView = sender as TreeView;
            var hit = treeView.HitTest(e.X, e.Y);

            if (hit.Node == null)
            {
                btnAddPage.Enabled = btnAddFolder.Enabled = true;
                treeView.SelectedNode = null;
                btnRemove.Enabled = false;
            }
            else
            {
                CustomTreeNode treeNode = hit.Node as CustomTreeNode;
                btnAddPage.Enabled = btnAddFolder.Enabled = (!treeNode?.Component?.IsPage()).Value;
                btnRemove.Enabled = true;
            }
        }

        private void btnAddPage_Click(object sender, EventArgs e)
        {
            FrmAddPage frmAddPage = new FrmAddPage()
                        .SetFormBookmark(this);
            frmAddPage.ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = tvBookmark.SelectedNode;
            if (selectedNode != null)
                tvBookmark.Nodes.Remove(selectedNode);
        }
    }
}
