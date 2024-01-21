using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcakRezervasyonu
{
    internal interface Lokasyon
    {
        string Ulke { get; set; }
        string Sehir { get; set; }
        string Havalimani { get; set; }
    }
}
