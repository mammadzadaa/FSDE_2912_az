using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method
{
    class Safari : ITurPaket
    {
        public string Name { get; set; } = "Safari";

        public void EnjoyIt()
        {
            Console.WriteLine($"Enjoy {Name} tour!");
        }
    }
}
