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
    public partial class ÖDEMELER : Form
    {
        public ÖDEMELER()
        {
            InitializeComponent();
        }

        private void ÖDEMELER_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'testDataSet2.borclar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.borclarTableAdapter.Fill(this.testDataSet2.borclar);
            /* MySqlConnection con = new MySqlConnection("Server=Localhost; Database=test; UserID=root; Password= =Zt.2601/*,d"); //open connection
             con.Open();
             dataGridViewodeme.DataSource = null;
             MySqlDataAdapter adapter = new MySqlDataAdapter("select * from OGR_VERİ", con);
             DataTable dt = new DataTable();
             adapter.Fill(dt);
             dataGridViewodeme.DataSource = dt;
             con.Close();*/
            dataGridViewodeme.Columns[1].HeaderText = "İd"; dataGridViewodeme.Columns[0].HeaderText = "Ad"; dataGridViewodeme.Columns[2].HeaderText = "Borç";

        }
        mysqlBaglanti bgl = new mysqlBaglanti();

        private void dataGridViewodeme_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, kalanbrc;
            secilen = dataGridViewodeme.SelectedCells[0].RowIndex;
            id = dataGridViewodeme.Rows[secilen].Cells[0].Value.ToString();
           
            kalanbrc = dataGridViewodeme.Rows[secilen].Cells[2].Value.ToString();
            textBox1.Text = id; textBox3.Text = kalanbrc;
        }

        private void button1_Click(object sender, EventArgs e)
        {   //borç güncelleme
            int odenen, kalan,yeniborc;
            odenen = Convert.ToInt32(textBox2.Text);

            kalan = Convert.ToInt32(textBox3.Text);
            yeniborc = kalan - odenen;
            textBox3.Text = yeniborc.ToString();
            // veri tabanı borç güncelleme
            MySqlCommand apd = new MySqlCommand("UPDATE BORCLAR SET OGR_KALANBORC = @P1 WHERE OGR_İD = @P2 ", bgl.baglanti());
            apd.Parameters.AddWithValue("@P2",textBox1.Text);
            apd.Parameters.AddWithValue("@P1",textBox3.Text);
            apd.ExecuteNonQuery();
            bgl.baglanti().Close();

            //kasa tablosuna ekleme yapma
            MySqlCommand komutkasa = new MySqlCommand("INSERT INTO kasa (ODEME_AY,ODEME_MIKTAR)VALUE('" +CmbAy.Text + "','" + textBox2.Text + "')", bgl.baglanti());
            komutkasa.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("kasaya eklendi");

        }

        private void dataGridViewodeme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
