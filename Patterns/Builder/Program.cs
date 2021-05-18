using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car(vendor:"Cayen", model:"Porshe",engine: new Engine(),wheels: new Wheels());
            Console.WriteLine(car);

            CarBuilder carBuilder = new CarBuilder("X5","BMW");
            carBuilder.SetEngine(new Engine());
            carBuilder.SetLeftDoor();
            carBuilder.SetRightDoor();
            carBuilder.SetWheels(new Wheels());
            var anotherCar = carBuilder.Build();
            Console.WriteLine(anotherCar);



            var someCar = new CarBuilder("C200", "Mercedes")
                                .SetEngine(new Engine())
                                .SetLeftDoor()
                                .SetWheels(new Wheels())
                                .Build();

            Console.WriteLine(someCar);
        }
    }
}
