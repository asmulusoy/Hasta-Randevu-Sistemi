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
    public partial class frmDoktorEkle : Form
    {
        public frmDoktorEkle()
        {
            InitializeComponent();
        }

        private void btnVazgeç_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Bilgiler kaydedilmeden kapatılacaktır.\nEmin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (cevap == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmDoktorEkle_Load(object sender, EventArgs e)
        {
            cmbServisler.DataSource = Enum.GetValues(typeof(Servisler));
            cmbCinsiyet.DataSource = Enum.GetValues(typeof(Cinsiyet));
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Doktor yeni = new Doktor()
                {
                    Ad = txtAd.Text,
                    Adres = txtAdres.Text,
                    Cinsiyet = (Cinsiyet)cmbCinsiyet.SelectedItem,
                    DogumTarihi = dTDogumTarihi.Value,
                    Mail = txtMail.Text,
                    Maas = decimal.Parse(txtMaas.Text),
                    Servis = (Servisler)cmbServisler.SelectedItem,
                    Soyad = txtSoyad.Text,
                    TCKN = txtTCKimlikNo.Text,
                    Telefon = txtTelefon.Text,
                    ID = Guid.NewGuid()
                };
                Doktor.Doktorlar.Add(yeni);
                MessageBox.Show($" Dr. {yeni.Ad} {yeni.Soyad} başarılı bir şekilde eklenmiştir.","İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
