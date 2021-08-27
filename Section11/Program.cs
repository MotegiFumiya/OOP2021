using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Section11 {
    class Program {
        static void Main(string[] args) {

            var novelists = ReadNovelists();

            foreach(var novelist in novelists) {
                Console.WriteLine("{0}({1}-{2})", novelist.Name, 
                    novelist.Birth.Year,novelist.Death.Year);
            }
        }
        //カスタムクラスのオブジェクトとして要素を取り出す
        static public IEnumerable<Novelists> ReadNovelists() 
            {
            var xdoc = XDocument.Load("novelists.xml");
            var novelists = xdoc.Root.Elements()
                .Select(x => new Novelists{
                    Name = (string)x.Element("name"),
                    KanaName=(string)(x.Element("name").Attribute("kana")),
                    Birth = (DateTime)x.Element("birth"),
                    Death = (DateTime)x.Element("death"),
                    Masterpieces=x.Element("masterpieces")
                    .Elements("title")
                    .Select(title=>title.Value)
                    .ToArray()
                });
            return novelists.ToArray();
        }
    }
}
