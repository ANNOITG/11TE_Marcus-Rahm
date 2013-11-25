using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace File_Brower
{
    public partial class Form1 : Form
    {

        LoadFolders loadFolders = new LoadFolders();
        public Form1()
        {
            InitializeComponent();
            LoadFoldersInTreeView(treeView1);
            
        }

        void LoadFoldersInTreeView(TreeView treeName)
        {
            treeName.BeginUpdate();
            treeName.Nodes.Add(@"C:\");

            DirectoryInfo dirInfo = new DirectoryInfo(@"C:\");
            loadFolders.GetSubDirectorysForRoot(treeName, dirInfo);
            

        }
        void GetFiles(DirectoryInfo d, TreeNode node)
        {
            FileInfo[] subfileInfo = d.GetFiles("*.*");
            if (subfileInfo.Length > 0)
            {
                for (int j = 0; j < subfileInfo.Length; j++)
                {
                    node.Nodes.Add(subfileInfo[j].Name);
                    
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            loadFolders.GetSubDirectorys(treeView1);
            treeView1.SelectedNode.Expand();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            loadFolders.GetSubDirectorys(treeView1);
        }
    }
}
