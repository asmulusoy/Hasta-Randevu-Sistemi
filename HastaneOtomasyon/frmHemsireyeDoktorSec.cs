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
    public partial class frmHemsireyeDoktorSec : Form
    {
        public frmHemsireyeDoktorSec()
        {
            InitializeComponent();
        }

        private void frmHemsireyeDoktorSec_Load(object sender, EventArgs e)
        {
            Islemler.DoktorListesiGuncelle(lstDoktorlar); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmHemsireDoktorAtama frm = new frmHemsireDoktorAtama();
            frm.Tag = (Doktor)lstDoktorlar.FocusedItem.Tag;
            frm.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Islemler.DoktorAra(lstDoktorlar, textBox1);
        }
    }
}
