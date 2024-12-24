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
            //var araclar = db.TblArac.ToList(); //var bütün değişkenleri üzerine alır. Bu yüzden var kullandım.
            //dataGridView1.DataSource = araclar;

            dataGridView1.DataSource = (from x in db.TblArac
                                        select new
                                        {
                                            x.AracID,
                                            x.Plaka,
                                            x.Marka,
                                            x.Seri,
                                            x.Yil,
                                            x.Renk,
                                            x.Kilometre,
                                            x.YakitTuru,
                                            x.GunlukKiraUcreti,
                                            x.Tarih,
                                            x.MusaitMi
                                        }).ToList(); //Bu şekilde seçtiğim sütunlar datagrdde listelenecek.


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
            arac.GunlukKiraUcreti = decimal.Parse(TxtKiraUcret.Text);
            arac.Tarih = TxtTarih.Text;
            arac.MusaitMi = bool.Parse(CmbAracMusaitMi.Text);
            db.SaveChanges();
            MessageBox.Show("Araç Bilgileri Güncellendi.");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtAracID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtPlaka.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            CmbAracMarka.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbAracSeri.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtAracYil.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtAracRenk.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtAracKm.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            CmbYakit.Text = dataGridView1.Rows[secilen ].Cells[7].Value.ToString();
            TxtKiraUcret.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            TxtTarih.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            CmbAracMusaitMi.Text = dataGridView1.Rows[secilen].Cells[10].Value.ToString();

        }

        private void BtnAnaSayfa_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }
    }
}
