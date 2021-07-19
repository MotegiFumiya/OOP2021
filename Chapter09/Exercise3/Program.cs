using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3 {
    class Program {
        static void Main(string[] args) {
            var lines = new[] { "====" };
            var filePath = @"output.txt";
            using (var writer = new StreamWriter(filePath, append: true)) {
                foreach (var line in lines)
                    writer.WriteLine(line);
                
            }
        }
    }
}
