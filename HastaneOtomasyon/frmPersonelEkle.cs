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
    public partial class frmPersonelEkle : Form
    {
        public frmPersonelEkle()
        {
            InitializeComponent();
        }

        private void btnVazgeç_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPersonelEkle_Load(object sender, EventArgs e)
        {
            cmbDepartmanlar.DataSource = Enum.GetValues(typeof(Departmanlar));
            cmbCinsiyet.DataSource = Enum.GetValues(typeof(Cinsiyet));

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Personel personel = new Personel()
                {
                    Ad = txtAd.Text,
                    Adres = txtAdres.Text,
                    Cinsiyet = (Cinsiyet)cmbCinsiyet.SelectedItem,
                    Departman = (Departmanlar)cmbDepartmanlar.SelectedItem,
                    DogumTarihi = dTDogumTarihi.Value,
                    Mail = txtMail.Text,
                    Maas = decimal.Parse(txtMaas.Text),       
                    Soyad = txtSoyad.Text,
                    TCKN = txtTCKimlikNo.Text,
                    Telefon = txtTelefon.Text,
                    ID = Guid.NewGuid()
                };
                Personel.Personeller.Add(personel);
                MessageBox.Show($"{personel.Ad} başarılı bir şekilde eklenmiştir.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
