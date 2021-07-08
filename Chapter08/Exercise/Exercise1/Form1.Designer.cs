
namespace Exercise1 {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.bttoday = new System.Windows.Forms.Button();
            this.tbdate = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.TextBox();
            this.reset = new System.Windows.Forms.Button();
            this.rap = new System.Windows.Forms.Button();
            this.tmDisp = new System.Windows.Forms.Timer(this.components);
            this.Iblapdisp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bttoday
            // 
            this.bttoday.Location = new System.Drawing.Point(35, 30);
            this.bttoday.Name = "bttoday";
            this.bttoday.Size = new System.Drawing.Size(75, 44);
            this.bttoday.TabIndex = 0;
            this.bttoday.Text = "今日";
            this.bttoday.UseVisualStyleBackColor = true;
            this.bttoday.Click += new System.EventHandler(this.bttoday_Click);
            // 
            // tbdate
            // 
            this.tbdate.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbdate.Location = new System.Drawing.Point(116, 12);
            this.tbdate.Multiline = true;
            this.tbdate.Name = "tbdate";
            this.tbdate.Size = new System.Drawing.Size(340, 105);
            this.tbdate.TabIndex = 1;
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.start.Location = new System.Drawing.Point(12, 282);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(102, 47);
            this.start.TabIndex = 3;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.stop.Location = new System.Drawing.Point(120, 282);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(102, 47);
            this.stop.TabIndex = 4;
            this.stop.Text = "stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // time
            // 
            this.time.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.time.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.time.Location = new System.Drawing.Point(12, 214);
            this.time.Multiline = true;
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(210, 43);
            this.time.TabIndex = 5;
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.reset.Location = new System.Drawing.Point(12, 335);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(102, 44);
            this.reset.TabIndex = 6;
            this.reset.Text = "reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // rap
            // 
            this.rap.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rap.Location = new System.Drawing.Point(120, 335);
            this.rap.Name = "rap";
            this.rap.Size = new System.Drawing.Size(102, 44);
            this.rap.TabIndex = 6;
            this.rap.Text = "rap";
            this.rap.UseVisualStyleBackColor = true;
            this.rap.Click += new System.EventHandler(this.rap_Click);
            // 
            // tmDisp
            // 
            this.tmDisp.Tick += new System.EventHandler(this.tmDisp_Tick);
            // 
            // Iblapdisp
            // 
            this.Iblapdisp.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Iblapdisp.Location = new System.Drawing.Point(228, 214);
            this.Iblapdisp.Multiline = true;
            this.Iblapdisp.Name = "Iblapdisp";
            this.Iblapdisp.Size = new System.Drawing.Size(126, 165);
            this.Iblapdisp.TabIndex = 7;
            this.Iblapdisp.Text = "IbLapDisp";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Iblapdisp);
            this.Controls.Add(this.rap);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.time);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Controls.Add(this.tbdate);
            this.Controls.Add(this.bttoday);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttoday;
        private System.Windows.Forms.TextBox tbdate;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button rap;
        private System.Windows.Forms.Timer tmDisp;
        private System.Windows.Forms.TextBox Iblapdisp;
    }
}

