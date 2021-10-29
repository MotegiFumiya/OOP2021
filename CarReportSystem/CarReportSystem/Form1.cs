using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class fmMain : Form {
        BindingList<CarReport> listCarReport = new BindingList<CarReport>();

        public fmMain() {
            InitializeComponent();
            //dgvData.DataSource = listCarReport;
        }

        private void btEnd_Click(object sender, EventArgs e) {
            //Exit
            Application.Exit();//アプリケーション終了
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
            if (cbAuther.Text == "" || cbCarname.Text == "") {
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

            foreach (var rb in groupBox1.Controls) {
                if (((RadioButton)rb).Checked) {
                    return (CarReport.MakerGroup)int.
                        Parse(((string)((RadioButton)rb).Tag));
                }
            }
            return CarReport.MakerGroup.その他;
        }
        //コンボボックスに記録者をセットする
        private void setCbAuther(string auther) {
            if (!cbAuther.Items.Contains(auther)) {
                cbAuther.Items.Add(auther);
                //                if (carReportDataGridView.Rows[3] == null) {
                //                    for(int i = 0; i < carReportDataGridView.RowCount; i++) {                     
                //                        setCbAuther(carReportDataGridView.Rows[i].Cells[3].Value.ToString());
                //}
                //                }
                for (int i = 0; i < carReportDataGridView.RowCount; i++) {
                    setCbAuther(carReportDataGridView.Rows[i].Cells[2].Value.ToString());
                    setCbCarName(carReportDataGridView.Rows[i].Cells[3].Value.ToString());
                }
            }
        }
        //コンボボックスに車名をセットする
        private void setCbCarName(string carname) {
            if (!cbCarname.Items.Contains(carname)) {
                cbCarname.Items.Add(carname);
            }
        }

        private void dgvData_CellClick(object sender,
            DataGridViewCellEventArgs e) {
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
        }

        private void setMakerRadioButton(CarReport.MakerGroup mg) {
            switch (mg) {
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
        }

        private void btDataDelete_Click(object sender, EventArgs e) {
            //listCarReport.RemoveAt(dgvData.CurrentRow.Index);
        }

        private void btDataCollect_Click(object sender, EventArgs e) {

        }

        //更新ボタンイベント管理
        private void btUpdate_Click(object sender, EventArgs e) 
            {
            if (carReportDataGridView.CurrentRow == null) return; 
            {
                carReportDataGridView.CurrentRow.Cells[1].Value = dtpDate.Value;    //
                carReportDataGridView.CurrentRow.Cells[2].Value = cbAuther.Text;    //
                carReportDataGridView.CurrentRow.Cells[3].Value = selectedGroup();  //
                carReportDataGridView.CurrentRow.Cells[4].Value = cbCarname.Text;   //
                carReportDataGridView.CurrentRow.Cells[5].Value = tbReport.Text;    //
                carReportDataGridView.CurrentRow.Cells[6].Value = ImageToByteArray(pbPicture.Image);  //画像
                //データベースへ反映
                this.Validate();
                this.carReportBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.infosys202134DataSet);
            }
        }

        private void btConnect_Click(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202134DataSet.CarReport' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportTableAdapter.Fill(this.infosys202134DataSet.CarReport);            
        }

        private void carReportBindingNavigatorSaveItem_Click
            (object sender, EventArgs e) {
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202134DataSet);

        }

        private void fmMain_Load(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202134DataSet.CarReport' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportTableAdapter.Fill(this.infosys202134DataSet.CarReport);
            carReportDataGridView.Columns[0].Visible = false;
            carReportDataGridView.Columns[1].HeaderText = "日付";
            carReportDataGridView.Columns[2].HeaderText = "記録者";
            carReportDataGridView.Columns[3].HeaderText = "メーカー";
            carReportDataGridView.Columns[4].HeaderText = "車名";
            carReportDataGridView.Columns[5].HeaderText = "レポート";
            carReportDataGridView.Columns[6].Visible = false;
        }

        private void carReportDataGridView_SelectionChanged(object sender, EventArgs e) {
            if (carReportDataGridView.CurrentRow == null) return; 
            try {
            cbAuther.Text = (string)carReportDataGridView.CurrentRow.Cells[2].Value; //日付           
            setMakerRadioButton((CarReport.MakerGroup)
                Enum.Parse(typeof(CarReport.MakerGroup),
                carReportDataGridView.CurrentRow.Cells[3].Value.ToString()));//メーカー
            cbCarname.Text = (string)carReportDataGridView.CurrentRow.Cells[4].Value;//車名
            tbReport.Text = (string)carReportDataGridView.CurrentRow.Cells[5].Value;//レポート
            pbPicture.Image = ByteArrayToImage((byte[])carReportDataGridView.CurrentRow.Cells[6].Value);//画像
                            }
            catch(Exception) {
                pbPicture.Image = null;
            }


#if false
            if (carReportDataGridView.CurrentRow == null) {
                carReportDataGridView.CurrentRow.Cells[1].Value = null;    //
                carReportDataGridView.CurrentRow.Cells[2].Value = null;    //
                carReportDataGridView.CurrentRow.Cells[3].Value = null;  //
                carReportDataGridView.CurrentRow.Cells[4].Value = null;   //
                carReportDataGridView.CurrentRow.Cells[5].Value = null;    //
                carReportDataGridView.CurrentRow.Cells[6].Value = null;  //画像

            }
#endif

        }
        public static Image ByteArrayToImage(byte[]b)
            {                    
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(b);
            return img;
        }
        public static byte[]ImageToByteArray(Image img) 
            {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }

        private void carReportDataGridView_DataError
            (object sender, DataGridViewDataErrorEventArgs e) {

        }

       
    }
}

