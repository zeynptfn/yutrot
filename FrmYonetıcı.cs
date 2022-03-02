using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace yutrotden
{
    public partial class FrmYonetıcı : Form
    {
        public FrmYonetıcı()
        {
            InitializeComponent();
        }
        mysqlBaglanti BGL = new mysqlBaglanti();
        private void FrmYonetıcı_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'testDataSet10.yönetici' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.yöneticiTableAdapter.Fill(this.testDataSet10.yönetici);
            dataGridView1.Columns[1].HeaderText = "İd"; dataGridView1.Columns[0].HeaderText = "Ad"; dataGridView1.Columns[2].HeaderText = "Şifre";
        }

        private void btnykyd_Click(object sender, EventArgs e)
        {
            MySqlCommand kmt = new MySqlCommand("INSERT INTO yönetici(YONETICI_AD,YONETICI_SIFRE)VALUE('" +txtYAd.Text + "','" + txtYSfr.Text + "')",BGL.baglanti());
            kmt.ExecuteNonQuery();
            BGL.baglanti().Close();
            MessageBox.Show("yönetici eklendi");
            this.yöneticiTableAdapter.Fill(this.testDataSet10.yönetici);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string ad, sifre, id;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            sifre = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            txtYAd.Text = ad;
            txtYSfr.Text = sifre;
            TxtYıd.Text = id;
        }

        private void btnysl_Click(object sender, EventArgs e)
        {
            MySqlCommand kmt = new MySqlCommand("DELETE FROM yönetici where YONETICI_ID= '"+TxtYıd.Text+"' ",BGL.baglanti());
            kmt.ExecuteNonQuery();
            BGL.baglanti().Close();
            this.yöneticiTableAdapter.Fill(this.testDataSet10.yönetici);
        }

        private void btnygnc_Click(object sender, EventArgs e)
        {
            MySqlCommand kmt = new MySqlCommand("UPDATE yönetici SET YONETICI_AD= @P1, YONETICI_SIFRE=@P2 WHERE YONETICI_ID=@P3 ", BGL.baglanti());
            kmt.Parameters.AddWithValue("@p3", TxtYıd.Text);
            kmt.Parameters.AddWithValue("@p1",txtYAd.Text);
            kmt.Parameters.AddWithValue("@p2", txtYSfr.Text);
           
            kmt.ExecuteNonQuery();
            BGL.baglanti().Close();
            MessageBox.Show("GÜNCELLEME BAŞARILI");
            this.yöneticiTableAdapter.Fill(this.testDataSet10.yönetici);
        }
    }
}
