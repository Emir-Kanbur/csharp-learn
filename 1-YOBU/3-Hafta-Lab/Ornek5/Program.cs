// UYGULAMA: OVERLOAD VE KAPSAM

int uygulamaNo = 5;

switch (uygulamaNo)
{
    case 5:
        {
            static void uygulamaNo05_OverloadVeKapsam()
            {
                //TAHMİN ET: Her çağrıda hangi EnBuyuk metodu seçilir?

                int ikiTamSayi = EnBuyukOrnek.EnBuyuk(7, 12);
                double ikiOndalikli = EnBuyukOrnek.EnBuyuk(7.5, 7.25);
                int ucTamSayi = EnBuyukOrnek.EnBuyuk(4, 19, 8);
                double ucOndalikli = EnBuyukOrnek.EnBuyuk(12.5, 9.75, 10.1);

                Console.WriteLine($"int/int: {ikiTamSayi}");
                Console.WriteLine($"double/double: {ikiOndalikli}");
                Console.WriteLine($"Üç int: {ucTamSayi}");
                Console.WriteLine($"Üç double: {ucOndalikli}");

                if (ikiTamSayi > 10)
                {
                    string blokMesaji = "bu degisken yalnizca bu blokta yasar.";
                    Console.WriteLine(blokMesaji);
                }

                //DEGISTIR: Uc double alan yeni bir overload ekleyin
                //HATA AVI: Aşağıdaki satırı açınca neden derlenmez??
                //Console.WriteLine(blokMesaji);
                //HATA AVI: Yalniz donus turu farklı iki metodun overload olmadığını açıklayınız.
            }

            uygulamaNo05_OverloadVeKapsam();
        }
        break;
}

static class EnBuyukOrnek
{
    public static int EnBuyuk(int a, int b) => a > b ? a : b;
    public static double EnBuyuk(double a, double b) => a > b ? a : b;
    public static int EnBuyuk(int a, int b, int c) => EnBuyuk(EnBuyuk(a, b), c);
    public static double EnBuyuk(double a, double b, double c) => EnBuyuk(EnBuyuk(a, b), c);
}