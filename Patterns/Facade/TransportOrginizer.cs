using System;

namespace Facade
{
    partial class Program
    {
        public static class TransportOrginizer
        {
            public static void OrderAirplaneTickets()
            {
                Console.WriteLine("Airplane tickets been ordered");
            }
            public static void OrderBusTickets()
            {
                Console.WriteLine("Bus tickets been ordered");
            }
        }
    }
}
