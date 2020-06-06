using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotNews_UWP.Data {
    public class RandomInfo {
        public string CreateTime { get; set; }
        public string Desc { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string icon { get; set; }
        public string id { get; set; }
        public string img { get; set; }
        public string tid { get; set; }
        public string type { get; set; }
    }

    public class RandomNewsWrapper {
        public int Code { get; set; }
        public string Message { get; set; }
        public IList<RandomInfo> Data { get; set; }
        public int Page { get; set; }
    }

    public class Datum {
        public int id { get; set; }
        public string CreateTime { get; set; }
        public int commentNum { get; set; }
        public int approvalNum { get; set; }
        public string Title { get; set; }
        public string hotDesc { get; set; }
        public string Url { get; set; }
        public string imgUrl { get; set; }
        public string isRss { get; set; }
        public int is_agree { get; set; }
        public string TypeName { get; set; }
    }

    public class Data {
        public IList<Datum> data { get; set; }
        public int page { get; set; }
    }

    public class AllNewsWrapper {
        public int Code { get; set; }
        public string Message { get; set; }
        public Data Data { get; set; }
    }
}

