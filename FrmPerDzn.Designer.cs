
namespace yutrotden
{
    partial class FrmPerDzn
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
            this.TxtPERID = new System.Windows.Forms.TextBox();
            this.TxtOgrAdL = new System.Windows.Forms.Label();
            this.textPERAD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textPERDEP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKyd = new System.Windows.Forms.Button();
            this.btngnc = new System.Windows.Forms.Button();
            this.btnsl = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pERSONELIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERSONELADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERSONELDEPARTMANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet11 = new yutrotden.testDataSet11();
            this.personelTableAdapter = new yutrotden.testDataSet11TableAdapters.personelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtPERID
            // 
            this.TxtPERID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(208)))));
            this.TxtPERID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPERID.Enabled = false;
            this.TxtPERID.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPERID.Location = new System.Drawing.Point(242, 54);
            this.TxtPERID.Name = "TxtPERID";
            this.TxtPERID.Size = new System.Drawing.Size(191, 25);
            this.TxtPERID.TabIndex = 3;
            // 
            // TxtOgrAdL
            // 
            this.TxtOgrAdL.AutoSize = true;
            this.TxtOgrAdL.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrAdL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(208)))));
            this.TxtOgrAdL.Location = new System.Drawing.Point(98, 54);
            this.TxtOgrAdL.Name = "TxtOgrAdL";
            this.TxtOgrAdL.Size = new System.Drawing.Size(138, 24);
            this.TxtOgrAdL.TabIndex = 2;
            this.TxtOgrAdL.Text = "PERSONEL ID";
            // 
            // textPERAD
            // 
            this.textPERAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(208)))));
            this.textPERAD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPERAD.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textPERAD.Location = new System.Drawing.Point(242, 90);
            this.textPERAD.Name = "textPERAD";
            this.textPERAD.Size = new System.Drawing.Size(191, 25);
            this.textPERAD.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(208)))));
            this.label1.Location = new System.Drawing.Point(92, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "PERSONEL AD";
            // 
            // textPERDEP
            // 
            this.textPERDEP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(208)))));
            this.textPERDEP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPERDEP.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textPERDEP.Location = new System.Drawing.Point(242, 126);
            this.textPERDEP.Name = "textPERDEP";
            this.textPERDEP.Size = new System.Drawing.Size(191, 25);
            this.textPERDEP.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(208)))));
            this.label2.Location = new System.Drawing.Point(48, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "PERSONEL BÖLÜM";
            // 
            // btnKyd
            // 
            this.btnKyd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(46)))), ((int)(((byte)(39)))));
            this.btnKyd.FlatAppearance.BorderSize = 0;
            this.btnKyd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKyd.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKyd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(208)))));
            this.btnKyd.Location = new System.Drawing.Point(80, 180);
            this.btnKyd.Name = "btnKyd";
            this.btnKyd.Size = new System.Drawing.Size(121, 35);
            this.btnKyd.TabIndex = 8;
            this.btnKyd.Text = "KAYDET";
            this.btnKyd.UseVisualStyleBackColor = false;
            this.btnKyd.Click += new System.EventHandler(this.btnKyd_Click);
            // 
            // btngnc
            // 
            this.btngnc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(46)))), ((int)(((byte)(39)))));
            this.btngnc.FlatAppearance.BorderSize = 0;
            this.btngnc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngnc.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngnc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(208)))));
            this.btngnc.Location = new System.Drawing.Point(207, 180);
            this.btngnc.Name = "btngnc";
            this.btngnc.Size = new System.Drawing.Size(122, 34);
            this.btngnc.TabIndex = 9;
            this.btngnc.Text = "GÜNCELLE";
            this.btngnc.UseVisualStyleBackColor = false;
            this.btngnc.Click += new System.EventHandler(this.btngnc_Click);
            // 
            // btnsl
            // 
            this.btnsl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(46)))), ((int)(((byte)(39)))));
            this.btnsl.FlatAppearance.BorderSize = 0;
            this.btnsl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsl.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(208)))));
            this.btnsl.Location = new System.Drawing.Point(335, 180);
            this.btnsl.Name = "btnsl";
            this.btnsl.Size = new System.Drawing.Size(121, 34);
            this.btnsl.TabIndex = 10;
            this.btnsl.Text = "SİL";
            this.btnsl.UseVisualStyleBackColor = false;
            this.btnsl.Click += new System.EventHandler(this.btnsl_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(93)))), ((int)(((byte)(49)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(166)))), ((int)(((byte)(124)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pERSONELIDDataGridViewTextBoxColumn,
            this.pERSONELADDataGridViewTextBoxColumn,
            this.pERSONELDEPARTMANDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personelBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(166)))), ((int)(((byte)(124)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Constantia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(46)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(46)))), ((int)(((byte)(39)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(604, 356);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pERSONELIDDataGridViewTextBoxColumn
            // 
            this.pERSONELIDDataGridViewTextBoxColumn.DataPropertyName = "PERSONEL_ID";
            this.pERSONELIDDataGridViewTextBoxColumn.HeaderText = "PERSONEL_ID";
            this.pERSONELIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pERSONELIDDataGridViewTextBoxColumn.Name = "pERSONELIDDataGridViewTextBoxColumn";
            this.pERSONELIDDataGridViewTextBoxColumn.Width = 135;
            // 
            // pERSONELADDataGridViewTextBoxColumn
            // 
            this.pERSONELADDataGridViewTextBoxColumn.DataPropertyName = "PERSONEL_AD";
            this.pERSONELADDataGridViewTextBoxColumn.HeaderText = "PERSONEL_AD";
            this.pERSONELADDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pERSONELADDataGridViewTextBoxColumn.Name = "pERSONELADDataGridViewTextBoxColumn";
            this.pERSONELADDataGridViewTextBoxColumn.Width = 125;
            // 
            // pERSONELDEPARTMANDataGridViewTextBoxColumn
            // 
            this.pERSONELDEPARTMANDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.pERSONELDEPARTMANDataGridViewTextBoxColumn.DataPropertyName = "PERSONEL_DEPARTMAN";
            this.pERSONELDEPARTMANDataGridViewTextBoxColumn.HeaderText = "PERSONEL_DEPARTMAN";
            this.pERSONELDEPARTMANDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pERSONELDEPARTMANDataGridViewTextBoxColumn.Name = "pERSONELDEPARTMANDataGridViewTextBoxColumn";
            this.pERSONELDEPARTMANDataGridViewTextBoxColumn.Width = 206;
            // 
            // personelBindingSource
            // 
            this.personelBindingSource.DataMember = "personel";
            this.personelBindingSource.DataSource = this.testDataSet11;
            // 
            // testDataSet11
            // 
            this.testDataSet11.DataSetName = "testDataSet11";
            this.testDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelTableAdapter
            // 
            this.personelTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPerDzn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(93)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(628, 589);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsl);
            this.Controls.Add(this.btngnc);
            this.Controls.Add(this.btnKyd);
            this.Controls.Add(this.textPERDEP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textPERAD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPERID);
            this.Controls.Add(this.TxtOgrAdL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmPerDzn";
            this.ShowIcon = false;
            this.Text = "PERSONEL DÜZENLE";
            this.Load += new System.EventHandler(this.FrmPerDzn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPERID;
        private System.Windows.Forms.Label TxtOgrAdL;
        private System.Windows.Forms.TextBox textPERAD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPERDEP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKyd;
        private System.Windows.Forms.Button btngnc;
        private System.Windows.Forms.Button btnsl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private testDataSet11 testDataSet11;
        private System.Windows.Forms.BindingSource personelBindingSource;
        private testDataSet11TableAdapters.personelTableAdapter personelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERSONELIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERSONELADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERSONELDEPARTMANDataGridViewTextBoxColumn;
    }
}