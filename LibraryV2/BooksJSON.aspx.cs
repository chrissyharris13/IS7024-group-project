using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryV2
{
    public partial class BooksJSON : System.Web.UI.Page
    {       
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Clear();
            Response.ContentType = "application/json; charset=utf-8";
            Response.Write(ShowJSON());
            Response.End();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string jsonLibraryRanking = ShowJSON();

            BooksJSONTxTBox.Text = jsonLibraryRanking;
        }

        private static string ShowJSON()
        {
            List<LibraryRanking> allRankings = new List<LibraryRanking>();
           
            //convert to JSON
            string jsonLibraryRanking = JsonConvert.SerializeObject(allRankings);
            return jsonLibraryRanking;
        }
    }
}