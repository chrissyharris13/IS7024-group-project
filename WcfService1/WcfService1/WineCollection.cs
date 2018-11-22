using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class WineCollection
    {
        private List<Wine> wine;

        public List<Wine> Wine { get => wine; set => wine = value; }
    }
}