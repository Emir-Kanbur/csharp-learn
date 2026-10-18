// UYGULAMA : METOT BİLDİRİMİ, PARAMETRE, ARGUMAN VE RETURN

int uygulamaNo = 1;

switch (uygulamaNo)
{
    case 1:
        {

            int sonuc = Kare(6);
            Console.WriteLine($"6'nin karesi: {sonuc}");

            //DEGISTIR: 6 yerine -4  ve 0 değerlerini girin
            //SINIR TESTI: int türünde büyük sayıların karesi taşabilir. 50_000'i deneyin
            //HATA AVI: Asagidaki cagri neden derlenmez?
            // int hatali = Kare("6");

        }
        break;
}

int Kare(int sayi)
{
    return sayi * sayi;
}