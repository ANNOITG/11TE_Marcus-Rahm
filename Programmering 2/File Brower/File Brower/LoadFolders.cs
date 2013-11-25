using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Brower
{
    class LoadFolders
    {
        public void GetSubDirectorys(TreeView treeView)
        {
            DirectoryInfo DirInfo = new DirectoryInfo(treeView.SelectedNode.FullPath);
            GetFolders(DirInfo, treeView);
        }
        public void GetSubDirectorysForRoot(TreeView treeView, DirectoryInfo DirInfo)
        {
            DirectoryInfo[] dInfo = DirInfo.GetDirectories();
            if (dInfo.Length > 0)
            {
                foreach (DirectoryInfo dirSub in dInfo)
                {

                        try
                        {
                            if (treeView.Nodes[0].Nodes.ContainsKey(dirSub.Name))
                            {
                                treeView.Nodes[0].Nodes.RemoveByKey(dirSub.Name);
                                treeView.Nodes[0].Nodes.Add(dirSub.Name).Name = dirSub.Name;
                            }
                            else
                            {
                                treeView.Nodes[0].Nodes.Add(dirSub.Name).Name = dirSub.Name;
                            }
                        }
                        catch
                        {
                            int i = 0;
                        }
                }
            }
        }
        void GetFolders(DirectoryInfo d, TreeView treeView)
        {
            try
            {
                DirectoryInfo[] dInfo = d.GetDirectories();
                if (dInfo.Length > 0)
                {
                    foreach (DirectoryInfo dirSub in dInfo)
                    {
                        
                        
                            try
                            {
                                if (treeView.SelectedNode.Nodes.ContainsKey(dirSub.Name))
                                {
                                    treeView.SelectedNode.Nodes.RemoveByKey(dirSub.Name);
                                    treeView.SelectedNode.Nodes.Add(dirSub.Name).Name = dirSub.Name;
                                }
                                else
                                {
                                    treeView.SelectedNode.Nodes.Add(dirSub.Name).Name = dirSub.Name;
                                }
                                
                            }
                            catch
                            {
                                int i = 0;
                            }
                        
                    }
                }
            }
            catch
            {
                int i = 0;
            }
            

        }
    }
}
