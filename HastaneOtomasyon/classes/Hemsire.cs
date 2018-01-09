using HastaneOtomasyon.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.classes
{
    public class Hemsire : Kisiler, IMaasAlabilen
    {
        public static List<Hemsire> Hemsireler { get; set; } = new List<Hemsire>();
        public Doktor Doktor { get; set; } = new Doktor();
        public Servisler Servis { get; set; }
        public bool BostaMi { get; set; } = true;
        private decimal _maas;
        public decimal Maas
        {
            get { return _maas; }
            set { _maas = Dogrulamalar.MaasDogrula(value); }
        }
        public override string ToString()
        {
            return $"{Ad} {Soyad} {Servis} " + (BostaMi ? "Boşta" : "Dolu");
        }
    }
}
