using System;
using System.Net;
using System.IO;
using System.Net.Http;

namespace NetConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpListener listener = new HttpListener();

            //HttpClient client = new HttpClient();
            //HttpContent content = new StringContent("");
            //client.PostAsync("",content);
                        
            listener.Prefixes.Add("http://localhost:8888/connection/");
            
            listener.Start();
            Console.WriteLine("Witing for Connection...");
            
            HttpListenerContext context = listener.GetContext();
            
            HttpListenerRequest request = context.Request;
            
            HttpListenerResponse response = context.Response;
            
            string responseStr = $"<html><head><meta charset='utf8'></head><body><H1>Hello World!</H1><br><H2>{DateTime.Now}<H2></body></html>";
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseStr);
            
            response.ContentLength64 = buffer.Length;
            Stream output = response.OutputStream;
            output.Write(buffer, 0, buffer.Length);
            
            output.Close();
          
            listener.Stop();
            Console.WriteLine("Connection ended");
        }
    }
}
