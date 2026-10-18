// UYGULAMA : Kullanıcıdan bilgi alma ve null guvenligi
// AMAC : Console.ReadLine ve ?? operatorunu kullanmak

Console.WriteLine("\n --- Uygulama ---");

Console.Write("Adinizi Yazdirin: ");
string ad = Console.ReadLine() ?? "Ad Girilmedi.";

Console.Write("Bolumunuzu yaziniz: ");
string bolum = Console.ReadLine() ?? "Bolum girilmedi.";

Console.WriteLine($"Merhaba {ad}. {bolum} bölümüne hoşgeldiniz.");
Console.WriteLine($"Bolum: {bolum}");
Console.WriteLine($"Ad: {ad}");
// DENE: Bolum degiskenini ekrana iki farklı cümlede yazdırır.
// DUSUN: Readline neden string? dondurur: ?? ne işe yarar?