// UYGULAMA: Rehberli Laboratuvar: Öğrenci başarı kartı
// Amaç: Haftanın konularını tek bir küçük programda birleştirmek

using System.ComponentModel.Design.Serialization;

Console.Write("Öğrencinin adini girin:");
string kartOgrenciAdi = Console.ReadLine() ?? "Bilinmeyen öğrenci";

Console.Write("Dersin adini giriniz:");
string kartDersAdi = Console.ReadLine() ?? "Bilinmeyen Ders";

Console.Write("Vize notunuzu giriniz:");
string vizeMetni = Console.ReadLine() ?? "";
bool vizeDonustuMu = double.TryParse(vizeMetni, out double vize);

Console.Write("Final notunu giriniz:");
string finalMetni = Console.ReadLine() ?? "";
bool finalDonustuMu = double.TryParse(finalMetni, out double FinalNotu);

double vizeKatkisi = vize * 0.40;
double finalKatkisi = FinalNotu * 0.60;
double basariNotu = vizeKatkisi + finalKatkisi;

Console.WriteLine("---Ogrenci Basari Karti---");
Console.WriteLine($"Ogrenci: {kartOgrenciAdi}");
Console.WriteLine($"Ders: {kartDersAdi}");
Console.WriteLine($"Vize: {vize:F2}");
Console.WriteLine($"Final: {FinalNotu:F2}");
Console.WriteLine($"vize katkisi: {vizeKatkisi:F2}");
Console.WriteLine($"Final Katkisi: {finalKatkisi:F2}");
Console.WriteLine($"Basari Notu: {basariNotu:F2}");
Console.WriteLine($"Girisler gecerli mi? Vize={vizeDonustuMu}, Final={finalDonustuMu}");

// DENE 1: Vize 50 ve Final 70 için başarı notunu once kendin hesapla
// DENE 2: Vize agirligini %30, final agirligini %70 yap
// DENE 3: Ciktiya ogrenci numaranı ekle
