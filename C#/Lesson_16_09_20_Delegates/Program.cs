using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Transactions;

namespace Lesson_16_09_20_Delegates
{
    class Program
    {
        delegate void MyDelegate();
        delegate int SomeDelegate(int num1, int num2);

        static int Sum(int num1, int num2) { return num1 + num2; }
        static void Print()
        {
            Console.WriteLine("Something");
        }
        static void PrintSomething(string text)
        { 
            Console.WriteLine($"Print Something {text}");
        }
        static void PrintSomethingElse()
        {
            Console.WriteLine("Print Something Else");
        }

        delegate bool Condition<T>(T num);

        static bool ZeroCheck(int num) { return true; }

        static bool PositiveCheck(int num) { return num > 0; }

        static bool EvenCheck(int num) { return num % 2 == 0; }

        static bool LenthCheck(string str) { return str.Length > 3; }
        static void Filter<T>(T[] arr, /*Condition*/Predicate<T> check)
        {
            if (check == null)
            {
                throw new ArgumentNullException("Predicate chek was null");
            }

            foreach (var item in arr)
            {
                if (check.Invoke(item))
                {
                    Console.WriteLine(item);
                }
            }
        }
        
        static int Foo()
        {
            return 1;
        }

        static string Foo1(int num1, int num2)
        {
            return (num1 + num2).ToString();
        }

        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 12, 3, -34, 7, -9, -12, 56, 89, -1 };

           // //list.ForEach((int num) => num++); // not allowed

           // list.ForEach(( num) => Console.WriteLine(num));

           // if (list.Exists(( num) => num > 90))
           // {
           //     Console.WriteLine("Yes, exist");
           // }
           // else
           // {
           //     Console.WriteLine("No, does not exist");

           // }

           //var newList = list.ConvertAll<int>(( num) => ++num);

           // newList.ForEach(( num) => Console.WriteLine(num));

           // Console.WriteLine( list.Find(( num) => num < -5));
           // Console.WriteLine(list.FindLast(( num) => num < -5));
           // var foundList = list.FindAll(( num) => num < -5);
           // Console.WriteLine();
           // foreach (var item in foundList)
           // {
           //     Console.WriteLine(item);
           // }

           // if (list.TrueForAll((num) => num < 90))
           // {
           //     Console.WriteLine("True for all");
           // }
           // else
           // {
           //     Console.WriteLine("Not true for all");
           // }

            list.ForEach((num) => Console.WriteLine(num));
            Console.WriteLine();
            list.Sort((x, y) => x - y);
            list.ForEach((num) => Console.WriteLine(num));

            Console.WriteLine();
            list.RemoveAll((num) => num < 0);
            list.ForEach((num) => Console.WriteLine(num));

            

            //Predicate<int> predicate = delegate (int num) { return true; };
            // Predicate<int> predicate = delegate (int num) { return num > 30; };
            // Predicate<int> predicate = d => d > 30;
            //Predicate<int> predicate = d =>
            //{
            //    Console.WriteLine("OK");
            //    return d > 30;
            //};


            //Func<int, int, int> Sum = (x, y) => x + y;
            //Func<int> func = () => 0;
            //Action action = () => Console.WriteLine("Action");

            //int[] array = new int[] { 12, 3, -34, 7, -9, -12, 56, 89, -1 };

            ////  Filter(array, delegate (int num) { return num < 30; });
            //// Filter(array, predicate);

            //Filter(array, x => x < -1);


            //Predicate<int> predicate = ZeroCheck;

            //Func<int> func = Foo;
            //Func<int, int, string> func1 = Foo1;

            //Action action = Print;
            //action.Invoke();

            //Action<string> action1 = PrintSomething;
            //action1("hdjsahdajd");


            // Action
            // Func
            // Predicate

            //Condition<int> condition = EvenCheck;
            //condition += ZeroCheck;
            //condition += EvenCheck;


            //int[] array = new int[] { 12, 3, -34, 7, -9, -12, 56, 89, -1 };

            // Filter<int>(array, condition);

            // Filter<int>(array, EvenCheck);

            //string[] strArr = new string[] { "Hello", "Hi", "How", "Excuse", "Ola" };

            //Filter(strArr, LenthCheck);



            //MyDelegate fooDelegate = Print;
            //MyDelegate myDelegate = PrintSomething;

            //MyDelegate newDelegate = fooDelegate + myDelegate;
            //newDelegate();

            // MyDelegate fooDelegate = new MyDelegate(Print);

            //fooDelegate += PrintSomething;
            //fooDelegate += PrintSomethingElse;

            //fooDelegate -= PrintSomething;

            //fooDelegate = PrintSomething;

            // fooDelegate = null;

            // fooDelegate?.Invoke();

            //SomeDelegate someDelegate = Sum;
            //int num = someDelegate(12,13);

            //fooDelegate.Invoke();
            // fooDelegate();            

        }
    }
}
