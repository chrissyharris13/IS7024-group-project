using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

namespace LibraryV2
{
    public partial class AutoCompleteMovie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string term = Request.QueryString["term"];

            Response.Clear();
            // change the content type
            Response.ContentType = "application/json; charset=utf-8";

            //our suggested data
            List<String> suggestions = new List<String>();
            suggestions.Add("White Oak");
            suggestions.Add("Burr Oak");



            List<string> filteredResults = new List<string>();

            if (term != null && term.Length > 0)
            {

                foreach (string movie in suggestions)
                {
                    if (movie.Contains(term))
                    {
                        filteredResults.Add(movie);
                    }
                }
            }
            string responseJson = JsonConvert.SerializeObject(filteredResults);

            Response.Write(responseJson);

            //flush output
            Response.End();
        }
    }
}