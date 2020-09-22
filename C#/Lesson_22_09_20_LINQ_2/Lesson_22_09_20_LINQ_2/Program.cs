using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
using System.Diagnostics.CodeAnalysis;

namespace Lesson_22_09_20_LINQ_2
{
    class CompareByName : IEqualityComparer<Person>
    {
        public bool Equals(Person x, Person y)
        {
            return x.FirstName == y.FirstName;
        }

        public int GetHashCode(Person obj)
        {
            return obj.FirstName.GetHashCode() + obj.LastName.GetHashCode();
        }
    }

    class CompareByDate : IEqualityComparer<Person>
    {
        public bool Equals(Person x, Person y)
        {
            return x.DateOfBirth == y.DateOfBirth;
        }

        public int GetHashCode(Person obj)
        {
            return obj.DateOfBirth.GetHashCode();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string data = File.ReadAllText("Data1.json");
            var people = JsonConvert.DeserializeObject<List<Person>>(data);

            List<int> list1 = new List<int>() { 1, 2, 3, 4, 5, 11, 4, 1 };
            List<int> list2 = new List<int>() { 1, 9, 3, 0, 5, 7, 8, 3, 9 };

            // LINQ Query Syntax

            var list = from x in people
                       orderby x.Salary
                       select x;



            //var list = people.Where(s => s.Country == "Azerbaijan");

                       //var list = from s in people
                       //           where s.Country == "Azerbaijan"
                       //           select s;

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            // var newList =  list1.Concat(list2);
            // var newList = list1.Distinct();
            //var newList = list1.Union(list2);
            // var newList = list1.Concat(list2).Distinct();

            // var newList = list1.Intersect(list2);

            //var newList = list1.Except(list2);

            //foreach (var item in newList)
            //{
            //    Console.WriteLine(item);
            //}

            //Person person = new Person() { FirstName = "Brittany", LastName = "Gllafsdfdsyzer", };
            //Person person = new Person() { DateOfBirth = DateTime.Parse("10.10.1963") };

            //Console.WriteLine(people.Contains(person, new CompareByDate()));

            //var groups = people.GroupBy(x => x.Country).OrderBy(x => x.Key);

            //foreach (var item in groups)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var person in item)
            //    { 
            //        Console.WriteLine($"\t{person}");
            //    }
            //}


            //var newList = people.Where(x => x.Country == "Azerbaijan").ToDictionary(x => x.ID);

            //foreach (var item in newList)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine();
            //Console.WriteLine(newList[77]);

            //var newList = people.Where(x => x.Country == "Azerbaijan");
            //                    .Select(x => new { FullName = $"{x.FirstName} {x.LastName}", x.Salary });

            //foreach (var item in newList)
            //{

            //    Console.WriteLine($"{item.FullName} {item.Salary}");
            //}

            //Console.WriteLine(people.Single(x => x.FirstName == "Georgie"));
            //Console.WriteLine(people.Single(x => x.FirstName == "Georgiedsds"));


            //Console.WriteLine(people.SingleOrDefault(x => x.Country == "Azerbaijan"));
            //Console.WriteLine(people.SingleOrDefault(x => x.Country == "Azerbaijani"));


            //var newList = people.Where(x => x.Salary > 7000).TakeLast(5);

            //var newList = people.TakeWhile(x => x.Salary > 2000);
            //var newList = people.SkipWhile(x => x.Salary < 9000).Take(5);


            //foreach (var item in newList)
            //{
            //    Console.WriteLine(item);
            //}

            //int page = 0;

            //do
            //{
            //    var newList = people.Where(x => x.Salary > 7000).Skip(5 * page).Take(5);

            //    foreach (var item in newList)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    page++;
            //    Console.ReadKey(true);
            //    Console.Clear();
            //} while (true);

            ///////////////*************   Deferred Execution *******************\\\\\\\\\\\\\\\ 

            // var newPeople = people.Where(x => x.JobTitle == "Programmer III").ToList();
            //// var newPeople = people.Where(x => x.JobTitle == "Programmer III");


            // foreach (var item in newPeople)
            // {
            //     Console.WriteLine(item);
            // }
            //  people.RemoveAt(192);

            // Console.WriteLine();
            // foreach (var item in newPeople)
            // {
            //     Console.WriteLine(item);
            // }

            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 7, 8 };

            //var newList =  list.OrderByDescending(x => x).ToList();
            //foreach (var item in newList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(list.First(x => x == 3));
            //Console.WriteLine(list.FirstOrDefault(x => x == 13));


        }
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

}
