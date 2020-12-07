using MVVMNavigation.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace MVVMNavigation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private ViewModelBase currentViewModel;

        public ViewModelBase CurrentViewModel
        {
            get => currentViewModel;
            set
            {
                currentViewModel = value;
                PropertyChanged?.Invoke(this,new PropertyChangedEventArgs("CurrentViewModel"));
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            CurrentViewModel = new HomeViewModel();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void HomeButtonClick(object sender, RoutedEventArgs e)
        {
            CurrentViewModel = new HomeViewModel();
        }

        private void AboutButtonClick(object sender, RoutedEventArgs e)
        {
            CurrentViewModel = new AboutViewModel();
        }
    }
}
