using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class GlobalWineScore
    {
        private int wine_ID;
        int vintage;
        string color;
        bool is_primeurs;
        string lwin;
        string lwin_11;
        int number;
        int offset;
        int ordering;

        public int Wine_ID { get => wine_ID; set => wine_ID = value; }
        public int Vintage { get => vintage; set => vintage = value; }
        public string Color { get => color; set => color = value; }
        public bool Is_primeurs { get => is_primeurs; set => is_primeurs = value; }
        public string Lwin { get => lwin; set => lwin = value; }
        public string Lwin_11 { get => lwin_11; set => lwin_11 = value; }
        public int Number { get => number; set => number = value; }
        public int Offset { get => offset; set => offset = value; }
        public int Ordering { get => ordering; set => ordering = value; }
    }
}