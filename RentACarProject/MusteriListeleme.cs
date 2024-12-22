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
            var musteriler = db.TblMusteri.ToList(); //var bütün değişkenleri üzerine alır. Bu yüzden var kullandım.
            dataGridView1.DataSource = musteriler;
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
    }
}
