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
    public partial class FrmGdrist : Form
    {
        public FrmGdrist()
        {
            InitializeComponent();
        }
        mysqlBaglanti bgl = new mysqlBaglanti();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {    this.chart1.Series["Aylık"].Points.Clear();
            MySqlCommand kmt3 = new MySqlCommand("SELECT (ELEKTRIK+SU+DOGALGAZ+INTERNET+GIDA+PERSONEL+DIGER) FROM giderler WHERE ODEME_ID = '" + comboBox1.Text + "'", bgl.baglanti());
            MySqlDataReader oku = kmt3.ExecuteReader();
            while (oku.Read())
            {
                label3.Text = oku[0].ToString();
            }
            bgl.baglanti().Close();

            MySqlCommand kmtvrc = new MySqlCommand("select ELEKTRIK,SU, DOGALGAZ,INTERNET,GIDA,PERSONEL,DIGER from giderler WHERE ODEME_ID = '" + comboBox1.Text + "'", bgl.baglanti());
            MySqlDataReader okuvrc = kmtvrc.ExecuteReader();
            while (okuvrc.Read())
            {
                //this.chart1.Series["Aylık"].Points.AddXY("Ay", okuvrc[0]);
                this.chart1.Series["Aylık"].Points.AddXY("Elektrik",okuvrc[0]);
                this.chart1.Series["Aylık"].Points.AddXY("Su",okuvrc[1]);
                this.chart1.Series["Aylık"].Points.AddXY("DoğalGaz",okuvrc[2]);
                this.chart1.Series["Aylık"].Points.AddXY("İnternet",okuvrc[3]);
                this.chart1.Series["Aylık"].Points.AddXY("Gıda",okuvrc[4]);
                this.chart1.Series["Aylık"].Points.AddXY("Personel",okuvrc[5]);
                this.chart1.Series["Aylık"].Points.AddXY("Diğer",okuvrc[6]);
            }

            bgl.baglanti().Close();

        }

        private void FrmGdrist_Load(object sender, EventArgs e)
        {

            MySqlCommand toplam = new MySqlCommand("SELECT SUM(ELEKTRIK)+SUM(SU)+SUM(DOGALGAZ)+SUM(INTERNET)+SUM(GIDA)+SUM(PERSONEL)+SUM(DIGER) FROM giderler",bgl.baglanti());
            MySqlDataReader k = toplam.ExecuteReader();
            k.Read();
            label3.Text = "Toplam Gider:"+k[0].ToString();
            
            
            //Ayları combobax a çekme
            MySqlCommand komut2 = new MySqlCommand("SELECT ODEME_ID FROM giderler ", bgl.baglanti());
            MySqlDataReader oku2 = komut2.ExecuteReader();
            //verileri cmbbox'a yazdırma
            while (oku2.Read())
            {
                comboBox1.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();
        }
    }
}
