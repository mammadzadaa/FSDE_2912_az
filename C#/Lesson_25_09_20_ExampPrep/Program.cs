using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using MyLIb;
using ServiceStack.Text;
//using coll = System.Collections;


namespace Lesson_25_09_20_ExampPrep
{
    //class Person<T>
    //{
    //    public string Name { get; set; }
    //    public string Surname { get; set; }

    //}
    static class Extentions
    {
        public static void Print(this string str)
        {
            Console.WriteLine(str);
        }
    }
    public class BaseClass
    {
        public BaseClass(int num)
        {
            Console.WriteLine("Base class ctor");
        }
    }
    public partial class MyClass : BaseClass
    {
        public static int num;
        public static void Foo()
        {

        }
        public MyClass() : base(0)
        {
            Console.WriteLine("Default ctor");
        }
        public MyClass(int num)  : this()
        {
            Console.WriteLine("Ctor with param");
        }
        static MyClass()
        {
            Console.WriteLine("Static ctor");
        }
        public int MyProperty { get; set; }

    }
    public partial class MyClass : BaseClass,IEnumerable
    {
        //public object this[int index]
        //{
        //    get { /* return the specified index here */ }
        //    set { /* set the specified index to value here */ }
        //}
        public int MyProperty1 { get; set; }

        private int myVar;

