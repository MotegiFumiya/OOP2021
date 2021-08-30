using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise {
    class Program {
        //private static string file;
        static void Main(string[] args) {
            var file = "Sample.xml";
            Exercise1_1(file);
            Console.WriteLine();
            Console.WriteLine("---------------");

            Exercise1_2(file);
            Console.WriteLine();
            Console.WriteLine("---------------");

            Exercise1_3(file);
            Console.WriteLine();
            Console.WriteLine("----------------");

            Exercise1_4(file);
            Console.WriteLine();
            Console.WriteLine("----------------");
        }

        

        private static void Exercise1_1(string file) {
            var xdoc = XDocument.Load(file);
            var sports = xdoc.Root.Elements()
                .Select(x => new {
                    Name = x.Element("name").Value,
                    Teammembers = x.Element("teammembers").Value
                });
            foreach (var sport in sports) {
                Console.WriteLine("{0} {1}", sport.Name, sport.Teammembers);
            }
        }
        private  static void Exercise1_2(string file) {
            var xdoc = XDocument.Load(file);
            var sports = xdoc.Root.Elements()
                .Select(x => new {
                    Firstplayed = x.Element("firstplayed").Value,
                    Name = x.Element("name").Attribute("kanji").Value
                }).OrderBy(x => int.Parse(x.Firstplayed));
            foreach(var sport in sports) {
                Console.WriteLine("{0} {1}", sport.Name, sport.Firstplayed);
            }
        }
        private static void Exercise1_3(string file) {
            var xdoc = XDocument.Load(file);
            var sports = xdoc.Root.Elements()
                .Select(x => new {
                    Name = x.Element("name").Value,
                    Teammembers = x.Element("teammembers").Value
                })
                .OrderByDescending(x => int.Parse(x.Teammembers));
            foreach(var sport in sports) {
                Console.WriteLine("{0} {1}", sport.Name);
            }
        }
        
        private static void Exercise1_4(string file) {
            XDocument document = XDocument.Parse(file);
            var xdoc = XDocument.Load("Sample.xml");


            xdoc.Save("Sample.xml");
            
        }
        
    }
}
