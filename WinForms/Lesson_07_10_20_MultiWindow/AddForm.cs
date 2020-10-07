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
    public partial class AddForm : Form
    {
        public Person Person { get; private set; }
        public AddForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Person = new Person();
            Person.Name = nameTextBox.Text;
            Person.Surname = surnameTextBox.Text;
            Person.Email = emailTextBox.Text;
            Person.Number = numberMaskedTextBox.Text;
            Person.DateOfBirth = birthDateTimePicker.Value;
            Person.Favorite = favoriteCheckBox.Checked;
            if (maleRadioButton.Checked)
            {
                Person.Gender = Gender.Male;
            }
            else if (femaleRadioButton.Checked)
            {
                Person.Gender = Gender.Female;
            }
            else
            {
                Person.Gender = Gender.Other;
            }
            Close();
        }
    }
}
