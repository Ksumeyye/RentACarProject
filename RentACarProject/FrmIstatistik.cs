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
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }
        RentACarEntities1 db = new RentACarEntities1();
        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            label2.Text = db.TblArac.Count().ToString();
            label3.Text = db.TblMusteri.Count().ToString();
            label15.Text = db.TblSozlesme.Count().ToString();
            label5.Text = db.TblArac.Count(x=>x.MusaitMi==true).ToString();
            label9.Text = db.TblArac.Count(x => x.MusaitMi == false).ToString();
            label13.Text = (from y in db.TblArac orderby y.GunlukKiraUcreti ascending select y.Marka + " " + y.Seri).FirstOrDefault();
            //label13.Text = db.TblArac.Min(x => x.GunlukKiraUcreti).ToString();
            label7.Text = (from x in db.TblArac orderby x.GunlukKiraUcreti descending select x.Marka +" "+ x.Seri).FirstOrDefault();
            //label7.Text = db.TblArac.Max(x => x.GunlukKiraUcreti).ToString();
        }
    }
}
