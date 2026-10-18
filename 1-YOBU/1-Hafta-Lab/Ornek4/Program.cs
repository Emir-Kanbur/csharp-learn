// UYGULAMA : Guvenli tur donusumu
// Amac: int.TryParse ile metni sayiya donusturmek.

Console.WriteLine("\n ---Uygulama : Yas Donusturme ---");

Console.Write("Yasinizi giriniz: ");
string yasMetni = Console.ReadLine();

bool yasDonustuMu = int.TryParse(yasMetni, out int yas);
int gelecekYilYas = yas + 1;

if (yasDonustuMu)
{
    Console.WriteLine($"Gelecek yil {gelecekYilYas} yasinda olacaksiniz.");
}
else
{
    Console.WriteLine("Lutfen gecerli bir sayi giriniz.");
}

Console.WriteLine($"donusum basarili mi? {yasDonustuMu}");

