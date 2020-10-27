using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernUI
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(   this,"Hello","MB",MessageBoxButtons.YesNoCancel,
                                    MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
            
        }
    }
}
