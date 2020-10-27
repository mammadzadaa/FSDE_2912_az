using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    class AppleIPad : ITablet
    {
        public string Videos { get; set; } = "catvideo.mp4";

        public void WtchVideo()
        {
            Console.WriteLine("Apple Ipad shows video form " + Videos);
        }
    }
}
