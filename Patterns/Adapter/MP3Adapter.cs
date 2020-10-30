using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class MP3Adapter : MP3
    {
        public MP3Adapter(WAW waw) : base("","",waw.Size,waw.Bit,waw.Data){}
    }
}
