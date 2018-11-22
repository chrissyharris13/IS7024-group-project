using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class Wine
    {
        private int id;
        int points;
        string title;
        string description;
        string taster_name;
        string taster_twitter_handle;
        decimal price;
        string designation;
        string variety;
        string region_1;
        string region_2;
        string province;
        string country;
        string wintery;

        public int Id { get => id; set => id = value; }
        public int Points { get => points; set => points = value; }
        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public string Taster_name { get => taster_name; set => taster_name = value; }
        public string Taster_twitter_handle { get => taster_twitter_handle; set => taster_twitter_handle = value; }
        public decimal Price { get => price; set => price = value; }
        public string Designation { get => designation; set => designation = value; }
        public string Variety { get => variety; set => variety = value; }
        public string Region_1 { get => region_1; set => region_1 = value; }
        public string Region_2 { get => region_2; set => region_2 = value; }
        public string Province { get => province; set => province = value; }
        public string Country { get => country; set => country = value; }
        public string Wintery { get => wintery; set => wintery = value; }
    }
}