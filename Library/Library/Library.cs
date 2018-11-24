using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library
{
    public class Library
    {
        private int id;
        string Rank;
        string Title;
        string Author;
        string PubYear;
        string catalogrecords;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Rank1
        {
            get
            {
                return Rank;
            }

            set
            {
                Rank = value;
            }
        }

        public string Title1
        {
            get
            {
                return Title;
            }

            set
            {
                Title = value;
            }
        }

        public string Author1
        {
            get
            {
                return Author;
            }

            set
            {
                Author = value;
            }
        }

        public string PubYear1
        {
            get
            {
                return PubYear;
            }

            set
            {
                PubYear = value;
            }
        }

        public string Catalogrecords
        {
            get
            {
                return catalogrecords;
            }

            set
            {
                catalogrecords = value;
            }
        }
    }
}
    