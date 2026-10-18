// UYGULAMA: TEK YONLU IF

int secim = 2;

switch (secim)
{
    case 2:
        {
            Console.Write("Hava sicakligini girin: ");
            bool donustu = double.TryParse(Console.ReadLine(), out double sicaklik);

            if (donustu && sicaklik < 0)
            {
                Console.WriteLine("Buzlanma riski var");

            }

            Console.WriteLine("Kontrol Tamamlandi");

            // TAHMİN ET: Giris -5, 8 ve abc oldugunda ayri ayri ne yazilir

            // DEGİSTİR: Kosulu sicaklik <= 0 yapin. 0 girdisini tekrar deneyin

            // SINIR TESTİ: -0.1, 0 ve 0.1 degerlerini kullanın.
        }
        break;
}