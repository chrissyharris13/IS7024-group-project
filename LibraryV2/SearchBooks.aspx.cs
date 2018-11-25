using System;
using System.Collections.Generic;
using System.Linq;
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
                String rawData =
                    webClient.DownloadString("https://data.cityofchicago.org/resource/6gjb-wqjd.json");
            }
        }

        protected void BltdListDescr_Click(object sender, BulletedListEventArgs e)
        {

        }
    }
}