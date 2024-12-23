namespace RentACarProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnMstrEkleme = new System.Windows.Forms.Button();
            this.BtnMstrListele = new System.Windows.Forms.Button();
            this.BtnArcKayit = new System.Windows.Forms.Button();
            this.BtnArcListeleme = new System.Windows.Forms.Button();
            this.BtnSozlesme = new System.Windows.Forms.Button();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnIstatistik = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 266);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnMstrEkleme
            // 
            this.BtnMstrEkleme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMstrEkleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMstrEkleme.Location = new System.Drawing.Point(29, 77);
            this.BtnMstrEkleme.Name = "BtnMstrEkleme";
            this.BtnMstrEkleme.Size = new System.Drawing.Size(297, 23);
            this.BtnMstrEkleme.TabIndex = 1;
            this.BtnMstrEkleme.Text = "Müşteri Ekleme";
            this.BtnMstrEkleme.UseVisualStyleBackColor = true;
            this.BtnMstrEkleme.Click += new System.EventHandler(this.BtnMstrEkleme_Click);
            // 
            // BtnMstrListele
            // 
            this.BtnMstrListele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMstrListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMstrListele.Location = new System.Drawing.Point(29, 124);
            this.BtnMstrListele.Name = "BtnMstrListele";
            this.BtnMstrListele.Size = new System.Drawing.Size(297, 23);
            this.BtnMstrListele.TabIndex = 2;
            this.BtnMstrListele.Text = "Müsteri Listeleme";
            this.BtnMstrListele.UseVisualStyleBackColor = true;
            this.BtnMstrListele.Click += new System.EventHandler(this.BtnMstrListele_Click);
            // 
            // BtnArcKayit
            // 
            this.BtnArcKayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnArcKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnArcKayit.Location = new System.Drawing.Point(29, 173);
            this.BtnArcKayit.Name = "BtnArcKayit";
            this.BtnArcKayit.Size = new System.Drawing.Size(297, 23);
            this.BtnArcKayit.TabIndex = 3;
            this.BtnArcKayit.Text = "Araç Kayıt";
            this.BtnArcKayit.UseVisualStyleBackColor = true;
            this.BtnArcKayit.Click += new System.EventHandler(this.BtnArcKayit_Click);
            // 
            // BtnArcListeleme
            // 
            this.BtnArcListeleme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnArcListeleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnArcListeleme.Location = new System.Drawing.Point(473, 77);
            this.BtnArcListeleme.Name = "BtnArcListeleme";
            this.BtnArcListeleme.Size = new System.Drawing.Size(297, 23);
            this.BtnArcListeleme.TabIndex = 4;
            this.BtnArcListeleme.Text = "Araç Listeleme";
            this.BtnArcListeleme.UseVisualStyleBackColor = true;
            this.BtnArcListeleme.Click += new System.EventHandler(this.BtnArcListeleme_Click);
            // 
            // BtnSozlesme
            // 
            this.BtnSozlesme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSozlesme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSozlesme.Location = new System.Drawing.Point(473, 124);
            this.BtnSozlesme.Name = "BtnSozlesme";
            this.BtnSozlesme.Size = new System.Drawing.Size(297, 23);
            this.BtnSozlesme.TabIndex = 5;
            this.BtnSozlesme.Text = "Sözleşme";
            this.BtnSozlesme.UseVisualStyleBackColor = true;
            this.BtnSozlesme.Click += new System.EventHandler(this.BtnSozlesme_Click);
            // 
            // BtnCikis
            // 
            this.BtnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCikis.Location = new System.Drawing.Point(473, 173);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(297, 23);
            this.BtnCikis.TabIndex = 7;
            this.BtnCikis.Text = "Çıkış";
            this.BtnCikis.UseVisualStyleBackColor = true;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "PIERRE RENT A CAR";
            // 
            // BtnIstatistik
            // 
            this.BtnIstatistik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIstatistik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnIstatistik.Location = new System.Drawing.Point(252, 221);
            this.BtnIstatistik.Name = "BtnIstatistik";
            this.BtnIstatistik.Size = new System.Drawing.Size(297, 23);
            this.BtnIstatistik.TabIndex = 9;
            this.BtnIstatistik.Text = "İstatistikler";
            this.BtnIstatistik.UseVisualStyleBackColor = true;
            this.BtnIstatistik.Click += new System.EventHandler(this.BtnIstatistik_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.BtnIstatistik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCikis);
            this.Controls.Add(this.BtnSozlesme);
            this.Controls.Add(this.BtnArcListeleme);
            this.Controls.Add(this.BtnArcKayit);
            this.Controls.Add(this.BtnMstrListele);
            this.Controls.Add(this.BtnMstrEkleme);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Araç Kiralama Ana Sayfa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnMstrEkleme;
        private System.Windows.Forms.Button BtnMstrListele;
        private System.Windows.Forms.Button BtnArcKayit;
        private System.Windows.Forms.Button BtnArcListeleme;
        private System.Windows.Forms.Button BtnSozlesme;
        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnIstatistik;
    }
}

