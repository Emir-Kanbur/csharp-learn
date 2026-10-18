int secim = 6;

switch (secim)
{
    case 6:
        {
            Console.WriteLine("1 - Bakiye Goruntule");
            Console.WriteLine("2 - Para Yatir");
            Console.WriteLine("3 - Para Cek");
            Console.WriteLine("0 - Cikis");
            Console.WriteLine("Seciniz: ");

            string banka = Console.ReadLine() ?? string.Empty;

            switch (banka)
            {
                case "1":
                    Console.WriteLine("Bakiyeniz: 2500 TL");
                    break;

                case "2":
                    Console.WriteLine("Para yatirma islemi gerceklesti");
                    break;

                case "3":
                    Console.WriteLine("Para cekme islemi gerceklesti");
                    break;

                case "0":
                    Console.WriteLine("Cikis yapildi");
                    break;

                default:
                    Console.WriteLine("Gecersiz secim");
                    break;
            }

            break; // Dıştaki case 6 için gerekli
        }
}