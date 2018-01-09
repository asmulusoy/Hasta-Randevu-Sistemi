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
    public partial class frmHemsireGuncelleSil : Form
    {
        public frmHemsireGuncelleSil()
        {
            InitializeComponent();
        }

        private void frmHemsireGuncelleSil_Load(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            Islemler.HemsirelerListesiGuncelle(lstHemsireler);
            cmbServisler.DataSource = Enum.GetValues(typeof(Servisler));
            cmbCinsiyet.DataSource = Enum.GetValues(typeof(Cinsiyet));
            List<Doktor> yeniliste = (from x in Doktor.Doktorlar
                                      where x.Servis == (Servisler)cmbServisler.SelectedItem
                                      select x).ToList();
            cmbDoktorlar.DataSource = yeniliste;
            cmbDoktorlar.DisplayMember = "AdSoyad";
            cmbDoktorlar.ValueMember = "ID";
            this.Width = 376;

        }

        private void lstHemsireler_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hemsire seciliHemsire = (Hemsire)(lstHemsireler.FocusedItem.Tag);
            txtAd.Text = seciliHemsire.Ad;
            txtSoyad.Text = seciliHemsire.Soyad;
            cmbServisler.SelectedItem = seciliHemsire.Servis;
            txtTCKimlikNo.Text = seciliHemsire.TCKN;
            txtMail.Text = seciliHemsire.Mail;
            txtTelefon.Text = seciliHemsire.Telefon;
            txtAdres.Text = seciliHemsire.Adres;
            dTDogumTarihi.Value = seciliHemsire.DogumTarihi;
            cmbCinsiyet.SelectedItem = seciliHemsire.Cinsiyet;
            cmbDoktorlar.SelectedValue = seciliHemsire.Doktor.ID;
            this.Width = 700;
            groupBox3.Visible = true;
            this.CenterToScreen();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult cevap = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    Hemsire seciliHemsire = (Hemsire)(lstHemsireler.FocusedItem.Tag);
                    Hemsire.Hemsireler.Remove(seciliHemsire);
                    Islemler.DoktorListesiGuncelle(lstHemsireler);
                    Islemler.GroupBoxTemizle(groupBox3);
                    this.Width = 700;
                    groupBox3.Visible = false;
                    this.CenterToScreen();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Hemsire seciliHemsire = (Hemsire)(lstHemsireler.FocusedItem.Tag);
                seciliHemsire.Ad = txtAd.Text;
                seciliHemsire.Adres = txtAdres.Text;
                seciliHemsire.Cinsiyet = (Cinsiyet)cmbCinsiyet.SelectedItem;
                if (cmbDoktorlar.SelectedIndex == 0)
                {
                    seciliHemsire.Doktor = null;
                    seciliHemsire.BostaMi = true;
                }
                else
                {
                    seciliHemsire.Doktor = (Doktor)cmbDoktorlar.SelectedItem;
                    seciliHemsire.BostaMi = false;
                }
                seciliHemsire.DogumTarihi = dTDogumTarihi.Value;
                seciliHemsire.Mail = txtMail.Text;
                seciliHemsire.Soyad = txtSoyad.Text;
                seciliHemsire.Servis = (Servisler)cmbServisler.SelectedItem;
                seciliHemsire.TCKN = txtTCKimlikNo.Text;
                seciliHemsire.Telefon = txtTelefon.Text;
                Islemler.HemsirelerListesiGuncelle(lstHemsireler);
                Islemler.GroupBoxTemizle(groupBox3);
                this.Width = 700;
                groupBox3.Visible = false;
                this.CenterToScreen();
                MessageBox.Show($"{seciliHemsire.Ad} {seciliHemsire.Soyad} başarılı şekilde güncellenmiştir.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Islemler.HemsireAra(lstHemsireler, textBox1);
        }

        private void cmbDoktorlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmbServisler.SelectedItem = ((Doktor)cmbDoktorlar.SelectedItem).Servis;
        }

        private void cmbServisler_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Doktor> yeniliste = (from x in Doktor.Doktorlar
                                      where x.Servis == (Servisler)cmbServisler.SelectedItem
                                      select x).ToList();
            cmbDoktorlar.DataSource = yeniliste;
            cmbDoktorlar.DisplayMember = "AdSoyad";
            cmbDoktorlar.ValueMember = "ID";
        }
    }
}
