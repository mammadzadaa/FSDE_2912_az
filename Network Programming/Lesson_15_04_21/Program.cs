using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_15_04_21
{
    class Program
    {
        static void Main(string[] args)
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Any,5001);

            TcpListener server = new TcpListener(endPoint);
            server.Start();
            Console.WriteLine("Server is running...");

            while (true)
            {
                TcpClient client = server.AcceptTcpClient();
                Console.WriteLine("Client is connected...");

                Task.Run(() =>
                {
                    using (var stream =  client.GetStream())
                    {
                       using (var reader = new StreamReader(stream))
                       {                            
                            while (true)
                            {
                                var msg = reader.ReadLine();
                                if (msg == "exit")
                                {
                                    break;
                                }
                                Console.WriteLine(msg);
                            }
                       }

                    }
                


                    /*byte[] buf = new byte[65536];
                    //using (var stream = client.GetStream())
                    //{
                    //    while (true)
                    //    {
                    //        var size = stream.Read(buf,0,65536);
                    //        var msg = Encoding.Unicode.GetString(buf,0,size);
                    //        if (msg == "exit")
                    //        {                               
                    //            server.Stop();
                    //            Console.WriteLine("Server disconnected!");
                    //        }
                    //        Console.WriteLine(msg);
                    //    }
                    }*/

                });
            }
        }
    }
}
