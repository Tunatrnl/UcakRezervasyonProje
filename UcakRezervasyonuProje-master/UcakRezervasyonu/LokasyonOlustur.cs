using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcakRezervasyonu
{
    internal class LokasyonOlustur : Lokasyon
    {
        public string Ulke { get; set; }
        public string Sehir { get; set; }
        public string Havalimani { get; set; }

        public List<string> Lokasyonlar = new List<string>();

        public LokasyonOlustur()
        {
            Lokasyonlar.Add("İstanbul / Türkiye, Sabiha Gökçen Havalimanı");
            Lokasyonlar.Add("İstanbul / Türkiye, Atatürk Havalimanı");
            Lokasyonlar.Add("Moskova / Rusya, Domodedovo Havalimanı");
            Lokasyonlar.Add("New York City / Amerika, LuGuardia Havalimanı");
            Lokasyonlar.Add("Muan / Kore, Muan Uluslararası Havalimanı");
            Lokasyonlar.Add("Augsburg / Almanya, Augsburg Havalimanı");
            Lokasyonlar.Add("Amsterdan / Hollanda, Amsterdam Schiphol Havalimanı");
        }
    }
}
