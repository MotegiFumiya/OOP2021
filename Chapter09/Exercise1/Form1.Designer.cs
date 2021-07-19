
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
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.tbOutPut = new System.Windows.Forms.TextBox();
            this.btOpen = new System.Windows.Forms.Button();
            this.keyword = new System.Windows.Forms.TextBox();
            this.btReadAllLines = new System.Windows.Forms.Button();
            this.ReadLines = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.FileName = "openFileDialog1";
            // 
            // tbOutPut
            // 
            this.tbOutPut.Location = new System.Drawing.Point(12, 84);
            this.tbOutPut.Multiline = true;
            this.tbOutPut.Name = "tbOutPut";
            this.tbOutPut.Size = new System.Drawing.Size(776, 354);
            this.tbOutPut.TabIndex = 0;
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(12, 12);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(75, 36);
            this.btOpen.TabIndex = 1;
            this.btOpen.Text = "開く...";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // keyword
            // 
            this.keyword.Location = new System.Drawing.Point(102, 29);
            this.keyword.Name = "keyword";
            this.keyword.Size = new System.Drawing.Size(100, 19);
            this.keyword.TabIndex = 2;
            // 
            // btReadAllLines
            // 
            this.btReadAllLines.Location = new System.Drawing.Point(218, 6);
            this.btReadAllLines.Name = "btReadAllLines";
            this.btReadAllLines.Size = new System.Drawing.Size(125, 49);
            this.btReadAllLines.TabIndex = 3;
            this.btReadAllLines.Text = "ReadAllLines";
            this.btReadAllLines.UseVisualStyleBackColor = true;
            this.btReadAllLines.Click += new System.EventHandler(this.btReadAllLines_Click);
            // 
            // ReadLines
            // 
            this.ReadLines.Location = new System.Drawing.Point(349, 6);
            this.ReadLines.Name = "ReadLines";
            this.ReadLines.Size = new System.Drawing.Size(125, 49);
            this.ReadLines.TabIndex = 3;
            this.ReadLines.Text = "ReadLines";
            this.ReadLines.UseVisualStyleBackColor = true;
            this.ReadLines.Click += new System.EventHandler(this.ReadLines_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReadLines);
            this.Controls.Add(this.btReadAllLines);
            this.Controls.Add(this.keyword);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.tbOutPut);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.TextBox tbOutPut;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.TextBox keyword;
        private System.Windows.Forms.Button btReadAllLines;
        private System.Windows.Forms.Button ReadLines;
    }
}

