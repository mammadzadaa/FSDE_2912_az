using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson_01_04_21_Async
{
    class Program
    {
        static void Main(string[] args)
        {

            //int x = 0;
            //Semaphore semaphore = new Semaphore(1, 1);
            //Task[] tasks = new Task[2];
            //for (int i = 0; i < tasks.Length; i++)
            //{
            //    tasks[i] = Task.Run(() =>
            //    {
            //        for (int j = 0; j < 1000000; j++)
            //        {
            //            semaphore.WaitOne();
            //            x++;
            //            semaphore.Release();
            //        }
            //    });
            //}
            //Task.WaitAll(tasks);
            //Console.WriteLine(x);
            Start();
            Infinity();
        }

        static void Infinity()
        {
            int x = 0;
            while (true)
            {
                Console.WriteLine(x++);
                Thread.Sleep(500);
            }
        }

        static async void  Start()
        {
            Console.WriteLine("Started");

            // var result = GetResult();
            // Console.WriteLine(result);

            //GetResultThread();

            // var task = GetResultTask();
            // Console.WriteLine(task.Result);
            int result = await GetResultTask();
            Console.WriteLine(result);
            Console.WriteLine("Finished");
        }

        static int GetResult()
        {
            Thread.Sleep(1000);
            var result = 42;
            return result;
        }

        static Task<int> GetResultTask()
        {
           return Task.Run(() =>
            {
                Thread.Sleep(1000);
                var result = 42;
                return result;
            });
            
        }

        static void GetResultThread()
        {
            new Thread(() =>
            {
                Thread.Sleep(1000);
                var result = 42;
                CallBack(result);
            }).Start();
        }
        private static void CallBack(int result)
        {
            Console.WriteLine(result);
        }
    }
}
