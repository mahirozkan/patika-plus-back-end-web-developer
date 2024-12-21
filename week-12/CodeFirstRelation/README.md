# Code First Relation - Entity Framework Core

Bu proje, Entity Framework Core kullanarak Code First yaklaşımını uygulamak için bir örnektir. Bu projede iki tablo oluşturulmuştur: `Users` ve `Posts`. Kullanıcılar ve gönderiler arasında bir ilişki kurulmuş, her kullanıcı birden fazla gönderi oluşturabilirken, her gönderi yalnızca bir kullanıcıya ait olacaktır.

## Proje Özeti

Proje, aşağıdaki iki tablodan oluşmaktadır:

- **User Tablosu**: Kullanıcı bilgilerini tutar.
- **Post Tablosu**: Kullanıcıların oluşturduğu gönderilerin bilgilerini tutar.

### Veritabanı Bilgisi

- **Veritabanı İsmi**: `PatikaCodeFirstDb2`
- **Context Sınıfı İsmi**: `PatikaSecondDbContext`

### Kullanıcı Tablosu (Users)

- **Id**: int (Birincil anahtar ve otomatik artan)
- **Username**: string (Kullanıcının kullanıcı adı)
- **Email**: string (Kullanıcının e-posta adresi)

### Gönderi Tablosu (Posts)

- **Id**: int (Birincil anahtar ve otomatik artan)
- **Title**: string (Gönderinin başlığı)
- **Content**: string (Gönderinin içeriği)
- **UserId**: int (Gönderinin yazarı, kullanıcı kimliği)

### İlişki

- Bir kullanıcı birden fazla gönderi oluşturabilir.
- Her gönderi yalnızca bir kullanıcıya ait olacak şekilde tasarlanmıştır.
