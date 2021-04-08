using IPluginDLL;
using System;

namespace PluginTwoDLL
{
    public class PluginTwo : IPlugin
    {
        public string Name { get; set; } = "Samur's Extention!";

        public void Action()
        {
            Console.WriteLine("Ogru aleminin sade oglani, Samur!✴");
        }
    }
}
