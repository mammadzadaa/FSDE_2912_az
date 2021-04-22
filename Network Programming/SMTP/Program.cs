using System;
using System.IO;
using System.Net;
using System.Text;

namespace FtpConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://127.0.0.1/test.txt");
            request.Method = WebRequestMethods.Ftp.DownloadFile;
            //request.Credentials = new NetworkCredential("login", "password");
            //request.EnableSsl = true;
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            
            Stream responseStream = response.GetResponseStream();
            FileStream fs = new FileStream("newTest.txt", FileMode.Create);
            byte[] buffer = new byte[64];
            int size = 0;
            while ((size = responseStream.Read(buffer, 0, buffer.Length)) > 0)
            {
                fs.Write(buffer, 0, size);
            }
            fs.Close();
            response.Close();
            Console.WriteLine("Loading and saving of fies is ready");
            Console.Read();
        }
    }
}


//using System;
//using System.Net;
//using System.IO;
//using System.Threading.Tasks;
//using System.Net.Mail;

//namespace NetConsoleApp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            MailAddress from = new MailAddress("aqil.mamedzade@gmail.com", "Agil");

//            MailAddress to = new MailAddress("agil.mammadzada@gmail.com");

//            MailMessage m = new MailMessage(from, to);

//            m.Subject = "Test";

//            m.Body = "<h2>Hey There, How are you?</h2>";

//            m.IsBodyHtml = true;

//            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);

//            smtp.Credentials = new NetworkCredential("aqil.mammedzade@gmail.com", "");
//            smtp.EnableSsl = true;
//            smtp.Send(m);
//            Console.Read();
//        }
//    }
//}
