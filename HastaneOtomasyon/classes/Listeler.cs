using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.classes
{
   public class Listeler
    {
        public List<Doktor> DoktorListesi { get; set; } = new List<Doktor>();
        public List<Hemsire> HemsireListesi { get; set; } = new List<Hemsire>();
        public List<Hasta> HastaListesi { get; set; } = new List<Hasta>();
        public List<Personel> PersonelListesi { get; set; } = new List<Personel>();
        public List<Randevu> RandevuListesi { get; set; } = new List<Randevu>();
        public Listeler()
        {
            DoktorListesi = Doktor.Doktorlar;
            HemsireListesi = Hemsire.Hemsireler;
            HastaListesi = Hasta.Hastalar;
            PersonelListesi = Personel.Personeller;
            RandevuListesi = Randevu.Randevular;
        }
    }
}
