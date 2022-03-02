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
using System.Configuration;





namespace yutrotden
{
    public partial class FrmOgrKyt : Form
    {
       // public static string data = "Server=Localhost; Database=test; UserID=root; Password= =Zt.2601/*,d";
        public FrmOgrKyt()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        mysqlBaglanti bgl = new mysqlBaglanti(); 
        private void MskOgrTel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        static public int kontrol(string s)
        {
            int x = 0;
            int t = s.IndexOf("@");
            int f = s.IndexOf(".");


            if (t>0 && f>0 && f>t)
            {
                x = 1;
            }
            
            return x;
          
        }
        
        //veri tabanı bağlantısı oluşturma
        MySqlConnection baglanti = new MySqlConnection("Server=Localhost; Database=test; UserID=root; Password= =Zt.2601/*,d");
        private void FrmOgrKyt_Load(object sender, EventArgs e)
        {   //tablodan verileri alma
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select FAKULTE_AD From fakulte ", baglanti);
            MySqlDataReader oku = komut.ExecuteReader();
            //verileri cmbbox'a yazdırma
            while (oku.Read())
            {
                CmbBolum.Items.Add(oku[0].ToString());
            }
            baglanti.Close();
            //odaları veri tabanından çekmek ama sadece boş olanları
            baglanti.Open();
            MySqlCommand komut2 = new MySqlCommand("select ODA_NO From odalar where ODA_KAPASİTE != ODA_AKTİF", baglanti);
            MySqlDataReader oku2 = komut2.ExecuteReader();
            //verileri cmbbox'a yazdırma
            while (oku2.Read())
            {
                CmbOdaNo.Items.Add(oku2[0].ToString());
            }
            baglanti.Close();
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
        private void Btnkaydet_Click(object sender, EventArgs e)
        {
            string dgmtrh = MskOgrDog.Text;
            //doğum tarihi kontrol ediliyor
            bak(dgmtrh);
            //forma girilen öğrenciyi veri tabanına kayıt ettirme

            try
            {
                string s = TxtMail.Text;
                if(kontrol(s)==1)
                {
                   MessageBox.Show("mail adresi doğru");
                }
                else
                {
                    MessageBox.Show("hatalı mail girdiniz");
                    TxtMail.Text = null;
                }

                MySqlCommand komutkyt = new MySqlCommand("INSERT INTO OGR_VERİ (OGR_AD,OGR_SOYAD,TC,TEL,OGR_DOG,OGR_BOLUM,OGR_MAİL,OGR_ODA,OGRV_ADSOYAD,OGRV_TEL,OGR_ADRES)VALUE('" + TxtOgrAd.Text + "','" + TxtOgrSAd.Text + "','" + MskTC.Text + "','" + MskOgrTel.Text + "','" + MskOgrDog.Text + "','" + CmbBolum.Text + "','" + TxtMail.Text + "','" + CmbOdaNo.Text + "','" + TxtVlAd.Text + "','" + MskVelıTel.Text + "','" + RTxtAdres.Text + "')", baglanti);

                baglanti.Open();
                komutkyt.ExecuteNonQuery();
                MessageBox.Show("kayıt başarılı");

                MySqlCommand kmtbrc = new MySqlCommand("SELECT OGR_İD FROM OGR_VERİ ", baglanti);
                MySqlDataReader oku = kmtbrc.ExecuteReader();
                while(oku.Read())
                {
                    label10.Text = oku[0].ToString();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Hata");
            }
            baglanti.Close();
            //BORÇLAR TABLOSUNA KAYIT EKLEME
            MySqlCommand komukyk2 = new MySqlCommand("INSERT INTO BORCLAR (OGR_İD,OGR_AD,OGR_SOYAD)VALUE('" + label10.Text + "','" + TxtOgrAd.Text + "','" + TxtOgrSAd.Text + "')", baglanti);
            baglanti.Open();
            komukyk2.ExecuteNonQuery();
            baglanti.Close();

            // öğrenci oda kontenjanı arttırma
            MySqlCommand kmtknt = new MySqlCommand("update odalar set ODA_AKTİF = ODA_AKTİF+1 WHERE ODA_NO =@ODA1 ",bgl.baglanti());
            kmtknt.Parameters.AddWithValue("@ODA1",CmbOdaNo.Text);
            kmtknt.ExecuteNonQuery();
            bgl.baglanti().Close();









        }
    }
}
