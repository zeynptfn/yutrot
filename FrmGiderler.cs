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
    public partial class FrmGiderler : Form
    {
        public FrmGiderler()
        {
            InitializeComponent();
        }
        mysqlBaglanti bgl = new mysqlBaglanti();
        private void btngdr_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand komutg =
               new MySqlCommand("INSERT INTO giderler (ELEKTRIK,SU,DOGALGAZ,INTERNET,GIDA,PERSONEL,DIGER)VALUE('" + TxtGdrElktrk.Text + "','" + txtsu.Text + "','" + txtgaz.Text + "','" + txtint.Text + "','" + txtgıda.Text + "','" + txtper.Text + "','" + txtdgr.Text + "')", bgl.baglanti());
                komutg.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("KAYIT DURUMU BAŞARILI");
            }
            catch (Exception)
            {
                MessageBox.Show("KAYIT DURUMU BAŞARISIZ");
            }
           
        }
    }
}
