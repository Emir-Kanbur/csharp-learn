// UYGULAMA 10 - ARRAY. SORT, ARRAY.REVERSE VE ARRAY. INDEXOF

int uygulamaNo = 10;

switch (uygulamaNo)
{
    case 10:
        {
            static void Uygulama10_ArrayIslemleri()
            {
                Console.WriteLine("10 - Array Islemleri");

                int[] sayilar = [8, 2, 5, 2];
                int[] sirali = (int[])sayilar.Clone();

                Array.Sort(sirali);
                Console.WriteLine($"Artan: {string.Join(", ", sirali)}");

                Array.Reverse(sirali);
                Console.WriteLine($"Azalan: {string.Join(", ", sirali)}");

                // TAHMIN ET: 2 iki kez bulunmasına rağmen hangi indeks döner?
                Console.WriteLine($"Asil dizide 2'nin ilk indeksi: {Array.IndexOf(sayilar, 2)}");
                Console.WriteLine($"Asil dizide 7'nin indeksi: {Array.IndexOf(sayilar, 7)}");

                // DEGISTIR: En küçük ikinci değeri üretmeye çalışın.
                // int[] kopya = (int[])sayilar.Clone();
                // Array.Sort(kopya);
                // [2, 2, 5, 8]
                // int enKucuk = kopya[0];
            }

            Uygulama10_ArrayIslemleri();
        }
        break;
}