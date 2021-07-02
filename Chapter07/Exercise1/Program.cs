using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            var text = "Cozy Lumox gives smart squid who asks for job pen";
            Exercise1(text);
            Console.WriteLine();
            Exercise2(text);
        }

        private static void Exercise1(string text) {
            var dict = new Dictionary<Char, int>();
            foreach (var c in text) {
                //大文字小文字を区別しないためすべて大文字に変換して処理
                var uc = char.ToUpper(c);
                if ('A' <= uc && uc <= 'Z') {
                    if (dict.ContainsKey(uc)) {
                        dict[uc]++;
                    } else {
                        dict[uc] = 1;
                    }
                }
            }
            //Aから並び変えて出力
            foreach (var item in dict.OrderBy(x => x.Key)) {
                Console.WriteLine("{0}:{1}",item.Key, item.Value);
            } 
        }
        private static void Exercise2(string text) {
            var dict = new SortedDictionary<Char, int>();
            foreach (var c in text) {
                //大文字小文字を区別しないため全て大文字に変換して処理
                var uc = char.ToUpper(c);
                if ('A' <= uc && uc <= 'Z') {
                    if (dict.ContainsKey(uc)) {
                        dict[uc]++;
                    } else {
                        dict[uc] = 1;
                    }
                }
            }
            //Aから並べ替えて出力
            foreach (var item in dict) {
                Console.WriteLine("{0}:{1}", item.Key, item.Value);
            }
        }
    }
}

