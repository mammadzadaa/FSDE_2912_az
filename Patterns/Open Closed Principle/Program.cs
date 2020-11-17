using System;

namespace Open_Closed_Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    interface IMeal
    {
        void Make();
    }

    class MashedPotato : IMeal
    {
        public void Make()
        {
            Console.WriteLine("Kartofu yuyur");
            Console.WriteLine("Kartofu soyur");
            Console.WriteLine("Kartofu qaynadir");
            Console.WriteLine("Kartofu ezir");
            Console.WriteLine("Kartofa duz istiot elave edir");
            Console.WriteLine("Kartof puresi hazirdir!");
        }
    }

    class Boznash : IMeal
    {
        public void Make()
        {
            Console.WriteLine("Mom knows how to do it!");
        }
    }
    class Cook
    {
        public string Name { get; set; }

        public Cook(string name)
        {
            Name = name;
        }

        public void MakeDinner(IMeal meal)
        {
            meal.Make();
        }
    }

    //class Cook
    //{
    //    public string Name { get; set; }

    //    public Cook(string name)
    //    {
    //        Name = name;
    //    }

    //    public void MakeDinner()
    //    {
    //        Console.WriteLine("Kartofu yuyur");
    //        Console.WriteLine("Kartofu soyur");
    //        Console.WriteLine("Kartofu qaynadir");
    //        Console.WriteLine("Kartofu ezir");
    //        Console.WriteLine("Kartofa duz istiot elave edir");
    //        Console.WriteLine("Kartof puresi hazirdir!");
    //    }
    //}
}
