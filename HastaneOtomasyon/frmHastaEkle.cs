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
    public partial class frmHastaEkle : Form
    {
        public frmHastaEkle()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Hasta hasta = new Hasta()
                {
                    Ad = txtAd.Text,
                    Adres = txtAdres.Text,
                    Cinsiyet = (Cinsiyet)cmbCinsiyet.SelectedItem,
                    DogumTarihi = dTDogumTarihi.Value,
                    Mail = txtMail.Text,
                    Soyad = txtSoyad.Text,
                    TCKN = txtTCKimlikNo.Text,
                    Telefon = txtTelefon.Text,
                    ID = Guid.NewGuid()
                };
                Hasta.Hastalar.Add(hasta);
                MessageBox.Show($"{hasta.Ad} {hasta.Soyad} başarılı bir şekilde eklenmiştir.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmHastaEkle_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.DataSource = Enum.GetValues(typeof(Cinsiyet));
        }

        private void btnVazgeç_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
