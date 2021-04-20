using GalaSoft.MvvmLight.Command;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace TeamviewerApp.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class MainVM
    {
        public Image Img { get; set; }
        public ImageSource ImgSrc { get; set; }
        public string ImageStr { get; set; }
        public string Ip { get; set; }
        public string Port { get; set; }
        public RelayCommand ConnectButtonCommand { get; set; }

        public MainVM()
        {
            ConnectButtonCommand = new RelayCommand(() =>
             {
                 IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(Ip),int.Parse(Port));
                 UdpClient server = new UdpClient(endPoint);
                 //server.Connect(endPoint);

                 IPEndPoint ipEndPoint = null;
                 var data = server.Receive(ref ipEndPoint);

                 byte[] buffer = new byte[6500];
                 using (MemoryStream mStream = new MemoryStream(data))
                 {
                     //Img = Image.FromStream(mStream);
                     var bitmap = new BitmapImage();
                     bitmap.BeginInit();
                     bitmap.StreamSource = mStream;
                     bitmap.EndInit();
                     ImgSrc = bitmap as ImageSource;
                     ImageStr = ImgSrc.ToString();
                     MessageBox.Show(ImgSrc.ToString());
                 }
             });
   
        }
    }
}
