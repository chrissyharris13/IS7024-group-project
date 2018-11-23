using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class GlobalWineScores
    {
        private List<GlobalWineScore> globalwinescore;

        public List<GlobalWineScore> Globalwinescore { get => globalwinescore; set => globalwinescore = value; }
    }
}