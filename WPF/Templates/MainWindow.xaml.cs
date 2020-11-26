using System;
using System.Collections.Generic;
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

namespace Templates
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            myImage.Margin = new Thickness(10);
            Uri uri = new Uri(@"C:\Users\Aqil\Downloads\space.jpg",UriKind.Absolute);
            ImageSource imageSource = new BitmapImage(uri);
            myImage.Source = imageSource;
        }
    }
}
