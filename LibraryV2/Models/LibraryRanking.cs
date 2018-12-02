using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryV2
{
    public class LibraryRanking
    {
        string author;
        string catalog_record;
        string pub_year;
        int rank;
        string title;

        public string Author { get { return author;} set { author = value; } }
        public string Catalog_record { get { return catalog_record; } set { catalog_record = value; } }
        public string Pub_year { get { return pub_year;} set { pub_year = value; }
        }

        public int Rank
        {
            get
            {
                return rank;
            }

            set
            {
                rank = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }
    }
}