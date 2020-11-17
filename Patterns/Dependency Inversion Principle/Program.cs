using System;

namespace Dependency_Inversion_Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    
    interface IPrinter
    {
        void Print(string text);
    }

    class Printer : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }

    class HTMLPrinter : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine($"<HTML>{text}</HTML>");
        }
    }

    class Book
    {
        public string Title { get; set; }
        public string Text { get; set; }
        
        public void Print(IPrinter printer)
        {
            printer.Print(Text);
        }
    }
}
