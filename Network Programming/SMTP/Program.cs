using System;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using System.Net.Mail;

namespace NetConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
                     
            MailAddress from = new MailAddress("somemail@gmail.com", "Agil");
          
            MailAddress to = new MailAddress("somemail@yandex.ru");
            
            MailMessage m = new MailMessage(from, to);
            
            m.Subject = "Test";
            
            m.Body = "<h2>Hey There, How are you?</h2>";
           
            m.IsBodyHtml = true;
            
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            
            smtp.Credentials = new NetworkCredential("somemail@gmail.com", "mypassword");
            smtp.EnableSsl = true;
            smtp.Send(m);
            Console.Read();
        }
    }
}
