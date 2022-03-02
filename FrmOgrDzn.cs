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
    public partial class FrmOgrDzn : Form
    {
        public FrmOgrDzn()
        {
            InitializeComponent();
        }
        public string id ,ad ,soyad ,tc,telefon ,dogum ,bolum;

        private void btnOgrDznSl_Click(object sender, EventArgs e)
        { // öğrenci silme
            MySqlCommand kmtsl = new MySqlCommand("DELETE FROM ogr_veri where OGR_İD= '" + txtogrid.Text + "'  ", bgl.baglanti());
            kmtsl.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("kayıt silindi");

            // oda kontenjanı arttırma 
            MySqlCommand kntat = new MySqlCommand("UPDATE odalar SET ODA_AKTİF ODA_AKTİF-1 WHERE ODA_NO =@ODA" ,bgl.baglanti());
            kntat.Parameters.AddWithValue("@ODA",CmbOdaNo.Text);
            kntat.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
        public void bak(string s)
        {
            int trh = DateTime.Now.Year;
            int kntr1 = Int32.Parse(s[0].ToString() + s[1].ToString());
            int kntr2 = Int32.Parse(s[3].ToString() + s[4].ToString());
            int kntr3 = Int32.Parse(s[6].ToString() + s[7].ToString() + s[8].ToString() + s[9].ToString());
            if (kntr1 > 12 || kntr2 > 24 || kntr3 > trh || 1950 > kntr3)
            {
                MskOgrDog.Text = null;
            }
        }
        mysqlBaglanti bgl = new mysqlBaglanti();
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            string s = MskOgrDog.Text;
            bak(s);
            MySqlCommand komut = new MySqlCommand("UPDATE OGR_VERİ SET OGR_AD=@T,OGR_SOYAD=@P2,TC=@P3,TEL=@P4,OGR_DOG=@P5,OGR_BOLUM=@P6,OGR_MAİL=@P7,OGR_ODA=@P8,OGRV_ADSOYAD=@P9,OGRV_TEL=@P10,OGR_ADRES=@P11 WHERE OGR_İD=@P1",bgl.baglanti());
            komut.Parameters.AddWithValue("@P1",txtogrid.Text);
            komut.Parameters.AddWithValue("@T", textBox1.Text);
            komut.Parameters.AddWithValue("@P2",TxtOgrSAd.Text);
            komut.Parameters.AddWithValue("@P3",MskTC.Text);
            komut.Parameters.AddWithValue("@P4",MskOgrTel.Text);
            komut.Parameters.AddWithValue("@P5",MskOgrDog.Text);
            komut.Parameters.AddWithValue("@P6",CmbBolum.Text);
            komut.Parameters.AddWithValue("@P7",TxtMail.Text);
            komut.Parameters.AddWithValue("@P8",CmbOdaNo.Text);
            komut.Parameters.AddWithValue("@P9",TxtVlAd.Text);
            komut.Parameters.AddWithValue("@P10",MskVelıTel.Text);
            komut.Parameters.AddWithValue("@P11",RTxtAdres.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            if (oda_no!=CmbOdaNo.Text)
            {
                MySqlCommand kmtknt = new MySqlCommand("update odalar set ODA_AKTİF = ODA_AKTİF+1 WHERE ODA_NO =@ODA1 ", bgl.baglanti());
                kmtknt.Parameters.AddWithValue("@ODA1", CmbOdaNo.Text);
                kmtknt.ExecuteNonQuery();
                bgl.baglanti().Close();
            }
        }

        public string mail, odano, veliad ,velitel ,adres;
        public  string oda_no;
        private void FrmOgrDzn_Load(object sender, EventArgs e)
        {   
            txtogrid.Text = id;
            //TxtOgrAd.Text = ad;
            textBox1.Text = ad;
            TxtOgrSAd.Text = soyad;
            MskTC.Text = tc;
            MskOgrDog.Text = dogum;
            MskOgrTel.Text = telefon;
            CmbBolum.Text = bolum;
            TxtMail.Text = mail;
            CmbOdaNo.Text = odano;
            TxtVlAd.Text = veliad;
            MskVelıTel.Text = velitel;
            RTxtAdres.Text = adres;

            oda_no = odano;

            bgl.baglanti();
            MySqlCommand komut2 = new MySqlCommand("select ODA_NO From odalar where ODA_KAPASİTE != ODA_AKTİF", bgl.baglanti());
            MySqlDataReader oku2 = komut2.ExecuteReader();
            //verileri cmbbox'a yazdırma
            while (oku2.Read())
            {
                CmbOdaNo.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();
        }
    }
}
