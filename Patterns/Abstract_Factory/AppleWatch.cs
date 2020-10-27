using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    class AppleWatch : ISmartWatch
    {
        public int Steps { get; set; } = 7300;

        public void ShowSteps()
        {
            Console.WriteLine($"Apple Watch showed {Steps} steps been made today");
        }
    }
}
