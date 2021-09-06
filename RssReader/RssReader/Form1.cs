using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {
        private object cityCode;

        public Form1() {
            InitializeComponent();
            
        }

        private void SetRssTitle(TextBox tbUrl) {

        }

        private void Form1_Load(object sender, EventArgs e) {

        }
        //指定したURL先からXMLデータを取得しtitle要素を取得し、リストボックスへセットする
        private void SetRssTitle(string uri) {
            using (var wc = new WebClient()) {
                wc.Headers.Add("Content-type", "charset=UTF-8");
                var uriString = string.Format(
                    @"http://rss.weather.yahoo.co.jp/rss/days/{0}.xml");
                var url = new Uri(uriString);
                var stream = wc.OpenRead(url);

                XDocument xdoc = XDocument.Load(stream);
                var nodes = xdoc.Root.Descendants("title");

                lbTitles.Items.Add(nodes);

                //foreach (var node in nodes) {
                //    //string s = Regex.Replace(node.Value, "【|】| - Yahoo!天気・災害", "");
                //    //yield return s;
                //}
            }
        }

        private void btRead_Click(object sender, EventArgs e) {
            //XDocument xdoc = XDocument.Load(stream);
            //var nodes = xdoc.Root.Descendants("title");

            SetRssTitle(tbUrl.Text);

            //lbTitles.Items.Add("http://rss.weather.yahoo.co.jp/rss/days/{0}.xml");

            
        }

        private void lbTitles_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) {

        }
    }
}
        
