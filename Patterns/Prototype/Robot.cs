
using System;

namespace Prototype
{
    class Robot : ICloneable
    {
        public Robot(string name, string vendor, string model, int upTime, double weight, string color, Soft soft)
        {
            Name = name;
            Vendor = vendor;
            Model = model;
            UpTime = upTime;
            Weight = weight;
            Color = color;
            Soft = soft;
        }

        public string Name { get; set; }
        public string Vendor { get; set; }
        public string Model { get; set; }
        public int UpTime { get; set; }
        public double Weight { get; set; }
        public string Color { get; set; }
        public Soft Soft { get; set; }

        public object Clone()
        {
            var temp = MemberwiseClone() as Robot;
            temp.Soft = Soft.Clone() as Soft;
            return temp;
        }

        public override string ToString()
        {
            return $"{Name} is {Color} {Model} model robot made by {Vendor}. " +
                $"Up time is {UpTime} hours and waight is {Weight} kg." +
                 $"\nWith Software release " + Soft?.Release;
        }
    }
}
