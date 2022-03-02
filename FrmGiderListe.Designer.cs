
namespace yutrotden
{
    partial class FrmGiderListe
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
            this.testDataSet5 = new yutrotden.testDataSet5();
            this.giderlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.giderlerTableAdapter = new yutrotden.testDataSet5TableAdapters.giderlerTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.oDEMEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eLEKTRIKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOGALGAZDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıNTERNETDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERSONELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIGERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giderlerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet6 = new yutrotden.testDataSet6();
            this.giderlerTableAdapter1 = new yutrotden.testDataSet6TableAdapters.giderlerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderlerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // testDataSet5
            // 
            this.testDataSet5.DataSetName = "testDataSet5";
            this.testDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giderlerBindingSource
            // 
            this.giderlerBindingSource.DataMember = "giderler";
            this.giderlerBindingSource.DataSource = this.testDataSet5;
            // 
            // giderlerTableAdapter
            // 
            this.giderlerTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(84)))), ((int)(((byte)(31)))));
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
            this.oDEMEIDDataGridViewTextBoxColumn,
            this.eLEKTRIKDataGridViewTextBoxColumn,
            this.sUDataGridViewTextBoxColumn,
            this.dOGALGAZDataGridViewTextBoxColumn,
            this.ıNTERNETDataGridViewTextBoxColumn,
            this.gIDADataGridViewTextBoxColumn,
            this.pERSONELDataGridViewTextBoxColumn,
            this.dIGERDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.giderlerBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(224)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(182)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1263, 517);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // oDEMEIDDataGridViewTextBoxColumn
            // 
            this.oDEMEIDDataGridViewTextBoxColumn.DataPropertyName = "ODEME_ID";
            this.oDEMEIDDataGridViewTextBoxColumn.HeaderText = "ODEME_ID";
            this.oDEMEIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oDEMEIDDataGridViewTextBoxColumn.Name = "oDEMEIDDataGridViewTextBoxColumn";
            this.oDEMEIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // eLEKTRIKDataGridViewTextBoxColumn
            // 
            this.eLEKTRIKDataGridViewTextBoxColumn.DataPropertyName = "ELEKTRIK";
            this.eLEKTRIKDataGridViewTextBoxColumn.HeaderText = "ELEKTRIK";
            this.eLEKTRIKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eLEKTRIKDataGridViewTextBoxColumn.Name = "eLEKTRIKDataGridViewTextBoxColumn";
            this.eLEKTRIKDataGridViewTextBoxColumn.Width = 125;
            // 
            // sUDataGridViewTextBoxColumn
            // 
            this.sUDataGridViewTextBoxColumn.DataPropertyName = "SU";
            this.sUDataGridViewTextBoxColumn.HeaderText = "SU";
            this.sUDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sUDataGridViewTextBoxColumn.Name = "sUDataGridViewTextBoxColumn";
            this.sUDataGridViewTextBoxColumn.Width = 125;
            // 
            // dOGALGAZDataGridViewTextBoxColumn
            // 
            this.dOGALGAZDataGridViewTextBoxColumn.DataPropertyName = "DOGALGAZ";
            this.dOGALGAZDataGridViewTextBoxColumn.HeaderText = "DOGALGAZ";
            this.dOGALGAZDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dOGALGAZDataGridViewTextBoxColumn.Name = "dOGALGAZDataGridViewTextBoxColumn";
            this.dOGALGAZDataGridViewTextBoxColumn.Width = 125;
            // 
            // ıNTERNETDataGridViewTextBoxColumn
            // 
            this.ıNTERNETDataGridViewTextBoxColumn.DataPropertyName = "INTERNET";
            this.ıNTERNETDataGridViewTextBoxColumn.HeaderText = "INTERNET";
            this.ıNTERNETDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıNTERNETDataGridViewTextBoxColumn.Name = "ıNTERNETDataGridViewTextBoxColumn";
            this.ıNTERNETDataGridViewTextBoxColumn.Width = 125;
            // 
            // gIDADataGridViewTextBoxColumn
            // 
            this.gIDADataGridViewTextBoxColumn.DataPropertyName = "GIDA";
            this.gIDADataGridViewTextBoxColumn.HeaderText = "GIDA";
            this.gIDADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gIDADataGridViewTextBoxColumn.Name = "gIDADataGridViewTextBoxColumn";
            this.gIDADataGridViewTextBoxColumn.Width = 125;
            // 
            // pERSONELDataGridViewTextBoxColumn
            // 
            this.pERSONELDataGridViewTextBoxColumn.DataPropertyName = "PERSONEL";
            this.pERSONELDataGridViewTextBoxColumn.HeaderText = "PERSONEL";
            this.pERSONELDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pERSONELDataGridViewTextBoxColumn.Name = "pERSONELDataGridViewTextBoxColumn";
            this.pERSONELDataGridViewTextBoxColumn.Width = 125;
            // 
            // dIGERDataGridViewTextBoxColumn
            // 
            this.dIGERDataGridViewTextBoxColumn.DataPropertyName = "DIGER";
            this.dIGERDataGridViewTextBoxColumn.HeaderText = "DIGER";
            this.dIGERDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dIGERDataGridViewTextBoxColumn.Name = "dIGERDataGridViewTextBoxColumn";
            this.dIGERDataGridViewTextBoxColumn.Width = 125;
            // 
            // giderlerBindingSource1
            // 
            this.giderlerBindingSource1.DataMember = "giderler";
            this.giderlerBindingSource1.DataSource = this.testDataSet6;
            // 
            // testDataSet6
            // 
            this.testDataSet6.DataSetName = "testDataSet6";
            this.testDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giderlerTableAdapter1
            // 
            this.giderlerTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmGiderListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 517);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmGiderListe";
            this.ShowIcon = false;
            this.Text = "AYLARA GÖRE GİDER LİSTESİ";
            this.Load += new System.EventHandler(this.FrmGiderListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderlerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private testDataSet5 testDataSet5;
        private System.Windows.Forms.BindingSource giderlerBindingSource;
        private testDataSet5TableAdapters.giderlerTableAdapter giderlerTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn oDEMEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eLEKTRIKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOGALGAZDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıNTERNETDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERSONELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIGERDataGridViewTextBoxColumn;
        private testDataSet6 testDataSet6;
        private System.Windows.Forms.BindingSource giderlerBindingSource1;
        private testDataSet6TableAdapters.giderlerTableAdapter giderlerTableAdapter1;
    }
}