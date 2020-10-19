using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_15_10_20_TreeView
{
    public partial class ExplorerForm : Form
    {
        public ExplorerForm()
        {
            InitializeComponent();

            var directories = Directory.GetDirectories(@"C:\");
            foreach (var dir in directories)
            {
                try
                {
                    var node = folderTreeView.Nodes.Add(Path.GetFileName(dir));
                    node.Tag = dir;
                    var subdirectories = Directory.GetDirectories(dir);
                    foreach (var subdir in subdirectories)
                    {
                        var temp = node.Nodes.Add(Path.GetFileName(subdir));
                        temp.Tag = subdir;
                    }
                }
                catch (UnauthorizedAccessException){}              
            }
        }

        private void folderTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            foreach (var node in e.Node.Nodes)
            {
                var selectecNode = node as TreeNode;
                if (selectecNode.Nodes.Count == 0)
                {
                    try
                    {
                        var subdirs = Directory.GetDirectories(selectecNode.Tag as string);
                        //selectecNode.Nodes.Clear();
                        foreach (var sub in subdirs)
                        {
                            var temp = selectecNode.Nodes.Add(Path.GetFileName(sub));
                            temp.Tag = sub;
                        }
                    }
                    catch (UnauthorizedAccessException){}                   
                }
                
            } 
        }

        private void folderTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var fullPath = e.Node.Tag as string;
            pathTextBox.Text = fullPath;
            try
            {
                var count = Directory.GetFiles(fullPath).Length;
                fileCountToolStripStatusLabel.Text = $"Files: {count}";

                elementsListView.Items.Clear();
                var allFiles = Directory.GetFiles(fullPath);
                var group = new ListViewGroup("Some Group");
                elementsListView.Groups.Add(group);
                foreach (var file in allFiles)
                {
                    var item = new ListViewItem(file);
                    item.ImageIndex = 0;
                    item.Group = group;
                    elementsListView.Items.Add(item);
                }
            }
            catch (UnauthorizedAccessException) { }

        }

        private void elementsListView_ItemActivate(object sender, EventArgs e)
        {
            var path = elementsListView.SelectedItems[0].Text;
            if (Path.HasExtension(path))
            {
                Process.Start(path);
            }
        }
    }
}
