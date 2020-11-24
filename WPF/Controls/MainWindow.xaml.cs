using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Controls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Person> Items { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Items = new ObservableCollection<Person>()
            {
                new Person(){ Name = "Aftandil", PhoneNumber = "111" },
                new Person(){ Name = "Israfil", PhoneNumber = "222" },
                new Person(){ Name = "Aghamir", PhoneNumber = "333" }

            };

            //listBox.ItemsSource = Items;
            //comboBox.ItemsSource = Items;
        }

        //private void addButton_Click(object sender, RoutedEventArgs e)
        //{
        //    var text = textBox.Text;
        //    Items.Add(new Person() { Name = text , PhoneNumber = "000"});
        //    textBox.Text = string.Empty;
        //}



        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    var text = textBox.Text;
        //    textBlock.Text = text;
        //}

        //private void Button_Click_1(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show(passwordBox.Password);
        //}
    }
}
