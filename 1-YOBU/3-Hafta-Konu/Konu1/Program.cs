namespace Uygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 10;
            int[] sayilar = { 1, 3, 2, 10, 100, 35, 50, 75, 67 };
            Artir(ref sayi);
            Console.WriteLine(sayi);
            Console.WriteLine();
            int minn, maxx;
            double ort;
            MinMax(sayilar, out minn, out maxx, out ort);
            // Bir metot sadece bi değer döndürür.
            Console.WriteLine("Min Değer: " + minn);
            Console.WriteLine("Max Değer: " + maxx);
            Console.WriteLine("Ortalama Değer: " + ort);
        }
        static void Artir(ref int x) => x++;

        static void MinMax(int[] sayidizisi, out int min, out int max, out double ort)
        {
            min = max = sayidizisi[0];
            int toplam = 0;
            foreach (int item in sayidizisi)
            {
                if (item < min) min = item;
                if (item > max) max = item;
                toplam += item;
            }
            ort = toplam;
        }
    }
}