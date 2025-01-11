# Pratik - Identity and Data Protection

Bu proje, kullanıcı yönetimi ve veritabanı oluşturma sürecini adım adım gerçekleştirir. Kullanıcı bilgilerini güvenli bir şekilde saklamak ve yönetmek amacıyla Identity ve Data Protection kullanılarak bir API oluşturulmuştur. Aşağıda proje hakkında detaylı açıklama ve kurulum adımları yer almaktadır.

## Proje Açıklaması

Proje, aşağıdaki adımları içermektedir:

1. **User Tablosu Oluşturma:** 
   - `User` adında bir tablo oluşturulur ve bu tablonun içerisinde `Email` ve `Password` gibi gerekli alanlar tanımlanır.

2. **Entity Framework Code First Yaklaşımı:**
   - Entity Framework Code First kullanarak veritabanı oluşturulur. Bu yaklaşımda, model sınıfları önce oluşturulur ve ardından veritabanı otomatik olarak oluşturulur.

3. **Model Validation:**
   - API modelinde `Email` ve `Password` alanları için doğrulama (validation) işlemi yapılır. Örneğin, `[Required]` gibi öznitelikler kullanılarak zorunlu alanlar tanımlanır.

4. **Şifreleme:**
   - Kayıt işlemi sırasında, `Password` alanı şifrelenir. Şifreleme işlemi güvenli bir şekilde yapılır ve hassas bilgiler veritabanında şifreli olarak saklanır.

5. **Identity ve Data Protection:**
   - Kullanıcı doğrulama ve kimlik doğrulama işlemleri için `Identity` API kullanılır. Veritabanında şifrelerin güvenli bir şekilde saklanması ve yönetilmesi için Data Protection yöntemleri uygulanır.
