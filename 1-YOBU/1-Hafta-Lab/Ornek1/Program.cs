// Lab Uygulamalari Ornekleri

// Uygulama 1.1.1: Degiskenler ve string interpolation

using System;
Console.WriteLine("\n --- Ilk Uygulama Ornegi --- ");

// Buradaki örnek tamamen hayal ürünü olarak üretilmiştir. Gerçek değildir. Herhangi bir çağrışımda da bulunamaz.

string ogrenciAdi = "Ayse Yilmaz";
int ogrenciYasi = 20;
double notOrtalamasi = 85.68;
bool derseKayitliMi = true;

Console.WriteLine($"Ad Soyad       :   {ogrenciAdi}");
Console.WriteLine($"Yas            :   {ogrenciYasi}");
Console.WriteLine($"Not Ortalamasi :   {notOrtalamasi:F2}");
Console.WriteLine($"Derse Kayitli  :   {derseKayitliMi}");

// DENE : Değişken değerlerini kendine göre düzenle.
// DUSUN: 19 degeri neden tirnak icinde yazilmadi. 

Console.WriteLine($"Devam etmek icin bir tuşa basin");
Console.ReadLine();
