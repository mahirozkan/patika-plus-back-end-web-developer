# Pratik - Jwt

Bu proje, bir JWT (JSON Web Token) kimlik doğrulama sistemi oluşturmayı amaçlamaktadır.

## Adımlar

### 1. Kullanıcı Modeli
Bir `User` sınıfı oluşturulmuştur. Aşağıdaki özelliklere sahiptir:
- `Id` (int, anahtar)
- `Email` (string, benzersiz)
- `Password` (string)

### 2. Veritabanı 
Entity Framework Core kullanarak bir `DbContext` sınıfı oluşturulmuş ve `User` modelini bu sınıfa dahil edilmiştir.

### 3. JWT Oluşturma
- `AuthController` sınıfı oluşturulmuş, kullanıcı doğrulaması ve JWT oluşturma işlemi yapılmıştır.
- Kullanıcı e-posta ve şifresi ile doğrulandıktan sonra geçerli bir JWT token oluşturulur.

### 4. JWT Doğrulama
- JWT doğrulaması için `Authorize` niteliği kullanılmıştır.
- Her API isteğinde JWT doğrulaması yapılması için gerekli yapılandırmalar `Startup.cs` veya `Program.cs` dosyasına eklenmiştir.
