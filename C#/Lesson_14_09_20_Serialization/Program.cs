using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Xml.Serialization;

namespace Lesson_14_09_20_Serialization
{
    [Serializable] // Atribute
    public class Person 
    {
        public Person()
        {

        }
        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }


        public override string ToString()
        {
            return $"{Name} {Surname} {Age}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            //using (FileStream fs = new FileStream("log.txt", FileMode.Create))
            //{
            //    using (StreamWriter sw = new StreamWriter(fs))
            //    {
            //        for (int i = 0; i < 10; i++)
            //        {
            //            Thread.Sleep(1000);
            //            sw.Write(DateTime.Now + "\n");
            //            Console.WriteLine(DateTime.Now);
            //        }
            //    }
            //}


            // Binary, XML, SOAP, JSON


            // JSON

            //string peopleText = File.ReadAllText("people.json");
            //var people = JsonSerializer.Deserialize<List<Person>>(peopleText);

            //foreach (var item in people)
            //{
            //    Console.WriteLine(item);
            //}

            //string personText = File.ReadAllText("person.json");
            //Person person = JsonSerializer.Deserialize<Person>(personText);

            //Console.WriteLine(person);

            //var list = new List<Person>()
            //{
            //    new Person("Mammad","Aliev",24),
            //    new Person("Ali","Taghiyev",27),
            //    new Person("Seymur", "Gafarov", 14),
            //    new Person("Idris", "Ismayilov", 4)
            //};


            //File.WriteAllText("people.json", JsonSerializer.Serialize(list));

            //var person = new Person("Mammad", "Aliev", 24);

            //string jsonText =  JsonSerializer.Serialize(person);

            //Console.WriteLine(jsonText);

            //File.WriteAllText("person.json", jsonText);


            // XML

            //XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Person>));
            //using (FileStream fs = new FileStream("people.xml", FileMode.Open))
            //{
            //    List<Person> list = xmlSerializer.Deserialize(fs) as List<Person>;

            //    foreach (var item in list)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            //var list = new List<Person>()
            //{
            //    new Person("Mammad","Aliev",24),
            //    new Person("Ali","Taghiyev",27),
            //    new Person("Seymur", "Gafarov", 14),
            //    new Person("Idris", "Ismayilov", 4)
            //}

            //XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Person>));

            //using (FileStream fs = new FileStream("people.xml", FileMode.Create))
            //{
            //    xmlSerializer.Serialize(fs, list);
            //}

            //XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));

            //using (FileStream fs = new FileStream("person.xml", FileMode.Open))
            //{
            //    Person person = xmlSerializer.Deserialize(fs) as Person;
            //    Console.WriteLine(person);
            //}

            //var person = new Person("Mammad", "Aliev", 24);

            //XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));

            //using (FileStream fs = new FileStream("person.xml", FileMode.Create))
            //{
            //    xmlSerializer.Serialize(fs,person);
            //}

            // Binary


            //BinaryFormatter formatter = new BinaryFormatter();
            //using (FileStream fs = new FileStream("people.bin", FileMode.Open))
            //{
            //   List<Person> list =  formatter.Deserialize(fs) as List<Person>;

            //    foreach (var item in list)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}



            //var list = new List<Person>()
            //{
            //    new Person("Mammad","Aliev",24),
            //    new Person("Ali","Taghiyev",27),
            //    new Person("Seymur", "Gafarov", 14),
            //    new Person("Idris", "Ismayilov", 4)
            //};

            //BinaryFormatter formatter = new BinaryFormatter();

            //using (FileStream fs = new FileStream("people.bin", FileMode.Create))
            //{
            //    formatter.Serialize(fs, list);
            //}



            //BinaryFormatter formatter = new BinaryFormatter();
            //Person person;

            //using (FileStream fs = new FileStream("person.bin", FileMode.Open))
            //{
            //    person = formatter.Deserialize(fs) as Person;
            //}

            //Console.WriteLine(person);
            //Console.WriteLine(person.Age);

            //var person = new Person("Mammad", "Aliev", 24);
            //BinaryFormatter formatter = new BinaryFormatter();

            //using (FileStream fs = new FileStream("person.bin", FileMode.Create))
            //{
            //    formatter.Serialize(fs, person);
            //}


            //using (FileStream fs = new FileStream("people.txt", FileMode.Open))
            //{
            //    using (StreamReader sr = new StreamReader(fs))
            //    {
            //        while (!sr.EndOfStream)
            //        {
            //            Console.WriteLine(sr.ReadLine());
            //        }                    
            //    }
            //}

            //var list = new List<Person>()
            //{
            //    new Person("Mammad","Aliev",24),
            //    new Person("Ali","Taghiyev",27),
            //    new Person("Seymur", "Gafarov", 14),
            //    new Person("Idris", "Ismayilov", 4)
            //};

            //using(FileStream fs = new FileStream("people.txt", FileMode.Create))
            //{
            //    using (StreamWriter sw = new StreamWriter(fs))
            //    {
            //        foreach (var item in list)
            //        {
            //            sw.WriteLine(item);
            //        }
            //    }
            //}


            //FileStream fs = new FileStream("people.txt", FileMode.Create);
            //foreach (var item in list)
            //{
            //    byte[] yazilasi = Encoding.UTF8.GetBytes(item.ToString() + "\n");
            //    fs.Write(yazilasi, 0, yazilasi.Length);
            //}
            //fs.Close();

            //var person = new Person("Aftandil","Mammadov",35);
            //File.WriteAllText("person.txt",person.ToString());

            //string someText = "Hello World!";

            //FileStream fs = new FileStream("person.txt",FileMode.Create);

            //byte[] buffer = Encoding.UTF8.GetBytes(someText);
            //fs.Write(buffer,0,buffer.Length);

            ////fs.Flush();
            ////fs.Close();
            //    FileStream fs = new FileStream("person.txt", FileMode.Open);
            //try
            //{
            //    byte[] buffer = new byte[30];
            //    fs.Read(buffer, 0, 30);

            //    string text = Encoding.UTF8.GetString(buffer);
            //    Console.WriteLine(text);

            //}
            //finally
            //{
            //    fs.Close();
            //}

            //using (FileStream fs = new FileStream("person.txt", FileMode.Open))
            //{
            //    byte[] buffer = new byte[30];
            //    fs.Read(buffer, 0, 30);

            //    string text = Encoding.UTF8.GetString(buffer);
            //    Console.WriteLine(text);
            //} // Dispose called (Close)




        }
    }
}
