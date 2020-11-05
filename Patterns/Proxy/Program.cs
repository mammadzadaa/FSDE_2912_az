using System;
using System.Linq;

namespace Proxy
{
    class Program
    {
            static void Main(string[] args)
            {
                while (true)
                {
                    IMovieSearcher searcher = new LocalMovieSearcher(new GlobalMovieSearcher());
                    Console.Write("Serch: ");
                    ShowMovieData(searcher.SearchByTitle(Console.ReadLine()));
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            public static void ShowMovieData(Movie movie)
            {
                Console.WriteLine($"Country: {movie.Country}\nDirected by: {movie.Director}\n" +
                    $"Genre: {movie.Genre}\nActors: {movie.Actors}\n\n");
            }
    }
    
}
