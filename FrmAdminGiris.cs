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
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }
        mysqlBaglanti bgl = new mysqlBaglanti();
        private void btnGrs_Click(object sender, EventArgs e)
        {
            MySqlCommand kmt = new MySqlCommand("SELECT * FROM yönetici WHERE YONETICI_AD = @A1 AND YONETICI_SIFRE = @A2",bgl.baglanti());
            kmt.Parameters.AddWithValue("@A1",txtKad.Text);
            kmt.Parameters.AddWithValue("@A2",txtKSfr.Text);
            MySqlDataReader vr = kmt.ExecuteReader();

            if (vr.Read())
            {
                FrmAnaForm fr = new FrmAnaForm();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("hatalı giriş");
                txtKad.Clear();
                txtKSfr.Clear();
                txtKad.Focus();
            }
            bgl.baglanti().Close();

        }

        private void txtKad_MouseMove(object sender, MouseEventArgs e)
        {
            txtKad.BackColor = Color.FromArgb(191, 182, 164);
            panel3.BackColor = Color.FromArgb(191, 182, 164);
        }

        private void txtKSfr_MouseMove(object sender, MouseEventArgs e)
        {
            txtKSfr.BackColor = Color.FromArgb(191, 182, 164);
            panel4.BackColor = Color.FromArgb(191,182, 164);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtKSfr_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}
