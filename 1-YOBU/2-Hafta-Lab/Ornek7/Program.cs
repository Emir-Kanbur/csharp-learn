// UYGULAMA : SWITCH EXPRESSION ILE UCRET HESABI

int secim = 7;

switch (secim)
{
    case 7:
        {
            Console.Write("Otoparkta kalinan saati giriniz: ");

            if (!int.TryParse(Console.ReadLine(), out int saat) || saat < 0)
            {
                Console.WriteLine("Gecersiz sure");
                break;
            }

            decimal ucret = saat switch
            {
                0 => 0m,
                <= 2 => 40m,
                <= 5 => 70m,
                _ => 150m,
            };
            Console.WriteLine($"Otopark ucreti: {ucret:F2}");
            break;

            // TAHMIN ET: 0, 1, 2, 3, 5, 6, 10 ve 11 saat icin ucretleri yazin

            // DEGISTIR: 24 saatten fazla kalisi gecersiz sayin

            // SINIR TESTI: -1, 0, 2, 5, 10 ve 24 degerlerini deneyiniz
        }

}