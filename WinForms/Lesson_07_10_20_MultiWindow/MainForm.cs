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
using Newtonsoft.Json;

namespace Lesson_07_10_20_MultiWindow
{
    public partial class MainForm : Form
    {
        private List<Person> people;
        public MainForm()
        {
            InitializeComponent();
            people = JsonConvert.DeserializeObject<List<Person>>(File.ReadAllText("data.json"));
            peopleListBox.Items.AddRange(people.ToArray());
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            if (peopleListBox.SelectedItem is Person person)
            {
                var viewForm = new ViewForm(person);
                viewForm.ShowDialog();
            }
        }
        private void peopleListBox_DoubleClick(object sender, EventArgs e)
        {
            viewButton_Click(sender, e);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            File.WriteAllText("data.json", JsonConvert.SerializeObject(people));
            base.OnClosing(e);
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            var addForm = new AddForm();
            var result = addForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                people.Add(addForm.Person);
                peopleListBox.Items.Add(addForm.Person);  
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (peopleListBox.SelectedItem is Person person)
            {
                var editForm = new AddForm(person);
                var result = editForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var index = peopleListBox.SelectedIndex;
                    people.RemoveAt(index);
                    people.Insert(index, editForm.Person);
                    peopleListBox.Items.RemoveAt(index);
                    peopleListBox.Items.Insert(index, editForm.Person);                  
                }
            }
        }
    }
}
