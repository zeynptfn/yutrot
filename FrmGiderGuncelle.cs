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
    public partial class FrmGiderGuncelle : Form
    {
        public FrmGiderGuncelle()
        {
            InitializeComponent();
        }
        public string elektrik, su, dogalgaz, gida, diger, internet, personel, id;
        mysqlBaglanti bgld = new mysqlBaglanti();
        private void btngdr_Click(object sender, EventArgs e)
        {
            
                MySqlCommand kmtgdrgncl = new MySqlCommand("update giderler set ELEKTRIK='" + TxtGdrElktrk.Text + "', SU='" + txtsu.Text + "', DOGALGAZ='" + txtgaz.Text + "', INTERNET='" + txtint.Text + "', GIDA='" + txtgıda.Text + "', PERSONEL='" + txtper.Text + "', DIGER='" + txtdgr.Text + "' where  ODEME_ID= '" + txtGDRID.Text + "' ", bgld.baglanti());
                kmtgdrgncl.ExecuteNonQuery();
                bgld.baglanti().Close();
                MessageBox.Show("GİDER GÜNCELLEME İŞLEMİ BAŞARILI");
            /*
            catch (Exception)
            {
                MessageBox.Show("GİDER GÜNCELLEME İŞLEMİ BAŞARISIZ");
            }*/
           

        }

        private void FrmGiderGuncelle_Load(object sender, EventArgs e)
        {
            txtGDRID.Text = id;
            TxtGdrElktrk.Text = elektrik;
            txtsu.Text = su;
            txtgaz.Text = dogalgaz;
            txtgıda.Text = gida;
            txtdgr.Text = diger;
            txtint.Text = internet;
            txtper.Text = personel;
        }
    }
}
