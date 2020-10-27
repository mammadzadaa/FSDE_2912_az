using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    class GalaxyWatch : ISmartWatch
    {
        public int Steps { get; set; } = 6400;

        public void ShowSteps()
        {
            Console.WriteLine($"Samsung Watch showed {Steps} steps been made today");
        }
    }
}
