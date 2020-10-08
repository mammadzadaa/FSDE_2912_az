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
    public partial class ViewForm : Form
    {
        public ViewForm(Person person)
        {
            InitializeComponent();
            nameLabel.Text = person.Name;
            surnameLabel.Text = person.Surname;
            emailTextBox.Text = person.Email;
            numberTextBox.Text = person.Number;
            infoLabel.Text = $"Gender: {person.Gender}\n\nDate of Birth: {person.DateOfBirth.ToShortDateString()}\n";
            favoriteLabel.Visible = person.Favorite;
            if (person.ImagePath != null)
            {
                viewPictureBox.Image = Image.FromFile(person.ImagePath);
            }
            else
            {
                var directory = Directory.GetCurrentDirectory();
                viewPictureBox.Image = Image.FromFile($@"{directory}\Photos\default.png");
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
