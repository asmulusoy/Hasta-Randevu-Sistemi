using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.classes
{
    public class Dogrulamalar
    {
        public static string AdSoyadDogrula(string adsoyad)
        {
            bool harfMi = true;

            foreach (char item in adsoyad)
            {
                if (Char.IsNumber(item))
                {
                    harfMi = false;
                }
            }
            if (adsoyad.Length < 2)
                throw new Exception("Ad ve Soyad değerleri 2 karakterden az olamaz!");
            if (harfMi == false)
                throw new Exception("Ad ve Soyad değerleri nümerik içerik barındıramaz!");
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(adsoyad);
        }
        public static string TcKimlikDogrula(string tcKN)
        {
            int sonrakam = Convert.ToInt32(tcKN[tcKN.Length - 1]);
            if (sonrakam % 2 == 1)
            {
                throw new Exception("Tc Kimlik numarasının son rakamı tek olamaz!");
            }

            bool harfMi = true;
            foreach (char item in tcKN)// Karakterleri tek tek kontrol ediyor
            {
                if (!char.IsNumber(item))
                { harfMi = false; break; }
            }

            if (tcKN.Length != 11)
                throw new Exception("TC Kimlik Numarası 11 hane olmalıdır!");
            if (harfMi != true)
                throw new Exception("TC Kimlik Numarası rakam dışında bir değer alamaz!");
            return tcKN;
        }
        public static string TelefonNoDogrula(string telefonNo)
        {
            bool harfMi = true;
            foreach (char item in telefonNo)
            {
                if (char.IsLetter(item))
                {
                    harfMi = false; break;
                }
            }
            if (harfMi == false)
            {
                throw new Exception("Telefon numarası nümerik değer dışında bir değer alamaz!");
            }
            return telefonNo;
        } // Telefon no numeric değer dışında bir değer barındıramaz.
        public static string MailAdresiDogrula(string mail)
        {
            if (mail.Trim() != string.Empty)
            {
                if (mail.Contains("@") == false)
                    throw new Exception("Mail adresini yanlış girdiniz!");
            }

            return mail;
        } //Mail @ karakteri bulundurmuyorsa hata verecek
        public static decimal MaasDogrula(decimal maas)
        {
            if (maas<0)
            {
                throw new Exception("Maaş negatif değer alamaz!");
            }
            return maas;
        } // maas negatif olursa 

    }
}
