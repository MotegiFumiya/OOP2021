
<<<<<<< HEAD
namespace SendMail {
    partial class Form1 {
=======
namespace SendMail
{
    partial class Form1
    {
>>>>>>> f1e43fdaa7b9a4134d520a72f166d344a203f3be
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
<<<<<<< HEAD
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
=======
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
>>>>>>> f1e43fdaa7b9a4134d520a72f166d344a203f3be
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
<<<<<<< HEAD
        private void InitializeComponent() {
=======
        private void InitializeComponent()
        {
>>>>>>> f1e43fdaa7b9a4134d520a72f166d344a203f3be
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.btSend = new System.Windows.Forms.Button();
<<<<<<< HEAD
=======
            this.label4 = new System.Windows.Forms.Label();
            this.tbCc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbBcc = new System.Windows.Forms.TextBox();
            this.btConfig = new System.Windows.Forms.Button();
>>>>>>> f1e43fdaa7b9a4134d520a72f166d344a203f3be
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
<<<<<<< HEAD
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "送信先：";
=======
            this.label1.Location = new System.Drawing.Point(51, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "To：";
>>>>>>> f1e43fdaa7b9a4134d520a72f166d344a203f3be
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
<<<<<<< HEAD
            this.label2.Location = new System.Drawing.Point(36, 59);
=======
            this.label2.Location = new System.Drawing.Point(29, 135);
>>>>>>> f1e43fdaa7b9a4134d520a72f166d344a203f3be
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "件名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
<<<<<<< HEAD
            this.label3.Location = new System.Drawing.Point(36, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 0;
=======
            this.label3.Location = new System.Drawing.Point(29, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 1;
>>>>>>> f1e43fdaa7b9a4134d520a72f166d344a203f3be
            this.label3.Text = "本文：";
            // 
            // tbTo
            // 
            this.tbTo.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
<<<<<<< HEAD
            this.tbTo.Location = new System.Drawing.Point(112, 22);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(480, 31);
            this.tbTo.TabIndex = 1;
=======
            this.tbTo.Location = new System.Drawing.Point(105, 12);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(519, 31);
            this.tbTo.TabIndex = 2;
>>>>>>> f1e43fdaa7b9a4134d520a72f166d344a203f3be
            // 
            // tbTitle
            // 
            this.tbTitle.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
<<<<<<< HEAD
            this.tbTitle.Location = new System.Drawing.Point(112, 59);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(480, 31);
            this.tbTitle.TabIndex = 1;
=======
            this.tbTitle.Location = new System.Drawing.Point(105, 132);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(519, 31);
            this.tbTitle.TabIndex = 2;
>>>>>>> f1e43fdaa7b9a4134d520a72f166d344a203f3be
            // 
            // tbMessage
            // 
            this.tbMessage.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
<<<<<<< HEAD
            this.tbMessage.Location = new System.Drawing.Point(112, 97);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(480, 229);
            this.tbMessage.TabIndex = 1;
=======
            this.tbMessage.Location = new System.Drawing.Point(105, 177);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(519, 251);
            this.tbMessage.TabIndex = 2;
>>>>>>> f1e43fdaa7b9a4134d520a72f166d344a203f3be
            // 
            // btSend
            // 
            this.btSend.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
<<<<<<< HEAD
            this.btSend.Location = new System.Drawing.Point(499, 332);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(93, 39);
            this.btSend.TabIndex = 2;
=======
            this.btSend.Location = new System.Drawing.Point(525, 441);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(99, 40);
            this.btSend.TabIndex = 3;
>>>>>>> f1e43fdaa7b9a4134d520a72f166d344a203f3be
            this.btSend.Text = "送信";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
<<<<<<< HEAD
=======
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(49, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cc：";
            // 
            // tbCc
            // 
            this.tbCc.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbCc.Location = new System.Drawing.Point(105, 49);
            this.tbCc.Name = "tbCc";
            this.tbCc.Size = new System.Drawing.Size(519, 31);
            this.tbCc.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(38, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bcc：";
            // 
            // tbBcc
            // 
            this.tbBcc.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbBcc.Location = new System.Drawing.Point(105, 86);
            this.tbBcc.Name = "tbBcc";
            this.tbBcc.Size = new System.Drawing.Size(519, 31);
            this.tbBcc.TabIndex = 2;
            // 
            // btConfig
            // 
            this.btConfig.Location = new System.Drawing.Point(105, 441);
            this.btConfig.Name = "btConfig";
            this.btConfig.Size = new System.Drawing.Size(61, 40);
            this.btConfig.TabIndex = 4;
            this.btConfig.Text = "設定";
            this.btConfig.UseVisualStyleBackColor = true;
            this.btConfig.Click += new System.EventHandler(this.btConfig_Click);
            // 
>>>>>>> f1e43fdaa7b9a4134d520a72f166d344a203f3be
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(626, 450);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.tbTo);
            this.Controls.Add(this.label3);
=======
            this.ClientSize = new System.Drawing.Size(651, 503);
            this.Controls.Add(this.btConfig);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.tbBcc);
            this.Controls.Add(this.tbCc);
            this.Controls.Add(this.tbTo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
>>>>>>> f1e43fdaa7b9a4134d520a72f166d344a203f3be
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "メール送信アプリ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button btSend;
<<<<<<< HEAD
=======
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbBcc;
        private System.Windows.Forms.Button btConfig;
>>>>>>> f1e43fdaa7b9a4134d520a72f166d344a203f3be
    }
}

