using System;
using System.Collections.Generic;
using System.IO;

namespace UcakRezervasyonu
{
    internal class Ucak
    {
        private int UcakID { get; set; }
        private int KoltukSayisi { get; set; }

        public string Ad;
        public char Cinsiyet;
        public string Tarih;
        public string Saat;
        public string Lokasyon;

        public Ucak(string AdX, char CinsiyetX)
        {
            Ad = AdX;
            Cinsiyet = CinsiyetX;
            UcakID = 1;
            KoltukSayisi = 90;

            Console.WriteLine("\nEtkin uçuşlar: ");
            LokasyonOlustur lokasyonOlustur = new LokasyonOlustur();

            for (int i = 0; i < lokasyonOlustur.Lokasyonlar.Count; i++)
            {
                Console.WriteLine("{0} - " + lokasyonOlustur.Lokasyonlar[i], i + 1);
            }

            bool lokasyonok = false;

            while (!lokasyonok)
            {
                Console.Write("\nLokasyonunuzu seçiniz: ");
                int lokasyonSecim = Convert.ToInt32(Console.ReadLine());

                if (lokasyonSecim > 0 && lokasyonSecim <= lokasyonOlustur.Lokasyonlar.Count)
                {
                    Lokasyon = lokasyonOlustur.Lokasyonlar[lokasyonSecim - 1];
                    lokasyonok = true;
                }
            }

            Console.Write("\nTarih seçiniz (Gün/Ay/Yıl): ");
            Tarih = Console.ReadLine();

            Console.Write("\nSaat Seçiniz (00:00): ");
            Saat = Console.ReadLine();

            Rezervasyon rezervasyon = new Rezervasyon();

            // Kullanıcı bilgilerini CSV'ye kaydet
            SaveToCSV();
        }

        public string Tamamla()
        {
            string tempReturn = "";
            Rezervasyon rezervasyon = new Rezervasyon();

            if (Cinsiyet == 'E')
                tempReturn = "\nSayın " + Ad + " bey; \nUçak numaranız: " + UcakID + "\nUçuş tarihiniz: " + Tarih + "\nUçuş Saatiniz: " + Saat + "\nLokasyonunuz: " + Lokasyon + "\nBilet ücretiniz: " + rezervasyon.Fiyat + " TL\n";
            else if (Cinsiyet == 'K')
                tempReturn = "\nSayın " + Ad + " hanım; \nUçak numaranız: " + UcakID + "\nUçuş tarihiniz: " + Tarih + "\nUçuş Saatiniz: " + Saat + "\nULokasyonunuz: " + Lokasyon + "\nBilet ücretiniz: " + rezervasyon.Fiyat + " TL\n";

            return tempReturn;
        }

        private void SaveToCSV()
        {
            string csvFilePath = "musteri.csv";

            try
            {
                // Dosya var mı kontrol et, yoksa yeni bir tane oluştur ve başlık yaz
                if (!File.Exists(csvFilePath))
                {
                    using (StreamWriter sw = new StreamWriter(csvFilePath))
                    {
                        sw.WriteLine("Ad,Cinsiyet,UcakID,KoltukSayisi,Lokasyon,Tarih,Saat");
                    }
                }

                // Kullanıcı verilerini CSV dosyasına ekle
                using (StreamWriter sw = new StreamWriter(csvFilePath, true))
                {
                    string csvLine = $"{Ad},{Cinsiyet},{UcakID},{KoltukSayisi},{Lokasyon},{Tarih},{Saat}";
                    sw.WriteLine(csvLine);
                }

                Console.WriteLine("Kullanıcı bilgileri musteri.csv dosyasına kaydedildi.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }
        }
    }
}
