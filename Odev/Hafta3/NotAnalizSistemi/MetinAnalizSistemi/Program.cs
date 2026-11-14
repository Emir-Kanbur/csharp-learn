using System;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("=== METIN ANALIZI ===");

string[] konular;

// Kullanıcıdan geçerli metin alınması
while (true)
{
    Console.Write("Konulari virgulle ayirarak giriniz: ");
    string? giris = Console.ReadLine();
    if (giris is null)
    {
        return;
    }

    if (string.IsNullOrWhiteSpace(giris))
    {
        Console.WriteLine("Bos metin girilemez!");
        continue;
    }

    konular = giris.Split(',',
        StringSplitOptions.TrimEntries |
        StringSplitOptions.RemoveEmptyEntries);

    if (konular.Length == 0)
    {
        Console.WriteLine("En az bir konu girilmelidir!");
        continue;
    }

    break;
}

// Rapor oluşturma
StringBuilder rapor = new StringBuilder();

rapor.AppendLine("\n=== METIN ANALIZ RAPORU ===");

rapor.AppendLine(
    $"Temizlenmis liste: {string.Join(", ", konular)}");

rapor.AppendLine("\nKonu Bilgileri:");

bool cSharpVarMi = false;

// Karakter ve sesli harf analizi
for (int i = 0; i < konular.Length; i++)
{
    string konu = konular[i];

    int karakter = KarakterSayisi(konu);
    int sesli = SesliHarfSayisi(konu);

    rapor.AppendLine(
        $"{i + 1}. {konu} - Karakter: {karakter}, Sesli harf: {sesli}");

    if (string.Equals(konu, "C#",
        StringComparison.OrdinalIgnoreCase))
    {
        cSharpVarMi = true;
    }
}

rapor.AppendLine(
    $"\nC# ifadesi bulundu mu?: {(cSharpVarMi ? "Evet" : "Hayir")}");

// Tekrar analizi
rapor.AppendLine("\nTekrar Analizi:");

for (int i = 0; i < konular.Length; i++)
{
    bool dahaOnceYazildi = false;

    for (int j = 0; j < i; j++)
    {
        if (AyniKonuMu(konular[i], konular[j]))
        {
            dahaOnceYazildi = true;
            break;
        }
    }

    if (dahaOnceYazildi)
    {
        continue;
    }

    int gorulmeSayisi = 0;

    for (int j = 0; j < konular.Length; j++)
    {
        if (AyniKonuMu(konular[i], konular[j]))
        {
            gorulmeSayisi++;
        }
    }

    rapor.AppendLine(
        $"{konular[i]} - Gorulme: {gorulmeSayisi}, Tekrar: {gorulmeSayisi - 1}");
}

// Raporun ekrana yazdırılması
Console.WriteLine(rapor.ToString());


// Karakter sayısını hesaplar
static int KarakterSayisi(string metin)
{
    return metin.Length;
}

// Türkçe sesli harfleri sayar
static int SesliHarfSayisi(string metin)
{
    string sesliler = "aeıioöuüAEIİOÖUÜ";
    int sayac = 0;

    foreach (char harf in metin)
    {
        if (sesliler.Contains(harf))
        {
            sayac++;
        }
    }

    return sayac;
}

// Karşılaştırma için metni düzenler
static string MetniDuzenle(string metin)
{
    return metin.Trim()
        .Replace('İ', 'i')
        .Replace('I', 'i')
        .Replace('ı', 'i')
        .ToLowerInvariant();
}

// İki konunun aynı olup olmadığını kontrol eder
static bool AyniKonuMu(string ilk, string ikinci)
{
    string birinci = MetniDuzenle(ilk);
    string ikinciMetin = MetniDuzenle(ikinci);

    return string.Equals(
        birinci,
        ikinciMetin,
        StringComparison.Ordinal);
}
