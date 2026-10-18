
int secim = 5;

switch (secim)
{
    case 5:
        {
            const string dogruKullanici = "ogrenci";
            const string dogruParola = "CSharp2026";

            Console.Write("Kullanici adi: ");
            string kullanici = Console.ReadLine() ?? string.Empty;

            Console.Write("Parola: ");
            string parola = Console.ReadLine() ?? string.Empty;

            if (kullanici.Length == 0 || parola.Length == 0)
            {
                Console.WriteLine("Kullanici adi ve parola bos birakilamaz");
            }
            else
            {
                bool kullaniciDogru = kullanici == dogruKullanici;
                bool parolaDogru = parola == dogruParola;

                if (kullaniciDogru && parolaDogru)
                {
                    Console.WriteLine("Giris Basarili");
                }
                else if (kullaniciDogru)
                {
                    Console.WriteLine("Parola yanlis");
                }
                else
                {
                    Console.WriteLine("Kullanici bilgileri hatali");
                }
            }
            break;
        }
}