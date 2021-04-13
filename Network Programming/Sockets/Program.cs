using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ServerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var listener = new Socket(  AddressFamily.InterNetwork,
                                        SocketType.Stream,
                                        ProtocolType.Tcp);
            var endPoint = new IPEndPoint(IPAddress.Any,5001);
            
            listener.Bind(endPoint);

            listener.Listen(10);

            Console.WriteLine("Server is listening...");
            var clientSocket = listener.Accept();
            Console.WriteLine("Client Connected!");

            byte[] buffer = new byte[1024];
            while (true)
            {
                clientSocket.Receive(buffer);

                var msg = Encoding.Unicode.GetString(buffer);
                Console.WriteLine(msg);
            }

        }
    }
}
