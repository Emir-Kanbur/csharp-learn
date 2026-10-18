// UYGULAMA 11 - MATRIS VE JAGGED DIZILER

int uygulamaNo = 11;

switch (uygulamaNo)
{
    case 11:
        {
            static void Uygulama11_MatrisVeJagged()
            {
                int[,] matris =
                {
                    {10, 20, 30},
                    {40, 50, 60}
                };

                Console.WriteLine($"Matris: {matris.GetLength(0)} satir × {matris.GetLength(1)} sutun");

                int matrisToplami = 0;
                for (int satir = 0; satir < matris.GetLength(0); satir++)
                {
                    for (int sutun = 0; sutun < matris.GetLength(1); sutun++)
                    {
                        matrisToplami += matris[satir, sutun];
                    }
                }

                Console.WriteLine($"Matris toplamı: {matrisToplami}");

                int[][] gruplar =
                {
                    new[] { 70, 80 },
                    new[] { 55, 65, 75 },
                    new[] { 90 }
                };

                Console.WriteLine($"Gruplar.Length = {gruplar.Length}, gruplar[1].Length = {gruplar[1].Length}");
                Console.WriteLine($"Gruplar[1] => {string.Join(", ", gruplar[1])}");

                // TAHMIN ET: gruplar.Length ile gruplar[1].Length ayni mi?
                // HATA AVI: Jagged dizi elemanları farklı uzunlukta olabilir.
            }

            Uygulama11_MatrisVeJagged();
        }
        break;
}
