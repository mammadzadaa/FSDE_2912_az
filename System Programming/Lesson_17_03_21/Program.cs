using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson_17_03_21
{
    class Program
    {
        private static void Foo()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Hello!");    
            }
            Console.WriteLine("T1 ended");
        }
        private static void Foo1(object o)
        {
            Console.WriteLine(o);
        }

        //private static event EventHandler<string> downloadingEnded;

        static void Main(string[] args)
        {
            string s = "";
            var webThread = new Thread(() =>
            {
                var web = new WebClient();
                //var res = web.DownloadString(@"https://itstep.az/");
                s = web.DownloadString(@"https://itstep.az/");
                Console.WriteLine("Web finished!");
                //downloadingEnded?.Invoke(null, res);
            });

            var fileThread = new Thread((x) =>
            {
                File.WriteAllText("step.html",x.ToString());
                Console.WriteLine("File finished!");

            });

            webThread.Start();
            webThread.Join();

            fileThread.Start(s);
            fileThread.Join();

            //downloadingEnded += (s, x) =>
            //{
            //    fileThread.Start(x);
            //};


         

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Some job");
                Thread.Sleep(500);
            }


            //var t = new Thread(Foo1);
            //t.Start("Step IT Academy");

            //var t1 = new Thread(Foo);
            
            //var name = "Afti";
            //var age = 45;
            //var t2 = new Thread(() => {
            //    for (int i = 0; i < 1000; i++)
            //    {
            //        Console.WriteLine($"Salam {name} yashi {age}!"); 
            //    }
            //    Console.WriteLine("T2 ended");
            //});
            //t1.Priority = ThreadPriority.Lowest;
            //t2.Priority = ThreadPriority.Highest;
            ////t1.IsBackground = true;
            ////t2.IsBackground = true;
            //t1.Start();
            //t2.Start();
            //for (int i = 0; i < 1000; i++)
            //{
            //    Console.WriteLine("Hi");
            //}
            //Console.WriteLine("Main thread ended");
        }
    }
}
