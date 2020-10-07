using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_07_10_20_MultiWindow
{
    public partial class MainForm : Form
    {
        private List<Person> people = new List<Person>();
        public MainForm()
        {
            InitializeComponent();
            people.Add(new Person()
            {
                Name = "Aftandil",
                Surname = "Mammadov",
                Email = "afti@gmail.com",
                Number = "(051)5515151",
                DateOfBirth = new DateTime(1972, 10, 20),
                Gender = Gender.Male,
                Favorite = true,
            });
            people.Add(new Person()
            {
                Name = "Gulnise",
                Surname = "Novruzova",
                Email = "guli@yahoo.com",
                Number = "(055)5115131",
                DateOfBirth = new DateTime(1992, 9, 12),
                Gender = Gender.Female,
                Favorite = false,
            });
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
    }
}
