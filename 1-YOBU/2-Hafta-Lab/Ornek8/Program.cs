// UYGULAMA: FOR DONGUSU, SAYAC ve BIRIKTIRICI

int secim = 8;

switch (secim)
{
    case 8:
        {
            Console.Write("Kaca kadar toplansin?");

            if (!int.TryParse(Console.ReadLine(), out int ustSinir) || ustSinir < 1)
            {
                Console.WriteLine("1 veya daha buyuk tam sayi giriniz: ");
                break;
            }

            int toplam = 0;
            int ciftAdedi = 0;

            for (int i = 1; i <= ustSinir; i++)
            {
                toplam += 1;

                if (i % 2 == 0)
                {
                    ciftAdedi++;
                }
            }

            Console.WriteLine($"1-{ustSinir} toplami: {toplam}");
            Console.WriteLine($"Cift sayi adedi: {ciftAdedi}");

        }
        break;
}