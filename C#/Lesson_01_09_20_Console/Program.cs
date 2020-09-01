using Microsoft.VisualBasic.FileIO;
using System;

namespace Lesson_01_09_20_Console
{
    struct Point
    {
        public int x;
        public int y;
    }

    class Person
    {
        public string name;
        public int age;
    }
    class Program
    {
        static void Foo(Point point)
        {
            point.x = 0;
            point.y = 0;
        }

        static void Foo(Person person)
        {
            person.name = "Isreafil";
            person.age = 45;
        }

        static void Main(string[] args)
        {
            String str = "Some text";
            String str1 = new String("Some text");

            // Point point = new Point(); // created in stack // for constructor call only
            Point point;
            point.x = 12;
            point.y = 23;
            Foo(point);
            Console.WriteLine($"X is {point.x} and Y is {point.y}");

            Person person = new Person(); // created in heap
            
            Person p = null;
            person.name = "Aftandil";
            person.age = 35;
            Foo(person);
            Console.WriteLine($"Name: {person.name} \nAge: {person.age}");

            // VALUE TYPE and REFERENCE TYPE
              // struct         // class
               
            // long - Int64
            // int - Int32
            // short - Int16
            // byte - Byte

            // double - Double
            // float - Float
            // decimal - Decimal
            // char - Char

            // string - String

           // string name;

           // Console.Write("Enter your name: ");

           // name = Console.ReadLine();

           // Console.Write("Enter your age: ");
           //// int age = Convert.ToInt32(Console.ReadLine());
           // int age = int.Parse(Console.ReadLine());

           // Console.WriteLine($"Your name is {name} \nYour age is {age}");

            //string name = "Aftandil";
            //int age = 25;

            //string filename = "lesson.cs";

            //Console.WriteLine($@"C:\User\Aftandil\Downloads\{filename}");

            //Console.WriteLine(@"C:\User\Aftandil\Downloads\");

            //Console.WriteLine($"My name is {name}\nI am {age}");

            //Console.WriteLine("My name is {0} \nI am {1}",name, age);

            //Console.WriteLine("My name is " + name + "\nI am " + age);

            //Console.Write("My name is ");
            //Console.WriteLine(name);
            //Console.Write("I am ");
            //Console.WriteLine(age);

            // byte - 1 (0 - 255)
            // sbyte - 1 (-128 - 127)
            // short - 2
            // int - 4
            // long - 8

            // ushort (unsigned)

            // float - 4
            // double - 8
            // decimal - 16

            // bool - 1
            // char - 2

            // string

        }
    }
}

// .NET 

// Languages: C#, VB.NET, F#

// Desktop App: WinForms, WPF, UWP
// Mobile App: Xamarin
// Web back-end: ASP.NET
// WEb front-end: Blazor
// Game: Unity

// (MS) IL code - Intermadiate Language 
// CLR - Common Laguage Runtime
            // JIT compiler - Just-in-Time
            // GC - garbage collector

// BCL - Base Class Libraray 
// CTS - Common Type System
// CLS - Common Language Specification

// .NET Framework 
// .NET Core
// .NET 5


// reflector
// dotfuscate