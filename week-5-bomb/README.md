# Hafta 5 - Kapanış

Bir araba fabrikasında araba üretiyoruz.

## Araba Özellikleri

- **Üretim Tarihi**
- **Seri Numarası**
- **Marka**
- **Model**
- **Renk**
- **Kapı Sayısı**

## Program Akışı

1. Konsol ekranından kullanıcıya araba üretmek isteyip istemediğini soralım. Üretmek istiyorsa `e`, istemiyorsa `h` harfi ile yanıt versin. Büyük - küçük harf duyarlılığını ortadan kaldıralım. Geçersiz bir cevap verirse, bu cevabın geçersiz olduğunu söyleyerek aynı soruyu tekrar yöneltelim.

2. Kullanıcının cevabı "hayır" ise programı sonlandıralım, "evet" ise bir araba nesnesi üretip özelliklerini konsol ekranından kullanıcıya girdirelim.

3. Üretim Tarihi değeri araba üretilirken otomatik olarak o an olarak atanacak.

4. Kapı Sayısı için sayısal olmayan bir değer atanılmaya çalışılırsa programın exception fırlatmasını engelleyelim, uyarı mesajı verelim ve kullanıcıyı yeniden o satıra yönlendirelim. (goto komutunu araştırınız.)

5. Oluşturulan araba nesnesini `arabalar` isimli bir listeye atayınız.

6. Kullanıcıya başka araba oluşturmak isteyip istemediğini sorunuz, evet ise program akışında 2. aşamaya geri dönünüz ve yeni bir araba üretip listeye ekleyiniz. Cevap hayır ise arabalar listesinin bütün elemanlarının seri numaralarını ve markalarını yazdırınız.
