using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method
{
    class HikingFactory : ITurFactory
    {
        public ITurPaket CreateTur()
        {
            return new Hiking();
        }
    }

}
