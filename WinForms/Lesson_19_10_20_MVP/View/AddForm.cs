using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_19_10_20_MVP.View
{
    public partial class AddForm : Form,IAddForm
    {
        public AddForm()
        {
            InitializeComponent();
        }

        public string Title => titleTextBox.Text;

        public string Description => descriptionTextBox.Text;

        public event Action Add;

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Add?.Invoke();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
