namespace RentACarProject
{
    partial class MusteriListeleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriListeleme));
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MskMusteriTC = new System.Windows.Forms.MaskedTextBox();
            this.MskMusteriTelefon = new System.Windows.Forms.MaskedTextBox();
            this.TxtMusteriEmail = new System.Windows.Forms.TextBox();
            this.TxtMusteriAdres = new System.Windows.Forms.TextBox();
            this.TxtMusteriSoyad = new System.Windows.Forms.TextBox();
            this.TxtMusteriAd = new System.Windows.Forms.TextBox();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnSil = new System.Windows.Forms.Button();
            this.TxtMusteriID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MskEhliyetTarih = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(53, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "E-Mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(53, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Adres:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(40, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(50, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(78, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(68, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "T.C.:";
            // 
            // MskMusteriTC
            // 
            this.MskMusteriTC.Location = new System.Drawing.Point(146, 57);
            this.MskMusteriTC.Mask = "00000000000";
            this.MskMusteriTC.Name = "MskMusteriTC";
            this.MskMusteriTC.Size = new System.Drawing.Size(175, 20);
            this.MskMusteriTC.TabIndex = 2;
            this.MskMusteriTC.ValidatingType = typeof(int);
            // 
            // MskMusteriTelefon
            // 
            this.MskMusteriTelefon.Location = new System.Drawing.Point(146, 192);
            this.MskMusteriTelefon.Mask = "(999) 000-0000";
            this.MskMusteriTelefon.Name = "MskMusteriTelefon";
            this.MskMusteriTelefon.Size = new System.Drawing.Size(175, 20);
            this.MskMusteriTelefon.TabIndex = 5;
            // 
            // TxtMusteriEmail
            // 
            this.TxtMusteriEmail.Location = new System.Drawing.Point(146, 327);
            this.TxtMusteriEmail.Name = "TxtMusteriEmail";
            this.TxtMusteriEmail.Size = new System.Drawing.Size(175, 20);
            this.TxtMusteriEmail.TabIndex = 8;
            // 
            // TxtMusteriAdres
            // 
            this.TxtMusteriAdres.Location = new System.Drawing.Point(146, 282);
            this.TxtMusteriAdres.Name = "TxtMusteriAdres";
            this.TxtMusteriAdres.Size = new System.Drawing.Size(175, 20);
            this.TxtMusteriAdres.TabIndex = 7;
            // 
            // TxtMusteriSoyad
            // 
            this.TxtMusteriSoyad.Location = new System.Drawing.Point(146, 147);
            this.TxtMusteriSoyad.Name = "TxtMusteriSoyad";
            this.TxtMusteriSoyad.Size = new System.Drawing.Size(175, 20);
            this.TxtMusteriSoyad.TabIndex = 4;
            // 
            // TxtMusteriAd
            // 
            this.TxtMusteriAd.Location = new System.Drawing.Point(146, 102);
            this.TxtMusteriAd.Name = "TxtMusteriAd";
            this.TxtMusteriAd.Size = new System.Drawing.Size(175, 20);
            this.TxtMusteriAd.TabIndex = 3;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.Color.PapayaWhip;
            this.BtnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Location = new System.Drawing.Point(146, 376);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(175, 40);
            this.BtnGuncelle.TabIndex = 24;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(361, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(940, 300);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.Orange;
            this.BtnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Location = new System.Drawing.Point(1317, 52);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(64, 40);
            this.BtnSil.TabIndex = 27;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // TxtMusteriID
            // 
            this.TxtMusteriID.Location = new System.Drawing.Point(146, 12);
            this.TxtMusteriID.Name = "TxtMusteriID";
            this.TxtMusteriID.Size = new System.Drawing.Size(175, 20);
            this.TxtMusteriID.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(17, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Müşteri ID:";
            // 
            // MskEhliyetTarih
            // 
            this.MskEhliyetTarih.Location = new System.Drawing.Point(146, 237);
            this.MskEhliyetTarih.Mask = "00/00/0000";
            this.MskEhliyetTarih.Name = "MskEhliyetTarih";
            this.MskEhliyetTarih.Size = new System.Drawing.Size(175, 20);
            this.MskEhliyetTarih.TabIndex = 6;
            this.MskEhliyetTarih.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(1, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Ehliyet Tarih:";
            // 
            // BtnListele
            // 
            this.BtnListele.BackColor = System.Drawing.Color.PapayaWhip;
            this.BtnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnListele.Location = new System.Drawing.Point(1307, 114);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(90, 38);
            this.BtnListele.TabIndex = 32;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = false;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // MusteriListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(1411, 428);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.MskEhliyetTarih);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtMusteriID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.MskMusteriTC);
            this.Controls.Add(this.MskMusteriTelefon);
            this.Controls.Add(this.TxtMusteriEmail);
            this.Controls.Add(this.TxtMusteriAdres);
            this.Controls.Add(this.TxtMusteriSoyad);
            this.Controls.Add(this.TxtMusteriAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MusteriListeleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Listeleme Paneli";
            this.Load += new System.EventHandler(this.MusteriListeleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MskMusteriTC;
        private System.Windows.Forms.MaskedTextBox MskMusteriTelefon;
        private System.Windows.Forms.TextBox TxtMusteriEmail;
        private System.Windows.Forms.TextBox TxtMusteriAdres;
        private System.Windows.Forms.TextBox TxtMusteriSoyad;
        private System.Windows.Forms.TextBox TxtMusteriAd;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.TextBox TxtMusteriID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox MskEhliyetTarih;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnListele;
    }
}