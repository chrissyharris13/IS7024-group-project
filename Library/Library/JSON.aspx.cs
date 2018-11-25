using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library
{
    public partial class Json_Library : System.Web.UI.Page
    {
       protected void Page_Load(object sender, EventArgs e)
        {

         using (var webClient = new WebClient())
            {
                //another link to this data is available at https://data.cityofchicago.org/resource/6gjb-wqjd.json 
                string rawData =
                    webClient.DownloadString("https://data.cityofchicago.org/api/views/izv6-vdkm/rows.json?accessType=DOWNLOAD");

            }
            using (var webClient = new WebClient())
            {
                //API documentation available at https://openlibrary.org/dev/docs/api/covers   
                string rawData =
                    webClient.DownloadString("Open Libraries API");

            }
        }
    }
}