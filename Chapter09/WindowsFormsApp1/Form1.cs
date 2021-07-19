using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {
        string inputPath = "";
        string outputPath = "";

        public Form1() {
            InitializeComponent();
        }
        //変換元のファイル指定
        private void button1_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                inputPath = openFileDialog1.FileName;
            }
        }
        //変換したファイルの保存先を指定
        private void btChangeFile_Click(object sender, EventArgs e) {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                outputPath = saveFileDialog1.FileName;
            }
        }
        
        //行番号を追加する処理
        private void btNum_Click(object sender, EventArgs e) {
            var lines = File.ReadAllLines(inputPath)
                          .Select((s, ix) => String.Format("{0,4}:{1}", ix + 1, s)).ToArray();
            File.WriteAllLines(outputPath, lines);
        }
    }
}
