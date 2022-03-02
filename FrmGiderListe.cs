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
    public partial class FrmGiderListe : Form
    {
        public FrmGiderListe()
        {
            InitializeComponent();
        }

        private void FrmGiderListe_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'testDataSet6.giderler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.giderlerTableAdapter1.Fill(this.testDataSet6.giderler);
            // TODO: Bu kod satırı 'testDataSet5.giderler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            // this.giderlerTableAdapter.Fill(this.testDataSet5.giderler);
            /* MySqlConnection con = new MySqlConnection("Server=Localhost; Database=test; UserID=root; Password= =Zt.2601/*,d"); //open connection
             con.Open();
             dataGridViewgider.DataSource = null;
             MySqlDataAdapter adapter = new MySqlDataAdapter("select * from giderler", con);
             DataTable dt = new DataTable();
             adapter.Fill(dt);
             dataGridViewgider.DataSource = dt;
             con.Close();*/
            dataGridView1.Columns[0].HeaderText = "AY"; dataGridView1.Columns[1].HeaderText = "ELEKTRİK"; dataGridView1.Columns[2].HeaderText = "SU";
            dataGridView1.Columns[3].HeaderText = "DOĞAL GAZ"; dataGridView1.Columns[4].HeaderText = "İNTERNET"; dataGridView1.Columns[5].HeaderText = "GIDA";
            dataGridView1.Columns[6].HeaderText = "PERSONEL"; dataGridView1.Columns[7].HeaderText = "DİĞER"; 
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            FrmGiderGuncelle frg = new FrmGiderGuncelle();
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            frg.id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            frg.elektrik = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            frg.su = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            frg.dogalgaz = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            frg.internet = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            frg.gida = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            frg.personel = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            frg.diger = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            frg.Show();
        }
    }
}
