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
    public partial class frmHemsireDoktorAtama : Form
    {
        public frmHemsireDoktorAtama()
        {
            InitializeComponent();
        }

        private void frmHemsireDoktorSecimi_Load(object sender, EventArgs e)
        {
            Doktor seciliDoktor = (Doktor)Tag;
            var bostaHemsireler = (from x in Hemsire.Hemsireler
                                   where x.BostaMi == true && x.Servis == seciliDoktor.Servis
                                   select x).ToList();
            foreach (Hemsire item in bostaHemsireler)
            {
                ListViewItem satir = new ListViewItem();
                satir.Text = item.Ad;
                satir.SubItems.Add(item.Soyad);
                satir.Tag = item;
                listView1.Items.Add(satir);
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            ((Hemsire)listView1.FocusedItem.Tag).Doktor = (Doktor)Tag;
            ((Hemsire)listView1.FocusedItem.Tag).BostaMi = false;
            MessageBox.Show($"{((Hemsire)listView1.FocusedItem.Tag).AdSoyad} Dr.{((Doktor)Tag).AdSoyad} ile görevlendirilmiştir.");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
