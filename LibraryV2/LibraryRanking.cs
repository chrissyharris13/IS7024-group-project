using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryV2
{
    public class LibraryRanking
    {
        private int id;
        string author;
        string catalog_record;
        int pub_year;
        int rank;
        string title;

        public int Id { get => id; set => id = value; }
        public string Author { get => author; set => author = value; }
        public string Catalog_record { get => catalog_record; set => catalog_record = value; }
        public int Pub_year { get => pub_year; set => pub_year = value; }
        public int Rank { get => rank; set => rank = value; }
        public string Title { get => title; set => title = value; }
    }
}