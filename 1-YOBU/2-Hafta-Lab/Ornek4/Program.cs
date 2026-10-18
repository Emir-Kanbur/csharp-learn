// UYGULAMA: ELSE IF ILE HARF NOTU

int secim = 4;

switch (secim)
{
    case 4:
        {
            Console.Write("Notu Giriniz (0-100): ");

            if (!int.TryParse(Console.ReadLine(), out int not) || not < 0 || not > 100)
            {
                Console.WriteLine("Gecersiz not.");
            }
            else if (not >= 85)
            {
                Console.WriteLine("Harf Notu: AA");
            }
            else if (not >= 70)
            {
                Console.WriteLine("Harf Notu: BB");
            }
            else if (not >= 60)
            {
                Console.WriteLine("Harf Notu: CC");
            }
            else if (not >= 50)
            {
                Console.WriteLine("Harf Notu: DD");
            }
            else
            {
                Console.WriteLine("Harf Notu: FF");
            }
        }
        break;
}