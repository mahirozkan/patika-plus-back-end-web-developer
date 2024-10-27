#  Hafta 4 - Kapanış: Teknoloji Mağazasında Ürün Kayıtları

Bu proje, bir teknoloji mağazasında telefon ve bilgisayar kayıtlarını tutmak amacıyla geliştirilmiştir. Projede, her ürün türü için belirlenen özellikleri kullanarak nesne tabanlı programlama kavramları (kalıtım, soyutlama, kapsülleme ve çok biçimlilik) uygulanmıştır.

## Proje Özeti

- **Amaç**: Telefon ve bilgisayar bilgilerini içeren nesneler oluşturmak ve kullanıcıya ürünlerin tüm özelliklerini konsolda göstermek.
- **Kapsanan Konular**: Kalıtım (Inheritance), Kapsülleme (Encapsulation), Çok Biçimlilik (Polymorphism), Soyutlama (Abstraction).
- **Kullanılan Sınıflar**:
  - **BaseMakine**: Telefon ve Bilgisayar sınıfları için ortak olan özellikleri ve metotları içeren temel sınıf.
  - **Telefon** ve **Bilgisayar**: `BaseMakine` sınıfından türeyen, her ürün için özel özellikler ve davranışlar içeren sınıflar.

## Sınıflar ve Özellikler

- **BaseMakine (Base Class)**:
  - **Ortak Özellikler**: Üretim Tarihi, Seri Numarası, Ad, Açıklama, İşletim Sistemi.
  - **BilgileriYazdir() Metodu**: Ürünün ortak özelliklerini konsola yazdıran bir metot. Derived sınıflarda ezilerek (`override`), her ürün türüne özel bilgiler de eklenir.
  - **UrunAdiGetir() Abstract Metodu**: Her ürün için özel bir mesaj ile ad bilgisi konsola yazdırılır.

- **Telefon (Derived Class)**:
  - **Ek Özellik**: TR Lisans durumu (evet/hayır).

- **Bilgisayar (Derived Class)**:
  - **Ek Özellikler**: USB giriş sayısı (2 veya 4), Bluetooth var/yok durumu.
  - **Usb Giriş Sayısı Kontrolü**: USB giriş sayısı yalnızca 2 veya 4 olabilir. Farklı bir değer girilirse uyarı verilir ve -1 atanır.
## Program Akışı

1. **Ürün Seçimi**: Kullanıcıdan telefon üretmek için '1', bilgisayar üretmek için '2' tuşuna basması istenir.
2. **Özelliklerin Alınması**: Kullanıcının seçimine göre uygun sınıftan bir nesne oluşturulur ve özellikleri kullanıcıdan alınır.
3. **Bilgilerin Yazdırılması**: Kullanıcı tüm bilgileri girdikten sonra ürün başarıyla üretildiğini belirten bir mesaj gösterilir.
4. **Tekrar Üretim**: Kullanıcıya başka bir ürün üretmek isteyip istemediği sorulur:
   - **Evet**: İlk adıma geri dönülür.
   - **Hayır**: Program sonlandırılır.
