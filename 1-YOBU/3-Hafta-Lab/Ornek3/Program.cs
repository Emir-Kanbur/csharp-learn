// UYGULAMA: DEGER AKTARIMI, REF VE OUT PARAMETRELERI

int uygulamaNO = 3;

switch (uygulamaNO)
{
    case 3:
        {
            static void Uygulama3_DegerRefOut()
            {
                int sayi = 10;

                // TAHMIN ET: Iki cagridan sonra sayi kac olur?

                ArtirKopyayi(sayi);
                Console.WriteLine($"Normal parametreden sonra: {sayi}");

                ArtirAsilDegeri(ref sayi);
                Console.WriteLine($"ref parametresinden sonra sayi: {sayi}");

                int[] notlar = [72, 85, 49, 91];
                MinMax(notlar, out int enDusuk, out int enYuksek);
                Console.WriteLine($"En düsük: {enDusuk}, En Yuksek: {enYuksek}");

                //DEGISTIR: Arttırma miktarını parametre olarak alın.
                //SINIR TESTI: MinMax metoduna tek elemanlı ve boş dizi gönderin.
                //HATA AVI: ref cagrisindaki "ref" sozcugunu silince neden derleme hatasi olur??
            }

            Uygulama3_DegerRefOut();

            static void ArtirKopyayi(int x) => x++;

            static void ArtirAsilDegeri(ref int x) => x++;

            static void MinMax(int[] sayilar, out int min, out int max)
            {
                if (sayilar.Length == 0)
                    throw new ArgumentException("Dizi bos olamaz.", nameof(sayilar));

                min = max = sayilar[0];

                foreach (int sayi in sayilar)
                {
                    if (sayi < min) min = sayi;
                    if (sayi > max) max = sayi;
                }
            }
        }
        break;
}
