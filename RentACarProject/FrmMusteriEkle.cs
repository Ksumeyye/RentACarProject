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
            //var sozlesme = (from x in db.TblSozlesme select new { x.SozlesmeID, x.KiraSekli }).ToList();
            //CmbSozlesmeID.ValueMember = "ID";
            //CmbSozlesmeID.DisplayMember = "Kira Şekli";
            //CmbSozlesmeID.DataSource = sozlesme;

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TblMusteri t = new TblMusteri();
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

        private void BtnAnaSayfa_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }
    }
}
