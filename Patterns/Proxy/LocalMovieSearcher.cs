using System.Collections.Generic;
using System.Linq;

namespace Proxy
{
    // Proxy Service
    public class LocalMovieSearcher : IMovieSearcher
    {
        List<Movie> localMovieDB;
        IMovieSearcher globalMovieSearcher;
        public LocalMovieSearcher(IMovieSearcher movieSearcher)
        {
            globalMovieSearcher = movieSearcher;
            localMovieDB = new List<Movie>()
            {
                new Movie() {Country = "Azerbaijan", Director = "Haci", Genre = "Action", Actors = "Maga", Title = "Rocky" },
                new Movie() {Country = "Azerbaijan", Director = "Samur", Genre = "Dram", Actors = "Bred Pit", Title = "Thinking man" },
                new Movie() {Country = "Azerbaijan", Director = "Elesger", Genre = "Detective", Actors = "Benedict", Title = "Pianist" }

            };
        }
        public Movie SearchByTitle(string title)
        {
            if (localMovieDB.Any(x => x.Title == title))
            {
                return localMovieDB.FirstOrDefault(x => x.Title == title);
            }
            else
            {
                return globalMovieSearcher.SearchByTitle(title);
            }
        }
    }
    
}
