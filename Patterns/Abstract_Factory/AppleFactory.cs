using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    class AppleFactory : ITechCompany
    {
        public ISmartPhone CreatePhone()
        {
            return new AppleIPhone();
        }

        public ITablet CreateTablet()
        {
            return new AppleIPad();
        }

        public ISmartWatch CreateWatch()
        {
            return new AppleWatch();
        }
    }
}
