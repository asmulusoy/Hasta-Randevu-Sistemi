using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.classes
{
    public static class Arama<HastaArama> where HastaArama : Kisiler
    {
        public static List<HastaArama> Ara(List<HastaArama> kisiler, string kelime)
        {
            List<HastaArama> sonuclar = new List<HastaArama>();
            sonuclar = kisiler.Where(item => item.Ad.ToLower().Contains(kelime.ToLower()) || item.Soyad.ToLower().Contains(kelime.ToLower()) || item.TCKN.Contains(kelime)).ToList();
            return sonuclar;
        }
    }
}
