using System;
using System.Collections.Generic;
using System.IO;

namespace Single_Responsibility_Principle
{
    class Phone
    {
        public string Model { get; set; }
        public decimal Price { get; set; }
    }

    interface IReader
    {
        string[] GetInputData();
    }

    class PhoneReader : IReader
    {
        public string[] GetInputData()
        {
            string[] data = new string[2];
            Console.WriteLine("Input Model: ");
            data[0] = Console.ReadLine();
            Console.WriteLine("Input Price: ");
            data[1] = Console.ReadLine();
            return data;
        }
    }

    interface IBinder<T>
    {
        T CreateItem(string[] data);
    }

    class PhoneBinder : IBinder<Phone>
    {
        public Phone CreateItem(string[] data)
        {
            return new Phone()
            {
                Model = data[0],
                Price = decimal.Parse(data[1])
            };
        }
    }

    interface IValidator<T>
    {
        bool IsValid(T item);
    }

    class PhoneValidator : IValidator<Phone>
    {
        public bool IsValid(Phone item)
        {
            return item.Price > 0 && !string.IsNullOrEmpty(item.Model);
        }
    }

    interface ISaver<T>
    {
        void Save(T item, string path);
    }

    class PhoneSaver : ISaver<Phone>
    {
        public void Save(Phone item, string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(item.Model);
                sw.WriteLine(item.Price);
            }
        }
    }

    class PhoneStore
    {
        private IReader reader;
        private IBinder<Phone> binder;
        private IValidator<Phone> validator;
        private ISaver<Phone> saver;

        public PhoneStore(IReader reader, IBinder<Phone> binder, IValidator<Phone> validator, ISaver<Phone> saver)
        {
            this.reader = reader;
            this.binder = binder;
            this.validator = validator;
            this.saver = saver;
        }

        public void Process()
        {
            string[] data = reader.GetInputData();
            var phone = binder.CreateItem(data);
            if (validator.IsValid(phone))
            {
                saver.Save(phone, "store.txt");
            }
        }
    }

    //class PhoneStore
    //{
    //    private List<Phone> phones = new List<Phone>();
    //    public void Process()
    //    {
    //        Console.WriteLine("input model: ");
    //        string model = Console.ReadLine();
    //        Console.WriteLine("Input price: ");
    //        bool result = decimal.TryParse(Console.ReadLine(), out decimal price);

    //        if (result == false || price <= 0 || String.IsNullOrEmpty(model))
    //        {
    //            Console.WriteLine("Incorrect input!");
    //        }
    //        else
    //        {
    //            phones.Add(new Phone() { Model = model, Price = price });
    //            using (StreamWriter sw = new StreamWriter("store.txt"))
    //            {
    //                sw.WriteLine(model);
    //                sw.WriteLine(price);
    //            }
    //            Console.WriteLine("Succesfully Complited!");
    //        }
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    
    interface IPrint
    {
        void Print(string text);
    }

    class ConsolePrint : IPrint
    {
        public void Print(string text)
        {
            Console.WriteLine("Text of Report: ");
            Console.WriteLine(text);
        }
    }

    class Report
    {
        public string Text { get; set; }
        public void GoToFirstPage() { }
        public void GoToLastPage() { }
        public void GoToPage(int page) { }

        public void Print(IPrint printer)
        {
            printer.Print(Text);
        }
    }

    //class Report
    //{
    //    public string Text { get; set; }
    //    public void GoToFirstPage() { }
    //    public void GoToLastPage() { }
    //    public void GoToPage(int page) { }

    //    public void Print()
    //    {
    //        Console.WriteLine("Text of Report: ");
    //        Console.WriteLine(Text);
    //    }
    //}
}
