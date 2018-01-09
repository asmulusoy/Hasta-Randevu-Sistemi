using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace HastaneOtomasyon.classes
{
    class Islemler
    {
        public static void DısariAktar()
        {
            Listeler tumListeler = new Listeler();
            XmlSerializer xml = new XmlSerializer(typeof(Listeler));//xml formatına çevirmek için
            using (TextWriter writer = new StreamWriter(Application.StartupPath + "/Save.xml"))//yazıcı 
            {
                xml.Serialize(writer, tumListeler);// xml formatına çevirip yazma
                writer.Close();
            }
            MessageBox.Show("Dosyalar başarılı bir şekilde kaydedildi", "Kayıt Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void RandevulariCek(ListView lst)
        {
            foreach (Randevu item in Randevu.Randevular.OrderBy(x=>x.RandevuSaati).ToList())
            {
                if (item.RandevuSaati.Day == DateTime.Now.Day)
                {
                    ListViewItem satir = new ListViewItem();
                    satir.Text = item.Hasta.AdSoyad;
                    satir.SubItems.Add(item.Doktor.AdSoyad);
                    satir.SubItems.Add(item.RandevuSaati.ToShortTimeString());
                    satir.Tag = item;
                    lst.Items.Add(satir);
                }
                else
                {
                    Randevu.Randevular.Remove(item);
                }

            }
        }
        public static void IceriAktar()
        {
            Listeler tumListeler = new Listeler();
            XmlSerializer xml = new XmlSerializer(typeof(Listeler));
            using (TextReader reader = new StreamReader(Application.StartupPath + "/Save.xml"))
            {
                tumListeler = xml.Deserialize(reader) as Listeler;
                reader.Close();
            }
            Doktor.Doktorlar = tumListeler.DoktorListesi;
            Hemsire.Hemsireler = tumListeler.HemsireListesi;
            Hasta.Hastalar = tumListeler.HastaListesi;
            Personel.Personeller = tumListeler.PersonelListesi;
            Randevu.Randevular = tumListeler.RandevuListesi;

        }
        public static void GroupBoxTemizle(GroupBox grp)
        {
            foreach (Control item in grp.Controls)
            {
                if (item is TextBox)
                    (item as TextBox).Text = String.Empty;
                if (item is ComboBox)
                    (item as ComboBox).SelectedIndex = 0;
                if (item is DateTimePicker)
                    (item as DateTimePicker).Value = DateTime.Now;
                if (item is MaskedTextBox)
                    (item as MaskedTextBox).Text = string.Empty;
            }
        }
        public static void DoktorListesiGuncelle(ListView lstDoktorlar)
        {
            lstDoktorlar.Items.Clear();
            foreach (Doktor doktor in Doktor.Doktorlar)
            {
                ListViewItem satir = new ListViewItem();
                satir.Text = doktor.Ad;
                satir.SubItems.Add(doktor.Soyad);
                satir.Tag = doktor;
                lstDoktorlar.Items.Add(satir);
            }
        }
        public static void PersonellerListesiGuncelle(ListView lstPersoneller)
        {
            lstPersoneller.Items.Clear();
            foreach (Personel personel in Personel.Personeller)
            {
                ListViewItem satir = new ListViewItem();
                satir.Text = personel.Ad;
                satir.SubItems.Add(personel.Soyad);
                satir.Tag = personel;
                lstPersoneller.Items.Add(satir);
            }
        }
        public static void HemsirelerListesiGuncelle(ListView lstHemsireler)
        {
            lstHemsireler.Items.Clear();
            foreach (Hemsire hemsire in Hemsire.Hemsireler)
            {
                ListViewItem satir = new ListViewItem();
                satir.Text = hemsire.Ad;
                satir.SubItems.Add(hemsire.Soyad);
                satir.Tag = hemsire;
                lstHemsireler.Items.Add(satir);
            }
        }
        public static void HastalarListesiGuncelle(ListView lstHastalar)
        {
            lstHastalar.Items.Clear();
            foreach (Hasta hasta in Hasta.Hastalar)
            {
                ListViewItem satir = new ListViewItem();
                satir.Text = hasta.Ad;
                satir.SubItems.Add(hasta.Soyad);
                satir.SubItems.Add(hasta.TCKN);
                satir.Tag = hasta;
                lstHastalar.Items.Add(satir);
            }
        }
        public static void DoktorAra(ListView lst, TextBox txt)
        {
            lst.Items.Clear();
            var gosterilecek = (from x in Doktor.Doktorlar
                                where x.Ad.ToLower().StartsWith(txt.Text.ToLower()) || x.Soyad.ToLower().StartsWith(txt.Text.ToLower())
                                select x).ToList();
            foreach (Doktor item in gosterilecek)
            {
                ListViewItem satir = new ListViewItem();
                satir.Text = item.Ad;
                satir.SubItems.Add(item.Soyad);
                satir.Tag = item;
                lst.Items.Add(satir);
            }
        }
        public static void HemsireAra(ListView lst, TextBox txt)
        {
            lst.Items.Clear();
            var gosterilecek = (from x in Hemsire.Hemsireler
                                where x.Ad.ToLower().StartsWith(txt.Text.ToLower()) || x.Soyad.ToLower().StartsWith(txt.Text.ToLower())
                                select x).ToList();
            foreach (Hemsire item in gosterilecek)
            {
                ListViewItem satir = new ListViewItem();
                satir.Text = item.Ad;
                satir.SubItems.Add(item.Soyad);
                satir.Tag = item;
                lst.Items.Add(satir);
            }
        }
        public static void PersonelAra(ListView lst, TextBox txt)
        {
           
                lst.Items.Clear();
                var gosterilecek = (from x in Personel.Personeller
                                    where x.Ad.ToLower().StartsWith(txt.Text.ToLower()) || x.Soyad.ToLower().StartsWith(txt.Text.ToLower())
                                    select x).ToList();
                foreach (Personel item in gosterilecek)
                {
                    ListViewItem satir = new ListViewItem();
                    satir.Text = item.Ad;
                    satir.SubItems.Add(item.Soyad);
                    satir.Tag = item;
                    lst.Items.Add(satir);
                }
            
        }
        public static void HastaAra(ListView lst, TextBox txt)
        {
            
                var gosterilecek = (from x in Hasta.Hastalar
                                    where x.Ad.ToLower().StartsWith(txt.Text.ToLower()) || x.TCKN == txt.Text || x.Soyad.ToLower().StartsWith(txt.Text.ToLower())
                                    select x).ToList();
                lst.Items.Clear();
                foreach (Hasta item in gosterilecek)
                {
                    ListViewItem satir = new ListViewItem();
                    satir.Text = item.Ad;
                    satir.SubItems.Add(item.Soyad);
                    satir.SubItems.Add(item.TCKN);
                    satir.Tag = item;
                    lst.Items.Add(satir);
                }
            
        }
        public static void OncekiRandevulariSil()
        {
            foreach (Randevu item in Randevu.Randevular)
            {
                if (item.RandevuSaati<DateTime.Today)
                {
                    Randevu.Randevular.Remove(item);
                }
            }
        }
    }
}
