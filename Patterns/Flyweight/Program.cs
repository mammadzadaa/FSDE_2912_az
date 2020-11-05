using System;
using System.Net.Http.Headers;

namespace Flyweight
{

    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                MovieSearcher searcher = new MovieSearcher();
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
