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
    public partial class FrmSozlesme : Form
    {
        public FrmSozlesme()
        {
            InitializeComponent();
        }
        RentACarEntities1 db = new RentACarEntities1();
        private void FrmSozlesme_Load(object sender, EventArgs e)
        {
            var arac = (from x in db.TblArac select new { x.AracID,x.Plaka, x.Marka, x.Seri,x.MusaitMi,x.GunlukKiraUcreti }).ToList();
            CmbAracID.ValueMember = "AracID";
            CmbAracID.DisplayMember = "Plaka"+"Marka"+"Seri"+"MusaitMi"+"GunlukKiraUcreti";
            CmbAracID.DataSource = arac;

            var musteriler = (from m in db.TblMusteri
                              select new
                              {
                                  m.MusteriID,
                                  AdSoyad = m.Ad + " " + m.Soyad // FullName, isim ve soyisim birleşti
                              }).ToList();

            CmbMusteriID.ValueMember = "MusteriID";
            CmbMusteriID.DisplayMember = "Ad"+"Soyad"; // FullName olarak gösterilsin
            CmbMusteriID.DataSource = musteriler;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TblSozlesme s = new TblSozlesme();
            s.KiraSekli = CmbKiraSekli.Text;
            s.KiraGunSayisi = int.Parse(TxtKiraGun.Text);
            s.ToplamTutar = decimal.Parse(TxtToplamTutar.Text);
            s.AlisTarih = TxtAlısTarih.Text;
            s.TeslimTarih = TxtTeslimTarih.Text;
            s.AracID = Convert.ToInt32(CmbAracID.SelectedValue); //Arac Secimi
            s.MusteriID = Convert.ToInt32(CmbMusteriID.SelectedValue); //Müsteri Secimi
            

            db.TblSozlesme.Add(s);
            db.SaveChanges();
            MessageBox.Show("Sözleşme Yapıldı.");

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            //var sozlesmeler = db.TblSozlesme.ToList(); //var bütün değişkenleri üzerine alır. Bu yüzden var kullandım.
            //dataGridView1.DataSource = sozlesmeler;
            dataGridView1.DataSource = (from x in db.TblSozlesme
                                        select new
                                        {
                                            x.SozlesmeID,
                                            x.KiraSekli,
                                            x.KiraGunSayisi,
                                            x.ToplamTutar,
                                            x.AlisTarih,
                                            x.TeslimTarih,
                                            x.TblArac.Plaka,
                                            x.TblArac.Marka,
                                            x.TblArac.Seri,
                                            x.TblArac.MusaitMi,
                                            x.TblMusteri.Ad,
                                            x.TblMusteri.Soyad,
                                            
                                        }).ToList(); //Bu şekilde seçtiğim sütunlar datagrdde listelenecek.
                                      
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int z = Convert.ToInt32(TxtSozlesmeId.Text);
            var sozlesme = db.TblSozlesme.Find(z);
            db.TblSozlesme.Remove(sozlesme);
            db.SaveChanges();
            MessageBox.Show("Sözleşme Silindi.");
        }

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtSozlesmeId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            CmbKiraSekli.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtKiraGun.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtToplamTutar.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtAlısTarih.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtTeslimTarih.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            CmbAracMusaitMi.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
        }

        private void BtnAnaSayfa_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }
    }
    
}
