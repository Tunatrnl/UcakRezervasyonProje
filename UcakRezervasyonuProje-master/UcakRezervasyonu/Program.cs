using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcakRezervasyonu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Uçak Rezervasyonu Uygulaması";
            Console.WriteLine("#########################################################################\n");
            Console.WriteLine("              Uçak Rezervasyonu Uygulamasına Hoşgeldiniz.\n");
            Console.WriteLine("#########################################################################\n");

            MusteriOlustur musteriOlustur = new MusteriOlustur();
            Musteri musteri = musteriOlustur.musteriOlustur();

            Ucak ucusOlustur = new Ucak(musteri.Ad, musteri.Cinsiyet);
            Console.Write(ucusOlustur.Tamamla());

            Console.WriteLine("\nRezervasyon bilgileriniz sms olarak +90{0} No'lu telefon numaranıza gönderilecektir.", musteri.Tel);
            Console.WriteLine("Bizi seçtiğiniz için teşekkürler. İyi uçuşlar dileriz.");
            Console.ReadKey();
        }
    }
}
