# CelebritiesApi

Bu proje, ünlü sanatçılar ve oyuncularla ilgili bilgileri yönetmek için geliştirilmiş basit bir **ASP.NET Core Web API** uygulamasıdır. API, ünlülerin bilgilerini yönetmek için CRUD (Create, Read, Update, Delete) işlemleri sunar.

## Proje Yapısı

### 1. Proje Oluşturma

- **Proje Adı**: CelebritiesApi
- **Şablon**: ASP.NET Core Web API

### 2. Model: **Celebrity**

`Celebrity.cs` dosyasındaki `Celebrity` sınıfı, ünlülerin bilgilerini temsil eder:

- **Id**: Kişinin benzersiz kimliği
- **Name**: Kişinin adı
- **Profession**: Kişinin mesleği (müzik sanatçısı, oyuncu)

### 3. Controller: **CelebritiesController**

`CelebritiesController.cs` sınıfı, API isteklerini işler ve CRUD operasyonlarını gerçekleştiren metodları içerir:

- **GET /api/celebrities**: Tüm ünlüleri listeleme
- **GET /api/celebrities/{id}**: Belirli bir ünlüyü getirme
- **POST /api/celebrities**: Yeni bir ünlü ekleme
- **PUT /api/celebrities/{id}**: Mevcut bir ünlüyü güncelleme
- **DELETE /api/celebrities/{id}**: Bir ünlüyü silme

### 4. API Kullanımı

#### GET /api/celebrities
Tüm ünlüleri listelemek için kullanılır.

#### GET /api/celebrities/{id}
Belirli bir ünlüyü ID ile getirmek için kullanılır.

#### POST /api/celebrities
Yeni bir ünlü eklemek için kullanılır. Örnek gövde:

```json
{
    "name": "Hadise",
    "profession": "Pop Müzik Sanatçısı"
}
```

#### PUT /api/celebrities/{id}
Bir ünlüyü güncellemek için kullanılır. Örnek gövde:

```json
{
    "name": "Banu Alkan",
    "profession": "Afrodit Bebeğim"
}
```
#### DELETE /api/celebrities/{id}
Bir ünlüyü silmek için kullanılır.
