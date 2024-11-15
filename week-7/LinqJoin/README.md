# Linq Join

Sistem, **Yazarlar** ve **Kitaplar** adında iki ana tablodan oluşmaktadır. Bu tabloların her biri, yazar bilgilerini ve kitap bilgilerini içerir. **LINQ Join** kullanılarak yazarlar ve kitaplar arasında ilişki kurularak, her kitabın başlığı ve yazarının adı birleştirilip ekrana yazdırılacaktır.

## Proje Yapısı

### Yazarlar Tablosu (Authors)
- **AuthorId (int)**: Yazarın benzersiz kimliği
- **Name (string)**: Yazarın adı

### Kitaplar Tablosu (Books)
- **BookId (int)**: Kitabın benzersiz kimliği
- **Title (string)**: Kitabın başlığı
- **AuthorId (int)**: Kitabın yazarının kimliği (Yazarlar tablosundaki `AuthorId` ile ilişkilidir)

## Kullanılan Teknolojiler

- C#
- LINQ

## Özellikler

- Yazarlar ve kitaplar arasında ilişki kurmak için LINQ kullanılmıştır.
- Yazar adı ve kitap başlıkları birleştirilerek ekrana yazdırılmıştır.
