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
    public partial class FrmGlrİst : Form
    {
        public FrmGlrİst()
        {
            InitializeComponent();
        }
        mysqlBaglanti bgl = new mysqlBaglanti();
        private void FrmGlrİst_Load(object sender, EventArgs e)
        {   //kasadaki toplam parayı görüntüleme
            MySqlCommand kmt = new MySqlCommand("SELECT SUM(ODEME_MIKTAR) FROM KASA", bgl.baglanti());
            MySqlDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                lblKsPr.Text = oku[0].ToString();
            }
            bgl.baglanti().Close();

            //tekrarsız olarak ayları listeleme
            MySqlCommand kmt2 = new MySqlCommand("SELECT distinct(ODEME_AY )FROM KASA", bgl.baglanti());
            MySqlDataReader oku2 = kmt2.ExecuteReader();
            while (oku2.Read())
            {
                CmbAyScm.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();

            //veri tabanından grafiklere veri çekme 
            MySqlCommand kmtvrc = new MySqlCommand("select ODEME_AY, sum(ODEME_MIKTAR) from KASA group by ODEME_AY",bgl.baglanti());
            MySqlDataReader okuvrc = kmtvrc.ExecuteReader();
            while (okuvrc.Read())
            {
                this.chart1.Series["Aylık"].Points.AddXY(okuvrc[0],okuvrc[1]);
            }

            bgl.baglanti().Close();
        }

        private void CmbAyScm_SelectedIndexChanged(object sender, EventArgs e)
        {//combobox taki seçim değiştiğinde kasadan toplam parayı getirme o ay için
            MySqlCommand kmt3 = new MySqlCommand("SELECT SUM(ODEME_MIKTAR) FROM KASA WHERE ODEME_AY = '"+CmbAyScm.Text+"'", bgl.baglanti());
            MySqlDataReader oku = kmt3.ExecuteReader();
            while (oku.Read())
            {
                label3.Text = oku[0].ToString();
            }
            bgl.baglanti().Close();
        }
    }
}
