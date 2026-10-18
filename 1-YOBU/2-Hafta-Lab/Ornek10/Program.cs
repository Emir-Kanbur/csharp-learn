// UYGULAMA : FOREACH ILE METIN ANALIZI

int secim = 10;

switch (secim)
{
    case 10:
        {
            Console.Write("Bir Kelime veya cumle giriniz: ");
            string metin = Console.ReadLine() ?? string.Empty;

            int harfSayisi = 0;
            int rakamSayisi = 0;
            int boslukSayisi = 0;

            foreach (char karakter in metin)
            {
                if (char.IsLetter(karakter))
                {
                    harfSayisi++;
                }
                else if (char.IsWhiteSpace(karakter))
                {
                    boslukSayisi++;
                }
            }

            Console.WriteLine($"Harf Sayisi: {harfSayisi}");
            Console.WriteLine($"Rakam Sayisi: {rakamSayisi}");
            Console.WriteLine($"Bosluk Sayisi: {boslukSayisi}");

        }
        break;
}