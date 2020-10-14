using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_14_10_20_GDI
{
    public partial class Some : Form
    {
        public Some()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new InnerForm();
            form.MdiParent = this;

            form.Show();
        }
    }
}
