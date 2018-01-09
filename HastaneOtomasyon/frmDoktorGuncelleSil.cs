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
    public partial class frmDoktorGuncelleSil : Form
    {
        public frmDoktorGuncelleSil()
        {
            InitializeComponent();
        }

        private void frmDoktorGuncelleSil_Load(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            Islemler.DoktorListesiGuncelle(lstDoktorlar);
            cmbCinsiyet.DataSource = Enum.GetValues(typeof(Cinsiyet));
            cmbServisler.DataSource = Enum.GetValues(typeof(Servisler));
            this.Width = 376;
        }

       

        private void lstDoktorlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Doktor seciliDoktor = (Doktor)(lstDoktorlar.FocusedItem.Tag);
            txtAd.Text = seciliDoktor.Ad;
            txtSoyad.Text = seciliDoktor.Soyad;
            txtTCKimlikNo.Text = seciliDoktor.TCKN;
            txtMail.Text = seciliDoktor.Mail;
            txtTelefon.Text = seciliDoktor.Telefon;
            txtAdres.Text = seciliDoktor.Adres;
            dTDogumTarihi.Value = seciliDoktor.DogumTarihi;
            cmbCinsiyet.SelectedItem = seciliDoktor.Cinsiyet;
            cmbServisler.SelectedItem = seciliDoktor.Servis;
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
                    Doktor seciliDoktor = (Doktor)(lstDoktorlar.FocusedItem.Tag);
                    Doktor.Doktorlar.Remove(seciliDoktor);
                    Islemler.DoktorListesiGuncelle(lstDoktorlar);
                    Islemler.GroupBoxTemizle(groupBox3);
                    this.Width = 376;
                    groupBox3.Visible = false;
                    this.CenterToScreen();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Doktor seciliDoktor = (Doktor)(lstDoktorlar.FocusedItem.Tag);
                seciliDoktor.Ad = txtAd.Text;
                seciliDoktor.Adres = txtAdres.Text;
                seciliDoktor.Cinsiyet = (Cinsiyet)cmbCinsiyet.SelectedItem;
                seciliDoktor.DogumTarihi = dTDogumTarihi.Value;
                seciliDoktor.Mail = txtMail.Text;
                seciliDoktor.Servis = (Servisler)cmbServisler.SelectedItem;
                seciliDoktor.Soyad = txtSoyad.Text;
                seciliDoktor.TCKN = txtTCKimlikNo.Text;
                seciliDoktor.Telefon = txtTelefon.Text;
                Islemler.DoktorListesiGuncelle(lstDoktorlar);
                Islemler.GroupBoxTemizle(groupBox3);
                this.Width = 376;
                groupBox3.Visible = false;
                MessageBox.Show($"{seciliDoktor.Ad} {seciliDoktor.Soyad} başarılı şekilde güncellenmiştir.");
                this.CenterToScreen();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Islemler.DoktorAra(lstDoktorlar, textBox1);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}

