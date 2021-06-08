using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kv
{
    class Data
    {
        public string tld { get; set; }
        public string time { get; set; }
        public string spon { get; set; }
        public string desc { get; set; }
        public string lnk { get; set; }
        public string dir { get; set; }

        public Data(string Tld, string Time, string Spon, string Desc, string Link, string Dir)
        {
            tld = Tld;
            time = Time;
            spon = Spon;
            desc = Desc;
            lnk = Link;
            dir = Dir;
        }
    }
}
