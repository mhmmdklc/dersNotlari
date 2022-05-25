using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Ayse";
            ogrenci.Soyismi = "Yılmaz";
            ogrenci.OgrenciNo = 293;
            ogrenci.Sinif = 3;
            ogrenci.OgrenciBilgileriniGetir();
            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();
            System.Console.WriteLine("***** Ogrenci 1 *****");
            Ogrenci ogrenci1 = new Ogrenci("Deniz", "Arda", 256, 1);
            ogrenci1.SinifDusur();
            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriniGetir();
        }
    }

    class Ogrenci
    {
        private string _isim;
        private string _soyismi;
        private int _ogrenciNo;
        private int _sinif;

        public string Isim
        {
            get { return _isim; }
            set { _isim = value; }
        }

        public string Soyismi { get => _soyismi; set => _soyismi = value; }
        public int OgrenciNo { get => _ogrenciNo; set => _ogrenciNo = value; }
        public int Sinif
        {
            get => _sinif;
            set
            {
                if (value <= 1)
                {
                    Console.WriteLine("Sınıf en az 1 olabilir");
                    _sinif = 1;
                }
                else
                    _sinif = value;
            }
        }

        public Ogrenci(string ısim, string soyismi, int ogrenciNo, int sinif)
        {
            Isim = ısim;
            Soyismi = soyismi;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }
        public Ogrenci() { }

        public void OgrenciBilgileriniGetir()
        {
            System.Console.WriteLine("****** Öğrenci Bilgilerini Getir ****** ");
            Console.WriteLine("Öğrenci Adı      :{0}", this.Isim);
            Console.WriteLine("Öğrenci Soyadı   :{0}", this.Soyismi);
            Console.WriteLine("Öğrenci No       :{0}", this.OgrenciNo);
            Console.WriteLine("Öğrenci Sınıfı   :{0}", this.Sinif);
        }

        public void SinifAtlat()
        {
            this.Sinif += 1;
        }
        public void SinifDusur()
        {
            this.Sinif -= 1;
        }

    }
}