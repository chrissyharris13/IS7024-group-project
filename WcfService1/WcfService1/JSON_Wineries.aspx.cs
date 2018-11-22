using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WcfService1
{
    public partial class JSON_Wineries : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnFindWine_Click(object sender, EventArgs e)
        {
            using (var webClient = new WebClient())
            {
                String rawData =
                    webClient.DownloadString("https://www.kaggle.com/zynicide/wine-reviews#winemag-data-130k-v2.json");
            }
        }
    }
}