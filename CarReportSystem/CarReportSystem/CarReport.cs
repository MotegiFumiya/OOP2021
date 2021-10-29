using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReportSystem {
    [Serializable]
    public class CarReport {
        [DisplayName("日付")]
        public DateTime Date { get; set; }      //日付
        [DisplayName("記録者")]
        public string Auther { get; set; }      //記録者
        [DisplayName("メーカー")]
        public MakerGroup Maker { get; set; }   //メーカー
        [DisplayName("車種")]
        public string CarName { get; set; }     //車種
        [DisplayName("レポート")]
        public string Report { get; set; }
        [DisplayName("画像")]
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
