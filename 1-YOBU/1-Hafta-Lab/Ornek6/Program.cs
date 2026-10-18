// Uygulama : Sıcaklık donusturucu
// Amac : double turu islem onceligi ve ondalikli cikti

Console.Write("santigrat sicaklik degerini giriniz:");
string santigratMetni = Console.ReadLine();
double.TryParse(santigratMetni, out double santigrat);

double fahrenheit = (santigrat * 9 / 5) + 32;

Console.WriteLine($"Santigrat: {santigrat:F1} °C = {fahrenheit:F1} °F");

// DENE : 0, 25 ve 100 degerleri icin sonucu once tahmin et sonrasında calistir
// HATA AVI : Formulu santigrat * 9 / 5 + 32 seklinde yazarsaniz sonuc neden degisir?
