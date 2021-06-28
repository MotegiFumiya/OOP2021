using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3 {
    public partial class Form1 : Form {
        //コンストラクタ
        public Form1() {
            InitializeComponent();
        }
        //フォームがロードされるタイミングで１回だけ実行される
        private void Form1_Load(object sender, EventArgs e) {
            inputStrText.Text = "Jackdaws love my big sphinx of quartz";
            indate1.Text = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";
        }
        //
        private void Button5_3_1_Click(object sender, EventArgs e) {
            var count = inputStrText.Text.Count(c => c == ' ');
            TextBoxSpaceCount.Text = count.ToString();
        }

        private void Button5_3_2_Click(object sender, EventArgs e) {
            //P146を参照する
            TextBoxWordChange.Text = inputStrText.Text.Replace("big", "small");
        }

        private void Button5_3_3_Click(object sender, EventArgs e) {
            tbWordCount.Text = inputStrText.Text.Split(' ').Length.ToString();
        }

        private void Button5_3_4_Click(object sender, EventArgs e) {
            var Words = inputStrText.Text.Split(' ').Where(s => s.Length <= 4);
            foreach (var word in Words) {
                tbWordCount4.Text += word + " ";
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            var array = inputStrText.Text.Split(' ').ToArray();
            if (array.Length > 0) {
                var sb = new StringBuilder(array[0]);
                foreach(var word in array.Skip(1)) {
                    sb.Append(' ');
                    sb.Append(word);
                }
                inputStrText.Text = sb.ToString();
            }
        }

        private void inputStrText_TextChanged(object sender, EventArgs e) {
                
        }

        private void indate1_TextChanged(object sender, EventArgs e) {

        }

        private void button54_Click(object sender, EventArgs e) {
            //  Novelist=谷崎潤一郎
            //  BestWork=春琴抄
            //  Born=1886
            foreach(var pair in indate1.Text.Split(';')) {
                var array = pair.Split('=');
                outdate.Text += ToJapanese(array[0]) + ":" + array[1] +Environment.NewLine;
            }
        }
        private string ToJapanese(string key) {
            switch (key) {
                case "Novelist":
                    return "作家";

                case "BestWork":
                    return "代表作";

                case "Born":
                    return "誕生年";
            }
            throw new ArgumentException("引数が正しくありません");
        }
    }
}
