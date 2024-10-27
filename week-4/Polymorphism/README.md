# Polymorphism - Geometrik Şekiller Uygulaması

Bu proje, C# dilinde polimorfizm prensibini kullanarak temel geometrik şekillerin alan hesaplamalarını gerçekleştiren bir uygulama geliştirmeyi amaçlamaktadır. 

## Proje Açıklaması

Uygulamada `Kare`, `Dikdortgen` ve `DikUcgen` adında üç farklı geometrik şekil nesnesi bulunmaktadır. Bu şekiller, `BaseGeometrikSekil` adlı bir temel sınıftan türetilmiştir. Her bir şeklin alan hesaplama işlemi kendi sınıfında yapılmaktadır ve polimorfizm sayesinde tüm şekiller aynı taban sınıf metodunu (AlanHesapla) kullanarak kendi özel hesaplamalarını yapmaktadır.

### Sınıflar ve Özellikleri

- **BaseGeometrikSekil (Temel Sınıf)**:
  - Ortak Özellikler:
    - `Genislik`: Şeklin genişliği
    - `Yukseklik`: Şeklin yüksekliği
  - Ortak Metod:
    - `Alan()`: Şeklin alanını hesaplar. Her şekil kendi alan formülüne göre bu metodu geçersiz kılar (override eder).

- **Kare Sınıfı**:
  - `Alan()` metodunu `Genislik * Yukseklik` formülü ile yeniden tanımlar.

- **Dikdortgen Sınıfı**:
  - `Alan()` metodunu `Genislik * Yukseklik` formülü ile yeniden tanımlar.

- **DikUcgen Sınıfı**:
  - `Alan()` metodunu `(Genislik * Yukseklik) / 2` formülü ile yeniden tanımlar.
