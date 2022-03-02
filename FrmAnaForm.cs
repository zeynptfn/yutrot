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
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }
        
        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'testDataSet12.yönetici' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.yöneticiTableAdapter.Fill(this.testDataSet12.yönetici);
            // TODO: Bu kod satırı 'testDataSet9.ogr_veri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.ogr_veriTableAdapter3.Fill(this.testDataSet9.ogr_veri);
            // TODO: Bu kod satırı 'testDataSet8.ogr_veri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.ogr_veriTableAdapter2.Fill(this.testDataSet8.ogr_veri);
            // TODO: Bu kod satırı 'testDataSet7.ogr_veri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.ogr_veriTableAdapter1.Fill(this.testDataSet7.ogr_veri);
            // TODO: Bu kod satırı 'testDataSet.ogr_veri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.ogr_veriTableAdapter.Fill(this.testDataSet.ogr_veri);
            /*MySqlConnection con = new MySqlConnection("Server=Localhost; Database=test; UserID=root; Password= =Zt.2601/*,d"); //open connection
            con.Open();
            dataGridViewANA.DataSource = null;
            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from ogr_veri ", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewANA.DataSource = dt;
            con.Close();*/
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void hESAPMAKİNESİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void pAİNTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("MsPaint.exe");
        }

        private void öĞRENCİEKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrKyt fr = new FrmOgrKyt();
            fr.Show();
        }

        private void öĞRENCİLİSTESİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ogrenciListe fr = new ogrenciListe();
            fr.Show();
        }

        private void öĞRENCİDÜZENLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ogrenciListe fr = new ogrenciListe();
            fr.Show();
        }

        private void öDEMEALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ÖDEMELER fr = new ÖDEMELER();
            fr.Show();
        }

        private void gİDEREKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGiderler fr = new FrmGiderler();
            fr.Show();
        }

        private void gİDERİSTATİKLİKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGiderListe fr = new FrmGiderListe();
            fr.Show();
        }

        private void gELİRİÇİNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGlrİst fr = new FrmGlrİst();
            fr.Show();
        }

        private void şİFREİŞLEMLERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmYonetıcı fr = new FrmYonetıcı();
            fr.Show();
        }

        private void pERSONELDÜZENLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPerDzn fr = new FrmPerDzn();
            fr.Show();
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gİDERİÇİNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGdrist fr = new FrmGdrist();
            fr.Show();
        }
    }
}
