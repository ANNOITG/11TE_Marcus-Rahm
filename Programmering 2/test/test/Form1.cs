using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public string copyPath = "";
        public string copyFileName = "";
        public bool copyIsDirectory = false;
        public Form1()
        {
            InitializeComponent();
            FillListView();
            
        }
        private void FillListView()
        {
            //load in the directory info
            DirectoryInfo info = new DirectoryInfo(@"C:\");
            listView.Items.Clear();
            ListViewItem.ListViewSubItem[] subItem;
            ListViewItem item = null;


            foreach(DirectoryInfo dir in info.GetDirectories())
            {
                //add listview items and its subitem info
                item = new ListViewItem(dir.Name, 0);
                subItem = new ListViewItem.ListViewSubItem[]
                {
                    new ListViewItem.ListViewSubItem(item, "Directory"), 
                    new ListViewItem.ListViewSubItem(item, dir.LastAccessTime.ToShortTimeString()),
                    new ListViewItem.ListViewSubItem(item, dir.FullName)
                };
                item.SubItems.AddRange(subItem);
                listView.Items.Add(item);
            }
            foreach (FileInfo file in info.GetFiles())
            {
                //get the items in the direcory and add the item and the subitem info
                item = new ListViewItem(file.Name, 1);
                subItem = new ListViewItem.ListViewSubItem[]
                {
                    new ListViewItem.ListViewSubItem(item, "File"),
                    new ListViewItem.ListViewSubItem(item, file.LastAccessTime.ToShortTimeString()),
                    new ListViewItem.ListViewSubItem(item, file.FullName)
                };

                item.SubItems.AddRange(subItem);
                listView.Items.Add(item);

            }

            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }

        private void refreshListView()
        {
            //get the directory and the parent directory
            ListViewItem item;
            ListViewItem.ListViewSubItem[] subItem;
            DirectoryInfo nodeDirInfo = new DirectoryInfo(listView.SelectedItems[0].SubItems[3].Text);
            nodeDirInfo = nodeDirInfo.Parent;
            nodeDirInfo.Refresh();
            listView.Items.Clear();
            try
            {
                // add the go back arrow
                item = new ListViewItem("Go back", 2);
                subItem = new ListViewItem.ListViewSubItem[]
                {
                    new ListViewItem.ListViewSubItem(item, ".."),
                    new ListViewItem.ListViewSubItem(item, ""),
                    new ListViewItem.ListViewSubItem(item, nodeDirInfo.Parent.FullName)
                };
                item.SubItems.AddRange(subItem);
                listView.Items.Add(item);
            }
            catch
            {
                int i = 1;
            }
            item = null;

            foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
            {
                //make sure that all diretorys that contains My wont load becouse 
                //they point to a diffrent directory and fail to load
                if (dir.Name.Contains("My"))
                {
                }
                else
                {
                    item = new ListViewItem(dir.Name, 0);
                    subItem = new ListViewItem.ListViewSubItem[]
                {
                    //add the sub directorys
                    new ListViewItem.ListViewSubItem(item, "Directory"), 
                    new ListViewItem.ListViewSubItem(item, dir.LastAccessTime.ToShortTimeString()),
                    new ListViewItem.ListViewSubItem(item, dir.FullName)
                };
                    item.SubItems.AddRange(subItem);
                    listView.Items.Add(item);
                }
            }
            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                // adds the files for the directory
                item = new ListViewItem(file.Name, "File");
                subItem = new ListViewItem.ListViewSubItem[]
                {
                    new ListViewItem.ListViewSubItem(item, "File"),
                    new ListViewItem.ListViewSubItem(item, file.LastAccessTime.ToShortTimeString()),
                    new ListViewItem.ListViewSubItem(item, file.FullName)
                };

                item.SubItems.AddRange(subItem);
                listView.Items.Add(item);

            }

            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listView_DoubleClick(object sender, EventArgs e)
        {
            // load the selected directory and its subitems 
            ListViewItem item;
            ListViewItem.ListViewSubItem[] subItem;
            DirectoryInfo nodeDirInfo = new DirectoryInfo(listView.SelectedItems[0].SubItems[3].Text);
            nodeDirInfo.Refresh();
            listView.Items.Clear();
            try
            {
                //adds the go back arrow
                item = new ListViewItem("Go back", 2);
                subItem = new ListViewItem.ListViewSubItem[]
                {
                    new ListViewItem.ListViewSubItem(item, ".."),
                    new ListViewItem.ListViewSubItem(item, ""),
                    new ListViewItem.ListViewSubItem(item, nodeDirInfo.Parent.FullName)
                };
                item.SubItems.AddRange(subItem);
                listView.Items.Add(item);
            }
            catch
            {
                int i = 1;
            }
                item = null;
                
                foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
                {
                    if (dir.Name.Contains("My"))
                    {
                    }
                    else
                    {
                        item = new ListViewItem(dir.Name, 0);
                        subItem = new ListViewItem.ListViewSubItem[]
                {
                    //adds sub directorys
                    new ListViewItem.ListViewSubItem(item, "Directory"), 
                    new ListViewItem.ListViewSubItem(item, dir.LastAccessTime.ToShortTimeString()),
                    new ListViewItem.ListViewSubItem(item, dir.FullName)
                };
                        item.SubItems.AddRange(subItem);
                        listView.Items.Add(item);
                    }
                }
                foreach (FileInfo file in nodeDirInfo.GetFiles())
                {
                    //adds the sub files
                    item = new ListViewItem(file.Name, "File");
                    subItem = new ListViewItem.ListViewSubItem[]
                {
                    new ListViewItem.ListViewSubItem(item, "File"),
                    new ListViewItem.ListViewSubItem(item, file.LastAccessTime.ToShortTimeString()),
                    new ListViewItem.ListViewSubItem(item, file.FullName)
                };

                    item.SubItems.AddRange(subItem);
                    listView.Items.Add(item);

                }
            
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listView_MouseClick(object sender, MouseEventArgs e)
        {
            //opens the contextmenustrip for the cut and paste
            if (e.Button == MouseButtons.Right)
            {
                if (listView.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    if (listView.FocusedItem.SubItems[1].Text == "File")
                    {
                        
                            contextMenuStrip1.Show(Cursor.Position);
                        
                    }
                    else if (listView.FocusedItem.SubItems[1].Text == "Directory")
                    {
                        
                            contextMenuStrip1.Show(Cursor.Position);
                    }

                }
            } 
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //copy and cuts the item
            if (e.ClickedItem.Name == "copyItem")
            {
                if(listView.FocusedItem.SubItems[1].Text == "Directory")
                {
                    MessageBox.Show("you can't cut out a directory try a file");
                }
                else
                {
                copyPath = listView.FocusedItem.SubItems[3].Text;
                copyFileName = listView.FocusedItem.Text;
                }
            }
                //pastes the items in its new location
            else if (e.ClickedItem.Name == "pasteItem")
            {
                if (listView.FocusedItem.SubItems[1].Text == "Directory")
                {
                    string aPath = listView.FocusedItem.SubItems[3].Text + @"\" + copyFileName;
                    MoveItem(aPath);
                }
                else if (listView.FocusedItem.SubItems[1].Text == "File")
                {

                    FileInfo a = new FileInfo(listView.FocusedItem.SubItems[3].Text);
                    string aPath = a.DirectoryName + @"\" + copyFileName;
                    MoveItem(aPath);
                }
            }
        }
        private void MoveItem(string secondPath)
        {

            try
            {
                if (!File.Exists(secondPath))
                {
                    // This statement ensures that the file is created, 
                    // but the handle is not kept. 
                    using (FileStream fs = File.Create(secondPath)) { }
                }

                // Ensure that the target does not exist. 
                if (File.Exists(secondPath))
                    File.Delete(secondPath);

                // Move the file.
                File.Move(copyPath, secondPath);
                MessageBox.Show(copyPath + "was moved to" + secondPath);

                // See if the original exists now. 
                if (File.Exists(copyPath))
                {

                    MessageBox.Show("The original file still exists, which is unexpected.");
                }
                else
                {
                    MessageBox.Show("The original file no longer exists, which is expected.");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("The process failed: " + e.ToString());
            }
            //refreshes the listview
            refreshListView();
        }

        
        


        }
    }

