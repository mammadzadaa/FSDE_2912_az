using System;
using System.Collections;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArrayOfInt myArray = new MyArrayOfInt(5);
            myArray[0] = 1;
            myArray[1] = 2;
            myArray[2] = 3;
            myArray[3] = 4;
            myArray[4] = 5;

            var enumerator = myArray.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
            enumerator.Reset();

        }
    }

    class MyArrayOfInt : IEnumerable
    {
        private int[] array;
        public MyArrayOfInt(int size)
        {
            array = new int[size];
        }
        public int this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

        public class MyArrayOfIntEnumerator : IEnumerator
        {
            int[] array;
            int index = -1;
            public MyArrayOfIntEnumerator(int[] array)
            {
                this.array = array;
            }
            public object Current => array[index];

            public bool MoveNext()
            {
                return array.Length > ++index;
            }

            public void Reset()
            {
                index = -1;
            }
        }
        public IEnumerator GetEnumerator()
        {
            return new MyArrayOfIntEnumerator(array);
        }
    }
}
