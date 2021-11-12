using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUnitConverter {
    public class DistanceUnit {
    public string Name { get; set; }
        public double Cofficient { get; set; }
        public override string ToString() {
            return this.Name;
        }
    }
    //メートル単位を表すクラス
    public class MetricUnit : DistanceUnit {
        private static List<MetricUnit> units = new List<MetricUnit> {
            new MetricUnit{Name="mm",Cofficient = 1,},
            new MetricUnit{Name="cm",Cofficient = 10,},
            new MetricUnit{Name="m",Cofficient = 10 * 100,},
            new MetricUnit{Name="km",Cofficient = 1 * 100 * 1000,},
        };
        public static ICollection<MetricUnit> Units { get { return units; } }

        /// <summary>
        /// ヤード単位からメートル単位に変換します
        /// </summary>
        /// <param name="unit">ヤード単位</param>
        /// <param name="value">係数</param>
        /// <returns></returns>
        public double FromImperialUnit(ImperialUnit unit,double value) {
            return (value * unit.Cofficient) * 25.4 / this.Cofficient;
        }
    }

    public class ImperialUnit : DistanceUnit {
        private static List<ImperialUnit> units = new List<ImperialUnit> {
            new ImperialUnit{Name="in",Cofficient = 1,},
            new ImperialUnit{Name="ft",Cofficient = 12,},
            new ImperialUnit{Name="yd",Cofficient = 12 * 3,},
            new ImperialUnit{Name="ml",Cofficient = 12 * 3 * 1760,},
        };
        public static ICollection<ImperialUnit> Units { get { return units; } }

        /// <summary>
        /// メートル単位からヤード単位
        /// </summary>
        /// <param name="unit">メートル単位</param>
        /// <param name="value">係数</param>
        /// <returns></returns>
        public double FromMetricUnit(MetricUnit unit, double value) {
            return (value * unit.Cofficient) / 25.4 / this.Cofficient;
        }
    }
}

