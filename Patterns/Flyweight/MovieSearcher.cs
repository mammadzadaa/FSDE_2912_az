using System.Collections.Generic;
using System.Net;
using System.Text.Json;

namespace Flyweight
{
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
