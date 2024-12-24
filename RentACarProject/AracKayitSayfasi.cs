using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACarProject
{
    public partial class AracKayitSayfasi : Form
    {
        public AracKayitSayfasi()
        {
            InitializeComponent();
        }
        RentACarEntities1 db = new RentACarEntities1();

        private void BtnAracKaydet_Click(object sender, EventArgs e)
        {
            TblArac a=new TblArac();
            a.Plaka = TxtPlaka.Text;
            a.Marka = CmbAracMarka.Text;
            a.Seri = CmbAracSeri.Text;
            a.Yil = int.Parse(TxtAracYili.Text);// veri tipim int idi fakat textin içine yadırmak istediğim için dönüşüm yapmam gerekiyordu.  parse methodu ile bir string'i int türüne dönüştür
            a.Renk = TxtAracRenk.Text;
            a.Kilometre = int.Parse(TxtAracKm.Text);
            a.YakitTuru = CmbYakit.Text;
            a.GunlukKiraUcreti = decimal.Parse(TxtKiraUcret.Text); //veri tipim decimal idi fakat textin içine yadırmak istediğim için dönüşüm yapmam gerekiyordu. parse methodu ile bir string'i decimal tipine dönüştürdüm.
            a.Tarih = MskAracTarih.Text;
            
            if(CmbAracMusaitMi.Text=="Evet")
            {
                a.MusaitMi = true;
            }
            else if (CmbAracMusaitMi.Text=="Hayır")
            {
                a.MusaitMi = false;
            }
            else
            {
                MessageBox.Show("Lütfen Evet ya da Hayır Seçin. ");
                return;
            }

            db.TblArac.Add(a);
            db.SaveChanges(); //Değişiklikleri Kaydet.
            MessageBox.Show("Araç Eklendi.");


        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            FrmAracListeleme fr = new FrmAracListeleme();
            fr.Show();
            this.Hide();
        }

        private void BtnAnaSayfa_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }
    }
}
