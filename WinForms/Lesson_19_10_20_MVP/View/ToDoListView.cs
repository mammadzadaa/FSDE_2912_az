using Lesson_19_10_20_MVP.Model;
using Lesson_19_10_20_MVP.Presenter;
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
    public partial class ToDoListView : Form, IToDoListView
    {
        public event Action Add;
        public event Action<string> Remove;

        public ToDoListView()
        {
            InitializeComponent();
        }

        public void UpdateList(IEnumerable<ToDo> list)
        {
            elementListBox.Items.Clear();
            elementListBox.Items.AddRange(list.ToArray());
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            var item = elementListBox.SelectedItem;
            if (item != null)
            {
                Remove?.Invoke((item as ToDo).Id);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Add?.Invoke();
        }

        private void elementListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            descriptionTextBox.Text = (elementListBox.SelectedItem as ToDo).Description;
        }
    }
}
