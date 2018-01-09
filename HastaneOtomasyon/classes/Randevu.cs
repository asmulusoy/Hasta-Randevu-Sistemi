using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.classes
{
    public class Randevu
    {
        public static List<Randevu> Randevular { get; set; } = new List<Randevu>();
        public Hasta Hasta { get; set; } = new Hasta();
        public Doktor Doktor { get; set; } = new Doktor();
        public DateTime RandevuSaati { get; set; } = new DateTime();
    }
}
