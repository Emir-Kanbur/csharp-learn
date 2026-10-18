//UYGULAMA: BOOL VE KARSILASTIRMA OPERATORLERI
int secim = 1;

switch (secim)
{
    case 1:
        {
            int not = 65;
            int devamsizlik = 4;

            bool notYeterli = not >= 60;
            bool devamYeterli = devamsizlik <= 5;
            bool basarili = notYeterli && devamYeterli;

            Console.WriteLine($"Not yeterli mi? {notYeterli}");
            Console.WriteLine($"Devam yeterli mi? {devamYeterli}");
            Console.WriteLine($"Ogrenci basarili mi? {basarili}");

            //TAHMIN ET: Ekrana hangi True/False degerleri yazilacak

            //DEGISTIR: not degerini 59 yapin. Yalnizca hangi sonuclar degisecek.

            //SINIR TESTI: not = 60 ve devamsizlik = 5 icin sonucları inceleyin.

            //HATA AVI: not degerini > 60 yaparsak hangi degerler yanlis olarak degerlendirilir.

            break;

        }

}