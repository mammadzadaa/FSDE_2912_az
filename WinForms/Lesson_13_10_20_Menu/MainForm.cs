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

namespace Lesson_13_10_20_Menu
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var dialog = new ColorDialog();
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                richTextBox1.SelectionColor = dialog.Color;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var dialog = new ColorDialog();
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                richTextBox1.SelectionBackColor = dialog.Color;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            var dialog = new FontDialog();
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                richTextBox1.SelectionFont = dialog.Font;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "RTF | *.rtf";
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                File.WriteAllText(dialog.FileName, richTextBox1.Rtf);
            }
        }
    }
}
