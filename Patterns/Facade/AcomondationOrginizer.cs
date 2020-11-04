using System;

namespace Facade
{
    partial class Program
    {
        public static class AcomondationOrginizer
        {
            public static void BookHotel(int stars)
            {
                Console.WriteLine($"{stars} star hotel been booked");
            }
            public static void BookApartment(int stars)
            {
                Console.WriteLine($"{stars}star apartment been booked");
            }
        }
    }
}
