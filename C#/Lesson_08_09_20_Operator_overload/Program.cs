using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Lesson_08_09_20_Operator_overload
{

    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Person(){}

        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public override bool Equals(object obj)
        {
            if (obj is Person other)
            {
                return Name == other.Name && Surname == other.Surname;
            }
            else
            {
                return false;
            }

            //if (obj is Person)
            //{
            //    Person other = obj as Person;
            //    return Name == other.Name && Surname == other.Surname;
            //}
            //else
            //{
            //    return false;
            //}

        }

        //public static bool operator true (Person person)
        //{
        //    return !(string.IsNullOrEmpty(person.Name)) && !(string.IsNullOrEmpty(person.Surname));
        //}
        //public static bool operator false(Person person)
        //{
        //    return string.IsNullOrEmpty(person.Name) && string.IsNullOrEmpty(person.Surname);
        //}

        //public static bool operator==(Person left,Person right)
        //{
        //    return left.Name == right.Name && left.Surname == right.Surname;
        //}
        //public static bool operator !=(Person left, Person right)
        //{
        //    return !(left == right);
        //}

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Surname.GetHashCode();
        }

    }

    class Pul
    {
        private int qepik;

        public int Manat { get; set; }
        public int Qepik 
        { 
            get => qepik;
            set 
            {
                if (value >= 100)
                {
                    Manat += value / 100;
                    qepik += value % 100;
                }
                else
                {
                    qepik += value;
                }
            }
        }
        public Pul()
        {
            Manat = 0;
            Qepik = 0;
        }
        public Pul(int manat, int qepik)
        {
            Manat = manat;
            Qepik = qepik;
        }
        public override string ToString()
        {
            return $"{Manat},{Qepik} AZN";
        }

        public static Pul operator +(Pul left, Pul right)
        {
            return new Pul(left.Manat + right.Manat, left.Qepik + right.Qepik);
        }

        public static Pul operator++(Pul pul)
        {
            return new Pul(pul.Manat + 1, pul.qepik);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<int, string>();

            dic.Add(10,"Some text");
            if(dic.TryAdd(11, "Another text"))
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Same key");
            }

            if (dic.TryGetValue(15,out string str))
            {
                Console.WriteLine(str);
            }
            else
            {
                Console.WriteLine("No such key");
            }

            var dictionary = new Dictionary<Person, string>();

            dictionary.Add(new Person("Anna", "Semenovich"), "Singer");
            dictionary.Add(new Person("Ahmad", "Alarabi"), "Businessman");

            Console.WriteLine(dictionary[new Person("Anna", "Semenovich")]);

            var dictionaryInDictionary = new Dictionary<string, Dictionary<string, string>>();
            dictionaryInDictionary["key"] = new Dictionary<string, string>();
            dictionaryInDictionary["key"]["inner key"] = "Value";

            Console.WriteLine(dictionaryInDictionary["key"]["inner key"]);

            //int num = 1;
            //int num1 = 1;

            //string str = "Hello";
            //string str1 = "Hello";

            //Person person = new Person() { Name = "Anna", Surname = "Shestokovic" };
            //Person person1 = new Person() { Name = "Shestokovic", Surname = "Anna" };

            //Console.WriteLine(num.GetHashCode());
            //Console.WriteLine(num1.GetHashCode());

            //Console.WriteLine(str.GetHashCode());
            //Console.WriteLine(str1.GetHashCode());

            //Console.WriteLine(person.GetHashCode());
            //Console.WriteLine(person1.GetHashCode());

            //Pul pul = new Pul(34,789);
            //Pul pul1 = new Pul(10, 48);
            //Pul pul2 = new Pul() {Manat = 27, Qepik = 79 };
            //Pul pul3 = pul1 + pul2;

            //Console.WriteLine(pul);
            //Console.WriteLine(pul1);
            //Console.WriteLine(pul2);
            //Console.WriteLine(pul3);

            //Console.WriteLine();

            //Console.WriteLine(pul3++);
            //Console.WriteLine(pul3);
            //Console.WriteLine(++pul3);

            //Person person = new Person() { Name = "Israfil", Surname = "Rahmanov"};
            //Person person1 = new Person("Israfil","Rahmanov");
            //Person person2 = new Person("","");


            //if (person2)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}


            //if (person.Equals(13))
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}

        }
    }
}
