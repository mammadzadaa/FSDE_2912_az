using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Template_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            TxtDataReader txtDataReader = new TxtDataReader();
            var total = txtDataReader.GetProductsTotalPrice("products.txt");
            Console.WriteLine(total);

            CsvDataReader csvDataReader = new CsvDataReader();
            var sum = csvDataReader.GetProductsTotalPrice("products.csv");
            Console.WriteLine(sum);
        }
    }

    class Product
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
    }

    abstract class DataReader
    {
        public abstract IEnumerable<Product> ReadProductsFromFile(string path);

        public virtual decimal GetProductsTotalPrice(string path)
        {
            var products = ReadProductsFromFile(path);
            return products.Sum(x => x.Price);
        }
    }

    class TxtDataReader : DataReader
    {
        public override IEnumerable<Product> ReadProductsFromFile(string path)
        {
            List<Product> products = new List<Product>();
            var lines = File.ReadAllLines(path);
            foreach (var line in lines)
            {
                var item = line.Split(':');
                products.Add(new Product()
                {
                    Title = item[0],
                    Price = decimal.Parse(item[1])
                }) ;
            }
            return products;
        }
    }

    class CsvDataReader : DataReader
    {
        public override IEnumerable<Product> ReadProductsFromFile(string path)
        {
            List<Product> products = new List<Product>();
            var lines = File.ReadAllLines(path);
            foreach (var line in lines)
            {
                var item = line.Split(',');
                products.Add(new Product()
                {
                    Title = item[0],
                    Price = decimal.Parse(item[1])
                });
            }
            return products;
        }
    }
}
