//UYGULAMA: GUVENLI GIRDI VE TEK SORUMLULUKLU METOTLAR

int uygulamaNo = 2;

switch (uygulamaNo)
{
    case 2:
        {
            static void uygulamaNo2_GuvenliNotOkuma()
            {
                int not = NotOku("Notu giriniz: (0-100)");
                string harf = harfNotu(not);

                Console.WriteLine($"Puan: {not}, harf notu: {harf}");

                // DEGISTIR: Harf notu sınırlarını dersinizdeki sisteme uyarlayın
                // SINIR TESTI: abc, -1, 0, 49, 50, 84, 85 ve 101 degerlerini giriniz.
                // HATA AVI: TryParse yerine int.Parse kullanılırsa "abc" girisinde ne olur?
            }

            uygulamaNo2_GuvenliNotOkuma();

            static int NotOku(string mesaj)
            {
                while (true)
                {
                    Console.Write(mesaj);
                    string? girdi = Console.ReadLine();

                    if (int.TryParse(girdi, out int not) && not is >= 0 and <= 100)
                        return not;

                    Console.WriteLine("Hatali giris! 0-100 arasinda bir tam sayi giriniz");
                }
            }

            static string harfNotu(int not)
            {
                if (not >= 85)
                    return "AA";
                else if (not >= 70)
                    return "BB";
                else if (not >= 50)
                    return "CC";
                else
                    return "FF";
            }
        }

        break;
}