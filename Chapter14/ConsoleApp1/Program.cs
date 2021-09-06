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
            {"宇都宮", 4110},{ "前橋",4210},{ "埼玉",4310},{ "東京",4410}
        };

        //コードを保存する
        List<int> cityCode = new List<int>();

        static void Main(string[] args) {
            new Program();
        }
        //コンストラクタ
        public Program() {

            Console.WriteLine("yahoo!週間天気予報");
            Console.WriteLine();
            Console.WriteLine("地域コードを入力");
            int num = 1;
            
            foreach(KeyValuePair<string,int>pair in weahter) {
                Console.WriteLine("{0}:{1}", num ++ , pair.Key);
                cityCode.Add(pair.Value);//コードをリストへ保存
            }
            
            Console.WriteLine("9:その他");
            Console.WriteLine();

            Console.WriteLine(">");

            //文字列として入力した数字取り込む
            var wc = Console.ReadLine();
            int pos = int.Parse(wc);

            
            int code;
            if(pos !=9) {
                code = cityCode[pos - 1];
            } 
            else 
            {
                //その他の場合
                Console.Write("都市コードを入力");
               code = int.Parse(Console.ReadLine());
            }
            var results = GetWeatherReportFromYahoo(code);

            //int wet = int.Parse(Console.ReadLine());

            //Console.WriteLine("{0}番は", wc);
            //if(weahter==)
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


