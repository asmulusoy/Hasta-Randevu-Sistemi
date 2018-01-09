using HastaneOtomasyon.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.classes
{
    public class Personel : Kisiler, IMaasAlabilen
    {
        private decimal _maas;

        public static List<Personel> Personeller { get; set; } = new List<Personel>();
        public decimal Maas
        {
            get
            {
                return _maas;
            }

            set
            {
                _maas = Dogrulamalar.MaasDogrula(value);
            }
        }
        public Departmanlar Departman { get; set; }
    }
    public enum Departmanlar
    {
        Muhasebe, InsanKaynaklari, Finans,Yonetim,Maliye,Guvenlik,TeknikDestek
    }
}
