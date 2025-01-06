# Dependency Injection

Bu proje, Dependency Injection (DI) kullanarak öğretmen bilgilerini yöneten bir örnek uygulamadır. Amaç, DI prensiplerini kullanarak daha esnek ve sürdürülebilir bir kod yapısı oluşturmaktır.

## Proje Yapısı

### `IOgretmen` Arayüzü
- **Açıklama**: `Teacher` sınıfı için bir temel arayüz sağlar.
- **Metotlar**:
  - `string GetInfo()`: Öğretmenin adını ve soyadını döndüren bir metot.

### `Teacher` Sınıfı
- **Özellikler**:
  - `FirstName`: Öğretmenin adı (string)
  - `LastName`: Öğretmenin soyadı (string)
- **Metotlar**:
  - `GetInfo()`: Öğretmenin adını ve soyadını döndürür.

### `Classroom` Sınıfı
- **Özellikler**:
  - `Teacher`: `IOgretmen` türünde bir nesne.
- **Metotlar**:
  - `GetTeacherInfo()`: Öğretmenin bilgilerini döndüren bir metot. Bu metot, `Teacher` nesnesinin `GetInfo()` metodunu çağırır.

## Kullanılan Dependency Injection Yöntemi
- **Constructor Injection**: `Classroom` sınıfının yapıcısına `IOgretmen` türünde bir bağımlılık geçirilir. Bu yöntem, sınıfın bağımlılıklarını dışarıdan almasını sağlar.


## Notlar
- Dependency Injection, sınıflar arasındaki sıkı bağlılığı azaltarak daha modüler ve test edilebilir kod yazmayı sağlar.
- `IOgretmen` arayüzü, sınıf bağımlılıklarının somut sınıflara değil, soyut arayüzlere bağımlı olmasını sağlar.

