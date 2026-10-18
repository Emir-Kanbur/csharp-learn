// Uygulama : Dikdortgenin hesaplayici
// Amac : Girdi, TryParse, aritmetik islem ve bicimli ciktiyi birlestirmek.

Console.WriteLine("Kisa kenari giriniz:");
string kisaKenarMetni = Console.ReadLine();
double.TryParse(kisaKenarMetni, out double kisaKenar);

Console.WriteLine("Uzun kenari giriniz:");
string uzunKenarMetni = Console.ReadLine();
double.TryParse(uzunKenarMetni, out double uzunKenar);

double alan = kisaKenar * uzunKenar;
double cevre = 2 * (kisaKenar + uzunKenar);

Console.WriteLine($"Alan: {alan:F2} birim kare");
Console.WriteLine($"Cevre: {cevre:F2} birim");

// DENE : 4 ve 6 degerleri ile calistir once sonucu kagıtta hesapla.
// HATA AVI : Cevre formulundeki paratezler kaldırılırsa sonuc neden degisir?
