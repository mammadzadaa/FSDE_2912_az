using GalaSoft.MvvmLight.Command;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accepter.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class MainVM
    {
        public string Ip { get; set; }
        public int Port { get; set; }
        public RelayCommand DisconnectButtonClicked { get; set; }
        public MainVM()
        {
            DisconnectButtonClicked = new RelayCommand(() =>
            {
                Port = 5002;
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), Port);
                Ip = endPoint.Address.ToString();
                UdpClient client = new UdpClient();
                Rectangle bounds = Screen.GetBounds(System.Drawing.Point.Empty);
                using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
                {
                    using (Graphics g = Graphics.FromImage(bitmap))
                    {
                        g.CopyFromScreen(System.Drawing.Point.Empty, System.Drawing.Point.Empty, bounds.Size);
                    }
                    bitmap.Save("test.jpg", ImageFormat.Jpeg);
                    var width = bounds.Width * 0.2;
                    var height = bounds.Height * 0.2;

                    var newBitmap = new Bitmap(bitmap,(int)width,(int)height);

                    byte[] imageInBytes = (byte[])(new ImageConverter()).ConvertTo(newBitmap, typeof(byte[]));
                    client.Send(imageInBytes, imageInBytes.Length, endPoint);
                }
            });



        }
        public byte[] ImageToByteArray(Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
    }
}
 
