using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Car
    {
        public Car(string model, string vendor) 
        {
            Model = model;
            Vendor = vendor;
        }
        public Car(string model, string vendor, Engine engine = null, Door leftdoor = null, Door rightdoor = null, Wheels wheels = null)
        {
            Model = model;
            Vendor = vendor;
            Engine = engine;
            LeftDoor = leftdoor;
            RightDoor = rightdoor;
            Wheels = wheels;
        }
        public string Model { get; set; }
        public string Vendor { get; set; }
        public Engine Engine { get; set; }
        public Door LeftDoor { get; set; }
        public Door RightDoor { get; set; }
        public Wheels Wheels { get; set; }

        public override string ToString()
        {
            return $"{Model} {Vendor} {Engine?.ToString()} " +
                $"{LeftDoor?.ToString()} {RightDoor?.ToString()} {Wheels?.ToString()}";
        }


    }
}
