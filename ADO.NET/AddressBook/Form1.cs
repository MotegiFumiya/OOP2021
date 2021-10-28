using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void personBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202100DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'infosys202100DataSet.Person' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.personTableAdapter.Fill(this.infosys202100DataSet.Person);

        }

        private void btNameFilter_Click(object sender, EventArgs e)
        {
            this.personTableAdapter.FillByName(this.infosys202100DataSet.Person, tbNameSearch.Text);
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personBindingSource.EndEdit();
            //this.personTableAdapter.Update(this.infosys202100DataSet.Person);
            this.tableAdapterManager.UpdateAll(this.infosys202100DataSet);
        }

        private void personDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            tbName.Text = personDataGridView.CurrentRow.Cells[1].Value.ToString();      //名前
            dtpDate.Value = (DateTime)personDataGridView.CurrentRow.Cells[2].Value;     //誕生日
            tbTelephone.Text = personDataGridView.CurrentRow.Cells[3].Value.ToString(); //
            tbMemo.Text = personDataGridView.CurrentRow.Cells[4].Value.ToString();      //

        }

        private void button1_Click(object sender, EventArgs e) {
            this.personTableAdapter.ToString();
        }
    }
}
