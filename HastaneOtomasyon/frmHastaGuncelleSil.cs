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
    public partial class frmHastaGuncelleSil : Form
    {
        public frmHastaGuncelleSil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Hasta seciliHasta = (Hasta)(lstHastalar.FocusedItem.Tag);
                seciliHasta.Ad = txtAd.Text;
                seciliHasta.Adres = txtAdres.Text;
                seciliHasta.Cinsiyet = (Cinsiyet)cmbCinsiyet.SelectedItem;
                seciliHasta.DogumTarihi = dTDogumTarihi.Value;
                seciliHasta.Mail = txtMail.Text;
                seciliHasta.Soyad = txtSoyad.Text;
                seciliHasta.TCKN = txtTCKimlikNo.Text;
                seciliHasta.Telefon = txtTelefon.Text;
                Islemler.HastalarListesiGuncelle(lstHastalar);
                Islemler.GroupBoxTemizle(groupBox3);
                this.Width = 502;
                groupBox3.Visible = false;
                this.CenterToScreen();
                MessageBox.Show($"{seciliHasta.Ad} {seciliHasta.Soyad} başarılı şekilde güncellenmiştir.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                Hasta seciliHasta = (Hasta)(lstHastalar.FocusedItem.Tag);
                Hasta.Hastalar.Remove(seciliHasta);
                Islemler.HastalarListesiGuncelle(lstHastalar);
                Islemler.GroupBoxTemizle(groupBox3);
                this.Width = 502;
                groupBox3.Visible = false;
                this.CenterToScreen();
            }
        }

        private void frmHastaGuncelleSil_Load(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            Islemler.HastalarListesiGuncelle(lstHastalar);
            cmbCinsiyet.DataSource = Enum.GetValues(typeof(Cinsiyet));
        }

        private void lstHastalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hasta seciliHasta = (Hasta)(lstHastalar.FocusedItem.Tag);
            txtAd.Text = seciliHasta.Ad;
            txtSoyad.Text = seciliHasta.Soyad;
            txtTCKimlikNo.Text = seciliHasta.TCKN;
            txtMail.Text = seciliHasta.Mail;
            txtTelefon.Text = seciliHasta.Telefon;
            txtAdres.Text = seciliHasta.Adres;
            dTDogumTarihi.Value = seciliHasta.DogumTarihi;
            cmbCinsiyet.SelectedItem = seciliHasta.Cinsiyet;
            this.Width = 926;
            groupBox3.Visible = true;
            this.CenterToScreen();
        }
    }
}
