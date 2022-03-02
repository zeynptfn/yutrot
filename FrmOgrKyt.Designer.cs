
namespace yutrotden
{
    partial class FrmOgrKyt
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtOgrAdL = new System.Windows.Forms.Label();
            this.TxtOgrAd = new System.Windows.Forms.TextBox();
            this.TxtOgrSAdL = new System.Windows.Forms.Label();
            this.TxtOgrSAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MskOgrTel = new System.Windows.Forms.MaskedTextBox();
            this.MskOgrDog = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbBolum = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbOdaNo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtVlAd = new System.Windows.Forms.TextBox();
            this.MskVelıTel = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.RTxtAdres = new System.Windows.Forms.RichTextBox();
            this.Btnkaydet = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtOgrAdL
            // 
            this.TxtOgrAdL.AutoSize = true;
            this.TxtOgrAdL.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrAdL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(224)))), ((int)(((byte)(205)))));
            this.TxtOgrAdL.Location = new System.Drawing.Point(55, 25);
            this.TxtOgrAdL.Name = "TxtOgrAdL";
            this.TxtOgrAdL.Size = new System.Drawing.Size(118, 24);
            this.TxtOgrAdL.TabIndex = 0;
            this.TxtOgrAdL.Text = "Öğrenci Ad";
            this.TxtOgrAdL.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtOgrAd
            // 
            this.TxtOgrAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(224)))), ((int)(((byte)(205)))));
            this.TxtOgrAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtOgrAd.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TxtOgrAd.Location = new System.Drawing.Point(196, 23);
            this.TxtOgrAd.Name = "TxtOgrAd";
            this.TxtOgrAd.Size = new System.Drawing.Size(251, 26);
            this.TxtOgrAd.TabIndex = 1;
            // 
            // TxtOgrSAdL
            // 
            this.TxtOgrSAdL.AutoSize = true;
            this.TxtOgrSAdL.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrSAdL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(224)))), ((int)(((byte)(205)))));
            this.TxtOgrSAdL.Location = new System.Drawing.Point(24, 57);
            this.TxtOgrSAdL.Name = "TxtOgrSAdL";
            this.TxtOgrSAdL.Size = new System.Drawing.Size(149, 24);
            this.TxtOgrSAdL.TabIndex = 2;
            this.TxtOgrSAdL.Text = "Öğrenci Soyad";
            // 
            // TxtOgrSAd
            // 
            this.TxtOgrSAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(224)))), ((int)(((byte)(205)))));
            this.TxtOgrSAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtOgrSAd.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrSAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TxtOgrSAd.Location = new System.Drawing.Point(196, 55);
            this.TxtOgrSAd.Name = "TxtOgrSAd";
            this.TxtOgrSAd.Size = new System.Drawing.Size(251, 26);
            this.TxtOgrSAd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(224)))), ((int)(((byte)(205)))));
            this.label2.Location = new System.Drawing.Point(138, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "TC";
            // 
            // TxtMail
            // 
            this.TxtMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(224)))), ((int)(((byte)(205)))));
            this.TxtMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtMail.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TxtMail.Location = new System.Drawing.Point(196, 215);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(251, 26);
            this.TxtMail.TabIndex = 5;
            // 
            // MskTC
            // 
            this.MskTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(224)))), ((int)(((byte)(205)))));
            this.MskTC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MskTC.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MskTC.Location = new System.Drawing.Point(196, 87);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(251, 26);
            this.MskTC.TabIndex = 6;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(224)))), ((int)(((byte)(205)))));
            this.label3.Location = new System.Drawing.Point(92, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Telefon";
            // 
            // MskOgrTel
            // 
            this.MskOgrTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(224)))), ((int)(((byte)(205)))));
            this.MskOgrTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MskOgrTel.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskOgrTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MskOgrTel.Location = new System.Drawing.Point(196, 119);
            this.MskOgrTel.Mask = "(999) 000-0000";
            this.MskOgrTel.Name = "MskOgrTel";
            this.MskOgrTel.Size = new System.Drawing.Size(251, 26);
            this.MskOgrTel.TabIndex = 8;
            this.MskOgrTel.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MskOgrTel_MaskInputRejected);
            // 
            // MskOgrDog
            // 
            this.MskOgrDog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(224)))), ((int)(((byte)(205)))));
            this.MskOgrDog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MskOgrDog.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskOgrDog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MskOgrDog.Location = new System.Drawing.Point(196, 151);
            this.MskOgrDog.Mask = "00/00/0000";
            this.MskOgrDog.Name = "MskOgrDog";
            this.MskOgrDog.Size = new System.Drawing.Size(251, 26);
            this.MskOgrDog.TabIndex = 9;
            this.MskOgrDog.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(224)))), ((int)(((byte)(205)))));
            this.label1.Location = new System.Drawing.Point(29, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Doğum Tarihi";
            // 
            // CmbBolum
            // 
            this.CmbBolum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(224)))), ((int)(((byte)(205)))));
            this.CmbBolum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbBolum.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbBolum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CmbBolum.FormattingEnabled = true;
            this.CmbBolum.Location = new System.Drawing.Point(196, 183);
            this.CmbBolum.Name = "CmbBolum";
            this.CmbBolum.Size = new System.Drawing.Size(251, 26);
            this.CmbBolum.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(224)))), ((int)(((byte)(205)))));
            this.label4.Location = new System.Drawing.Point(16, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Öğrenci Bölüm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(224)))), ((int)(((byte)(205)))));
            this.label5.Location = new System.Drawing.Point(31, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Öğrenci Mail ";
            // 
            // CmbOdaNo
            // 
            this.CmbOdaNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(224)))), ((int)(((byte)(205)))));
            this.CmbOdaNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbOdaNo.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbOdaNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CmbOdaNo.FormattingEnabled = true;
            this.CmbOdaNo.Location = new System.Drawing.Point(196, 247);
            this.CmbOdaNo.Name = "CmbOdaNo";
            this.CmbOdaNo.Size = new System.Drawing.Size(251, 26);
            this.CmbOdaNo.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(224)))), ((int)(((byte)(205)))));
            this.label6.Location = new System.Drawing.Point(91, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Oda No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(224)))), ((int)(((byte)(205)))));
            this.label7.Location = new System.Drawing.Point(35, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Veli Ad Soyad";
            // 
            // TxtVlAd
            // 
            this.TxtVlAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(224)))), ((int)(((byte)(205)))));
            this.TxtVlAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtVlAd.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtVlAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TxtVlAd.Location = new System.Drawing.Point(196, 283);
            this.TxtVlAd.Name = "TxtVlAd";
            this.TxtVlAd.Size = new System.Drawing.Size(251, 26);
            this.TxtVlAd.TabIndex = 17;
            // 
            // MskVelıTel
            // 
            this.MskVelıTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(224)))), ((int)(((byte)(205)))));
            this.MskVelıTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MskVelıTel.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskVelıTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MskVelıTel.Location = new System.Drawing.Point(196, 315);
            this.MskVelıTel.Mask = "(999) 000-0000";
            this.MskVelıTel.Name = "MskVelıTel";
            this.MskVelıTel.Size = new System.Drawing.Size(251, 26);
            this.MskVelıTel.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(224)))), ((int)(((byte)(205)))));
            this.label8.Location = new System.Drawing.Point(50, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "Veli Telefon";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(224)))), ((int)(((byte)(205)))));
            this.label9.Location = new System.Drawing.Point(109, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 24);
            this.label9.TabIndex = 20;
            this.label9.Text = "Adres";
            // 
            // RTxtAdres
            // 
            this.RTxtAdres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(224)))), ((int)(((byte)(205)))));
            this.RTxtAdres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTxtAdres.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RTxtAdres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RTxtAdres.Location = new System.Drawing.Point(196, 349);
            this.RTxtAdres.Name = "RTxtAdres";
            this.RTxtAdres.Size = new System.Drawing.Size(251, 116);
            this.RTxtAdres.TabIndex = 21;
            this.RTxtAdres.Text = "";
            // 
            // Btnkaydet
            // 
            this.Btnkaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(224)))), ((int)(((byte)(205)))));
            this.Btnkaydet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(134)))), ((int)(((byte)(123)))));
            this.Btnkaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnkaydet.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btnkaydet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Btnkaydet.Location = new System.Drawing.Point(226, 488);
            this.Btnkaydet.Name = "Btnkaydet";
            this.Btnkaydet.Size = new System.Drawing.Size(183, 46);
            this.Btnkaydet.TabIndex = 22;
            this.Btnkaydet.Text = "Kaydet";
            this.Btnkaydet.UseVisualStyleBackColor = false;
            this.Btnkaydet.Click += new System.EventHandler(this.Btnkaydet_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(224)))), ((int)(((byte)(205)))));
            this.label10.Location = new System.Drawing.Point(17, 365);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "label10";
            this.label10.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::yutrotden.Properties.Resources.images_removebg_preview__3_1;
            this.pictureBox1.Location = new System.Drawing.Point(1, 390);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // FrmOgrKyt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(84)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(506, 564);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Btnkaydet);
            this.Controls.Add(this.RTxtAdres);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MskVelıTel);
            this.Controls.Add(this.TxtVlAd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CmbOdaNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmbBolum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MskOgrDog);
            this.Controls.Add(this.MskOgrTel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtOgrSAd);
            this.Controls.Add(this.TxtOgrSAdL);
            this.Controls.Add(this.TxtOgrAd);
            this.Controls.Add(this.TxtOgrAdL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmOgrKyt";
            this.ShowIcon = false;
            this.Text = "ÖĞRENCİ KAYIT SAYFASI";
            this.Load += new System.EventHandler(this.FrmOgrKyt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TxtOgrAdL;
        private System.Windows.Forms.TextBox TxtOgrAd;
        private System.Windows.Forms.Label TxtOgrSAdL;
        private System.Windows.Forms.TextBox TxtOgrSAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox MskOgrTel;
        private System.Windows.Forms.MaskedTextBox MskOgrDog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbBolum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbOdaNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtVlAd;
        private System.Windows.Forms.MaskedTextBox MskVelıTel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox RTxtAdres;
        private System.Windows.Forms.Button Btnkaydet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

