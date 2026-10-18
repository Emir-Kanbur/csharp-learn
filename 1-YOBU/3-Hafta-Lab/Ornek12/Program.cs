// UYGULAMA 12 - STRING DEĞİŞMEZLİĞİ, TEMİZLEME VE KARŞILAŞTIRMA

int uygulamaNo = 12;

switch (uygulamaNo)
{
    case 12:
        {
            static void Uygulama12_StringAnalizi()
            {
                Console.WriteLine("12 - String Analizi");

                string metin = "  dizi, Metot, string, C# ile ilgili;  ";

                Console.WriteLine($"Atamadan once: »{metin}«");

                string yenilenmis = metin.Replace("C#", "C# 14");
                Console.WriteLine($"Replace sonrası: »{yenilenmis}«");

                string temiz = metin.Trim();
                string[] parcalar = temiz.Split(';', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);

                Console.WriteLine($"Temiz: »{temiz}«");
                Console.WriteLine($"Parcalar: {string.Join(" | ", parcalar)}");
                Console.WriteLine($"'metot' var mi? {yenilenmis.Contains("metot", StringComparison.OrdinalIgnoreCase)}");
                Console.WriteLine($"Sesli harf sayisi: {SesliHarfSayisi(yenilenmis)}");

                // DEGISTIR: Ayırıcıyı ';' yapın ve örnek metni güncelleyin.
                // SINIR TESTI: Bos metin, fazla bosluk ve Turkce karakterler deneyin.
            }

            static int SesliHarfSayisi(string metin)
            {
                int sayac = 0;
                foreach (char c in metin)
                {
                    if ("aeiouAEIOU".Contains(c))
                        sayac++;
                }
                return sayac;
            }

            Uygulama12_StringAnalizi();
        }
        break;
}
