using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    interface ITechCompany
    {
        public ISmartPhone CreatePhone();
        public ISmartWatch CreateWatch();
        public ITablet CreateTablet();
    }
}
