using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    class GalaxyPhone : ISmartPhone
    {
        public string Number { get; set; } = "+99477777777";

        public void Call()
        {
            Console.WriteLine("Samsung Phone is calling from number " + Number);
        }
    }
}
