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
    public partial class frmPersonelGuncelleSil : Form
    {
        public frmPersonelGuncelleSil()
        {
            InitializeComponent();
        }

        private void frmPersonelGuncelleSil_Load(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            Islemler.PersonellerListesiGuncelle(lstPersoneller);
            cmbCinsiyet.DataSource = Enum.GetValues(typeof(Cinsiyet));
            cmbDepartmanlar.DataSource = Enum.GetValues(typeof(Departmanlar));
            this.Width = 376;
        }

        private void lstPersoneller_SelectedIndexChanged(object sender, EventArgs e)
        {
            Personel seciliPersonel = (Personel)(lstPersoneller.FocusedItem.Tag);
            txtAd.Text = seciliPersonel.Ad;
            txtSoyad.Text = seciliPersonel.Soyad;
            txtTCKimlikNo.Text = seciliPersonel.TCKN;
            txtMail.Text = seciliPersonel.Mail;
            txtTelefon.Text = seciliPersonel.Telefon;
            txtAdres.Text = seciliPersonel.Adres;
            dTDogumTarihi.Value = seciliPersonel.DogumTarihi;
            cmbCinsiyet.SelectedItem = seciliPersonel.Cinsiyet;
            cmbDepartmanlar.SelectedItem = seciliPersonel.Departman;
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
                    Personel seciliPersonel = (Personel)(lstPersoneller.FocusedItem.Tag);
                    Personel.Personeller.Remove(seciliPersonel);
                    Islemler.PersonellerListesiGuncelle(lstPersoneller);
                    Islemler.GroupBoxTemizle(groupBox3);
                    this.Width = 700;
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
                Personel seciliPersonel = (Personel)(lstPersoneller.FocusedItem.Tag);
                seciliPersonel.Ad = txtAd.Text;
                seciliPersonel.Adres = txtAdres.Text;
                seciliPersonel.Cinsiyet = (Cinsiyet)cmbCinsiyet.SelectedItem;
                seciliPersonel.DogumTarihi = dTDogumTarihi.Value;
                seciliPersonel.Mail = txtMail.Text;
                seciliPersonel.Departman = (Departmanlar)cmbDepartmanlar.SelectedItem;
                seciliPersonel.Soyad = txtSoyad.Text;
                seciliPersonel.TCKN = txtTCKimlikNo.Text;
                seciliPersonel.Telefon = txtTelefon.Text;
                Islemler.PersonellerListesiGuncelle(lstPersoneller);
                Islemler.GroupBoxTemizle(groupBox3);
                this.Width = 700;
                groupBox3.Visible = false;
                this.CenterToScreen();
                MessageBox.Show($"{seciliPersonel.Ad} {seciliPersonel.Soyad} başarılı şekilde güncellenmiştir.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lstPersoneller.Items.Clear();
            var gosterilecek = (from x in Personel.Personeller
                                where x.Ad.ToLower().StartsWith(textBox1.Text.ToLower())
                                select x).ToList();
            foreach (Personel item in gosterilecek)
            {
                ListViewItem satir = new ListViewItem();
                satir.Text = item.Ad;
                satir.SubItems.Add(item.Soyad);
                satir.Tag = item;
                lstPersoneller.Items.Add(satir);
                this.Width = 700;
            }
        }
    }
}
