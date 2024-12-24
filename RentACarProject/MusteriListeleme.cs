using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACarProject
{
    public partial class MusteriListeleme : Form
    {
        public MusteriListeleme()
        {
            InitializeComponent();
        }
        RentACarEntities1 db = new RentACarEntities1();
        private void MusteriListeleme_Load(object sender, EventArgs e)
        {
            //var musteriler = db.TblMusteri.ToList(); //var bütün değişkenleri üzerine alır. Bu yüzden var kullandım.
            //dataGridView1.DataSource = musteriler;

            dataGridView1.DataSource = (from x in db.TblMusteri
                                        select new
                                        {
                                            x.MusteriID,
                                            x.MusteriTC,
                                            x.Ad,
                                            x.Soyad,
                                            x.Telefon,
                                            x.EhliyetTarih,
                                            x.Adres,
                                            x.Email
                                        }).ToList(); //Bu şekilde seçtiğim sütunlar datagridde listelenecek.

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtMusteriID.Text);
            var musteri = db.TblMusteri.Find(x); //TblMusteri tablosunun içindeki Musteri ID ye ait olan x değerini bul
            db.TblMusteri.Remove(musteri); //Bulunan x değerini musterinin içinden sil.
            db.SaveChanges();//Değişiklikleri Kaydet.
            MessageBox.Show("Müşteri Silindi.");

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtMusteriID.Text);
            var musteri = db.TblMusteri.Find(x);
            musteri.MusteriTC = MskMusteriTC.Text;
            musteri.Ad = TxtMusteriAd.Text;
            musteri.Soyad = TxtMusteriSoyad.Text;
            musteri.Telefon = MskMusteriTelefon.Text;
            musteri.EhliyetTarih = MskEhliyetTarih.Text;
            musteri.Adres = TxtMusteriAdres.Text;
            musteri.Email = TxtMusteriEmail.Text;
            db.SaveChanges();
            MessageBox.Show("Güncelleme Yapıldı.");
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            MusteriListeleme fr = new MusteriListeleme();
            fr.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtMusteriID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            MskMusteriTC.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtMusteriAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtMusteriSoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            MskMusteriTelefon.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            MskEhliyetTarih.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtMusteriAdres.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            TxtMusteriEmail.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void BtnAnaSayfa_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }
    }
}
