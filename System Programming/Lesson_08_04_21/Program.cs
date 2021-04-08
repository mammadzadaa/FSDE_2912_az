using IPluginDLL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Lesson_08_04_21
{
    class Program
    {
        static public List<IPlugin> Plugins = new List<IPlugin>();

        static void Main(string[] args)
        {
            LoadAllPlugins();

            while (true)
            {
                int i = 1;
                foreach (var p in Plugins)
                {
                    Console.WriteLine($"{i++}. {p.Name}");
                }
                var key = int.Parse(Console.ReadLine());
                Plugins[key - 1].Action();
                Console.ReadKey();
            }
        }

        static public void LoadAllPlugins()
        {
            var files = Directory.GetFiles("Extentions");
            var assemblies = new List<Assembly>();
            foreach (var f in files.Where(x => x.EndsWith(".dll")))
            {
                var assembly = Assembly.LoadFile(Directory.GetCurrentDirectory() + "\\" + f);
                foreach (var type in assembly.GetTypes().Where(x => x.GetInterface("IPlugin") != null))
                { 
                    Plugins.Add(Activator.CreateInstance(type) as IPlugin);
                }
            }

        }
    }

}
