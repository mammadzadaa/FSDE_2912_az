using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method
{
    class Cruise : ITurPaket
    {
        public string Name { get; set; } = "Cruise";

        public void EnjoyIt()
        {
            Console.WriteLine($"Enjoy {Name} tour paket");
        }
    }
}
