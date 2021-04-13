using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var sender = new Socket(AddressFamily.InterNetwork,
                                        SocketType.Stream,
                                        ProtocolType.Tcp);

            var endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5001);

            sender.Connect(endPoint);
            Console.WriteLine("I am connected!");
            while (true)
            {
                var data = "Azeri torpaghinin hamimiz evladiyiq,\n Baki ezizi sheherim,\n Biz ona canla bagliyiq";
                
                sender.Send(Encoding.Unicode.GetBytes(data));
                Console.WriteLine("Message been sent");
                Thread.Sleep(2000);
            }

        }
    }
}
