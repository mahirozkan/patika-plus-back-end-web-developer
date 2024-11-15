# LINQ Group Join

Bu proje, öğrenciler ve sınıflar arasında `LINQ GroupJoin` işlemi gerçekleştiren bir C# konsol uygulamasıdır.

## Proje Açıklaması

Proje, aşağıdaki iki tabloyu temsil eden sınıflar üzerinden yapılacak `GroupJoin` işlemi ile her sınıfın altındaki öğrencileri listelemeyi amaçlamaktadır:

### Öğrenciler Tablosu (Students)
- **StudentId**: Öğrencinin benzersiz kimliği (int)
- **StudentName**: Öğrencinin adı (string)
- **ClassId**: Öğrencinin ait olduğu sınıfın kimliği (int)

### Sınıflar Tablosu (Classes)
- **ClassId**: Sınıfın benzersiz kimliği (int)
- **ClassName**: Sınıfın adı (string)
   
## Kod Açıklamaları

1. **Students ve Classes Sınıfları**:
   - `Students` sınıfı, her bir öğrenciyi temsil ederken, `Classes` sınıfı her bir sınıfı temsil etmektedir.

2. **GroupJoin LINQ Sorgusu**:
   - `GroupJoin`, `Classes` koleksiyonu ile `Students` koleksiyonunu, sınıf kimliğine göre birleştirir. Sonuç olarak, her sınıfın altında o sınıfa ait öğrencilerin listesi elde edilir.

3. **Ekran Çıktısı**:
   - Program, her bir sınıfı ve o sınıfa ait öğrencilerin isimlerini ekrana yazdırır.
