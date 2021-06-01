﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    class Program {
        static void Main(string[] args) {
            if (args.Length >= 1 && args[0] == "-toi") {
                // メートルからインチへの対応表を出力
                PrintMeterToInchList(1, 10);
            } else {
                // インチからメートルへの対応表を出力
                PrintInchToMeterList(1, 10);
            }
        }

        private static void PrintInchToMeterList(int start, int stop) {
            for (int meter = start; meter <= stop; meter++) {
                double inch = InchConverter.ToMetar(meter);
                Console.WriteLine("{0} inch = {1:0.0000} m", meter, inch);
            }
        }

        private static void PrintMeterToInchList(int start, int stop) {
            for (int inch = start; inch <= stop; inch++) {
                double meter = InchConverter.ToMetar(inch);
                Console.WriteLine("{0} ft = {1:0.0000} m", inch, meter);
            }
        }
    }
}
