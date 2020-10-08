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

namespace Lesson_07_10_20_MultiWindow
{
    public partial class AddForm : Form
    {
        private string filePath = null;
        public Person Person { get; private set; }
        public AddForm()
        {
            InitializeComponent();
        }
        public AddForm(Person person)
        {
            InitializeComponent();
            Person = person;
            addButton.Text = "Save";
            nameTextBox.Text = person.Name;
            surnameTextBox.Text = person.Surname;
            emailTextBox.Text = person.Email;
            numberMaskedTextBox.Text = person.Number;
            switch (person.Gender)
            {
                case Gender.Male:
                    maleRadioButton.Checked = true;
                    break;
                case Gender.Female:
                    femaleRadioButton.Checked = true;
                    break;
                case Gender.Other:
                    otherRadioButton.Checked = true;
                    break;
            }
            favoriteCheckBox.Checked = person.Favorite;
            birthDateTimePicker.Value = person.DateOfBirth;
            if (person.ImagePath != null)
            {
                userPictureBox.Image = Image.FromFile(person.ImagePath);
            }
            else
            {
                var directory = Directory.GetCurrentDirectory();
                userPictureBox.Image = Image.FromFile($@"{directory}\Photos\default.png");
            }
            filePath = person.ImagePath;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private string CreateNewFile(string oldPath)
        {
            string newPath = "";
            try
            {
                var directory = Directory.GetCurrentDirectory();
                if (!Directory.Exists($@"{directory}\Photos"))
                {
                    Directory.CreateDirectory($@"{directory}\Photos");
                }
                var extention = Path.GetExtension(oldPath);
                newPath = $@"{directory}\Photos\{Guid.NewGuid()}{extention}";
                File.Copy(oldPath, newPath);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return newPath;
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
            if (filePath != Person.ImagePath)
            {
                Person.ImagePath = CreateNewFile(filePath);
            }
            Close();
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog();
            fileDialog.Title = "Photo to select";
            fileDialog.Filter = "Pictures (*.png,*.jpg) | *.png;*.jpg";
            var result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                userPictureBox.Image = Image.FromFile(fileDialog.FileName);
                filePath = fileDialog.FileName;
            }
        }

    }
}
