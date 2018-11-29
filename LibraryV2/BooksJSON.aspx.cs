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
            // create an object
            LibraryRanking divergent = new LibraryRanking();
            divergent.Author = "Roth, Veronica.";
            divergent.Catalog_record = "http://chipublib.bibliocommons.com/search?suppress=true&custom_edit=false&custom_query=identifier%3A=9780062024022";
            divergent.Pub_year = "2011";
            divergent.Rank = 1;
            divergent.Title = "Divergent";
            allRankings.Add(divergent);

            LibraryRanking the_fault_in_our_stars = new LibraryRanking();
            the_fault_in_our_stars.Author = "Green, John, 1977-";
            the_fault_in_our_stars.Catalog_record = "http://chipublib.bibliocommons.com/search?suppress=true&custom_edit=false&custom_query=identifier%3A=9780525478812";
            the_fault_in_our_stars.Pub_year = "2012";
            the_fault_in_our_stars.Rank = 2;
            the_fault_in_our_stars.Title = "The fault in our stars";
            allRankings.Add(the_fault_in_our_stars);

            LibraryRanking the_book_thief = new LibraryRanking();
            the_book_thief.Author = "Zusak, Markus.";
            the_book_thief.Catalog_record = "http://chipublib.bibliocommons.com/search?suppress=true&custom_edit=false&custom_query=identifier%3A=9780375842207";
            the_book_thief.Pub_year = "2007";
            the_book_thief.Rank = 3;
            the_book_thief.Title = "The book thief";
            allRankings.Add(the_book_thief);

            LibraryRanking mockingjay = new LibraryRanking();
            mockingjay.Author = "Collins, Suzanne.";
            mockingjay.Catalog_record = "http://chipublib.bibliocommons.com/search?suppress=true&custom_edit=false&custom_query=identifier%3A=9780439023511";
            mockingjay.Pub_year = "2010";
            mockingjay.Rank = 4;
            mockingjay.Title = "Mockingjay";
            allRankings.Add(mockingjay);

            //convert to JSON
            string jsonLibraryRanking = JsonConvert.SerializeObject(allRankings);
            return jsonLibraryRanking;
        }
    }
}