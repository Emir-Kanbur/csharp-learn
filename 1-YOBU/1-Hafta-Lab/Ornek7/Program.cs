// UYGULAMA : Urun fiyati ve KDV hesaplama
// AMAC : decimal turunu ve parasal cikti bicimini kullanmak

Console.WriteLine("Urun fiyatini giriniz:");
string urunFiyatiMetni = Console.ReadLine();
decimal.TryParse(urunFiyatiMetni, out decimal urunFiyati);

decimal kdvOrani = 0.20m;
decimal kdvTutari = urunFiyati * kdvOrani;
decimal toplamFiyat = urunFiyati + kdvTutari;

Console.WriteLine($"Urun fiyati: {urunFiyati:C2}");
Console.WriteLine($"KDV tutari: {kdvTutari:C2}");
Console.WriteLine($"Toplam fiyat: {toplamFiyat:C2}");

// DENE : Fiyati 1000 gir. Ardindan KDV oranini 0.10m yap
// DUSUN : decimal sayilarin sonundaki m harfi neyi belirtiyor?
