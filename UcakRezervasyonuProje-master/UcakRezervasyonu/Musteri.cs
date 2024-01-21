using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcakRezervasyonu
{
    internal class Musteri
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
        public char Cinsiyet { get; set; }
        public string TCKN { get; set; }
        public string Tel { get; set; }

        public Musteri(string ad, string soyad, int yas, char cinsiyet, string tCKN, string tel)
        {
            Ad = ad;
            Soyad = soyad;
            Yas = yas;
            Cinsiyet = cinsiyet;
            TCKN = tCKN;
            Tel = tel;
        }
    }
}
