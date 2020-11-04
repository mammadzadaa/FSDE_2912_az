using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http.Headers;
using System.Text.Json;

namespace Flyweight
{

    public class Movie
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string Rated { get; set; }
        public string Released { get; set; }
        public string Runtime { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string Writer { get; set; }
        public string Actors { get; set; }
        public string Plot { get; set; }
        public string Language { get; set; }
        public string Country { get; set; }
        public string Awards { get; set; }
        public string Poster { get; set; }
        public Rating[] Ratings { get; set; }
        public string Metascore { get; set; }
        public string imdbRating { get; set; }
        public string imdbVotes { get; set; }
        public string imdbID { get; set; }
        public string Type { get; set; }
        public string DVD { get; set; }
        public string BoxOffice { get; set; }
        public string Production { get; set; }
        public string Website { get; set; }
        public string Response { get; set; }
    }

    public class Rating
    {
        public string Source { get; set; }
        public string Value { get; set; }
    }

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

    public class MovieSearcher
    {
        Dictionary<string, Movie> cach = new Dictionary<string, Movie>();
        public Movie SearchByTitle(string title)
        {
            Movie result;

            if (cach.ContainsKey(title))
            {
                result = cach[title];
            }
            else
            {
                WebClient web = new WebClient();
                var request = $@"http://www.omdbapi.com/?apikey=f4e0873a&t={title}";
                var answer = web.DownloadString(request);
                result = JsonSerializer.Deserialize<Movie>(answer);
                cach.Add(title, result);
            }
           return result;
        }
    }
}
