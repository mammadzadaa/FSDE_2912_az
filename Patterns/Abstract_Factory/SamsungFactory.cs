using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    class SamsungFactory : ITechCompany
    {
        public ISmartPhone CreatePhone()
        {
            return new GalaxyPhone();
        }

        public ITablet CreateTablet()
        {
            return new GalaxyTab();
        }

        public ISmartWatch CreateWatch()
        {
            return new GalaxyWatch();
        }
    }
}
