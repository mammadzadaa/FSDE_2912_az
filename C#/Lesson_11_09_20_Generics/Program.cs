using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Lesson_11_09_20_Generics
{
    abstract class DB
    {
        public string  Connection { get; set; }
        public abstract void Update();
        public abstract void Select();

        public abstract void Insert(string str);
        //......
    }

    class MySQL : DB
    {
        public override void Insert(string str)
        {
            Console.WriteLine($"MySQL db in {Connection} has inserted: {str}");
        }

        public override void Select()
        {
            Console.WriteLine($"MySQL db in {Connection} been selected!");
        }

        public override void Update()
        {
            Console.WriteLine($"MySQL db in {Connection} been Updated!");
        }
    }

    class PostgreeSQL : DB
    {
        public override void Insert(string str)
        {
            Console.WriteLine($"PostgreeSQL db in {Connection} has inserted: {str}");
        }

        public override void Select()
        {
            Console.WriteLine($"PostgreeSQL db in {Connection} been selected!");
        }


        public override void Update()
        {
            Console.WriteLine($"PostgreeSQL db in {Connection} been Updated!");
        }
    }
    interface IDBwritabele
    {
        void WriteToDatabase(DB db);
    }
    class Person : IDBwritabele
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public void WriteToDatabase(DB db)
        {
            db.Insert(this.ToString());
        }

        public override string ToString()
        {
            return $"{Name} {Surname} {Age}";
        }
    }

    struct Animal// : ICloneable
    {
        public string Name { get; set; }

        //public object Clone()
        //{
        //    return new Animal() { Name = this.Name };
        //}
        public override string ToString()
        {
            return Name;
        }
    }

   static class Print<TOne,TTwo>
    {
        public static void PrintVal(TOne val,TTwo val1)
        {
            Console.WriteLine(val);
            Console.WriteLine(val1);
        }
    }

    class Account<T>
    {
        public Account()
        {
            ID = default;
            Password = "";
        }
        public Account(T iD, string password)
        {
            ID = iD;
            Password = password;
        }

        public T ID { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return $"{ID} {Password}";
        }
    }

    class MyList<T> : IEnumerable
    {
        class Enumirator : IEnumerator
        {
            private T[] array;
            public int index = -1;
            public Enumirator(T[] arr)
            {
                array = arr;
            }
            public object Current => array[index];


            public bool MoveNext()
            {
                if (array.Length - 1 > index)
                {
                    index++;
                    return true;
                }
                return false;
            }

            public void Reset()
            {
                index = -1;
            }
        }
        private T[] array;
        public int Length { get; }
        public T this[int index]
        {
            get => array[index];
            set => array[index] = value;            
        }
        public MyList(params T[] items)
        {
            array = items;
            Length = items.Length;
            //array = new T[items.Length];
            //for (int i = 0; i < items.Length; i++)
            //{
            //    array[i] = items[i];
            //}
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < Length; i++)
            {
                yield return array[i];
            }
        }
        //public IEnumerator GetEnumerator()
        //{
        //    return new Enumirator(array);
        //}
    }

    class Program
    {
        //static void WorkWithDB(DB dB)
        //{
        //    dB.Update();
        //    dB.Select();
        //}
        //static void WriteToDB(IDBwritabele dBwritabele, DB dB)
        //{
        //    dBwritabele.WriteToDatabase(dB);
        //}

        // where T : class
        static void PrintSomething<T>(T val) where T : class, new()
        {
            Console.WriteLine(val);
        }

        //static IEnumerable Foo() 
        //{
        //    yield return 1;
        //    yield return 2;
        //    yield return 3;
        //    yield return 4;
        //}
        static void Main(string[] args)
        {
            PrintSomething(new Account<int>(12,""));

            //var account = new Account<int>();
            //Console.WriteLine(account);

            //var account1 = new Account<decimal>();
            //Console.WriteLine(account1);

            //var account2 = new Account<DateTime>();
            //Console.WriteLine(account2);

            MyList<int> list = new MyList<int>(12, 32, 45, 23, 67);
            list[2] = 13;
            list[4] = 50;

            //var items = Foo();

            //foreach (var item in items)
            //{
            //    Console.WriteLine(item);
            //}

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //for (int i = 0; i < list.Length; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //var iterator = list.GetEnumerator();

            //while (iterator.MoveNext())
            //{
            //    Console.WriteLine(iterator.Current);
            //}
            //iterator.Reset();




            // var account = new Account<string>("00001","qwerty12345");


            //var id = Guid.NewGuid();

            //var account = new Account<Guid>(Guid.NewGuid(), "qwerty12345");
            //var account1 = new Account<Guid>(Guid.NewGuid(), "qwerty12345");
            //var account2 = new Account<Guid>(Guid.NewGuid(), "qwerty12345");
            //var account3 = new Account<Guid>(Guid.NewGuid(), "qwerty12345");


            //Print<int,string>.PrintVal(14,"Hello");
            //PrintSomething(15);
            //PrintSomething(new Person() { Name = "Anna", Surname = "Morozova", Age = 35});
            //PrintSomething(14.45m);


            //Animal animal = new Animal() { Name = "Barsik" };
            //// Animal animal1 = (Animal)animal.Clone();
            //Animal animal1 = animal;

            //animal1.Name = "Bobik";

            //Console.WriteLine(animal);
            //Console.WriteLine(animal1);


            //WorkWithDB(new PostgreeSQL() { Connection = "Connection string"});

            //Console.WriteLine();

            //Person person = new Person();
            //person.Name = "Aftandil";
            //person.Surname = "Mammadov";
            //person.Age = 35;

            //WriteToDB(person, new MySQL() { Connection = "Connection string" });

        }
    }
}
