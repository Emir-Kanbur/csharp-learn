// Nesneyi veri ve davranışla düşünme
// Amaç: Henüz sinif yazmadan bir nesnenin durumunu modellemek

using System.Data;
using System.Diagnostics;

Console.WriteLine("\n --- UYGULAMA ---");

string urunAdi = "Kablosuz Kulaklik";
decimal urunFiyati = 450.00m;
int stokMiktari = 12;
int satilanAdet = 2;

Console.WriteLine($"Urun Adi :  {urunAdi}");
Console.WriteLine($"Urun fiyati : {urunFiyati}");
Console.WriteLine($"Urun stok miktari : {stokMiktari:C2}");
Console.WriteLine($"Satilan urun adedi : {satilanAdet}");

stokMiktari = stokMiktari - satilanAdet;

Console.WriteLine($"Satilan adet : {satilanAdet}");
Console.WriteLine($"Kalan stok : {stokMiktari}");

// DENE : Satılan adet sayısını 5 yap ve kalan stok tahmin et
// DUSUN : Urunun ozellıklerı hangılerı davranıs hangısıdır 

Console.WriteLine($"\n Devam etmek için bir tusa basin.");
Console.ReadLine();
