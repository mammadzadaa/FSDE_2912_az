using System;
using System.IO;
using System.Threading;

namespace Lesson_07_09_20_Exceptions_Indexers
{
    class Program
    {
        class MyArray
        {
            public int Size { get; }
            public MyArray(int size)
            {
                Size = size;
                arr = new int[Size];
            }
            private int[] arr;
            public int this[int index]
            {
                get => arr[index];
                set => arr[index] = value;
            }
        }

        class Dictionary
        {
            public string this[string index]
            {
                get 
                {
                    return index switch
                    {
                        "Uno" => "One",
                        "Dos" => "Two",
                        "Tres" => "Tree",
                        "Quatro" => "Four",
                        _ => "There is no such a word in the dictionary",
                    };
                }
            }
        }

        public static void Foo() => Console.WriteLine("Some text");
        public static int Foo(int x, int y) => x + y;

        public enum Colour : ushort
        {
            Red = 1, Blue, Green
        }

        public enum Cins : byte
        {
            Kishi = 1, Qadin
        }
        class Person 
        {
            public Person(string name, string surname, Cins cins)
            {
                Name = name;
                Surname = surname;
                Cins = cins;
            }

            public string Name { get; set; }
            public string Surname { get; set; }
            public Cins Cins { get; set; }

            public override string ToString()
            {
                return $"{Name} {Surname} is {Cins}";
            }
        }
        struct Point 
        {
            public int X { get; set; }
            public int Y { get; set; }

            public void Foo() { }

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

        }
        static void Main(string[] args)
        {
            DateTime begin = DateTime.Now;
            int a = 1;
            for (int i = 0; i < 10000000; i++)
            {
                a++;
            }
            DateTime end = DateTime.Now;

            TimeSpan time = end.Subtract(begin);

            Console.WriteLine(time.TotalMilliseconds);




            //Thread.Sleep(1500);
            //while(true)
            //{
            //    Thread.Sleep(500);
            //    Console.Clear();
            //    Console.WriteLine(DateTime.Now);
            //}
            //DateTime dateTime = DateTime.Now;
            //Console.WriteLine(dateTime.ToString());

            //Point p = new Point();


            // Console.Write("Enter name: ");
            // string name = Console.ReadLine();
            // Console.Write("Enter surname: ");
            // string surname = Console.ReadLine();
            // Console.WriteLine("Enter your sex (Kishi, Qadin) : ");

            //if(Enum.TryParse(typeof(Cins),Console.ReadLine(),out object cins))
            // {
            //     Person person = new Person(name, surname, (Cins)cins);

            //     Console.WriteLine(person);
            // }
            // else
            // {
            //     Console.WriteLine("Invalid input");
            // }



            //Console.Write("Enter name: ");
            //string name = Console.ReadLine();
            //Console.Write("Enter surname: ");
            //string surname = Console.ReadLine();
            //Console.WriteLine("Enter your sex (Male = 1, Female = 2) : ");
            //Cins cins = (Cins)int.Parse(Console.ReadLine());

            //Person person = new Person(name,surname,cins);

            //Console.WriteLine(person);






            // Colour colour = Colour.Red;
            // Console.WriteLine(colour);

            //Foo();
            //Dictionary dictionary = new Dictionary();

            //Console.WriteLine(dictionary[Console.ReadLine()]);

            //int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            //Console.WriteLine(arr[1]);

            //MyArray my = new MyArray(5);
            //my[0] = 5;
            //my[1] = 10;

            //Console.WriteLine($"{my[0]} and {my[1]}");

            //int num = int.MaxValue;

            //Console.WriteLine(++num);

            //unchecked
            //{
            //    Console.WriteLine(++num);
            //}

            //checked
            //{
            //  Console.WriteLine(++num);
            //}

            //int num = 5;
            //try
            //{
            //    Console.WriteLine("Some code");
            //    throw new Exception("My exception");
            //}
            ////catch when (num < 3)
            ////{
            ////    Console.WriteLine("Caught Exception");
            ////}
            //catch(Exception ex) when (num > 3)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //try
            //{
            //    string filePath = Console.ReadLine();
            //    File.WriteAllText(filePath,null);
            //}
            //catch (NotSupportedException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch(DirectoryNotFoundException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (ArgumentNullException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Code that will work anyway!");
            //}

            //DirectoryNotFoundException
            // NotSupportedException
            // ArgumentNullException // inheritated from ArgumentException
            // ArgumentException 

            // throw new Exception("Message of exception");

            //int a = 5;
            //int b = 0;
            //double a = 5;
            //double b = 0;

            //try
            //{
            //   Console.WriteLine(a / b);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

        }
    }
}
