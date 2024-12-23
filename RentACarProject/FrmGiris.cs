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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
       
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            RentACarEntities1 db = new RentACarEntities1();
            var sorgu = from x in db.TblAdmin where x.Kullanici == TxtKullaniciAd.Text && x.Sifre == TxtSifre.Text select x;
            if(sorgu.Any()) //Yukarıdaki şartlar sağlanıyorsa any true dönecek 
            {
                Form1 fr = new Form1();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız.");
            }
        }
    }
}
