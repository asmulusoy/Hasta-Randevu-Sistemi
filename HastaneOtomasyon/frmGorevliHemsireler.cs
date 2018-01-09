using HastaneOtomasyon.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyon
{
    public partial class frmGorevliHemsireler : Form
    {
        public frmGorevliHemsireler()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Islemler.DoktorAra(lstDoktorlar, textBox1);
        }

        private void frmGorevliHemsireler_Load(object sender, EventArgs e)
        {
            Islemler.DoktorListesiGuncelle(lstDoktorlar);
            this.Width = 376;
        }

        private void lstDoktorlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            var seciliDoktorHemsireleri = (from x in Hemsire.Hemsireler
                                           where x.Doktor.ID == ((Doktor)lstDoktorlar.FocusedItem.Tag).ID
                                           select x).ToList();
            lstHemsireler.Items.Clear();
            foreach (Hemsire item in seciliDoktorHemsireleri)
            {
                ListViewItem satir = new ListViewItem();
                satir.Text = item.Ad;
                satir.SubItems.Add(item.Soyad);
                lstHemsireler.Items.Add(satir);
            }
            this.Width = 728;
        }
    }
}
