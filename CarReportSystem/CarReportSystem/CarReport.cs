using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReportSystem {
    public class CarReport {
        public DateTime Date { get; set; }      //日付
        public string Auther { get; set; }      //記録者
        public MakerGroup Maker { get; set; }   //メーカー
        public string CarName { get; set; }     //車種
        public string Report { get; set; }
        public Image Picture { get; set; }

        //メーカー
        public enum MakerGroup {
                トヨタ,
                日産,
                ホンダ,
                スバル,
                外国車,
                その他,
            }

        //データ更新
        public　void Update(DateTime date,
                         string auther,
                         MakerGroup makerGroup,
                         string carname,
                         string report,
                         Image picture) {
            this.Date = date;
            this.Auther = auther;
            this.Maker = makerGroup;
            this.CarName = carname;
            this.Report = report;
            this.Picture = picture;
        }
    }



}
