using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace DataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string myText = "Hello";
        private string phoneNumber;

        public string MyText { get => myText; set => OnChanged(out myText, value); }
        public string PhoneNumber { get => phoneNumber; set => OnChanged(out phoneNumber, value); }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyText = "Salam";
            PhoneNumber = "000000";
        }

        private void OnChanged<T>(out T prop, T value, [CallerMemberName] string propName = "")
        {
            prop = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        //private void OnTextChanged(object sender, TextChangedEventArgs e)
        //{
        //    textBlockOutput.Text = textBoxInput.Text;
        //}

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    var brush = Resources["redBrush"] as SolidColorBrush;
        //    brush.Color = Color.FromRgb(0,0,250);
        //}
    }
}
