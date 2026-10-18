// UYGULAMA: ISTEGE BAGLI ISIMLENDIRILME VE PARAMS PARAMETRELER

using System.ComponentModel;
using System.Runtime.Serialization;

int uygulamaNo = 4;

switch (uygulamaNo)
{
    case 4:
        {
            static void Uygulama04_OpsiyonelIsimliParams()
            {
                // TAHMIN ET: Ikinci cagrida arguman sırası neden sorun olmuyor?

                Console.WriteLine(Etiket("ada"));
                Console.WriteLine(Etiket(onEk: "Temsilci", ad: "Ali"));

                Console.WriteLine($"Toplam: {Topla(3, 5, 7)}");
                Console.WriteLine($"Bos cagrinin toplami: {Topla()}");

                // DEGISTIR: Etiket motoduna isteğe bağlı bir "ayrac" parametresi ekleyin.
                // SINIR TESTI: Topla() ve Topla(-5) cagrılarını deneyin.
                // HATA AVI: Istege baglı parametreyi zorunlu parametreden önce yazın

            }
            static string Etiket(string ad, string onEk = "Ogrenci") => $"{onEk}: {ad}";

            static int Topla(params int[] sayilar)
            {
                int toplam = 0;
                foreach (int sayi in sayilar)
                    toplam += sayi;

            }
        }
        break;
}