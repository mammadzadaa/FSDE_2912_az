using GalaSoft.MvvmLight.Messaging;
using MVVM_Messaging.Messages;
using MVVM_Messaging.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MVVM_Messaging.View
{
    /// <summary>
    /// Interaction logic for AddForecastUC.xaml
    /// </summary>
    public partial class AddForecastUC : UserControl
    {
        public AddForecastUC()
        {
            InitializeComponent();
        }

        private void MapRightMouseButtonClick(object sender, MouseButtonEventArgs e)
        {
            var location = Map.ViewportPointToLocation(e.GetPosition(Map));
            //if (DataContext is AddForecastVM vm)
            //{
            //    vm.Longtitude = location.Longitude.ToString();
            //    vm.Latitude = location.Latitude.ToString();
            //}

            var messanger = App.Container.GetInstance<Messenger>();
            messanger.Send(new LocationMessege()
            {
                Longitute = location.Longitude,
                Latitude = location.Latitude
            }) ;
        }
    }
}
