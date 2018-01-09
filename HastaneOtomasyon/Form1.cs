using HastaneOtomasyon.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyon
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Randevu seciliRandevu;
        private void Form1_Load(object sender, EventArgs e)
        {
            Islemler.OncekiRandevulariSil();
            if (File.Exists(Application.StartupPath + "/Save.xml"))
            {
                Islemler.IceriAktar();
            }
            Islemler.RandevulariCek(listView1);
        }
        private void randevuEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRandevuEkle frm = new frmRandevuEkle();
            frm.ShowDialog();
        }

        private void btnRandevuEkle_Click(object sender, EventArgs e)
        {
            frmRandevuEkle frm = new frmRandevuEkle();
            frm.ShowDialog();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDoktorEkle_Click(object sender, EventArgs e)
        {
            frmDoktorEkle frm = new frmDoktorEkle();
            frm.ShowDialog();
        }

        private void doktorEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoktorEkle frm = new frmDoktorEkle();
            frm.ShowDialog();
        }

        private void içeAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Islemler.IceriAktar();
        }

        private void dışaAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Islemler.DısariAktar();
        }

        private void doktorGüncelleSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoktorGuncelleSil frm = new frmDoktorGuncelleSil();
            frm.ShowDialog();
        }

        private void hemşireEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHemsireEkle frm = new frmHemsireEkle();
            frm.ShowDialog();
        }

        private void personelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonelEkle frm = new frmPersonelEkle();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmRandevuYazdir frm = new frmRandevuYazdir();
            frm.ShowDialog();
        }

        private void içeAktarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Islemler.IceriAktar();
        }

        private void dışaAktarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Islemler.DısariAktar();
        }

        private void personelEkleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmPersonelEkle frm = new frmPersonelEkle();
            frm.ShowDialog();
        }

        private void personelGüncelleSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonelGuncelleSil frm = new frmPersonelGuncelleSil();
            frm.ShowDialog();
        }

        private void hemşireGüncelleSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHemsireGuncelleSil frm = new frmHemsireGuncelleSil();
            frm.ShowDialog();
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Islemler.DısariAktar();// Tüm listeleri kaydetmemizi sağlıyor.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void hastaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHastaEkle frm = new frmHastaEkle();
            frm.ShowDialog();
        }

        private void hastaGüncelleSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHastaGuncelleSil frm = new frmHastaGuncelleSil();
            frm.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Islemler.DısariAktar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmHemsireyeDoktorSec frm = new frmHemsireyeDoktorSec();
            frm.ShowDialog();
        }

        private void görevliHemşirelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGorevliHemsireler frm = new frmGorevliHemsireler();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmHemsireEkle frm = new frmHemsireEkle();
            frm.ShowDialog();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Islemler.RandevulariCek(listView1);
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seciliRandevu != null)
            {
                DialogResult cevap = MessageBox.Show($"{seciliRandevu.Hasta.AdSoyad} adlı hastanın Dr.{seciliRandevu.Doktor.AdSoyad} ile saat  {seciliRandevu.RandevuSaati.ToShortTimeString()} olan randuvusu silinecek emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    Randevu.Randevular.Remove(seciliRandevu);
                    listView1.Items.Clear();
                    Islemler.RandevulariCek(listView1);
                    seciliRandevu = null;
                }
            }

        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Randevu seciliRandevu = (Randevu)listView1.FocusedItem.Tag;
            frmRandevuEkleDoktorSec frm = new frmRandevuEkleDoktorSec();
            frm.Tag = seciliRandevu;
            frm.ShowDialog();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                seciliRandevu = (Randevu)listView1.SelectedItems[0].Tag;
            }
            catch (Exception)
            {
            }
        }
    }
}
