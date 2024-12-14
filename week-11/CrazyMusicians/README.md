# Çılgın Müzisyenler API

## Proje Özeti
Çılgın Müzisyenler API, çılgın müzisyenlerin verilerini yönetmek için tasarlanmış bir ASP.NET Core Web API projesidir. API, müzisyen bilgileri üzerinde temel CRUD işlemleri sağlar ve esnek routing, doğrulama ve sorgulama mekanizmaları ile desteklenmiştir.

---

## Özellikler

1. **CRUD İşlemleri:**
   - **GET:** Tüm müzisyenleri veya belirli bir müzisyeni ID veya isme göre getirir.
   - **POST:** Yeni bir müzisyen ekler.
   - **PATCH:** Bir müzisyenin özelliklerini kısmi olarak günceller.
   - **PUT:** Bir müzisyenin adını günceller.
   - **DELETE:** Belirli bir müzisyeni siler.

2. **Routing:**
   - Route yapısı, esneklik ve okunabilirlik için düzenlenmiştir. Örneğin, "search" ve "patch" gibi özel yollar tanımlanmıştır.

3. **Doğrulama:**
   - Verilerin eksiksiz ve doğru bir şekilde işlenmesi için [Required] ve [StringLength] gibi Data Annotations kullanılmıştır.

4. **Sorgu Filtreleme:**
   - `[FromQuery]` ile isim bazlı arama yapabilirsiniz.

---

## API Uç Noktaları

### 1. GET
- **Tüm müzisyenleri getir:**
  ```http
  GET /api/CrazyMusicians
  ```
- **Belirli bir müzisyeni ID ile getir:**
  ```http
  GET /api/CrazyMusicians/{id}
  ```
- **Müzisyenleri isme göre ara:**
  ```http
  GET /api/CrazyMusicians/search?name=Ali
  ```

### 2. POST
- **Yeni bir müzisyen ekle:**
  ```http
  POST /api/CrazyMusicians
  ```
  **Örnek Gövde:**
  ```json
  {
    "name": "Yeni Müzisyen",
    "job": "Yeni İş",
    "feature": "Yeni Özellik"
  }
  ```

### 3. PATCH
- **Müzisyenin özelliklerini güncelle:**
  ```http
  PATCH /api/CrazyMusicians/feature/patch/{id}
  ```
  **Örnek Gövde:**
  ```json
  "Yeni Özellik"
  ```

### 4. PUT
- **Müzisyenin adını güncelle:**
  ```http
  PUT /api/CrazyMusicians/update/{id}/{newName}
  ```

### 5. DELETE
- **Bir müzisyeni sil:**
  ```http
  DELETE /api/CrazyMusicians/{id}
  ```

---

