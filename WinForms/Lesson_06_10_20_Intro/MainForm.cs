using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_06_10_20_Intro
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Console.Beep(1000, 500);
                this.Text = $"X:{e.X} Y:{e.Y}";
            }
            else if (e.Button == MouseButtons.Right)
            {
                var result = MessageBox.Show("Some text inside MS Box", "My MS box"
                                ,MessageBoxButtons.YesNoCancel,MessageBoxIcon.Error);

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("YES been selected");
                }
            }
        }

       

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            Text = $"X:{e.X} Y:{e.Y}";
        }

    }
}
