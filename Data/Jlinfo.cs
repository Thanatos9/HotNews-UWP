using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotNews_UWP.Data {
    public class Jlinfo {
        public string title { get; set; }
        public string date { get; set; }

        public Jlinfo(string title, string date) {
            this.title = title;
            this.date = date;
        }
    }
}
