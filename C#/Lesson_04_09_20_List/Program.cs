using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Lesson_04_09_20_List
{
    class Person
    {
        //public const int num = 3;

        //public readonly int rNum;

        //public static int sNum = 10;

        //public int ReadOnlyProp { get; }

        static public int Count { get; private set; } = 0;
        public int ID { get; }

        //static Person()
        //{
        //    Console.WriteLine("Hey, I am Static ctor of Person class!");
        //}
        public Person() /*: this("N/A","N/A",0)*/
        {
            ID = Count++;
            //rNum = 5;
            //ReadOnlyProp = 10;
        }
        public Person(string name, string surname, int age) : this()
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public string Name { get; set; } = "N/A";
        public string Surname { get; set; }

        private int age;
        public int Age { get => age; set => age = value >= 0 && value <= 100 ? value : 0; }

        public override string ToString()
        {
            return $"{Surname} {Name} {Age}";
        }

    }

    class Program
    {
        static void Foo(int id, string name = "N/A", string surname = "N/A", int age = 10) { }
        static void Main(string[] args)
        {
            string[] s = File.ReadAllLines("People.txt");

            var people = new List<Person>();

            foreach (var item in s)
            {
                string[] str = item.Split(' ');
                people.Add(new Person(surname: str[0], name: str[1], age: Convert.ToInt32(str[2])));
            }

            foreach (var item in people)
            {
                Console.WriteLine(item);
                Console.WriteLine(item.Age);
            }

            //var people = new List<Person>();

            //people.Add(new Person(surname: "Mammadov", name: "Arif", age: 40));
            //people.Add(new Person(surname: "Muradov", name: "Islam", age: 50));
            //people.Add(new Person(surname: "Ismayilov", name: "Arif", age: 60));

            //var strb = new StringBuilder();

            //foreach (var item in people)
            //{
            //    strb.Append(item.ToString());
            //    strb.Append('\n');
            //}

            //File.WriteAllText("People.txt", strb.ToString());


            //string str = File.ReadAllText("Person.txt");

            //string[] s = str.Split(' ');

            //Person person = new Person() { Surname = s[0], Name = s[1], Age = int.Parse(s[2]) };

            //Console.WriteLine(person);
            //Console.WriteLine(person.Age);


            //Person person = new Person(surname: "Mammadov", name: "Arif", age: 40);

            //File.WriteAllText("Person.txt", person.ToString());

            //string someText = "Hello World!";

            //File.WriteAllText("Test.txt",someText);

            //string s = File.ReadAllText("Test.txt");

            //Console.WriteLine(s);


            //List<Person> people = new List<Person>(); // vector in c++
            //                                          //LinkedList<Person> people1; // (double linked) list in c++

            //string s = "Aliyev";
            //people.Add(new Person(surname: "Mammadov", name: "Arif", age: 40));
            //people.Add(new Person(surname: "Muradov", name: "Islam", age: 50));
            //people.Add(new Person(surname: s, name: "Arif", age: 60));
            //people.Add(new Person(surname: "Mammadov", name: "Arif", age: 40));
            //people.Add(new Person(surname: "Muradov", name: "Islam", age: 50));

            //Console.WriteLine(people.Count);
            //Console.WriteLine(people.Capacity);

            //people.TrimExcess();
            //Console.WriteLine();
            //Console.WriteLine(people.Count);
            //Console.WriteLine(people.Capacity);


            //Person person = new Person();
            //people.Add(person);


            //Person person = new Person(surname: "Mammadov", name: "Arif", age:40);

            //Console.WriteLine( person /*person.ToString()*/);


            //Foo(10, age:10);
            //Foo(10, surname: "dsajhdjsahd", name:"sdasd");

            //Person person1 = new Person();
            //Console.WriteLine(person1.ID);
            //Person person = new Person(surname: "Mammadov", name: "Arif", age:40);
            //Console.WriteLine(person.ID);

            //Console.WriteLine(Person.num);
            //Console.WriteLine(Math.PI);

            //Console.WriteLine(Person.sNum);
            //Person person = new Person{ Name = "Aftandil", Surname = "Mammadov", Age = 30};
            //Person person1 = new Person();
            //Person person2 = new Person();
            //Console.WriteLine(person.rNum);
        }
    }
}
