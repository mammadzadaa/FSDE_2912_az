using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;

namespace Lesson_18_09_20_Collections_Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            //Regex regex = new Regex("^Step"); // ^ - begins with
            //Regex regex = new Regex("Step$"); // $ - ends with
            //Regex regex = new Regex("^[A-z]"); // [A - z] - one character is between

            Regex regex = new Regex(@"^C[0-9]{8}$");
            Regex regex1 = new Regex(@"^P[0-9]{7}$");

            string input;
            do
            {
                Console.WriteLine("Enter your Azerbaijani Pasport Number: ");
                input = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine();

            } while (!(regex.IsMatch(input) || regex1.IsMatch(input)));

            Console.WriteLine("Paspotr Number OK");





            //Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            //string input;
            //do
            //{
            //    Console.WriteLine("Enter your mail: ");
            //    input = Console.ReadLine();
            //    Console.WriteLine();

            //    Console.WriteLine();
            //    Console.WriteLine(regex.IsMatch(input));

            //} while (!regex.IsMatch(input));

            //Console.WriteLine("Mail OK");

            //Regex regex = new Regex(@"^\+([0-9]{3}) ([0-9]{2}) ([0-9]{7})$");
            //string input;
            //do
            //{
            //    Console.WriteLine("Enter your number: ");
            //    input = Console.ReadLine();
            //    Console.WriteLine();

            //    Console.WriteLine();
            //    Console.WriteLine(regex.IsMatch(input));

            //} while (!regex.IsMatch(input));

            //Console.WriteLine("Number OK");

            //Console.Write("Input your text: ");

            //string input = Console.ReadLine();
            //Console.WriteLine();

            //Console.WriteLine(regex.IsMatch(input));



            //Non-generic

            //ArrayList list = new ArrayList();
            //list.Add(12);
            //list.Add("Salam");
            //list.Add(23.54m);

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //Generic
            //List<int> list = new List<int>();                   // dynamic array
            //LinkedList<int> linkedList = new LinkedList<int>(); // double linked list
            //LinkedListNode<int> node = linkedList.First;
            //Queue<int> queue = new Queue<int>();                // queue
            //Stack<int> stack = new Stack<int>();                // stack

            //ObservableCollection<int> observable = new ObservableCollection<int>();

            //Dictionary<int, string> dictionary = new Dictionary<int, string>(); // hash table
            //HashSet<int> hashSet = new HashSet<int>();                          // hash table

            //SortedList<int,string> sortedList = new SortedList<int,string>();                       // array
            //SortedDictionary<int, string> sortedDictionary = new SortedDictionary<int, string>();   // tree
            //SortedSet<int> sortedSet = new SortedSet<int>();                                        // tree
        }
    }
}
