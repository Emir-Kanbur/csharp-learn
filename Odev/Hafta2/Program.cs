using System;

namespace OtoparkUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aracSayisi;

            // TODO 1: Araç sayısını doğrula
            while (true)
            {
                Console.Write("Araç sayısını giriniz (1-20): ");

                if (int.TryParse(Console.ReadLine(), out aracSayisi) &&
                    aracSayisi >= 1 &&
                    aracSayisi <= 20)
                {
                    break;
                }

                Console.WriteLine("Geçersiz giriş. 1-20 arasında bir sayı giriniz.");
            }

            decimal gunlukGelir = 0;
            int motosikletSayisi = 0;
            int otomobilSayisi = 0;
            int kamyonetSayisi = 0;

            decimal enYuksekUcret = 0;
            string enYuksekUcretPlaka = "";

            for (int i = 1; i <= aracSayisi; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"{i}. Araç");

                // TODO 2: Araç bilgilerini al
                Console.Write("Plaka: ");
                string plaka = Console.ReadLine() ?? "";

                string aracTuru;

                while (true)
                {
                    Console.Write("Araç türü (M/O/K): ");
                    aracTuru = (Console.ReadLine() ?? "").ToUpper();

                    if (aracTuru == "M" ||
                        aracTuru == "O" ||
                        aracTuru == "K")
                    {
                        break;
                    }

                    Console.WriteLine("Geçersiz araç türü. M, O veya K giriniz.");
                }

                int parkSuresi;

                while (true)
                {
                    Console.Write("Park süresi (1-24 saat): ");

                    if (int.TryParse(Console.ReadLine(), out parkSuresi) &&
                        parkSuresi >= 1 &&
                        parkSuresi <= 24)
                    {
                        break;
                    }

                    Console.WriteLine("Geçersiz süre. 1-24 arasında bir sayı giriniz.");
                }

                // TODO 3: Ücreti hesapla
                decimal saatlikUcret = aracTuru switch
                {
                    "M" => 15m,
                    "O" => 25m,
                    "K" => 40m,
                    _ => 0m
                };

                decimal ucret = saatlikUcret * parkSuresi;

                if (parkSuresi >= 8)
                {
                    ucret *= 0.90m;
                }

                Console.WriteLine($"Araç ücreti: {ucret:F2} TL");

                // TODO 4: Sayaç ve biriktiricileri güncelle
                gunlukGelir += ucret;

                switch (aracTuru)
                {
                    case "M":
                        motosikletSayisi++;
                        break;

                    case "O":
                        otomobilSayisi++;
                        break;

                    case "K":
                        kamyonetSayisi++;
                        break;
                }

                if (ucret > enYuksekUcret)
                {
                    enYuksekUcret = ucret;
                    enYuksekUcretPlaka = plaka;
                }
            }

            // TODO 5: Gün sonu özetini yazdır
            Console.WriteLine();
            Console.WriteLine("===== GÜN SONU ÖZETİ =====");
            Console.WriteLine($"Toplam gelir: {gunlukGelir:F2} TL");
            Console.WriteLine($"Motosiklet sayısı: {motosikletSayisi}");
            Console.WriteLine($"Otomobil sayısı: {otomobilSayisi}");
            Console.WriteLine($"Kamyonet sayısı: {kamyonetSayisi}");
            Console.WriteLine($"En yüksek ücret: {enYuksekUcret:F2} TL");
            Console.WriteLine($"En yüksek ücretli aracın plakası: {enYuksekUcretPlaka}");

            Console.WriteLine();
            Console.WriteLine("Programı kapatmak için bir tuşa basınız...");
            Console.ReadKey();
        }
    }
}