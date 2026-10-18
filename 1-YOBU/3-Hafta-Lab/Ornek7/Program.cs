// UYGULAMA: DIZI OLUSTURMA, VARSAYILAN DEGERLER VE SINIR

int uygulamaNo = 7;

switch (uygulamaNo)
{
    case 7:
        {
            static void Uygulama07_DiziIstatistikleri()
            {
                int[] notlar = [72, 85, 49, 91, 85];

                Console.WriteLine("Indexli Gorunum:");

                for (int i = 0; i < notlar.Length; i++)
                    Console.WriteLine($"[{i}] = {notlar[i]}");

                //TAHMIN ET: Ortalama tam sayi mi, ondalikli sayi mi??

                double ortalama = Ortalama(notlar);
                MinMax(notlar, out int min, out int max);

                Console.WriteLine($"Ortalama: {ortalama:F2}");
                Console.WriteLine($"Minimum: {min}, Maksimum: {max}");

                //DEGISTIR: Ortalama üstündeki notların sayısını hesaplayın.
                /*
                 static int OrtalamaUstuSayisi(int[] sayilar)
                 {
                    double ort = Ortalama(sayilar);
                    int adet = 0;
                 }

                 */
            }

            Uygulama07_DiziIstatistikleri();

            static double Ortalama(int[] sayilar)
            {
                int toplam = 0;
                foreach (int sayi in sayilar)
                    toplam += sayi;

                return (double)toplam / sayilar.Length;
            }

            static void MinMax(int[] sayilar, out int min, out int max)
            {
                min = sayilar[0];
                max = sayilar[0];

                foreach (int sayi in sayilar)
                {
                    if (sayi < min) min = sayi;
                    if (sayi > max) max = sayi;
                }
            }
        }
        break;
}