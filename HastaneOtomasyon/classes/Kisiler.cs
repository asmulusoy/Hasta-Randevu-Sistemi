using HastaneOtomasyon.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.classes
{
    public abstract class Kisiler
    {
        public Guid ID { get; set; } = new Guid();
        private string _adres;
        private string _tcKimlik;
        private string _ad;
        private Cinsiyet _cinsiyet;
        private string _soyad;
        private DateTime _dogumTarihi;
        private string _telefon;
        private string _mail;
        public string AdSoyad { get { return Ad + " " + Soyad; }}
        //--------PROPERTYLER-------------//
        public virtual string TCKN
        {
            get { return _tcKimlik; }
            set
            {
                _tcKimlik = Dogrulamalar.TcKimlikDogrula(value);
            }
        } //TCKN doğrulama çalışıyor
        public virtual string Ad
        {
            get { return _ad; }
            set
            {
                _ad = Dogrulamalar.AdSoyadDogrula(value);
            }
        }  // Ad doğrulama çalışıyor
        public virtual string Soyad
        {
            get { return _soyad; }
            set
            {
                _soyad = Dogrulamalar.AdSoyadDogrula(value);
            }
        } //Soyad doğrulama çalışıyor
        public virtual Cinsiyet Cinsiyet
        {
            get { return _cinsiyet; }
            set { _cinsiyet = value; }
        } //cinsiyette herhangi bir doğrulama yok
        public virtual DateTime DogumTarihi
        {
            get { return _dogumTarihi; }
            set { _dogumTarihi = value; }
        }
        public virtual string Telefon
        {
            get { return _telefon; }
            set
            {
                _telefon =Dogrulamalar.TelefonNoDogrula(value);
            }
        } //Telefon no doğrulama çalışıyor
        public virtual string Mail
        {
            get { return _mail; }
            set
            {
                _mail =  Dogrulamalar.MailAdresiDogrula(value);
            }
        } // mail doğrulama çalışıyor.
        public virtual string Adres
        {
            get { return _adres; }
            set { _adres = value; }
        }  //Adres te herhangi bir doğrulama bulunmuyor.
    }
    public enum Servisler
    {
        KBB, Nöroloji, Fizyoloji, Kardiyoloji, Psikoloji, Dermatoloji, Ortopedi, Üroloji
    }
    public enum Cinsiyet
    {
        Erkek, Kadın
    }

}
