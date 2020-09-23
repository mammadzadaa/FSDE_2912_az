using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace Lesson_23_09_2020_Garbage_Collector
{
    class Logger : IDisposable
    {
        private FileStream fs;
        private StreamWriter sr;

        public Logger(string path)
        {
            fs = new FileStream(path, FileMode.Create);
            sr = new StreamWriter(fs);
        }

        public void Log()
        {
            sr.Write("Some Event happend!\n" + DateTime.Now + "\n");
        }

        private bool isClosed = false;

        public void Close()
        {
            if (!isClosed)
            {
                sr.Close();
                fs.Close();

                isClosed = true;
            }
        }

        public void Dispose()
        {
            Close();
        }

        ~Logger()
        {
            Close();
        }

    }

    class Temp
    {
        public Temp()
        {
            Console.WriteLine("Ctor called");
        }

        // void Finalize() { }
        public int Prop { get; set; }
        ~Temp() // Finalizer
        {
            Console.WriteLine("Finalizer");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            using (Logger l = new Logger("log.txt"))
            {
                for (int i = 0; i < 3; i++)
                {
                    l.Log();
                    Thread.Sleep(1000);
                    Console.WriteLine("Logged");
                }

            } 


            //{
            //    Temp t = new Temp();
            //}
       
            //{
            //    Temp t = new Temp();
            //}
        }
    }
}
