using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Section04 {
    class Program {
        
        Dictionary<string, int> weahter = new Dictionary<string, int>() {
            {"宇都宮", 4110},
            { "前橋",4210},
            { "埼玉",4310},
            { "東京",4410}
        };
        static void Main(string[] args) {
            new Program();
        }
        //コンストラクタ
        public Program() {

            Console.WriteLine("yahoo!週間天気予報");
            Console.WriteLine();
            Console.WriteLine("地域コードを入力");
            int num = 1;
            /*foreach (int i = 0; i < weahter.Count; i++) {
                Console.WriteLine("{0}:{1}", i + 1, weahter);
            }*/
            foreach(KeyValuePair<string,int>pair in weahter) {
                Console.WriteLine("{0}:{1}", num ++ , pair.Key);
            }
            /*Console.WriteLine("1:宇都宮");
            Console.WriteLine("2:前橋");
            Console.WriteLine("3:埼玉");
            Console.WriteLine("4:東京");*/
            Console.WriteLine("9:その他");
            Console.WriteLine();

            Console.WriteLine(">");

            //文字列として入力した数字取り込む
            var wc = Console.ReadLine();

            int wet = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}番は", wc);
            //if(weahter==)

            var results = GetWeatherReportFromYahoo(4610);
            foreach(var s in results) {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }

        
        //リスト14.19()
        private static IEnumerable<string> GetWeatherReportFromYahoo
            (int cityCode) {
            using (var wc = new WebClient()) {
                wc.Headers.Add("Content-type", "charset=UTF-8");
                var uriString = string.Format(
                    @"http://rss.weather.yahoo.co.jp/rss/days/{0}.xml", cityCode);
                var url = new Uri(uriString);
                var stream = wc.OpenRead(url);

                XDocument xdoc = XDocument.Load(stream);
                var nodes = xdoc.Root.Descendants("title");
                foreach (var node in nodes) {
                    string s = Regex.Replace(node.Value, "【|】| - Yahoo!天気・災害", "");
                    yield return s;
                }
            }
        }
    }

    }


