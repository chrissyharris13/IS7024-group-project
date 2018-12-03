using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Services;
using Newtonsoft.Json;

namespace LibraryV2
{
    /// <summary>
    /// Summary description for MoviesWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MoviesWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string LookUpMovie(String title)
        {
            string returnValue = "No title found";

            MovieCollection movieCollection;

            IDictionary<String, Int32> titleCount = new Dictionary<String, Int32>();


            using (var webClient = new WebClient())
            {
                string rawData =
                    webClient.DownloadString("https://data.cityofchicago.org/resource/6gjb-wqjd.json");

                List<Movie> moviesList = JsonConvert.DeserializeObject<List<Movie>>(rawData);
            }

            foreach (Movie movie in movieCollection.Movies1)
            {
                if (titleCount.ContainsKey(movie.Title))
                {
                    int currentCount = titleCount[movie.Title];
                    currentCount++;
                    titleCount[movie.Title] = currentCount;
                }
                else
                {
                    //title does not exist; add it with a default count of "1"
                    titleCount.Add(movie.Title, 1);
                }
            }



            return returnValue;
        }
    }
}
