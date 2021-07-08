using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Diagnostics;

namespace Exercise1 {
    public partial class Form1 : Form {

        //時間計測のストップウォッチ
        Stopwatch sw = new Stopwatch();

        public Form1() {
            InitializeComponent();
        }

        private void bttoday_Click(object sender, EventArgs e) {
            var today = DateTime.Now;
            
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();

            var datestr = today.ToString("ggyy", culture);
            var dayOfWeek = culture.DateTimeFormat.GetDayName(today.DayOfWeek);

            

            tbdate.Text = string.Format("{0:yyyy/M/d HH:mm}", today)+"\r\n";
            //tbdate.Text = today.ToString("d");
            tbdate.Text += today.ToString("yyyy年MM月dd日 HH時mm分ss秒") + "\r\n";
            tbdate.Text += string.Format("{0}年{1,2}月{2,2}日({3})", datestr, today.Month, today.Day, dayOfWeek);
        }

        private void Form1_Load(object sender, EventArgs e) {
            Timer tm = new Timer();
            tm.Tick += tmDisp_Tick;
            //tm.Interval = 1000;
            //tm.Start();

            //tssTimeLabel.Text = DateTime.Now.ToString();

            time.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");//DateTime.Now.ToString()
        }

        private void tmDisp_Tick(object sender, EventArgs e) {
            time.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff") ;
        }

        private void start_Click(object sender, EventArgs e) {
            sw.Start();
            tmDisp.Start();
        }

        private void stop_Click(object sender, EventArgs e) {
            sw.Stop();
            tmDisp.Stop();
        }

        private void reset_Click(object sender, EventArgs e) {
            sw.Reset();
            time.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");
        }

        private void rap_Click(object sender, EventArgs e) {
            //Iblapdisp.Items.Insert(0, sw.Elapsed.ToString(@"hh\:mm\:ss\.ff"));
        }

    }
}
