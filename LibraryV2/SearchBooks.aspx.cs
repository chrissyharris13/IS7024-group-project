using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryV2
{
    public partial class SearchBooks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var webClient = new WebClient())
            {
                //Data source: https://data.cityofchicago.org/Education/Libraries-Popular-Teen-Titles-at-the-Chicago-Publi/izv6-vdkm 
                String rawJSON =
                    webClient.DownloadString("https://data.cityofchicago.org/resource/6gjb-wqjd.json");
                List<LibraryRanking> libraryList = JsonConvert.DeserializeObject<List<LibraryRanking>>(rawJSON);
                Console.WriteLine(libraryList.Count);
            }
            //using (var webClient = new WebClient())
            //{
                //This is where our second data source will go.  We intend to use https://openlibrary.org/dev/docs/api/covers to show book covers when a title is put into the web form.   
                //String rawData =
                //webClient.DownloadString("Link to web service will go here");
            //}
        }

        protected void BltdListDescr_Click(object sender, BulletedListEventArgs e)
        {

        }
    }
}