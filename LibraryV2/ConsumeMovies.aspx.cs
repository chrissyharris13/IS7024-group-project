using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

namespace LibraryV2
{
    public partial class ConsumeMovies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var webClient = new WebClient())
            {
                string rawData =
                    webClient.DownloadString("https://raw.githubusercontent.com/prust/wikipedia-movie-data/master/movies.json");

                List<Movie> moviesList = JsonConvert.DeserializeObject<List<Movie>>(rawData);

                Console.WriteLine(moviesList.Count);
            }
        }

        protected void BtnReadJSON_Click(object sender, EventArgs e)
        {
            using (var webClient = new WebClient())
            {
                string rawJSON =
                    webClient.DownloadString("https://raw.githubusercontent.com/prust/wikipedia-movie-data/master/movies.json");

                List<Movie> movieslist = JsonConvert.DeserializeObject<List<Movie>>(rawJSON);

                LblJSONCount.Text = "" + movieslist.Count;
            }
        }

    }
}