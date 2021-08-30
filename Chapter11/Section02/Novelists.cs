using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section11 {
    class Novelists {
        public string Name { get; set; }
        public string KanaName { get; set; }
        public DateTime Birth { get; set; }
        public DateTime Death { get; set; }
        public IEnumerable<string> Masterpieces { get; set; }
    }
}
