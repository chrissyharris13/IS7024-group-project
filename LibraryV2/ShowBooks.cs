using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using Newtonsoft.Json;

namespace LibraryV2
{
    public class ShowBooks
    {

        static ShowBooks()
        {
            using (var webClient = new WebClient())
            {
                //Data source: https://data.cityofchicago.org/Education/Libraries-Popular-Teen-Titles-at-the-Chicago-Publi/izv6-vdkm 
                // get a String representation of our JSON
                String rawJSON =
                    webClient.DownloadString("https://data.cityofchicago.org/resource/6gjb-wqjd.json");
                // convert the JSON to a series of objects.
                List<LibraryRanking> libraryList = JsonConvert.DeserializeObject<List<LibraryRanking>>(rawJSON);
                // do some computation.
                Console.WriteLine(libraryList.Count);

                // take the objects parsed from JSON, and give them to my static collection.
                AllLibraryRankings1 = libraryList;
            }
        }

        private static List<LibraryRanking> allLibraryRankings1;

        public static List<LibraryRanking> AllLibraryRankings1 { get => allLibraryRankings1; set => allLibraryRankings1 = value; }

        public static List<LibraryRanking> GetLibraryRankings1()
        {
            return AllLibraryRankings1;
        }

    }
}