using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Section11 {
    class Program {
        static void Main(string[] args) {

            var xdoc = XDocument.Load("novellists.xml");
            

            foreach(var xnovelist in xdoc.Elements()) {
                var xname =xnovelist.Element("name");
                var works = xnovelist.Elements("masterpieces")
                                        .Elements("title")
                                        .Select(x => x.Value);
                Console.WriteLine("{0}{1}", xname.Value, string.Join(",",works));
            }
        }
    }
}
