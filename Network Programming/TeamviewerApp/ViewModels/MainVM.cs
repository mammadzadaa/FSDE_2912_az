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

namespace TeamviewerApp.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class MainVM
    {
        public Image Img { get; set; }
        public string ImgStr { get; set; }
        public string Ip { get; set; }
        public string Port { get; set; }
        public RelayCommand ConnectButtonCommand { get; set; }

        public MainVM()
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 5001);
            TcpListener server = new TcpListener(endPoint);
            server.Start();

                TcpClient client = server.AcceptTcpClient();
                Task.Run(()=>
                {
                    byte[] buffer = new byte[6500];
                    using (MemoryStream mStream = new MemoryStream(buffer))
                    {
                        Img = Image.FromStream(mStream);
                    }

                }
                );
        }
    }
}
