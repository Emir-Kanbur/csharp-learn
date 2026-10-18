// UYGULAMA: Sondan Indeks (^) Ve Aralık (..)

int uygulamaNo = 8;

switch (uygulamaNo)
{
    case 8:
        {
            static void Uygulama08_IndexVeRange()
            {
                int[] sayilar = [10, 20, 30, 40, 50];

                //TAHMIN ET: 1..4 aralığı kaç eleman üretir??

                int son = sayilar[^1];
                int[] orta = sayilar[1..4];

                Console.WriteLine($"Son Eleman: {son}");
                Console.WriteLine($"1..4: {string.Join(", ", orta)}");

                // Aralık işlemi yeni bir dizi üretir.
                orta[0] = 999;
                Console.WriteLine($"Orta dizisi degisti: {string.Join(", ", orta)}");
                Console.WriteLine($"Asil dizi ayni kaldi: {string.Join(", ", sayilar)}");

                //DEGISTIR: Ilk iki elemani ve son iki elemani ayrı dizilere alin
                int[] ilkIki = sayilar[0..2];
                int[] sonIki = sayilar[^2..^0];

                Console.WriteLine($"Ilk Iki: {string.Join(", ", ilkIki)}");
                Console.WriteLine($"Son Iki: {string.Join(", ", sonIki)}");
            }

            Uygulama08_IndexVeRange();
        }
        break;
}