using HastaneOtomasyon.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.classes
{
    public class Doktor : Kisiler,IMaasAlabilen
    {
        public static List<Doktor> Doktorlar { get; set; } = new List<Doktor>();
        public Servisler Servis { get; set; } = new Servisler();
        private decimal _maas;
        public decimal Maas
        {
            get { return _maas; }
            set { _maas = Dogrulamalar.MaasDogrula(value); }
        }
    }
}
