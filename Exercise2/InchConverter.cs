using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    //フィートとメートルの単位変換クラス
    public static class InchConverter {
        private const double ratio = 0.0254;
    //メートルからインチを求める
    public static double FromMeter(double metar) {
            return metar / ratio;
        }
    //インチからメートルを求める
        public static double ToMetar(double feet) {
            return feet * ratio;
        }
    }
}
