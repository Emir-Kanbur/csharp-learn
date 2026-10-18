// UYGULAMA: IF ELSE ile TEK ve CİFT SAYİ

using System.Runtime.CompilerServices;

int secim = 3;

switch (secim)
{
    case 3:
        {
            Console.Write("Bir tam sayi giriniz: ");

            if (int.TryParse(Console.ReadLine(), out int sayi))
            {
                if (sayi % 2 == 0)
                {
                    Console.WriteLine($"{sayi} cift sayidir");
                }
                else
                {
                    Console.WriteLine($"{sayi} tek sayidir");
                }
            }
            else
            {
                Console.WriteLine("Gecerli bir tam sayi girilmedi");
            }
        }

        // TAHMIN ET: 8, -3, 0 ve 2.5 girislerinin sonuclarini yaziniz

        // DEGİSTİR: Programi sayinin pozitif/negatif olmasini da yazacak sekilde genisletin.
        // Sifiri ayrı bir şekilde ele alın

        // SINIR TESTI: 0 hem cift hem de pozitif midir? Programiniz ne yaziyor

        // HATA AVI: sayi % 2 = 0 yazilirsa neden derleme hatasi olusur?

        break;
}