        public int MyProperty2
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < 10; i++)
            {
                yield return i;
            }
            yield break;

        }
    }
        struct MyStruct 
    {
        public MyStruct(int x, int y)
        {
            MyProperty = x;
            MyProperty1 = y;
        }
        public void Foo() { }
        public int MyProperty { get; set; } 
        public int MyProperty1 { get; set; } 
    }
    enum MyEnum : ushort
    {
        Red, Blue, Green
    }
    abstract class Base
    {
        public abstract void Func();
        public virtual void Foo()
        {

        }
        public virtual void Function()
        {

        }
    }
    abstract class Derived : Base
    {
        public new void Function()
        {
        }
        public override sealed void Foo()
        {
            base.Foo();
        }

        public abstract void Func1();

    }
    class D : Derived
    {
        //public override void Foo()
        //{
        //    base.Foo();
        //}
        public override void Func()
        {
            throw new NotImplementedException();
        }

        public override void Func1()
        {
            throw new NotImplementedException();
        }
    }
    interface IA
    {
        public void Foo();
    }
    interface IB
    {
        public void Foo();
    }
    class AB : IA, IB, IComparable, IEquatable<AB>, IDisposable, ICloneable, ICollection, IConvertible, IEnumerable,IEqualityComparer
    {
        public int Count => throw new NotImplementedException();

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public new bool Equals(object x, object y)
        {
            throw new NotImplementedException();
        }

        public bool Equals([AllowNull] AB other)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int GetHashCode(object obj)
        {
            throw new NotImplementedException();
        }

        public TypeCode GetTypeCode()
        {
            throw new NotImplementedException();
        }

        public bool ToBoolean(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public byte ToByte(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public char ToChar(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public DateTime ToDateTime(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public decimal ToDecimal(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public double ToDouble(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public short ToInt16(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public int ToInt32(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public long ToInt64(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public sbyte ToSByte(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public float ToSingle(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public string ToString(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public object ToType(Type conversionType, IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public ushort ToUInt16(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public uint ToUInt32(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public ulong ToUInt64(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        void IB.Foo()
        {
            Console.WriteLine("IB");
        }

        void IA.Foo()
        {
            Console.WriteLine("IA");
        }
    }
    delegate void MyDelegate(int a, int b);
    class MyClass1
    {
        public event MyDelegate MyEvent;
        public void SomeAction()
        {
            MyEvent?.Invoke(1,2);
        }

    }

    [Serializable]
    class Person
    {
        public Person()
        {
            Console.WriteLine("Was called");
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public ushort Age { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname} {Age}";
        }
    }


    
    class Program
    {     
        public static ref int Func(ref int p)
        {            
            return ref p;
        }
        public static void Foo<T>() where T : class, IEnumerable, new()
        {
            T val = new T();
            val.GetEnumerator();
        }
        static void Main(string[] args)
        {
            dynamic d = 12;
            d = "dsadad";
            Console.WriteLine(d.ToUpper());
            d = new { Name = "Ad", Surname = "Soyad" };

            Console.WriteLine(d.Name);


            //Regex r = new Regex(@"\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})");
            //Match m = r.Match("32132131312");
            //if (m.Success)
            //{
            //    Console.WriteLine("Success");
            //}

            //Lazy<Person> lp = new Lazy<Person>();
            //Console.WriteLine("Start");
            //lp.Value.Name = "Aftandil";

            //int[] arr = new int[] { 1, 2, 3, 4, 5, 7 };

            //Span<int> s = new Span<int>(arr);

            //foreach (var item in s.Slice(0,3))
            //{
            //    Console.WriteLine(item);
            //}

            //FileStream fs = new FileStream("text.txt",FileMode.Create);

            //StreamReader sr = new StreamReader(fs);
            //StreamWriter sw = new StreamWriter(fs);
            //BinaryReader br = new BinaryReader(fs);
            //BinaryWriter bw = new BinaryWriter(fs);

            //MemoryStream ms = new MemoryStream();

            //List<Person> list = new List<Person>();
            //list.Add(new Person() { Name = "Aftandil", Surname = "Mammadov", Age = 35 });
            //list.Add(new Person() { Name = "Israfil", Surname = "Mahmudov", Age = 45 });
            //list.Add(new Person() { Name = "Akif", Surname = "Quliyev", Age = 47 });

            //string str = CsvSerializer.SerializeToCsv<Person>(list);

            //Console.WriteLine(str);

            //var newList = CsvSerializer.DeserializeFromString<List<Person>>(str);

            //foreach (var item in newList)
            //{
            //    Console.WriteLine(item);
            //}

            //MyClass1 my = new MyClass1();

            //my.MyEvent += (x, y)=>{ };





            //IA ab = new AB();
            //ab.Foo();

            //IEnumerable enumer;
            //Derived d;

            //try
            //{
            //    throw new Exception();
            //}
            //catch(FileNotFoundException ex)
            //{

            //}
            //catch (Exception)
            //{
            //    throw;
            //}
            //finally
            //{

            //}

            //string s = "Some text";
            //s.Print();

            //coll.ArrayList;
            //MyClass.Foo();
            //MyClass.num = 12;
            // MyClass my = new MyClass(12);


            //MyClass my1 = new MyClass();

            //string s = "";
            //StringBuilder sb = new StringBuilder(100);
            //for (int i = 0; i < 100; i++)
            //{
            //    //s += i.ToString();
            //    sb.Append(i.ToString());
            //}

            //Console.WriteLine(sb.ToString());

            //MyClass a = new MyClass();
            //MyClass b = new MyClass();

            //Console.WriteLine(a.GetHashCode());
            //Console.WriteLine(b.GetHashCode());

            //MyStruct c = new MyStruct(1,2);
            //MyStruct d = new MyStruct(4,7);

            //Console.WriteLine(c.GetHashCode());
            //Console.WriteLine(d.GetHashCode());




            //MyEnum e = MyEnum.Blue;

            //Func(1, 2, 3, 4, 5, 7);

            //Foo3(out int num);

            //int n = 3;
            ////Foo1(ref n);
            ////n = null;

            //int? number = null ;
            //Nullable<int> nullable = new Nullable<int>(10);

            //int? j = number ?? 0;
            //Console.WriteLine(j);

            //Console.WriteLine(number?.ToString());

            //object o = n;
            //n++;
            //Console.WriteLine(o);

            //MyStruct s = new MyStruct();
            //s.MyProperty1 = 6;

            //MyClass my = new MyClass();

            //Person p = new Person();
            //Type t = typeof(Person);

            //FieldInfo[] f = t.GetFields();

            //Type t1 = p.GetType();

            //ClassMY cm = new ClassMY();
            //Console.WriteLine("Hello World!");

            //unsafe
            //{
            //    int* ptr = stackalloc int[100];
            //}
        }
        static void Foo1(ref int num)
        {
            num = 5;
        }
        static void Foo2(in int num)
        {
            // num = 5;
        }
        static void Foo3(out int num)
        {
            num = 2;
        }
        static void Func(params int[] arr)
        {

        }
    }
}
