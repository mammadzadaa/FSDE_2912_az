using System;
using System.Reflection;

namespace Lesson_07_04_21
{
    class Test
    {
        public string Name { get; set; }
        public int Num { get; set; }
        public void Do()
        {
            Console.WriteLine("Hmm");
        }
        public void Print(string str)
        {
            Console.WriteLine($"Str is {str}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // MyLib.TestClass.DoSomething();

            var assembly = Assembly.GetCallingAssembly();
            Console.WriteLine(assembly);
            var t = assembly.GetTypes();
            var tType = assembly.GetType("Lesson_07_04_21.Test");
            var obj = Activator.CreateInstance(assembly.FullName, tType.FullName).Unwrap();
            Console.WriteLine(obj);
            obj.GetType().GetMethod("Print").Invoke(obj,new object[] {"What is love? Baybe don't hurt me!"});

            Console.WriteLine("\n////////////////\n\n");

            foreach (var i in t)
            {
                Console.WriteLine($"\t{i}");
                var members = i.GetMembers();
                foreach (var m in members)
                {
                    Console.WriteLine($"\t\t{m}");
                }
                
            }
        }
    }
}
