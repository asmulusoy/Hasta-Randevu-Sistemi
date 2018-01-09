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
    public partial class frmRandevuYazdir : Form
    {
        public frmRandevuYazdir()
        {
            InitializeComponent();
        }

        private void frmRandevuYazdir_Load(object sender, EventArgs e)
        {
            Islemler.DoktorListesiGuncelle(lstDoktorlar);
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            Islemler.DoktorAra(lstDoktorlar, txtAra);
        }

        private void lstDoktorlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            var randevular = (from x in Randevu.Randevular
                              where x.Doktor.ID == ((Doktor)lstDoktorlar.FocusedItem.Tag).ID
                              select x).ToList();
            lstRandevular.Items.Clear();
            foreach (Randevu item in randevular)
            {
                ListViewItem satir = new ListViewItem();
                satir.Text = item.Doktor.AdSoyad;
                satir.SubItems.Add(item.Hasta.AdSoyad);
                satir.SubItems.Add(item.RandevuSaati.ToShortTimeString());
                satir.Tag = item;
                lstRandevular.Items.Add(satir);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new System.Drawing.Font("Calibri", 14);
            Brush firca = new SolidBrush(Color.Black);
            //ana başlık
            e.Graphics.DrawString("Randevu Listesi", new Font("Calibri", 37), new SolidBrush(Color.Red), 250, 15);//başlık

            //doktor hasta ve randevu saati başlıkları
            Font altBaslikFontu = new Font("Calibri", 16,FontStyle.Bold);
            e.Graphics.DrawString("Doktor", altBaslikFontu, firca, 100, 90);
            e.Graphics.DrawString("Hasta", altBaslikFontu, firca, 350, 90);
            e.Graphics.DrawString("Randevu Saati", altBaslikFontu, firca, 600, 90);

            Pen kalem = new Pen(Color.Black, 2);//çigi kalemi
            e.Graphics.DrawLine(kalem, 0, 120, 1000, 120);//çizgi

            //listview tek tek yazdırılıyor.
            int ykoordinat = 130;
            foreach (ListViewItem item in lstRandevular.Items)
            {
                e.Graphics.DrawString(item.Text, font, firca, 100, ykoordinat);
                e.Graphics.DrawString(item.SubItems[1].Text, font, firca, 350, ykoordinat);
                e.Graphics.DrawString(item.SubItems[2].Text, font, firca, 600, ykoordinat);
                e.Graphics.DrawLine(new Pen(Color.Black, 1), 0, ykoordinat+25, 1000, ykoordinat+25);//aralardaki çizgiler
                ykoordinat += 30;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pageSetupDialog1.ShowDialog() == DialogResult.OK)
            {
                if (printDialog1.ShowDialog() == DialogResult.OK)
                {
                   
                    printDocument1.Print();
                }
            }
            this.Close();
        }
    }
}
