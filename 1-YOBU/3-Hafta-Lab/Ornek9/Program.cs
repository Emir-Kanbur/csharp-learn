// UYGULAMA: REFERANS ATAMASI VE CLONE

int uygulamaNo = 9;

switch (uygulamaNo)
{
    case 9:
        {
            static void Uygulama09_ReferansVeKopya()
            {
                Console.WriteLine("9 - Referans ve Bagimsiz Kopya");

                int[] a = [1, 2, 3];
                int[] ayniDizi = a;
                int[] bagimsizKopya = (int[])a.Clone();

                // TAHMIN ET: Iki degisiklikten sonra a[0] ve a[1] kaç olur?
                ayniDizi[0] = 99;
                bagimsizKopya[1] = 88;

                Console.WriteLine($"a: {string.Join(", ", a)}");
                Console.WriteLine($"ayniDizi: {string.Join(", ", ayniDizi)}");
                Console.WriteLine($"bagimsizKopya: {string.Join(", ", bagimsizKopya)}");

                // DEGISTIR: a[2]'yi değistirip iki diziyi yeniden yazdırın.
                // SINIR TESTI: Bos diziyi Clone ile kopyalayın.
                // HATA AVI: "int[] b = a" ifadesine neden kopyalama denemez?
            }

            Uygulama09_ReferansVeKopya();
        }
        break;
}