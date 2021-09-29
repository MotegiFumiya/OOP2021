using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendMail {

    class Settings {
        public int Port { get; set; }           //ポート番号
        public string Host { get; set; }        //ホスト名
        public string MailAddr { get; set; }    //メールアドレス
        public string Pass { get; set; }        //パスワード
        public bool Ssl { get; set; }           //SSL

        

        //初期値
        public string gHost() {
            return "smtp.gmail.com";
        }
        public string gPort() {
            return 587.ToString();
        }
        public string sMailAddr() {
            return "ojsinfosys01@gmail.com";
        }
        public string sPass() {
            return "OjsInfosys2019";
        }
    }
}
