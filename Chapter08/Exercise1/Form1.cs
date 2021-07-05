using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btaction_Click(object sender, EventArgs e) {
            //var today = DateTime.Today;
            var today = new DateTime((int)nudYear.Value, (int)nudMonth.Value, (int)nudDay.Value);
            DayOfWeek dayOfWeek = today.DayOfWeek;
            //tbOutput.Text = "今日は" + (DayOfWeek)dayOfWeek + "です";
            string dow = "";

            switch (dayOfWeek) {
                case DayOfWeek.Sunday:
                    dow = "日曜日";
                    break;
                case DayOfWeek.Monday:
                    dow = "月曜日";
                    break;
                case DayOfWeek.Tuesday:
                    dow = "火曜日";
                    break;
                case DayOfWeek.Wednesday:
                    dow = "水曜日";
                    break;
                case DayOfWeek.Thursday:
                    dow = "木曜日";
                    break;
                case DayOfWeek.Friday:
                    dow = "金曜日";
                    break;
                case DayOfWeek.Saturday:
                    dow = "土曜日";
                    break;
            }
            tbOutput.Text = dow + "です";

            var d1 = (DateTime.Today);
            TimeSpan diff = d1.Date - today.Date;
            day.Text = diff.ToString();

            var leap = DateTime.IsLeapYear((int)nudYear.Value);
            if (leap) {
                tbleapyear.Text="閏年です";
            } else {
                tbleapyear.Text = "閏年ではないです";
            }

            var Today = DateTime.Today;
            var birthday = today;

            ///Age.Text=Getage(DateTime.)
            //tbOutput.Text = DateTime.Today.DayOfYear.ToString();
        }
        public int Getage(DateTime birthday,DateTime targetday) {
         var age = targetday.Year - birthday.Year;
            if (targetday < birthday.AddYears(age)) {
                age--;
                Age.Text = age.ToString();
             }
            return age;
        }
    }
}
