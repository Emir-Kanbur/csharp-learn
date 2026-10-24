
using System;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("=== NOT ANALIZ SISTEMI ===");

int ogrenciSayisi = SayiOku("Ogrenci sayisi (5-20): ", 5, 20);

string[] adlar = new string[ogrenciSayisi];
int[] notlar = new int[ogrenciSayisi];

for (int i = 0; i < ogrenciSayisi; i++)
{
    Console.WriteLine($"\n{i + 1}. Ogrenci");

    adlar[i] = AdOku("Ogrenci adi: ");
    notlar[i] = SayiOku("Ogrenci notu (0-100): ", 0, 100);
}

double ortalama = OrtalamaHesapla(notlar);

MinMaxBul(notlar, out int enDusuk, out int enYuksek);

int ortalamaUstuSayisi = OrtalamaUstuSay(notlar, ortalama);

int[] siraliNotlar = (int[])notlar.Clone();
Array.Sort(siraliNotlar);

StringBuilder rapor = new StringBuilder();

rapor.AppendLine("\n=== SINIF NOT RAPORU ===");

for (int i = 0; i < ogrenciSayisi; i++)
{
    string harfNotu = HarfNotuBul(notlar[i]);

    rapor.AppendLine(
        $"{i + 1}. {adlar[i]} - {notlar[i]} - {harfNotu}");
}

rapor.AppendLine($"\nSinif ortalamasi: {ortalama:F2}");
rapor.AppendLine($"En dusuk not: {enDusuk}");
rapor.AppendLine($"En yuksek not: {enYuksek}");
rapor.AppendLine($"Ortalama ve ustu ogrenci sayisi: {ortalamaUstuSayisi}");
rapor.AppendLine($"Sirali notlar: {string.Join(", ", siraliNotlar)}");

Console.WriteLine(rapor.ToString());


// Belirlenen aralikta sayi okuma
static int SayiOku(string mesaj, int min, int max)
{
    while (true)
    {
        Console.Write(mesaj);
        string giris = Console.ReadLine() ?? "";

        if (int.TryParse(giris, out int sayi)
            && sayi >= min && sayi <= max)
        {
            return sayi;
        }

        Console.WriteLine("Hatali giris! Tekrar deneyiniz.");
    }
}

// Bos olmayan ogrenci adi okuma
static string AdOku(string mesaj)
{
    while (true)
    {
        Console.Write(mesaj);
        string ad = (Console.ReadLine() ?? "").Trim();

        if (!string.IsNullOrWhiteSpace(ad))
        {
            return ad;
        }

        Console.WriteLine("Ogrenci adi bos olamaz!");
    }
}

// Sinif ortalamasini hesaplama
static double OrtalamaHesapla(int[] notlar)
{
    int toplam = 0;

    foreach (int not in notlar)
    {
        toplam += not;
    }

    return (double)toplam / notlar.Length;
}

// En dusuk ve en yuksek notu bulma
static void MinMaxBul(int[] notlar, out int min, out int max)
{
    min = notlar[0];
    max = notlar[0];

    for (int i = 1; i < notlar.Length; i++)
    {
        if (notlar[i] < min)
            min = notlar[i];

        if (notlar[i] > max)
            max = notlar[i];
    }
}

// Nota gore harf notunu belirleme
static string HarfNotuBul(int not)
{
    if (not >= 85) return "AA";
    if (not >= 70) return "BB";
    if (not >= 60) return "CC";
    if (not >= 50) return "DD";

    return "FF";
}

// Ortalama ve uzerindeki ogrencileri sayma
static int OrtalamaUstuSay(int[] notlar, double ortalama)
{
    int sayac = 0;

    foreach (int not in notlar)
    {
        if (not >= ortalama)
        {
            sayac++;
        }
    }

    return sayac;
}
