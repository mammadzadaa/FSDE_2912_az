using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class CarBuilder
    {
        private Car car;
        public CarBuilder(string model, string vendor)
        {
            car = new Car(model, vendor);
        }
        public CarBuilder SetEngine(Engine engine)
        {
            car.Engine = engine;
            return this;
        }
        public CarBuilder SetLeftDoor()
        {
            car.LeftDoor = new Door(Side.Left);
            return this;
        }
        public CarBuilder SetRightDoor()
        {
            car.RightDoor = new Door(Side.Right);
            return this;
        }
        public CarBuilder SetWheels(Wheels wheels)
        {
            car.Wheels = wheels;
            return this;
        }
        public Car Build()
        {
            return car;
        }
    }
}
