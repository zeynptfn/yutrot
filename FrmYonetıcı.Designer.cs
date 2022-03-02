
namespace yutrotden
{
    partial class FrmYonetıcı
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TxtYıd = new System.Windows.Forms.TextBox();
            this.LBLYID = new System.Windows.Forms.Label();
            this.txtYAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYSfr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnykyd = new System.Windows.Forms.Button();
            this.btnygnc = new System.Windows.Forms.Button();
            this.btnysl = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yONETICIIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yONETICIADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yONETICISIFREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yöneticiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet10 = new yutrotden.testDataSet10();
            this.yöneticiTableAdapter = new yutrotden.testDataSet10TableAdapters.yöneticiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yöneticiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtYıd
            // 
            this.TxtYıd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(220)))), ((int)(((byte)(207)))));
            this.TxtYıd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtYıd.Enabled = false;
            this.TxtYıd.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtYıd.Location = new System.Drawing.Point(266, 31);
            this.TxtYıd.Name = "TxtYıd";
            this.TxtYıd.Size = new System.Drawing.Size(192, 25);
            this.TxtYıd.TabIndex = 3;
            // 
            // LBLYID
            // 
            this.LBLYID.AutoSize = true;
            this.LBLYID.Font = new System.Drawing.Font("Constantia", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBLYID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(220)))), ((int)(((byte)(207)))));
            this.LBLYID.Location = new System.Drawing.Point(113, 27);
            this.LBLYID.Name = "LBLYID";
            this.LBLYID.Size = new System.Drawing.Size(129, 27);
            this.LBLYID.TabIndex = 2;
            this.LBLYID.Text = "Yönetici ID";
            // 
            // txtYAd
            // 
            this.txtYAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(220)))), ((int)(((byte)(207)))));
            this.txtYAd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtYAd.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYAd.Location = new System.Drawing.Point(266, 66);
            this.txtYAd.Name = "txtYAd";
            this.txtYAd.Size = new System.Drawing.Size(192, 25);
            this.txtYAd.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(220)))), ((int)(((byte)(207)))));
            this.label1.Location = new System.Drawing.Point(111, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Yönetici Ad";
            // 
            // txtYSfr
            // 
            this.txtYSfr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(220)))), ((int)(((byte)(207)))));
            this.txtYSfr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtYSfr.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYSfr.Location = new System.Drawing.Point(266, 102);
            this.txtYSfr.Name = "txtYSfr";
            this.txtYSfr.Size = new System.Drawing.Size(192, 25);
            this.txtYSfr.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(220)))), ((int)(((byte)(207)))));
            this.label2.Location = new System.Drawing.Point(90, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Yönetici Şifre";
            // 
            // btnykyd
            // 
            this.btnykyd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(224)))), ((int)(((byte)(205)))));
            this.btnykyd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(224)))), ((int)(((byte)(205)))));
            this.btnykyd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnykyd.Font = new System.Drawing.Font("Constantia", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnykyd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.btnykyd.Location = new System.Drawing.Point(77, 153);
            this.btnykyd.Name = "btnykyd";
            this.btnykyd.Size = new System.Drawing.Size(138, 39);
            this.btnykyd.TabIndex = 8;
            this.btnykyd.Text = "KAYDET";
            this.btnykyd.UseVisualStyleBackColor = false;
            this.btnykyd.Click += new System.EventHandler(this.btnykyd_Click);
            // 
            // btnygnc
            // 
            this.btnygnc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(224)))), ((int)(((byte)(205)))));
            this.btnygnc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(224)))), ((int)(((byte)(205)))));
            this.btnygnc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnygnc.Font = new System.Drawing.Font("Constantia", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnygnc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.btnygnc.Location = new System.Drawing.Point(221, 152);
            this.btnygnc.Name = "btnygnc";
            this.btnygnc.Size = new System.Drawing.Size(157, 40);
            this.btnygnc.TabIndex = 9;
            this.btnygnc.Text = "GÜNCELLE";
            this.btnygnc.UseVisualStyleBackColor = false;
            this.btnygnc.Click += new System.EventHandler(this.btnygnc_Click);
            // 
            // btnysl
            // 
            this.btnysl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(224)))), ((int)(((byte)(205)))));
            this.btnysl.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(224)))), ((int)(((byte)(205)))));
            this.btnysl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnysl.Font = new System.Drawing.Font("Constantia", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnysl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.btnysl.Location = new System.Drawing.Point(384, 152);
            this.btnysl.Name = "btnysl";
            this.btnysl.Size = new System.Drawing.Size(123, 40);
            this.btnysl.TabIndex = 10;
            this.btnysl.Text = "SİL";
            this.btnysl.UseVisualStyleBackColor = false;
            this.btnysl.Click += new System.EventHandler(this.btnysl_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(84)))), ((int)(((byte)(31)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(224)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yONETICIIDDataGridViewTextBoxColumn,
            this.yONETICIADDataGridViewTextBoxColumn,
            this.yONETICISIFREDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.yöneticiBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 222);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(224)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(182)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView1.Size = new System.Drawing.Size(561, 286);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // yONETICIIDDataGridViewTextBoxColumn
            // 
            this.yONETICIIDDataGridViewTextBoxColumn.DataPropertyName = "YONETICI_ID";
            this.yONETICIIDDataGridViewTextBoxColumn.HeaderText = "YONETICI_ID";
            this.yONETICIIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yONETICIIDDataGridViewTextBoxColumn.Name = "yONETICIIDDataGridViewTextBoxColumn";
            this.yONETICIIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // yONETICIADDataGridViewTextBoxColumn
            // 
            this.yONETICIADDataGridViewTextBoxColumn.DataPropertyName = "YONETICI_AD";
            this.yONETICIADDataGridViewTextBoxColumn.HeaderText = "YONETICI_AD";
            this.yONETICIADDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yONETICIADDataGridViewTextBoxColumn.Name = "yONETICIADDataGridViewTextBoxColumn";
            this.yONETICIADDataGridViewTextBoxColumn.Width = 125;
            // 
            // yONETICISIFREDataGridViewTextBoxColumn
            // 
            this.yONETICISIFREDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.yONETICISIFREDataGridViewTextBoxColumn.DataPropertyName = "YONETICI_SIFRE";
            this.yONETICISIFREDataGridViewTextBoxColumn.HeaderText = "YONETICI_SIFRE";
            this.yONETICISIFREDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yONETICISIFREDataGridViewTextBoxColumn.Name = "yONETICISIFREDataGridViewTextBoxColumn";
            this.yONETICISIFREDataGridViewTextBoxColumn.Width = 147;
            // 
            // yöneticiBindingSource
            // 
            this.yöneticiBindingSource.DataMember = "yönetici";
            this.yöneticiBindingSource.DataSource = this.testDataSet10;
            // 
            // testDataSet10
            // 
            this.testDataSet10.DataSetName = "testDataSet10";
            this.testDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yöneticiTableAdapter
            // 
            this.yöneticiTableAdapter.ClearBeforeFill = true;
            // 
            // FrmYonetıcı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(76)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(585, 520);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnysl);
            this.Controls.Add(this.btnygnc);
            this.Controls.Add(this.btnykyd);
            this.Controls.Add(this.txtYSfr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtYAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtYıd);
            this.Controls.Add(this.LBLYID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmYonetıcı";
            this.ShowIcon = false;
            this.Text = "YÖNETİCİ KONTROL ";
            this.Load += new System.EventHandler(this.FrmYonetıcı_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yöneticiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtYıd;
        private System.Windows.Forms.Label LBLYID;
        private System.Windows.Forms.TextBox txtYAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYSfr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnykyd;
        private System.Windows.Forms.Button btnygnc;
        private System.Windows.Forms.Button btnysl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private testDataSet10 testDataSet10;
        private System.Windows.Forms.BindingSource yöneticiBindingSource;
        private testDataSet10TableAdapters.yöneticiTableAdapter yöneticiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn yONETICIIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yONETICIADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yONETICISIFREDataGridViewTextBoxColumn;
    }
}