# Code First Basic - Entity Framework Core

Bu proje, Entity Framework Core kullanılarak Code First yaklaşımıyla bir veri tabanı oluşturmayı amaçlamaktadır. Proje kapsamında iki bağımsız veri tablosu oluşturulmuştur: `Movies` ve `Games`.

## Proje Özellikleri

### Kullanılan Teknolojiler
- **C#**
- **Entity Framework Core**
- **.NET Core**

### Veritabanı Bilgileri
- **Veritabanı Adı:** `PatikaCodeFirstDb1`
- **Context Sınıfı Adı:** `PatikaFirstDbContext`
- **Tablolar:**
  - `Movies`
  - `Games`

## Tabloların Yapısı

### Movies Tablosu
| Kolon Adı   | Veri Tipi | Özellikler                          |
|-------------|-----------|-------------------------------------|
| `Id`        | `int`     | Birincil anahtar, otomatik artan   |
| `Title`     | `string`  | Filmin başlığı                     |
| `Genre`     | `string`  | Filmin türü (örneğin: "Action")   |
| `ReleaseYear`| `int`    | Filmin çıkış yılı                  |

### Games Tablosu
| Kolon Adı   | Veri Tipi | Özellikler                          |
|-------------|-----------|-------------------------------------|
| `Id`        | `int`     | Birincil anahtar, otomatik artan   |
| `Name`      | `string`  | Oyunun adı                         |
| `Platform`  | `string`  | Oyunun oynandığı platform          |
| `Rating`    | `decimal` | Oyunun puanı (0 ile 10 arasında)   |

## Projeyi Çalıştırmak
1. **Proje Çevresi:** Proje için bir .NET Core ortamı oluşturun.
2. **EF Core Paketleri:** Gerekli EF Core NuGet paketlerini yükleyin.
   ```bash
   dotnet add package Microsoft.EntityFrameworkCore
   dotnet add package Microsoft.EntityFrameworkCore.Design
   dotnet add package Microsoft.EntityFrameworkCore.SqlServer
   ```
3. **Context ve Model Tanımlamaları:** `PatikaFirstDbContext` sınıfını ve ilgili `Movie` ile `Game` modellerini oluşturun.
4. **Migration ve Veritabanı Oluşturma:**
   - Migration oluşturmak için:
     ```bash
     dotnet ef migrations add InitialCreate
     ```
   - Veritabanını güncellemek için:
     ```bash
     dotnet ef database update
     ```
5. **Projenizi Test Edin:** Tabloları ve verileri kontrol etmek için ilgili araçları veya sorgu araçlarını kullanın.

## Örnek Kodlar

### `Movie` ve `Game` Modelleri
```csharp
public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Genre { get; set; }
    public int ReleaseYear { get; set; }
}

public class Game
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Platform { get; set; }
    public decimal Rating { get; set; }
}
```

### Context Sınıfı
```csharp
public class PatikaFirstDbContext : DbContext
{
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Game> Games { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Database=PatikaCodeFirstDb1;Trusted_Connection=True;");
    }
}
```
