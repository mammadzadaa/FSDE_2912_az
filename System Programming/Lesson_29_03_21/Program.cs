using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson_29_03_21
{
    class Program
    {
        public static void Foo(object o)
        {
            Console.WriteLine("Hello my dear!");
        }
        public static void Foo1(object o)
        {
            Console.WriteLine("Hello dearling!");
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(Foo);
            t.Start();
            
            ThreadPool.QueueUserWorkItem(Foo1);

            Console.WriteLine("Hey Baybe!");

        }
    }
}
