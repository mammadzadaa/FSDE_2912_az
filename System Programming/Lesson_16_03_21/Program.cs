using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson_16_03_21
{
    class Program
    {
        static void Main(string[] args)
        {
            //foreach (var a in args)
            //{
            //    Console.Write(a + " ");
            //    Console.WriteLine(a.Length);
            //}
            //var proc = new Process()
            //{
            //    StartInfo = new ProcessStartInfo()
            //    {
            //        FileName = "chrome",
            //        Arguments = "fb.com",

            //    }
            //};

            //proc.Start();
            //Console.ReadKey();
            //PInvoke.Kernel32.TerminateProcess(proc.Handle,0);
            while (true)
            {
                foreach (var p in Process.GetProcessesByName("msedge"))
                {
                    Console.WriteLine(p.ProcessName);
                    p.Kill();
                    // p.Exited += (s, e) => { Console.WriteLine($"{p.Id} Killed "); };
                }
                Thread.Sleep(1000);
            }


        }


    }
}
