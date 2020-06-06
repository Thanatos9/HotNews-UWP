using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HotNews_UWP.Data {
    public class JsonManage {
        private static async Task<RandomNewsWrapper> GetRandomNewsAsync() {

            string url = string.Format("https://www.tophub.fun:8888/GetRandomInfo?time=0&is_follow=0");

            HttpClient http = new HttpClient();

            var response = await http.GetAsync(url);
            var jsonMessage = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RandomNewsWrapper));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonMessage));

            var result = (RandomNewsWrapper)serializer.ReadObject(ms);

            return result;

        }

        public static async Task RandomDataManageAsync(ObservableCollection<RandomInfo> newsData) {
            var info = await GetRandomNewsAsync();
            var news = info.Data;
            

            foreach (var n in news) {
                //UnicodeToString(n.Title);
                
                newsData.Add(n);
            }

        }

        private static async Task<AllNewsWrapper> GetAllNewsAsync(int id) {

            string url = string.Format("https://www.tophub.fun:8888/v2/GetAllInfoGzip?id={0}&page=0", id);

            HttpClient http = new HttpClient();

            var response = await http.GetAsync(url);
            var jsonMessage = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(AllNewsWrapper));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonMessage));

            var result = (AllNewsWrapper)serializer.ReadObject(ms);

            return result;

        }

        public static async Task AllDataManageAsync(ObservableCollection<Datum> newsData, int id) {
            var info = await GetAllNewsAsync(id);
            var news = info.Data.data;
            foreach (var n in news) {
                DateTime time = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(int.Parse(n.CreateTime)));
                n.CreateTime = time.ToString();
                newsData.Add(n);
            }

        }

        public static string UnicodeToString(string source) {
            return new Regex(@"\\u([0-9A-F]{4})", RegexOptions.IgnoreCase).Replace(
              source, x => string.Empty + Convert.ToChar(Convert.ToUInt16(x.Result("$1"), 16)));
        }
    }
}
