namespace RentACarProject
{
    partial class FrmAracListeleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAracListeleme));
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.TxtAracRenk = new System.Windows.Forms.TextBox();
            this.CmbYakit = new System.Windows.Forms.ComboBox();
            this.CmbAracSeri = new System.Windows.Forms.ComboBox();
            this.CmbAracMarka = new System.Windows.Forms.ComboBox();
            this.TxtAracKm = new System.Windows.Forms.TextBox();
            this.TxtPlaka = new System.Windows.Forms.TextBox();
            this.TxtAracID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbAracMusaitMi = new System.Windows.Forms.ComboBox();
            this.TxtKiraUcret = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnListele = new System.Windows.Forms.Button();
            this.TxtAracYil = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtTarih = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnAnaSayfa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.Color.PapayaWhip;
            this.BtnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Location = new System.Drawing.Point(45, 359);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(251, 34);
            this.BtnGuncelle.TabIndex = 42;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // TxtAracRenk
            // 
            this.TxtAracRenk.Location = new System.Drawing.Point(175, 172);
            this.TxtAracRenk.Name = "TxtAracRenk";
            this.TxtAracRenk.Size = new System.Drawing.Size(121, 20);
            this.TxtAracRenk.TabIndex = 6;
            // 
            // CmbYakit
            // 
            this.CmbYakit.FormattingEnabled = true;
            this.CmbYakit.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "Elektrik"});
            this.CmbYakit.Location = new System.Drawing.Point(175, 223);
            this.CmbYakit.Name = "CmbYakit";
            this.CmbYakit.Size = new System.Drawing.Size(121, 21);
            this.CmbYakit.TabIndex = 8;
            // 
            // CmbAracSeri
            // 
            this.CmbAracSeri.FormattingEnabled = true;
            this.CmbAracSeri.Items.AddRange(new object[] {
            "Mokka",
            "Astra",
            "Corsa",
            "308",
            "208",
            "3008",
            "i20",
            "i30",
            "Bayon",
            "Clio",
            "Megane",
            "Qashqai",
            "Micra",
            "T-Roc",
            "Golf",
            "c3"});
            this.CmbAracSeri.Location = new System.Drawing.Point(175, 119);
            this.CmbAracSeri.Name = "CmbAracSeri";
            this.CmbAracSeri.Size = new System.Drawing.Size(121, 21);
            this.CmbAracSeri.TabIndex = 4;
            // 
            // CmbAracMarka
            // 
            this.CmbAracMarka.FormattingEnabled = true;
            this.CmbAracMarka.Items.AddRange(new object[] {
            "Opel",
            "Peugeot",
            "Nissan",
            "Hyundai",
            "Renault",
            "Volkswagen",
            "Citroen"});
            this.CmbAracMarka.Location = new System.Drawing.Point(175, 92);
            this.CmbAracMarka.Name = "CmbAracMarka";
            this.CmbAracMarka.Size = new System.Drawing.Size(121, 21);
            this.CmbAracMarka.TabIndex = 3;
            // 
            // TxtAracKm
            // 
            this.TxtAracKm.Location = new System.Drawing.Point(175, 198);
            this.TxtAracKm.Name = "TxtAracKm";
            this.TxtAracKm.Size = new System.Drawing.Size(121, 20);
            this.TxtAracKm.TabIndex = 7;
            // 
            // TxtPlaka
            // 
            this.TxtPlaka.Location = new System.Drawing.Point(175, 66);
            this.TxtPlaka.Name = "TxtPlaka";
            this.TxtPlaka.Size = new System.Drawing.Size(121, 20);
            this.TxtPlaka.TabIndex = 2;
            // 
            // TxtAracID
            // 
            this.TxtAracID.Location = new System.Drawing.Point(175, 40);
            this.TxtAracID.Name = "TxtAracID";
            this.TxtAracID.Size = new System.Drawing.Size(121, 20);
            this.TxtAracID.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(64, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "Yakıt Türü:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(70, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "Kilometre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(98, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "Renk:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(59, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Model (Yıl):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(106, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Seri:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(92, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Marka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(94, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Plaka:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(83, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Araç ID:";
            // 
            // CmbAracMusaitMi
            // 
            this.CmbAracMusaitMi.FormattingEnabled = true;
            this.CmbAracMusaitMi.Items.AddRange(new object[] {
            "Müsait",
            "Müsait Değil"});
            this.CmbAracMusaitMi.Location = new System.Drawing.Point(175, 302);
            this.CmbAracMusaitMi.Name = "CmbAracMusaitMi";
            this.CmbAracMusaitMi.Size = new System.Drawing.Size(121, 21);
            this.CmbAracMusaitMi.TabIndex = 11;
            // 
            // TxtKiraUcret
            // 
            this.TxtKiraUcret.Location = new System.Drawing.Point(175, 250);
            this.TxtKiraUcret.Name = "TxtKiraUcret";
            this.TxtKiraUcret.Size = new System.Drawing.Size(121, 20);
            this.TxtKiraUcret.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(12, 255);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 16);
            this.label13.TabIndex = 44;
            this.label13.Text = "Günlük Kira Ücreti:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(317, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(974, 256);
            this.dataGridView1.TabIndex = 53;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.Orange;
            this.BtnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Location = new System.Drawing.Point(1322, 40);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(60, 30);
            this.BtnSil.TabIndex = 54;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnListele
            // 
            this.BtnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnListele.Location = new System.Drawing.Point(1297, 93);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(121, 34);
            this.BtnListele.TabIndex = 55;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // TxtAracYil
            // 
            this.TxtAracYil.Location = new System.Drawing.Point(175, 146);
            this.TxtAracYil.Name = "TxtAracYil";
            this.TxtAracYil.Size = new System.Drawing.Size(121, 20);
            this.TxtAracYil.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(98, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 59;
            this.label9.Text = "Tarih:";
            // 
            // TxtTarih
            // 
            this.TxtTarih.Location = new System.Drawing.Point(175, 276);
            this.TxtTarih.Name = "TxtTarih";
            this.TxtTarih.Size = new System.Drawing.Size(121, 20);
            this.TxtTarih.TabIndex = 60;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(70, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 16);
            this.label10.TabIndex = 62;
            this.label10.Text = "Müsait Mi?";
            // 
            // BtnAnaSayfa
            // 
            this.BtnAnaSayfa.BackColor = System.Drawing.Color.Red;
            this.BtnAnaSayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAnaSayfa.Location = new System.Drawing.Point(1297, 150);
            this.BtnAnaSayfa.Name = "BtnAnaSayfa";
            this.BtnAnaSayfa.Size = new System.Drawing.Size(124, 23);
            this.BtnAnaSayfa.TabIndex = 63;
            this.BtnAnaSayfa.Text = "Ana Sayfaya Dön";
            this.BtnAnaSayfa.UseVisualStyleBackColor = false;
            this.BtnAnaSayfa.Click += new System.EventHandler(this.BtnAnaSayfa_Click);
            // 
            // FrmAracListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(1448, 418);
            this.Controls.Add(this.BtnAnaSayfa);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtTarih);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtAracYil);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CmbAracMusaitMi);
            this.Controls.Add(this.TxtKiraUcret);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.TxtAracRenk);
            this.Controls.Add(this.CmbYakit);
            this.Controls.Add(this.CmbAracSeri);
            this.Controls.Add(this.CmbAracMarka);
            this.Controls.Add(this.TxtAracKm);
            this.Controls.Add(this.TxtPlaka);
            this.Controls.Add(this.TxtAracID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAracListeleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Listeleme Paneli";
            this.Load += new System.EventHandler(this.FrmAracListeleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.TextBox TxtAracRenk;
        private System.Windows.Forms.ComboBox CmbYakit;
        private System.Windows.Forms.ComboBox CmbAracSeri;
        private System.Windows.Forms.ComboBox CmbAracMarka;
        private System.Windows.Forms.TextBox TxtAracKm;
        private System.Windows.Forms.TextBox TxtPlaka;
        private System.Windows.Forms.TextBox TxtAracID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbAracMusaitMi;
        private System.Windows.Forms.TextBox TxtKiraUcret;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.TextBox TxtAracYil;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtTarih;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnAnaSayfa;
    }
}