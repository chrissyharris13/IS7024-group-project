using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryV2
{
    public class Movie
    {
        private int id;
        string title;
        int year; 

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public int Year { get => year; set => year = value; }

    }
}