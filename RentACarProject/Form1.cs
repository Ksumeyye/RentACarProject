using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentACarProject.Properties;


namespace RentACarProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        RentACarEntities1 db = new RentACarEntities1(); //Rent A Car Entities adlı sınıfıma db adlı nesne ürettim.


        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMstrListele_Click(object sender, EventArgs e)
        {
            MusteriListeleme fr = new MusteriListeleme();
            fr.Show();
            this.Hide();
        }

        private void BtnMstrEkleme_Click(object sender, EventArgs e)
        {
            FrmMusteriEkle fr = new FrmMusteriEkle();
            fr.Show();
            this.Hide();
        }

        private void BtnArcKayit_Click(object sender, EventArgs e)
        {
            AracKayitSayfasi fr = new AracKayitSayfasi();
            fr.Show();
            this.Hide();
        }

        private void BtnArcListeleme_Click(object sender, EventArgs e)
        {
            FrmAracListeleme fr = new FrmAracListeleme();
            fr.Show();
            this.Hide();
        }

        private void BtnSozlesme_Click(object sender, EventArgs e)
        {
            FrmSozlesme fr = new FrmSozlesme();
            fr.Show();
            this.Hide();
        }

        private void BtnIstatistik_Click(object sender, EventArgs e)
        {
            FrmIstatistik fr = new FrmIstatistik();
            fr.Show();
            this.Hide();
        }
    }
}
