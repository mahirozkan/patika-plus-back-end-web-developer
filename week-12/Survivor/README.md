# Survivor Web API

Bu proje, Survivor yarışması için bir Web API uygulaması sağlar. Uygulama, yarışmacılar ve kategoriler arasında bir ilişki kurarak CRUD (Create, Read, Update, Delete) işlemlerini gerçekleştiren API endpoint'leri içerir. Uygulama, bir Category'nin birden fazla Competitor'a sahip olabileceği ve her Competitor'ın yalnızca bir Category'ye ait olduğu bir ilişkiyi yönetir.

## Teknolojiler

- ASP.NET Core Web API
- Entity Framework Core
- SQL Server (veya başka bir veritabanı)

## Proje Yapısı

### Entity'ler

- BaseEntity
- Competitor
- Category

### Controller'lar

#### CompetitorController

Yarışmacılar için aşağıdaki CRUD işlemleri gerçekleştiren API endpoint'lerini içerir:
- `GET /api/competitors`: Tüm yarışmacıları listele.
- `GET /api/competitors/{id}`: Belirli bir yarışmacıyı getir.
- `GET /api/competitors/categories/{CategoryId}`: Kategori ID'sine göre yarışmacıları getir.
- `POST /api/competitors`: Yeni bir yarışmacı oluştur.
- `PUT /api/competitors/{id}`: Belirli bir yarışmacıyı güncelle.
- `DELETE /api/competitors/{id}`: Belirli bir yarışmacıyı sil.

#### CategoryController

Kategoriler için aşağıdaki CRUD işlemleri gerçekleştiren API endpoint'lerini içerir:
- `GET /api/categories`: Tüm kategorileri listele.
- `GET /api/categories/{id}`: Belirli bir kategoriyi getir.
- `POST /api/categories`: Yeni bir kategori oluştur.
- `PUT /api/categories/{id}`: Belirli bir kategoriyi güncelle.
- `DELETE /api/categories/{id}`: Belirli bir kategoriyi sil.
