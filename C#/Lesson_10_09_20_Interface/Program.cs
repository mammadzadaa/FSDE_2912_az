using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Schema;

namespace Lesson_10_09_20_Interface
{


    interface IFlyable
    {
        void Fly();
    }
    abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public abstract void Sound();

    }

    class Bird : Animal, IFlyable, ICloneable
    {
        public object Clone()
        {
            return new Bird() {Name = this.Name, Age = this.Age };
        }

        public void Fly()
        {
            Console.WriteLine("I Belive I can Fly!");
        }

        public override void Sound()
        {
            Console.WriteLine("Cik-Cirik");
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }

    abstract class Transport
    {
        public int Maxspeed { get; set; }
        public string Model { get; set; }
    }

    class Airplane : Transport, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("I belive I can touch the sky!");
        }
        public override string ToString()
        {
            return $"{Model}";
        }
    }

    interface IPoliceman
    {
        void Put();
    }

    interface IAdmin
    {
        void Put();
    }
    class Person : IComparable, IEquatable<Person>, IPoliceman, IAdmin
    {
        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public string Name { get; set; }
        public string Surname { get; set; }

        public int Age { get; set; }

        public int CompareTo(object obj)
        {
            if (obj is Person other)
                return this.Name.CompareTo(other.Name);
            // return this.Age - other.Age;
            else
                throw new ArgumentException();      
        }

        public bool Equals([AllowNull] Person other)
        {
            return this.Name == other.Name && this.Surname == other.Surname && this.Age == other.Age;
        }

        void IAdmin.Put()
        {
            Console.WriteLine($"{Name} puts USB in!");
        }

        void IPoliceman.Put()
        {
            Console.WriteLine($"{Name} puts someone into the jail!");
        }

        public override string ToString()
        {
            return $"{Name} {Surname} {Age}";
        }
    }
    class Program
    {
        public static void GoToFlightSchool(IFlyable flyingStudent)
        {
            Console.Write(flyingStudent.ToString());
            Console.WriteLine(" says:");
            flyingStudent.Fly();
            Console.WriteLine();
        }

        //public static void Foo(object obj)
        //{
        //    Console.WriteLine(obj);
        //}

        //public static void FooObj(object num)
        //{
        //    int number = (int)num;
        //}

        //public static void FooInt(int num)
        //{
        //    int number = num;
        //}

        static void Main(string[] args)
        {
            
            Person person = new Person("Aftandil", "Mammadov", 35);

            ((IPoliceman)person).Put();
            Console.WriteLine();
            ((IAdmin)person).Put();
            Console.WriteLine();

            if (person.Equals(new Person("Aftandil", "Mammadov", 35)))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            

            var people = new List<Person>();

            people.Add(new Person("Aftandil", "Mammadov", 35));
            people.Add(new Person("Israfil", "Abdullayev", 50));
            people.Add(new Person("Seid", "Letifov", 25));
            people.Add(new Person("Anna", "Yemelyanenko", 17));
            people.Add(new Person("Natasha", "Gorbachova", 18));

            people.Sort();

            foreach (var item in people)
            {
                Console.WriteLine(item.ToString());
            }

            //var numbers = new List<int>();

            //numbers.Add(11);
            //numbers.Add(7);
            //numbers.Add(17);
            //numbers.Add(1);
            //numbers.Add(0);


            //numbers.Sort();

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}


            //Bird bird = new Bird() { Name = "Gesha"};
            //Airplane airplane = new Airplane() { Model = "Boing 777" };

            //Bird b = bird.Clone() as Bird;
            //b.Name = "Masha";

            //Console.WriteLine(b.Name);

            //Animal animal = new Bird();
            //GoToFlightSchool(animal);

            //GoToFlightSchool(bird);
            //GoToFlightSchool(airplane);


            //var start = DateTime.Now;
            //for (int i = 0; i < 10000; i++)
            //{
            //    FooObj(13);
            //}

            //Console.WriteLine(DateTime.Now - start);
            //start = DateTime.Now;
            //for (int i = 0; i < 10000; i++)
            //{
            //    FooInt(13);
            //}
            //Console.WriteLine(DateTime.Now - start);

            //Person person = new Person() { Name = "A" , Surname = "M"};
            //Foo(new String("dsad"));
            //Foo(person);
            //int num = 10;
            //Foo(num);
        }
    }
}
