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
    public partial class frmRandevuEkleDoktorSec : Form
    {
        public frmRandevuEkleDoktorSec()
        {
            InitializeComponent();
        }

        private void frmRandevuEkleDoktorSec_Load(object sender, EventArgs e)
        {
            cmbServisler.DataSource = Enum.GetValues(typeof(Servisler));
            groupRandevuSaati.Visible = false;

        }
        Button seciliButon;
        private void cmbServisler_SelectedIndexChanged(object sender, EventArgs e)
        {
            var seciliservisDoktorlari = (from x in Doktor.Doktorlar
                                          where x.Servis == (Servisler)cmbServisler.SelectedItem
                                          select x).ToList();

            lstDoktorlar.Items.Clear();
            foreach (Doktor doktor in seciliservisDoktorlari)
            {
                ListViewItem satir = new ListViewItem();
                satir.Text = doktor.Ad;
                satir.SubItems.Add(doktor.Soyad);
                satir.Tag = doktor;
                lstDoktorlar.Items.Add(satir);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            seciliButon = (sender as Button);
            foreach (Button item in groupRandevuSaati.Controls)
            {
                if (item.BackColor == Color.Green)
                {
                    item.BackColor = SystemColors.Control;
                }
            }
            (sender as Button).BackColor = Color.Green;
        }

        private void lstDoktorlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupRandevuSaati.Visible = true;
            foreach (Button buton in groupRandevuSaati.Controls)
            {
                        (buton as Button).BackColor = SystemColors.Control;
                        (buton as Button).Enabled = true;
            }

           

            Doktor seciliDoktor = (Doktor)lstDoktorlar.FocusedItem.Tag;
            foreach (Randevu item in Randevu.Randevular)
            {

                if (item.Hasta.ID == ((Hasta)Tag).ID)
                {
                    foreach (Button buton in groupRandevuSaati.Controls)
                    {
                        if (DateTime.Parse(((buton as Button).Text)) == item.RandevuSaati)
                        {
                            (buton as Button).BackColor = Color.Red;
                            (buton as Button).Enabled = false;
                        }
                    }
                }


                if (item.Doktor.ID == seciliDoktor.ID)
                {
                    foreach (Button buton in groupRandevuSaati.Controls)
                    {
                            if (DateTime.Parse(((buton as Button).Text)) == item.RandevuSaati)
                            {
                                (buton as Button).BackColor = Color.Red;
                                (buton as Button).Enabled = false;
                            }
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult cevap = MessageBox.Show($"Doktor :{((Doktor)lstDoktorlar.FocusedItem.Tag).AdSoyad}\nHasta :{((Hasta)this.Tag).AdSoyad}\nSaat :{(DateTime.Parse((seciliButon).Text)).ToShortTimeString()}\nRandevu kaydedilecektir.\nDevam etmek istiyor musunuz?", "Uyarı.", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (cevap == DialogResult.Yes)
                {
                    Randevu yeni = new Randevu();
                    yeni.Doktor = (Doktor)lstDoktorlar.FocusedItem.Tag;
                    yeni.Hasta = (Hasta)this.Tag;
                    yeni.RandevuSaati = (DateTime.Parse((seciliButon).Text));
                    Randevu.Randevular.Add(yeni);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
