using System;
using System.Globalization;
using System.Text;

namespace Lesson_03_09_20_Class
{
    //class Account
    //{
    //    public string name;
    //    public string surname;
    //}

    struct MyStruct
    {
        public MyStruct(int num)
        {
            MyProperty = num;
        }
        public int MyProperty { get; set; }
        public void Foo()
        {

        }

    }

    class Person
    {
        public Person() //ctor
        {

        }

        ~Person() { }
        public Person(string name, string surname) : this(name, surname, "N/A", 0, 0) { }

        public Person(string name, string surname, string country, int age, int height)
        {
            this.name = name;
            this.surname = surname;
            Country = country;
            Age = age;
            Height = height;
        }

        private string name;
        private string surname;

        public string Country { get; set; } // prop

        private int age;
        
        public int Age // propfull
        {
            get { return age; }
            set
            {
                if (value >= 0 && value <= 100)
                    age = value;
                else
                    age = 0;
            }
        }

        private int height;

        public int Height
        {
            get { return height; }
            private set { height = value; }
        }

        public void SetHeigh(int height)
        {
            this.Height = height;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public void SetSurname(string surname)
        {
            this.surname = surname;
        }
        public string GetSurname()
        {
            return surname;
        }


    }

    class Program
    {


        static void Main(string[] args)
        {
            MyStruct a = new MyStruct(10);
            Console.WriteLine(a.MyProperty);
            Console.WriteLine();

            Person person = new Person();

            person.SetName("Aftandil");
            person.SetSurname("Mammadov");
            person.Age = 25;
            person.SetHeigh(170);
            person.Country = "Azerbaijan";

            Console.WriteLine($"Name: {person.GetName()} \nSurname: {person.GetSurname()} " +
                $"\nAge: {person.Age} \nHeight: {person.Height} \nCountry: {person.Country}");

            Person person1 = new Person("Israfil","Abiyev","Georgia",45,165);

            Console.WriteLine();
            Console.WriteLine($"Name: {person1.GetName()} \nSurname: {person1.GetSurname()} " +
                $"\nAge: {person1.Age} \nHeight: {person1.Height} \nCountry: {person1.Country}");

            Person person2 = new Person("Mammad", "Salmani");

            Console.WriteLine();
            Console.WriteLine($"Name: {person2.GetName()} \nSurname: {person2.GetSurname()} " +
                $"\nAge: {person2.Age} \nHeight: {person2.Height} \nCountry: {person2.Country}");

            //StringBuilder stringBuilder = new StringBuilder();
            //while (true)
            //{
            //    ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);

            //    if (consoleKeyInfo.Key == ConsoleKey.Enter)
            //    {
            //        break;
            //    }

            //    if (consoleKeyInfo.Key == ConsoleKey.Backspace)
            //    {
            //        stringBuilder.Remove(stringBuilder.Length - 1,1);
            //        Console.Write("\b \b");                     
            //    }
            //    else
            //    {
            //        stringBuilder.Append(consoleKeyInfo.KeyChar);
            //        Console.Write('*');        
            //    }

            //}
            //Console.WriteLine();
            //Console.WriteLine(stringBuilder);

            //string str = "1234567890qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";

            //Random random = new Random();
            //StringBuilder s = new StringBuilder(10);

            //for (int i = 0; i < 10; i++)
            //{
            //    s.Append(str[random.Next(0, str.Length)]);
            //}
            //string password = s.ToString();
            //Console.WriteLine(password);

            //Account[] accounts = new Account[10];
            //accounts[0] = new Account();
            //accounts[0].name = "Aftandil";
            //accounts[0].surname = "Mammadov";

            //Console.WriteLine($"Name: {accounts[0].name} \nSurname: {accounts[0].surname}");

            //StringBuilder str = new StringBuilder();
            //Console.WriteLine(str.Length);
            //Console.WriteLine(str.Capacity);
            //Console.WriteLine();
            //str.Append("Step IT Academy. ");
            //Console.WriteLine(str.Length);
            //Console.WriteLine(str.Capacity);
            //Console.WriteLine();
            //str.Append("Programming is cool, especially C# programming language with .NET!");
            //str.Append("Step IT Academy. ");


            //Console.WriteLine(str.Length);
            //Console.WriteLine(str.Capacity);
            //Console.WriteLine();
            //string s = str.ToString();
            //Console.WriteLine(s);

            //string str = "Memmedov Mirmmed Mirish";

            //var s = str.Split(' ');
            //string ad = s[1];
            //string soyAd = s[0];
            //string ataAdi = s[2];

            //Console.WriteLine($"Ad: {ad} \nSoyad: {soyAd} \nAta Adi{ataAdi}");

        }
    }
}
