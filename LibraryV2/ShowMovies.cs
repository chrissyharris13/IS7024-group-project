using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using Newtonsoft.Json;

namespace LibraryV2
{
    public class ShowMovies
    {
        static ShowMovies()
        {
            using (var webClient = new WebClient())
            {
                string rawJSON =
                    webClient.DownloadString("https://raw.githubusercontent.com/prust/wikipedia-movie-data/master/movies.json");

                List<Movie> moviesList = JsonConvert.DeserializeObject<List<Movie>>(rawJSON);

                Console.WriteLine(moviesList.Count);
            }
        }


        private static List<Movie> allMovies1;

        public static List<Movie> AllMovies1 { get => allMovies1; set => allMovies1 = value; }

        public static List<Movie> GetMovies1()
        {
            return AllMovies1;
        }
    }
}