using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcakRezervasyonu
{
    internal class MusteriOlustur
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
        public char Cinsiyet { get; set; }
        public string TCKN { get; set; }
        public string Tel { get; set; }

        public Musteri musteriOlustur()
        {
            Console.Write("İsminiz : ");
            Ad = Console.ReadLine();

            Console.Write("Soyadınız : ");
            Soyad = Console.ReadLine();

            Console.Write("Yaşınız : ");
            Yas = int.Parse(Console.ReadLine());

            bool tcknok = false;
            while (tcknok == false)
            {
                Console.Write("TC Kimlik Numaranız: ");
                TCKN = Console.ReadLine();

                if (TCKN.Length == 11 && TCKN.All(char.IsDigit) == true)
                    tcknok = true;
                else
                    Console.WriteLine("Hatalı değer girişi. Tekrar deneyin.\n");
            }

            bool telok = false;
            while (telok == false)
            {
                Console.Write("Telefon Numaranız : +90");
                Tel = Console.ReadLine();

                if (Tel.Length == 10 && Tel.All(char.IsDigit) == true)
                    telok = true;
                else
                    Console.WriteLine("Hatalı değer girişi. Tekrar deneyin.\n");
            }

            bool okcinsiyet = false;

            while (okcinsiyet == false)
            {
                Console.Write("Cinsiyetinizi giriniz (E/K) : ");
                Cinsiyet = Convert.ToChar(Console.ReadLine());

                if (Cinsiyet == 'E' || Cinsiyet == 'K')
                    okcinsiyet = true;
                else
                    Console.WriteLine("Hatalı değer girişi. Tekrar deneyin.\n");
            }

            Musteri musteri = new Musteri(Ad, Soyad, Yas, Cinsiyet, TCKN, Tel);

            return musteri;
        }
    }
}
