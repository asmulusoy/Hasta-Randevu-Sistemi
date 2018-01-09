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
    public partial class frmHemsireEkle : Form
    {
        public frmHemsireEkle()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Hemsire yeni = new Hemsire()
                {
                    Ad = txtAd.Text,
                    Adres = txtAdres.Text,
                    Cinsiyet = (Cinsiyet)cmbCinsiyet.SelectedItem,
                    DogumTarihi = dTDogumTarihi.Value,
                    Mail = txtMail.Text,
                    Servis = (Servisler)cmbServisler.SelectedItem,
                    Maas = decimal.Parse(txtMaas.Text),
                    Soyad = txtSoyad.Text,
                    TCKN = txtTCKimlikNo.Text,
                    Telefon = txtTelefon.Text,
                    ID = Guid.NewGuid()
                };
                Hemsire.Hemsireler.Add(yeni);
                MessageBox.Show($"Hemşire {yeni.Ad} {yeni.Soyad} başarılı bir şekilde eklenmiştir.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmHemsireEkle_Load(object sender, EventArgs e)
        {
            List<Doktor> yeniliste = Doktor.Doktorlar.ToList();
            yeniliste.Insert(0, new Doktor() { Ad = "Seçiniz"});
           
            cmbServisler.DataSource = Enum.GetValues(typeof(Servisler));
            
            cmbCinsiyet.DataSource = Enum.GetValues(typeof(Cinsiyet));
        }

        private void btnVazgeç_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Bilgiler kaydedilmeden kapatılacaktır.\nEmin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (cevap == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cmbDoktorlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbServisler_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
