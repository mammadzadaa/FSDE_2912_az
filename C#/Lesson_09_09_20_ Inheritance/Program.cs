using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Zoo;

namespace Lesson_09_09_20__Inheritance
{

    //class One
    //{

    //}

    //class Two
    //{
    //    public void Foo()
    //    {
    //        Console.WriteLine("Wohoo!");
    //    }

    //    public static explicit operator One(Two two)
    //    {
    //        return new One();
    //    }

    //}

    //class MyClass
    //{
    //    public override string ToString()
    //    {
    //        return "Hello";
    //    }
    //}

    internal class MyClass : Animal
    {
        public MyClass() : base("",0)
        {

        }
        public override void Sound()
        {
            // base.PrivateProtected // Inaccessable
            // base.InternalProtected // OK
            throw new NotImplementedException();
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            //Animal animal = new Animal("Animal", 0);
            Animal dog = new Dog("Buddy",2,"Doberman");
            // dog.Internal; // Inacessanble
            

           // Console.WriteLine(animal);
            Console.WriteLine(dog);

            Console.ReadKey();


            //Animal animal = new Animal();
            //Animal dog = new Dog();

            //animal.Sound();
            //dog.Sound();

            //Console.WriteLine();

            //animal.VSound();
            //dog.VSound();


            //Animal animal = new Animal();

            //Dog dog = new Dog();

            //animal.Sound();
            //dog.Sound();



            //int? num = null;

            //Console.WriteLine(num);

            //Nullable<int> nullable = new Nullable<int>(12);

            //nullable += 10;        



            //MyClass myClass = null; //new MyClass();

            //Console.WriteLine(myClass?.ToString());


            //// string str = null;
            // string str = "Hello";

            // string str1;

            // //str1 = str ?? "Is Empty";
            // str1 = str;

            // str1 ??= "Is Empty"; // if null the = "is Empty"

            // Console.WriteLine(str1);

            //if (str != null)
            //{
            //    str1 = str;
            //    Console.WriteLine(str1);
            //}
            //else
            //{
            //    Console.WriteLine("");
            //}


            // _ = new { Name = "Name", Surname = "Surname" };
            // var anonim = (Name: "Name", Surname: "Surname");

            //Tuple<int, string> tuple = new Tuple<int, string>(10,"sdadas");


            //(int, string) val = (5, "Salam");

            //val.Item1 = 10;
            //Console.WriteLine(val.Item2);

            //(int, int, string) val1 = (12,21,"");

            //Two two = new Two();
            //One one = (One)two;

            //object obj = new Two();

            //Two two = obj as Two;

            //if (obj is Two other)
            //{
            //    other.Foo();
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}

            //if (two != null)
            //{
            //    two.Foo();
            //}
        }
    }
}
