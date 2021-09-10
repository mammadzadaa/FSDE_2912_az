using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Lesson_15_04_21_L
{
    class Program
    {
        static void Main(string[] args)
        {
        IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"),5001);
            TcpClient client = new TcpClient();
            
            client.Connect(endPoint);

            using (var writer = new StreamWriter(client.GetStream()))
            {
                while (true)
                {
                    var msg = Console.ReadLine();
                    writer.WriteLine(msg);
                    writer.Flush();
                }
            }

        }
    }
}
