using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method
{
    class Hiking : ITurPaket
    {
        public string Name { get; set; } = "Hiking";

        public void EnjoyIt()
        {
            Console.WriteLine($"Enjoy {Name} tour paket");
        }
    }
}
