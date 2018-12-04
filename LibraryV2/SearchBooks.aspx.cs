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
    public partial class SearchBooks : System.Web.UI.Page
    {
		protected void Page_Load(object sender, EventArgs e)
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
			}
		}

		protected void BtnReadJSON_Click(object sender, EventArgs e)
		{
			using (var webClient = new WebClient())
			{
				string rawJSON =
					webClient.DownloadString("https://data.cityofchicago.org/resource/6gjb-wqjd.json");

				List<LibraryRanking> librarylist = JsonConvert.DeserializeObject<List<LibraryRanking>>(rawJSON);

				LblJSONCount.Text = "" + librarylist.Count;
			}
		}
	}
}