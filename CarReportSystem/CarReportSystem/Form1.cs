﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class fmMain : Form {
        BindingList<CarReport> listCarReport = new BindingList<CarReport>();

        public fmMain() {
            InitializeComponent();
            dgvData.DataSource = listCarReport;
        }

        private void btEnd_Click(object sender, EventArgs e) {
            //Exit
            Application.Exit();//アプリケーション終了
        }

        private void pbPicture_Click(object sender, EventArgs e) {

        }

        private void btPictureOpen_Click(object sender, EventArgs e) {
            if (ofdPictureOpen.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdPictureOpen.FileName);
            }
        }
        //画像削除
        private void btPictureDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }
        
        //追加ボタン
        private void btDataAdd_Click(object sender, EventArgs e) {
            if (cbAuther.Text==""||cbCarname.Text=="") {
                MessageBox.Show("入力されていません");
                return;
            }

            CarReport carReport = new CarReport {
                Date = dtpDate.Value,
                Auther = cbAuther.Text,
                CarName = cbCarname.Text,
                Report = tbReport.Text,
            };
            listCarReport.Add(carReport);//レコード追加

            setCbAuther(cbAuther.Text);
            setCbCarName(cbCarname.Text);            
        }
        //選択されているメーカーの列挙型を返す
        private CarReport.MakerGroup selectedGroup() {
            foreach(var rb in groupBox1.Controls){
                if (((RadioButton)rb).Checked) { 
                    return (CarReport.MakerGroup)int.Parse((string)((RadioButton)rb).Tag);
                }
            }
            return CarReport.MakerGroup.その他;
        }
        //コンボボックスに記録者をセットする
        private void setCbAuther(string auther) {
            if (!cbAuther.Items.Contains(auther)) {
                cbAuther.Items.Add(auther);
            }
        }
        //コンボボックスに車名をセットする
        private void setCbCarName(string carname) {
            if (!cbCarname.Items.Contains(carname)) {
                cbCarname.Items.Add(carname);
            }
        }
            
        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (0 < e.RowIndex)
                return;

            //選択された行のデータを取得
            CarReport selectedCar = listCarReport[e.RowIndex];

            //取得したデータ項目をコントロールへ設定
            dtpDate.Value = selectedCar.Date;
            cbAuther.Text = selectedCar.Auther;
            setMakerRadioButton(selectedCar.Maker);
            cbCarname.Text = selectedCar.CarName;
            tbReport.Text = selectedCar.Report;
            pbPicture.Image = selectedCar.Picture;

            switch (selectedCar.Maker) {
                case CarReport.MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case CarReport.MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.外国車:
                    rbImport.Checked = true;
                    break;
                default://その他
                    rbOther.Checked = true;
                    break;
            }
            //
        }

        private void setMakerRadioButton(CarReport.MakerGroup maker) {
            
        }

        private void btDataDelete_Click(object sender, EventArgs e) {
            listCarReport.RemoveAt(dgvData.CurrentRow.Index);
        }

        private void btDataCollect_Click(object sender, EventArgs e) {
            listCarReport[dgvData.CurrentRow.Index].Update(dtpDate.Value,cbAuther.Text,
                selectedGroup(),cbCarname.Text,tbReport.Text,pbPicture.Image);
            dgvData.DataSource = listCarReport;
        }
    }
}
