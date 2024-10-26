# Inheritance Project

Bu proje, C# dilinde nesne yönelimli programlama kullanarak bir okul yönetim sistemi oluşturmaktadır. Proje, kalıtım (inheritance) özelliğini kullanarak temel bir kişi sınıfı oluşturmakta ve bu sınıftan miras alan öğrenci ve öğretmen sınıflarını içermektedir.

### Ogrenci Sınıfı
- **Inheritance:** `Base` sınıfından miras alır.
  
- **Additional Properties:**
  - `ogrenciNumarasi`: Öğrencinin numarası.
  
- **Additional Methods:**
  - `OgrenciInfo()`: Öğrenci numarası, ad ve soyadı konsol ekranına yazdıran metot.

### Ogretmen Sınıfı
- **Inheritance:** `Base` sınıfından miras alır.

- **Additional Properties:**
  - `maas`: Öğretmenin maaşı.
  
- **Additional Methods:**
  - `OgretmenInfo()`: Maaş bilgisi, ad ve soyadı konsol ekranına yazdıran metot.

## Kullanım

Proje içerisinde bir öğretmen ve bir öğrenci nesnesi tanımlanmış ve bunlara değerler atanmıştır. Bu değerler konsol ekranına yazdırılmaktadır.
