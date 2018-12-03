using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryV2
{
    public class LibraryRankingCollection
    {
        private List<LibraryRanking> LibraryRankings;

        public List<LibraryRanking> LibraryRankings1
        {
            get
            {
                return LibraryRankings;
            }

            set
            {
                LibraryRankings = value;
            }
        }
    }
}