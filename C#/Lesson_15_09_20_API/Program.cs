using System;
using System.IO;
using System.Net;
using System.Text.Json;
// using Newtonsoft.Json;

namespace Lesson_15_09_20_API
{

    public class Movies
    {
        public Search[] Search { get; set; }
        public string totalResults { get; set; }
        public string Response { get; set; }
    }

    public class Search
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string imdbID { get; set; }
        public string Type { get; set; }
        public string Poster { get; set; }
    }


    public class Rootobject
    {
        public Rates rates { get; set; }
        public string @base { get; set; }
        public string date { get; set; }
    }

    public class Rates
    {
        public decimal CAD { get; set; }
        public decimal HKD { get; set; }
        public decimal ISK { get; set; }
        public decimal PHP { get; set; }
        public decimal DKK { get; set; }
        public decimal HUF { get; set; }
        public decimal CZK { get; set; }
        public decimal GBP { get; set; }
        public decimal RON { get; set; }
        public decimal SEK { get; set; }
        public decimal IDR { get; set; }
        public decimal INR { get; set; }
        public decimal BRL { get; set; }
        public decimal RUB { get; set; }
        public decimal HRK { get; set; }
        public decimal JPY { get; set; }
        public decimal THB { get; set; }
        public decimal CHF { get; set; }
        public decimal EUR { get; set; }
        public decimal MYR { get; set; }
        public decimal BGN { get; set; }
        public decimal TRY { get; set; }
        public decimal CNY { get; set; }
        public decimal NOK { get; set; }
        public decimal NZD { get; set; }
        public decimal ZAR { get; set; }
        public decimal USD { get; set; }
        public decimal MXN { get; set; }
        public decimal SGD { get; set; }
        public decimal AUD { get; set; }
        public decimal ILS { get; set; }
        public decimal KRW { get; set; }
        public decimal PLN { get; set; }
    }

    //class ExchangeRate
    //{
    //    public string @base { get; set; }
    //    public DateTime date { get; set; }
    //    public Rates rates { get; set; }
    //}

    //class Rates
    //{
    //    public decimal EUR { get; set; }
    //    public decimal RUB { get; set; }
    //    public decimal TRY { get; set; }
    //    public decimal GBP { get; set; }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            WebClient webClient = new WebClient();

            Console.WriteLine("Input Movie Name:");
            string str = Console.ReadLine();

            string url = "http://www.omdbapi.com/?apikey=2c9d65d5&s=" + str;
            string strResult = webClient.DownloadString(url);

            var result = JsonSerializer.Deserialize<Movies>(strResult);

            if (result.Response == "True")
            {
                foreach (var item in result.Search)
                {
                    Console.WriteLine(item.Title);
                    Console.WriteLine(item.Year);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("No results found!");
            }

            //WebClient webClient = new WebClient();

            //string url = "https://api.exchangeratesapi.io/latest?base=USD";
            //string strResult = webClient.DownloadString(url);

            //var result = JsonSerializer.Deserialize<Rootobject>(strResult);

            //Console.WriteLine(result.@base);
            //Console.WriteLine(result.date);
            //Console.WriteLine();
            //Console.WriteLine(result.rates.EUR);
            //Console.WriteLine(result.rates.GBP);
            //Console.WriteLine(result.rates.TRY);
            //Console.WriteLine(result.rates.RUB);

            //WebClient webClient = new WebClient();

            //Console.WriteLine("Input Movie Name:");
            //string str = Console.ReadLine();

            //string url = "http://www.omdbapi.com/?apikey=2c9d65d5&s=" + str;
            //string result = webClient.DownloadString(url);



            //dynamic resultObject = JsonConvert.DeserializeObject(result);

            //Console.WriteLine(resultObject.ToString());

            //try
            //{
            //    for (int i = 0; i < 5; i++)
            //    {
            //        Console.WriteLine(resultObject.Search[i].Title);
            //        Console.WriteLine(resultObject.Search[i].Year);
            //        Console.WriteLine();
            //    }

            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}



            //dynamic dynamic = 12;
            //Console.WriteLine(dynamic);
            //dynamic = "Aftandil";
            //Console.WriteLine(dynamic.ToUpper());
            //Console.WriteLine(dynamic);
            //dynamic = 12.5m;
            //Console.WriteLine(dynamic.ToUpper());

            //WebClient webClient = new WebClient();

            //string url = "https://api.exchangeratesapi.io/latest?base=USD";
            //string result = webClient.DownloadString(url);

            ////Console.WriteLine(result);

            //dynamic resultObject =  JsonConvert.DeserializeObject(result);

            //try
            //{
            //    Console.WriteLine(resultObject.@base);
            //    Console.WriteLine(resultObject.date);
            //    Console.WriteLine(resultObject.rates.EUR);
            //    Console.WriteLine(resultObject.rates.RUB);
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}


            //WebClient webClient = new WebClient();

            //string url = "https://itstep.org";
            //var result =  webClient.DownloadString(url);

            //Console.WriteLine(result);

            // File.WriteAllText("step.html",result);

        }
    }
}
