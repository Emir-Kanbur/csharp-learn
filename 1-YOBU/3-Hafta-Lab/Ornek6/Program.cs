// UYGULAMA: DİZİ OLUSTURMA, VARSAYILAN DEGERLER VE SINIR

int uygulamaNo = 6;

switch (uygulamaNo)
{
    case 6:
        {
            static void Uygulama06_DiziTemelleri()
            {
                int[] notlar = [72, 85, 49, 91];
                int[] bosSayilar = new int[3];
                bool[] durumlar = new bool[2];
                string[] adlar = new string[2];

                //TAHMIN ET: Yeni olusturulan dizilerin ilk elemanları nedir?

                Console.WriteLine($"İlk not: {notlar[0]}");
                Console.WriteLine($"Son not: {notlar[notlar.Length - 1]}");
                Console.WriteLine($"int varsayilani: {bosSayilar[0]}");
                Console.WriteLine($"bool varsayilani: {durumlar[0]}");
                Console.WriteLine($"string null mu=? {adlar[0] is null}");

                // DEGISTIR: Diziye bir not daha ekleyin ve Length sonucunu gözleyin
                // SINIR TESTI: Tek elemanlı ve sıfır elemanlı diziler oluşturun
                // HATA AVI: notlar[notlar.Length] neden IndexOutOfRangeException üretir??
            }

            Uygulama06_DiziTemelleri();
        }
        break;
}
