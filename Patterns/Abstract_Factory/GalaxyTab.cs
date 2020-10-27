using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    class GalaxyTab : ITablet
    {
        public string Videos { get; set; } = "dogvideo.mp4";

        public void WtchVideo()
        {
            Console.WriteLine("Samsung Tablet shows video form " + Videos);
        }
    }
}
