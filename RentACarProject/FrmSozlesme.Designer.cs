namespace RentACarProject
{
    partial class FrmSozlesme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSozlesme));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtSozlesmeId = new System.Windows.Forms.TextBox();
            this.CmbKiraSekli = new System.Windows.Forms.ComboBox();
            this.TxtKiraGun = new System.Windows.Forms.TextBox();
            this.TxtToplamTutar = new System.Windows.Forms.TextBox();
            this.TxtAlısTarih = new System.Windows.Forms.TextBox();
            this.TxtTeslimTarih = new System.Windows.Forms.TextBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.CmbAracID = new System.Windows.Forms.ComboBox();
            this.CmbMusteriID = new System.Windows.Forms.ComboBox();
            this.BtnListele = new System.Windows.Forms.Button();
            this.CmbAracMusaitMi = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 281);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(860, 199);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sözleşme ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(18, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(54, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kira Şekli:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(584, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kiralama Gün Sayısı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(639, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Toplam Tutar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(319, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Alış Tarih:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(297, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Teslim Tarih:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(91, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Araç:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(69, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Müşteri:";
            // 
            // TxtSozlesmeId
            // 
            this.TxtSozlesmeId.Location = new System.Drawing.Point(149, 42);
            this.TxtSozlesmeId.Name = "TxtSozlesmeId";
            this.TxtSozlesmeId.Size = new System.Drawing.Size(125, 20);
            this.TxtSozlesmeId.TabIndex = 1;
            // 
            // CmbKiraSekli
            // 
            this.CmbKiraSekli.FormattingEnabled = true;
            this.CmbKiraSekli.Items.AddRange(new object[] {
            "Günlük",
            "Aylık",
            "Yıllık"});
            this.CmbKiraSekli.Location = new System.Drawing.Point(149, 79);
            this.CmbKiraSekli.Name = "CmbKiraSekli";
            this.CmbKiraSekli.Size = new System.Drawing.Size(125, 21);
            this.CmbKiraSekli.TabIndex = 2;
            // 
            // TxtKiraGun
            // 
            this.TxtKiraGun.Location = new System.Drawing.Point(764, 45);
            this.TxtKiraGun.Name = "TxtKiraGun";
            this.TxtKiraGun.Size = new System.Drawing.Size(125, 20);
            this.TxtKiraGun.TabIndex = 5;
            // 
            // TxtToplamTutar
            // 
            this.TxtToplamTutar.Location = new System.Drawing.Point(764, 80);
            this.TxtToplamTutar.Name = "TxtToplamTutar";
            this.TxtToplamTutar.Size = new System.Drawing.Size(125, 20);
            this.TxtToplamTutar.TabIndex = 6;
            // 
            // TxtAlısTarih
            // 
            this.TxtAlısTarih.Location = new System.Drawing.Point(428, 45);
            this.TxtAlısTarih.Name = "TxtAlısTarih";
            this.TxtAlısTarih.Size = new System.Drawing.Size(122, 20);
            this.TxtAlısTarih.TabIndex = 3;
            // 
            // TxtTeslimTarih
            // 
            this.TxtTeslimTarih.Location = new System.Drawing.Point(428, 87);
            this.TxtTeslimTarih.Name = "TxtTeslimTarih";
            this.TxtTeslimTarih.Size = new System.Drawing.Size(122, 20);
            this.TxtTeslimTarih.TabIndex = 4;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.BtnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Location = new System.Drawing.Point(149, 245);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(125, 30);
            this.BtnKaydet.TabIndex = 20;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = false;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.Bisque;
            this.BtnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Location = new System.Drawing.Point(694, 245);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(140, 30);
            this.BtnSil.TabIndex = 21;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // CmbAracID
            // 
            this.CmbAracID.FormattingEnabled = true;
            this.CmbAracID.Location = new System.Drawing.Point(148, 149);
            this.CmbAracID.Name = "CmbAracID";
            this.CmbAracID.Size = new System.Drawing.Size(741, 21);
            this.CmbAracID.TabIndex = 22;
            // 
            // CmbMusteriID
            // 
            this.CmbMusteriID.FormattingEnabled = true;
            this.CmbMusteriID.Location = new System.Drawing.Point(149, 113);
            this.CmbMusteriID.Name = "CmbMusteriID";
            this.CmbMusteriID.Size = new System.Drawing.Size(740, 21);
            this.CmbMusteriID.TabIndex = 23;
            // 
            // BtnListele
            // 
            this.BtnListele.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.BtnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnListele.Location = new System.Drawing.Point(428, 245);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(125, 30);
            this.BtnListele.TabIndex = 24;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = false;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // CmbAracMusaitMi
            // 
            this.CmbAracMusaitMi.FormattingEnabled = true;
            this.CmbAracMusaitMi.Items.AddRange(new object[] {
            "Hayır",
            "Evet"});
            this.CmbAracMusaitMi.Location = new System.Drawing.Point(428, 176);
            this.CmbAracMusaitMi.Name = "CmbAracMusaitMi";
            this.CmbAracMusaitMi.Size = new System.Drawing.Size(125, 21);
            this.CmbAracMusaitMi.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(333, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Müsait Değil Mi?";
            // 
            // FrmSozlesme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(926, 492);
            this.Controls.Add(this.CmbAracMusaitMi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.CmbMusteriID);
            this.Controls.Add(this.CmbAracID);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.TxtTeslimTarih);
            this.Controls.Add(this.TxtAlısTarih);
            this.Controls.Add(this.TxtToplamTutar);
            this.Controls.Add(this.TxtKiraGun);
            this.Controls.Add(this.CmbKiraSekli);
            this.Controls.Add(this.TxtSozlesmeId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSozlesme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sözleşme Paneli";
            this.Load += new System.EventHandler(this.FrmSozlesme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtSozlesmeId;
        private System.Windows.Forms.ComboBox CmbKiraSekli;
        private System.Windows.Forms.TextBox TxtKiraGun;
        private System.Windows.Forms.TextBox TxtToplamTutar;
        private System.Windows.Forms.TextBox TxtAlısTarih;
        private System.Windows.Forms.TextBox TxtTeslimTarih;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.ComboBox CmbAracID;
        private System.Windows.Forms.ComboBox CmbMusteriID;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.ComboBox CmbAracMusaitMi;
        private System.Windows.Forms.Label label10;
    }
}