using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_12_10_20_Containers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser1.Url = new Uri(linkTextBox.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(linkTextBox.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox1.Visible)
            {
                listBox1.Visible = false;
            }
            else
            {
                listBox1.Visible = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage("New Tab");
            tabControl1.TabPages.Add(tab);
        }
    }
}
