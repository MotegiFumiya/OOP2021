
namespace Pelmanism {
    partial class FormGame {
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
            this.label1 = new System.Windows.Forms.Label();
            this.LabelGuidance = new System.Windows.Forms.Label();
            this.buttonstart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "0秒経過";
            // 
            // LabelGuidance
            // 
            this.LabelGuidance.AutoSize = true;
            this.LabelGuidance.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LabelGuidance.ForeColor = System.Drawing.Color.Red;
            this.LabelGuidance.Location = new System.Drawing.Point(88, 9);
            this.LabelGuidance.Name = "LabelGuidance";
            this.LabelGuidance.Size = new System.Drawing.Size(41, 12);
            this.LabelGuidance.TabIndex = 1;
            this.LabelGuidance.Text = "label2";
            // 
            // buttonstart
            // 
            this.buttonstart.Location = new System.Drawing.Point(196, 276);
            this.buttonstart.Name = "buttonstart";
            this.buttonstart.Size = new System.Drawing.Size(75, 23);
            this.buttonstart.TabIndex = 2;
            this.buttonstart.Text = "スタート";
            this.buttonstart.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // FormGame
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(459, 311);
            this.Controls.Add(this.buttonstart);
            this.Controls.Add(this.LabelGuidance);
            this.Controls.Add(this.label1);
            this.Name = "FormGame";
            this.Text = "神経衰弱";
            this.Load += new System.EventHandler(this.FormGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelGuidance;
        private System.Windows.Forms.Button buttonstart;
        private System.Windows.Forms.Timer timer1;
    }
}

