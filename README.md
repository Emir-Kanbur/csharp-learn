# C# Öğrenme Notları ve Uygulamaları

Yozgat Bozok Üniversitesi derslerinde hazırlanan Türkçe C# notları, konsol örnekleri ve ödevler.

| Bölüm | İçerik |
| --- | --- |
| [1. hafta](./1-YOBU/1-Hafta-Konu/) | Ders örnekleri ve [laboratuvar](./1-YOBU/1-Hafta-Lab/) |
| [2. hafta](./1-YOBU/2-Hafta-Lab/) | Laboratuvar ve [haftalık ödev](./Odev/Hafta2/) |
| [3. hafta](./1-YOBU/3-Hafta-Konu/) | Ders örnekleri, [laboratuvar](./1-YOBU/3-Hafta-Lab/) ve [not/metin analizi ödevi](./Odev/Hafta3/NotAnalizSistemi/) |
| [4. hafta](./Odev/Hafta4/KutuphaneOtomasyonu/) | Kitap arama, ödünç alma ve iade işlemlerini örnekleyen kütüphane otomasyonu |

## Derleme ve çalıştırma

.NET 10 SDK ile depo kökünde şu komutları kullanabilirsiniz:

```sh
# Tüm ders ve ödev projelerini derle
dotnet build CSharpLearn.slnx --configuration Release

# Tek bir laboratuvar örneğini çalıştır
dotnet run --project 1-YOBU/3-Hafta-Lab/Ornek2/Ornek2.csproj

# Kütüphane otomasyonunu çalıştır
dotnet run --project Odev/Hafta4/KutuphaneOtomasyonu
```

Her örnek bağımsız bir konsol uygulamasıdır. Yeni bir örnek oluşturduğunuzda çözüm dosyasına da ekleyin:

```sh
dotnet new console --output 1-YOBU/4-Hafta-Lab/Ornek1
dotnet sln CSharpLearn.slnx add 1-YOBU/4-Hafta-Lab/Ornek1/Ornek1.csproj --solution-folder 1-YOBU/4-Hafta-Lab
```

GitHub Actions çözümdeki tüm projeleri derler. Her proje ortak .NET ayarlarını [Directory.Build.props](./Directory.Build.props) dosyasından alır.

## Lisans

[MIT lisansı](./LICENSE).
