using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

<<<<<<< HEAD
namespace SendMail {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btSend_Click(object sender, EventArgs e) {
            try {
                //メール送信のためのインスタンスを生成
                MailMessage mailMessage = new MailMessage();
                //差出人アドレス
                mailMessage.From = new MailAddress("ojsinfosys01@gmail.com");
                //宛先(To)
                mailMessage.To.Add(tbTo.Text);
                //件名タイトル
=======
namespace SendMail
{
    public partial class Form1 : Form
    {
        //設定画面
        private ConfigForm configForm = new ConfigForm();

        //設定情報
        private Settings settings = Settings.getInstance();

        public Form1()
        {
            InitializeComponent();
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            try
            {
                //メール送信のためのインスタンスを生成
                MailMessage mailMessage = new MailMessage();
                //差出人アドレス
                mailMessage.From = new MailAddress(settings.MailAddr);
                //宛先（To）
                mailMessage.To.Add(tbTo.Text);
                //if (mailMessage.CC == null) {
                //    MessageBox.Show("CCが空です");
                //} else { mailMessage.CC.Add(tbCc.Text);}
                if (tbCc.Text != "") {
                    mailMessage.CC.Add(tbCc.Text);
                }

                if (tbBcc.Text != "") {
                    mailMessage.Bcc.Add(tbBcc.Text);
                }
                //
                //件名（タイトル）
>>>>>>> f1e43fdaa7b9a4134d520a72f166d344a203f3be
                mailMessage.Subject = tbTitle.Text;
                //本文
                mailMessage.Body = tbMessage.Text;

                //SMTPを使ってメールを送信する
                SmtpClient smtpClient = new SmtpClient();
                //メール送信のための認証情報を設定（ユーザー名、パスワード）
<<<<<<< HEAD
                smtpClient.Credentials
                    = new NetworkCredential("ojsinfosys01@gmail.com", "Infosys2021");
                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.Send(mailMessage);

                MessageBox.Show("送信完了");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
=======
                smtpClient.Credentials 
                    = new NetworkCredential(settings.MailAddr,settings.Pass);
                smtpClient.Host =settings.Host;
                smtpClient.Port =settings.Port;
                smtpClient.EnableSsl = settings.Ssl;
                //smtpClient.Send(mailMessage);//非同期でない場合

                //送信完了時に呼ばれるイベントハンドラの登録
                smtpClient.SendCompleted += SmtpClient_SendCompleted;
                //smtpClient.SendCompleted += new SendCompletedEventHandler(SmtpClient_SendCompleted);

                string userState = "SendMail";
                smtpClient.SendAsync(mailMessage, userState);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //送信が完了すると呼ばれるコールバックメソッド
        private void SmtpClient_SendCompleted(object sender,AsyncCompletedEventArgs e) {
            if(e.Error != null) {
                MessageBox.Show(e.Error.Message);    
            } 
            else 
            {
                MessageBox.Show("送信完了");
            }
        }


        private void btConfig_Click(object sender, EventArgs e)
        {
            configForm.ShowDialog();
        }
>>>>>>> f1e43fdaa7b9a4134d520a72f166d344a203f3be
    }
}
