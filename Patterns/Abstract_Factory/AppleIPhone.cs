using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    class AppleIPhone : ISmartPhone
    {
        public string Number { get; set; } = "+99455555555";

        public void Call()
        {
            Console.WriteLine("Apple Iphone is calling from number " + Number);
        }
    }
}
