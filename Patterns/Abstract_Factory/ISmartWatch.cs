using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    interface ISmartWatch
    {
        public int Steps { get; set; }
        public void ShowSteps();
    }

}
