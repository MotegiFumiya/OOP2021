using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    class Program {
        static void Main(string[] args) {
            if (args.Length >= 1 && args[0] == "-tom") {
                // フィートからメートルへの対応表を出力
                PrintFeetToMeterList(1, 10);
            } else {
                // メートルからフィートへの対応表を出力
                PrintMeterToFeetList(1, 10);
            }
        }
        // フィートからメートルへの対応表を出力
        private static void PrintFeetToMeterList(int start, int stop) {
            FeetConverter converter = new FeetConverter();
            for (int feet = start; feet <= stop; feet++) {
                double meter =converter.ToMetar(feet);
                Console.WriteLine("{0} ft = {1:0.0000} m", feet, meter);
            }
        }
        // メートルからフィートへの対応表を出力
        private static void PrintMeterToFeetList(int start, int stop) {
            FeetConverter converter  = new FeetConverter();
            for (int meter = start; meter <= stop; meter++) {
                double feet = converter.FromMeter(meter);
                Console.WriteLine("{0} m = {1:0.0000} ft", meter, feet);
            }
        }


        //private static double PrintMeterToFeetList(int meter) {
        //    throw new NotImplementedException();
        //}

        //// フィートからメートルを求める
        //static double FeetToMeter(int feet) {
        //    return feet * 0.3048;
        //}
        //// メートルからフィートを求める
        //static double MeterToFeet(int meter) {
        //    return meter / 0.3048;
        //}
    }    
}