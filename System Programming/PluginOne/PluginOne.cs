using IPluginDLL;
using System;

namespace PluginOneDLL
{
    public class PluginOne : IPlugin
    {
        public string Name { get; set; } = "Zabil's Extention!";

        public void Action()
        {
            Console.WriteLine("This is Zabil's Extention!!!!");
        }
    }
}
