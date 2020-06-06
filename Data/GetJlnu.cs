using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotNews_UWP.Data {
    public class GetJlnu {

        public static ObservableCollection<Jlinfo> GetJlnuNews() {
            var result = new ObservableCollection<Jlinfo>();

            var titleInfo = new List<string>();
            var dateInfo = new List<string>();



            HtmlWeb htmlWeb = new HtmlWeb();
            htmlWeb.OverrideEncoding = Encoding.GetEncoding("utf-8");
            HtmlDocument doc = htmlWeb.Load("http://www.jlnu.edu.cn/newmore.php?classid=1");


            HtmlNodeCollection titleNodes = doc.DocumentNode.SelectNodes("//div[@class='text_bt']");
            HtmlNodeCollection dateNodes = doc.DocumentNode.SelectNodes("//div[@class='text_fbsj']");




            foreach (var t in titleNodes) {
                var name = t.InnerText;
                titleInfo.Add(name);
            }

            foreach (var d in dateNodes) {
                var date = d.InnerText;
                dateInfo.Add(date);
            }

            for (int i = 0; i < titleInfo.Count; i++) {
                result.Add(new Jlinfo(titleInfo[i], dateInfo[i]));
            }

            return result;

        }



        public static ObservableCollection<Jlinfo> GetJlnuNotices() {
            var result = new ObservableCollection<Jlinfo>();

            var titleInfo = new List<string>();
            var dateInfo = new List<string>();



            HtmlWeb htmlWeb = new HtmlWeb();
            htmlWeb.OverrideEncoding = Encoding.GetEncoding("utf-8");
            HtmlDocument doc = htmlWeb.Load("http://www.jlnu.edu.cn/xyggmore.php?classid=2");


            HtmlNodeCollection titleNodes = doc.DocumentNode.SelectNodes("//div[@class='text_bt']");
            HtmlNodeCollection dateNodes = doc.DocumentNode.SelectNodes("//div[@class='text_fbsj']");




            foreach (var t in titleNodes) {
                var name = t.InnerText;
                titleInfo.Add(name);
            }

            foreach (var d in dateNodes) {
                var date = d.InnerText;
                dateInfo.Add(date);
            }

            for (int i = 0; i < titleInfo.Count; i++) {
                result.Add(new Jlinfo(titleInfo[i], dateInfo[i]));
            }

            return result;

        }

    }
}
