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
        public string Port { get; set; }

        public MainVM()
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5001);
            TcpClient client = new TcpClient();
            client.Connect(endPoint);
            Rectangle bounds = Screen.GetBounds(System.Drawing.Point.Empty);

            using (var writer = new FileStream(Directory.GetCurrentDirectory(),client.GetStream()))
            {
                using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
                {
                    using (Graphics g = Graphics.FromImage(bitmap))
                    {
                        g.CopyFromScreen(System.Drawing.Point.Empty, System.Drawing.Point.Empty, bounds.Size);
                    }
                    bitmap.Save("test.jpg", ImageFormat.Jpeg);
                    var imageInBytes = ImageToByteArray((Image)bitmap);
                    client.send(imageInBytes, 6500, endPoint);
                }
            }

            
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
 
}
