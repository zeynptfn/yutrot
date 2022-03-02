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
    public partial class FrmPerDzn : Form
    {
        public FrmPerDzn()
        {
            InitializeComponent();
        }
        mysqlBaglanti bgl = new mysqlBaglanti();
        private void FrmPerDzn_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'testDataSet11.personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelTableAdapter.Fill(this.testDataSet11.personel);
            dataGridView1.Columns[0].HeaderText = "İd"; dataGridView1.Columns[1].HeaderText = "Ad"; dataGridView1.Columns[2].HeaderText = "Departman";
        }

        private void btnKyd_Click(object sender, EventArgs e)
        {
            MySqlCommand kmtkyd = new MySqlCommand("INSERT INTO personel(PERSONEL_AD,PERSONEL_DEPARTMAN)VALUE('" + textPERAD.Text + "','" + textPERDEP.Text + "')", bgl.baglanti());
            kmtkyd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("KAYIT BAŞARILI");
            this.personelTableAdapter.Fill(this.testDataSet11.personel);
        }

        private void btnsl_Click(object sender, EventArgs e)
        {
            MySqlCommand kmtSL = new MySqlCommand("DELETE FROM personel where PERSONEL_ID= '" + TxtPERID.Text + "' ", bgl.baglanti());
            kmtSL.ExecuteNonQuery();
            bgl.baglanti().Close();
           
            this.personelTableAdapter.Fill(this.testDataSet11.personel);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string ad, gorev, id;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            gorev = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            TxtPERID.Text = id;
            textPERAD.Text = ad;
            textPERDEP.Text = gorev;

        }

        private void btngnc_Click(object sender, EventArgs e)
        {
            MySqlCommand kmt = new MySqlCommand("UPDATE personel  SET PERSONEL_AD= @P1, PERSONEL_DEPARTMAN=@P2 WHERE PERSONEL_ID=@P3 ", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p3", TxtPERID.Text);
            kmt.Parameters.AddWithValue("@p1", textPERAD.Text);
            kmt.Parameters.AddWithValue("@p2", textPERDEP.Text);

            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("GÜNCELLEME BAŞARILI");

            this.personelTableAdapter.Fill(this.testDataSet11.personel);

        }
    }
}
