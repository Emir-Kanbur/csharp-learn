// UYGULAMA: WHILE VE DO WHILE ILE GUVENLI GIRIS

int secim = 9;

switch (secim)
{
    case 9:
        {
            int yas;

            Console.WriteLine("WHILE: 18-100 arasinda yas girisi");
            Console.Write("Yas: ");

            while (!int.TryParse(Console.ReadLine(), out yas) || yas < 18 || yas > 100)
            {
                Console.WriteLine("Gecersiz yas. 18-100 arasinda giriniz.");
                Console.Write("Yas: ");
            }
            Console.WriteLine($"Kabul edilen yas: {yas}");

            string devam;

            do
            {
                Console.WriteLine("Yeni bir islem yapmak istiyor musunuz? (E/H): ");
                devam = (Console.ReadLine() ?? string.Empty).Trim().ToUpperInvariant();
            } while (devam != "E" && devam != "H");

            Console.WriteLine(devam == "E" ? "Isleme devam edilecek." : "Program sonlandirildi.");

        }
        break;
}