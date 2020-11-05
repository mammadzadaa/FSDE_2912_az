using System.Net;
using System.Text.Json;

namespace Proxy
{
    // Main Service
    public class GlobalMovieSearcher : IMovieSearcher
        {
        
            public Movie SearchByTitle(string title)
            {
                    WebClient web = new WebClient();
                    var request = $@"http://www.omdbapi.com/?apikey=f4e0873a&t={title}";
                    var answer = web.DownloadString(request);
                    return JsonSerializer.Deserialize<Movie>(answer);                
            }
        }
    
}
