using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    interface ISmartPhone
    {
        public string Number { get; set; }
        public void Call();
    }
}
