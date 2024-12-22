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
    public partial class FrmAracListeleme : Form
    {
        public FrmAracListeleme()
        {
            InitializeComponent();
        }
        RentACarEntities1 db = new RentACarEntities1();
        private void FrmAracListeleme_Load(object sender, EventArgs e)
        {
            var araclar = db.TblArac.ToList(); //var bütün değişkenleri üzerine alır. Bu yüzden var kullandım.
            dataGridView1.DataSource = araclar;

            var sozlesme = (from x in db.TblSozlesme select new { x.SozlesmeID, x.KiraSekli }).ToList();
            CmbSozlesmeID.ValueMember = "ID";
            CmbSozlesmeID.DisplayMember = "Kira Şekli";
            CmbSozlesmeID.DataSource = sozlesme;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtAracID.Text);
            var arac = db.TblArac.Find(x);
            db.TblArac.Remove(arac);
            db.SaveChanges();
            MessageBox.Show("Araç Silindi.");
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            FrmAracListeleme fr = new FrmAracListeleme();
            fr.Show();
            this.Hide();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtAracID.Text);
            var arac = db.TblArac.Find(x);
            arac.Plaka = TxtPlaka.Text;
            arac.Marka = CmbAracMarka.Text;
            arac.Seri = CmbAracSeri.Text;
            arac.Yil = int.Parse(TxtAracYil.Text);
            arac.Renk = TxtAracRenk.Text;
            arac.Kilometre = int.Parse(TxtAracKm.Text);
            arac.GunlukKiraUcreti = int.Parse(TxtKiraUcret.Text);
            arac.Tarih = MskAracTarih.Text;
            arac.Durum = CmbAracDurum.Text;
            db.SaveChanges();
            MessageBox.Show("Araç Bilgileri Güncellendi.");
        }
    }
}
