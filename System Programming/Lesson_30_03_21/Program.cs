using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson_30_03_21
{
    class Program
    {
        static void Main(string[] args)
        {


            var t = new Timer((x) => { Console.WriteLine($"Time is {DateTime.Now}"); },null,5000,1000);
            
            Task.Run(() =>
            {
                Console.WriteLine("Hi Dear!");
                Thread.Sleep(10000);
                t.Dispose();
            });
            

            ThreadPool.QueueUserWorkItem(x => { Console.WriteLine($"{x} World"); },"Hello");
            

            Console.ReadKey();
        }
    }
}
