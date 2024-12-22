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
    public partial class FrmMusteriEkle : Form
    {
        public FrmMusteriEkle()
        {
            InitializeComponent();
        }
        RentACarEntities1 db = new RentACarEntities1();
        private void FrmMusteriEkle_Load(object sender, EventArgs e)
        {

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TblMusteri t = new TblMusteri();
            t.MusteriID = int.Parse(TxtMusteriID.Text);// veri tipim int idi fakat textin içine yadırmak istediğim için dönüşüm yapmam gerekiyordu.  parse methodu ile bir string'i int türüne dönüştür
            t.MusteriTC = MskMusteriTC.Text;
            t.Ad = TxtMusteriAd.Text;
            t.Soyad = TxtMusteriSoyad.Text;
            t.EhliyetTarih = MskEhliyetTarih.Text;
            t.Telefon = MskMusteriTelefon.Text;
            t.Adres = TxtMusteriAdres.Text;
            t.Email = TxtMusteriEmail.Text;
            db.TblMusteri.Add(t);
            db.SaveChanges(); //Değişiklikleri Kaydet.
            MessageBox.Show("Müşteri Eklendi.");
        }
    }
}
