using System;
using System.Text;

namespace Lesson_02_09_20_Array_String
{
    struct Point
    {
        public int x;
    }
    class Person 
    {
        public int age;
    }
    class Program
    {
        static void Foo(Point p)
        {
            p.x = 0;
        }
        static void Foo(ref Point p) // ref, out , in
        {
            p.x = 0;
        }

        static void Foo(out int num)
        {
            num = 5; // OUT parametr must be assigned
            //Console.WriteLine(num);
        }

        static void Foo1(in int number)
        {
            Console.WriteLine(number);
            // number = 15; // not allowed with IN parametr
        }
        public enum MyEnum
        {
            Az,Eng, Ru
        }
        static void Main(string[] args)
        {
            //String str = new String("   Aftandil   ");
            //string s = "Israfil";

            //Console.WriteLine(str);
            //Console.WriteLine(str.Length);
            //Console.WriteLine(str.Trim());
            //str = str.ToUpper().Trim();
            //Console.WriteLine(str);
            //string str1 = "AFTANDIL";

            //Console.WriteLine(string.Compare(str, str1));

            //StringBuilder strb = new StringBuilder(str);
            //Console.WriteLine(strb.Capacity);
            //strb.Append(" Mammadov");
            
            

            //int[] arr = new int[10] { 6,3,5,1,9,4,2,8,0,7};
            //Array.Sort(arr);

            //int[] temp = new int[arr.Length + 1];
            //arr.CopyTo(temp, 0);
            //temp[arr.Length] = 10;
            //arr = temp;


            //foreach (var item in arr)
            //{
            //    Console.Write($" {item} ");
            //}

            //int[][] arr = new int[][] { new int[] {1,2,3,4 },
            //                            new int[] {5,6},
            //                            new int[] {7,8,9} };

            //int[][] arr1 = new int[3][] { new int[4] {1,2,3,4 },
            //                            new int[2] {5,6},
            //                            new int[3] {7,8,9} };

            //foreach (var subarr in arr)
            //{
            //    foreach (var item in subarr)
            //    {
            //        Console.Write($" {item} ");
            //    }
            //    Console.WriteLine();
            //}

            //int[,] arr = new int[,] { { 1,2,3},
            //                          { 4,5,6 } };

            //int[,] arr1 = new int[2,3] { { 1,2,3 },
            //                          { 4,5,6 } };

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j <= arr.GetUpperBound(1); j++)
            //    {
            //        Console.Write($" {arr[i,j]} ");
            //    }
            //    Console.WriteLine();
            //}

            //int[,,] arr2 = new int[2, 3, 4]
            //{
            //    { {1,2,3,4 },{ 5,6,7,8 }, { 9,10,11,12 } },
            //    { {13,14,15,16 },{ 17,18,19,20 },{ 21,22,23,24 } }
            //};
            //arr2[1, 2, 3] = 10 ;



            //Console.WriteLine(arr.Length);
            //Console.WriteLine(arr.Rank);
            //Console.WriteLine();
            //Console.WriteLine(arr.GetUpperBound(0));
            //Console.WriteLine(arr.GetLength(0));
            //Console.WriteLine();
            //Console.WriteLine(arr.GetUpperBound(1));
            //Console.WriteLine(arr.GetLength(1));

            //int size = 10;
            //int[] arr = null;
            //int[] arr1 = new int[size];
            //int[] arr2 = new int[] { 1, 2, 3, 4, 5 };
            //int[] arr3 = new int[5] { 1, 2, 3, 4, 5 };

            //foreach (var item in arr3)
            //{
            //    Console.Write($" {item} ");
            //}

            //for (int i = 0; i < arr3.Length; i++)
            //{
            //    Console.Write($"{arr3[i]}, ");
            //}

            //foreach (var item in collection)
            //{
            //}

            //int i = 10;
            //int j = 9;
            //if((j < i++) || (--i == j++))
            //{
            //    Console.WriteLine($"i = {i} and j = {j}"); // i is 11  and j is 9
            //}

            //double d = 2.1;
            //string s = "Az";
            //switch (s)
            //{
            //    case 2.1:
            //        break;
            //    case "Az":
            //        break;
            //    default:
            //        break;
            //}


            //MyEnum enumeration = MyEnum.Az;

            //switch (enumeration)
            //{
            //    case MyEnum.Az:
            //        Console.WriteLine("Azerbaijan");
            //        goto case MyEnum.Ru;                   
            //    case MyEnum.Eng:                    
            //    case MyEnum.Ru:
            //        Console.WriteLine("Foreign");
            //        break;
            //    default:
            //        break;
            //}



            //int num;
            //Foo(out num);
            //Console.WriteLine(num);
            //Foo(out int number);
            //Console.WriteLine(number);
            //Foo1(in number);


            //Point point; // value type, no need for new 
            //// Point point1 = new Point(); // used for calling constructors
            //// Point point1 = null; // not working, NOT reference type
            //point.x = 20;

            //Foo(point);
            //Foo(ref point);

            //Console.WriteLine($"X is {point.x}"); // interpolasiya

            //Person person = new Person(); // reference type requires new for creating an instance
            ////Person person1 = null; // working, reference type
            //person.age = 25;
            ////Person person1 = person;
            ////person1.age = 30;
            //Console.WriteLine($"My age is {person.age}");

        }
    }
}
