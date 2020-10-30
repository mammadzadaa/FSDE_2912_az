using System;

namespace Prototype
{
    public class Soft : ICloneable
    {
        public string Release { get; set; }

        public Soft(string release)
        {
            Release = release;
        }
        public object Clone()
        {
            return MemberwiseClone();
        }
        public override string ToString()
        {
            return Release;
        }
    }
}