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
using MySql.Data.EntityFramework;
using System.Configuration;

namespace yutrotden
{
    public partial class ogrenciListe : Form
    {
        public ogrenciListe()
        {
            InitializeComponent();
        }

        private void ogrenciListe_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'testDataSet3.ogr_veri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogr_veriTableAdapter2.Fill(this.testDataSet3.ogr_veri);
            // TODO: Bu kod satırı 'testDataSet.ogr_veri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            // this.ogr_veriTableAdapter1.Fill(this.testDataSet.ogr_veri);
            // TODO: Bu kod satırı 'testDataSet1.ogr_veri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            // this.ogr_veriTableAdapter.Fill(this.testDataSet1.ogr_veri);
            dataGridView1.Columns[1].HeaderText = "AD"; dataGridView1.Columns[0].HeaderText = "NO"; dataGridView1.Columns[2].HeaderText = "SOYAD";
            dataGridView1.Columns[3].HeaderText = "TC"; dataGridView1.Columns[4].HeaderText = "TELEFON"; dataGridView1.Columns[5].HeaderText = "DOĞUM TARİHİ";
            dataGridView1.Columns[6].HeaderText = "BÖLÜM"; dataGridView1.Columns[7].HeaderText = "MAİL"; dataGridView1.Columns[8].HeaderText = "ODA";
            dataGridView1.Columns[9].HeaderText = "VELİ İSİM"; dataGridView1.Columns[10].HeaderText = "VELİ TELEFON"; dataGridView1.Columns[11].HeaderText = "ADRES";
            
        }
        int seçilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seçilen = dataGridView1.SelectedCells[0].RowIndex;
            FrmOgrDzn lb= new FrmOgrDzn();
            lb.id = dataGridView1.Rows[seçilen].Cells[0].Value.ToString();
            lb.ad = dataGridView1.Rows[seçilen].Cells[1].Value.ToString();
            lb.soyad = dataGridView1.Rows[seçilen].Cells[2].Value.ToString();
            lb.tc = dataGridView1.Rows[seçilen].Cells[3].Value.ToString();
            lb.telefon = dataGridView1.Rows[seçilen].Cells[4].Value.ToString();
            lb.dogum= dataGridView1.Rows[seçilen].Cells[5].Value.ToString();
            lb.bolum= dataGridView1.Rows[seçilen].Cells[6].Value.ToString();
            lb.mail = dataGridView1.Rows[seçilen].Cells[7].Value.ToString();
            lb.odano = dataGridView1.Rows[seçilen].Cells[8].Value.ToString(); 
            lb.veliad = dataGridView1.Rows[seçilen].Cells[9].Value.ToString();
            lb.velitel = dataGridView1.Rows[seçilen].Cells[10].Value.ToString();
            lb.adres = dataGridView1.Rows[seçilen].Cells[11].Value.ToString();
            lb.Show();
        }
    }
}
