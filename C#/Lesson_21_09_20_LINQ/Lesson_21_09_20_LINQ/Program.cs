using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;


public class GrpoupOfPeople
{
    public Person[] People { get; set; }
}



public class Person
{
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Gender { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string JobTitle { get; set; }
    public decimal Salary { get; set; }
    public string ShirtSize { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime DateOfBirth { get; set; }
    public override string ToString()
    {
        return $"{ID} {FirstName} {LastName} {Gender} {Country} {City} {JobTitle} {Salary} {ShirtSize} {PhoneNumber} {DateOfBirth.ToShortDateString()}";
    }

}


namespace Lesson_21_09_20_LINQ
{
    class MyClass
    {
        private int MyProperty2 { get; set; }
        public int MyProperty1 { get; set; }
    }
    static class StringExtention
    {
        public static void PrintString(this string str, int count)
        {
            Console.WriteLine(str);
        }
        public static void PrintMyClass(this MyClass my)
        {
            Console.WriteLine(my.ToString());
            my.MyProperty1 = 12;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            //string str = File.ReadAllText("Data.json");
            string str1 = File.ReadAllText("Data1.json");
            Person[] People = JsonConvert.DeserializeObject<Person[]>(str1);

            //Console.WriteLine(People.Length);


            //OrderBy // OrdetByDescending // ThenBy // ThenByDescending

            //var oredered =  People.OrderBy(x => x.Salary).Take(10);
            //var oredered = People.OrderByDescending(x => x.Salary).Skip(10).Take(10);
            var oredered = People.OrderBy(x => (DateTime.Now - x.DateOfBirth).TotalDays / 365).ThenByDescending(x => x.Salary);


            foreach (var item in oredered)
            {
                Console.WriteLine(item);
            }

            //All, Any, Contains

            // Person test = People[10];
            //Console.WriteLine(People.All(x => x.Salary > 7000));
            //Console.WriteLine(People.Any(x => x.Salary > 7000));
            //Console.WriteLine(People.Contains(test));


            // Where, Firs, Last, FirstOrDefault, LastOrDefault

            // var newList = People.Where(x => x.Country == "Azerbaijan");
            //var newList = People.Where(x => x.Salary > 9000).Where(x => x.Country == "Russia");
            //Console.WriteLine(People.First(x => x.Country == "Azerbaijan"));
            //Console.WriteLine();
            //Console.WriteLine(People.Where(x => x.Salary > 9000).FirstOrDefault(x => x.Country == "Azerbaijan"));
            //Console.WriteLine();
            //Console.WriteLine(People.Where(x => x.Salary < 1000).Last(x => x.Country == "China"));

            //var newList = People.Where(x => x.Salary < 1000).Where(x => x.Country == "China");

            //Console.WriteLine();


            //foreach (var item in newList)
            //{
            //    Console.WriteLine(item);
            //}

            // Count , Min, Max, Sum, Avarage

            //Console.WriteLine(People.Count());
            //Console.WriteLine(People.Count(x => x.Salary > 5000));
            //Console.WriteLine(People.Count(x => x.Country == "Azerbaijan" ));

            //Console.WriteLine(People.Min(x => x.Salary));
            //Console.WriteLine(People.Min(x => x.DateOfBirth).ToShortDateString());
            //Console.WriteLine(People.Max(x => x.Salary));
            //Console.WriteLine(People.Max(x => x.DateOfBirth).ToShortDateString());

            //Console.WriteLine(People.Sum(x => x.Salary));
            //Console.WriteLine(People.Average(x => x.Salary));





            //var gp = JsonConvert.DeserializeObject<GrpoupOfPeople>(str);


            //Console.WriteLine(gp.People.Length);

            //foreach (var item in gp.People)
            //{
            //    Console.Write(item.ToString() + "    ");
            //    Console.WriteLine(item.Salary);
            //}



            //MyClass m = new MyClass();

            //m.PrintMyClass();

            //string str = "Aftandil";
            //str.PrintString(3);

            //StringExtention.PrintString(str,2);

            // mockaroo.com - site for data generation
        }
    }
}
