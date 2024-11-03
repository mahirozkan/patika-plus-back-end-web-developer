# Film Sorguları

1. **Country tablosunda bulunan country sütunundaki ülke isimlerinden 'A' karakteri ile başlayıp 'a' karakteri ile sonlananları sıralayınız.**

    ```sql
    SELECT country
    FROM country
    WHERE country LIKE'A%a'; 
    ```
    ![Cevap01](https://github.com/mahirozkan/patika-plus-back-end-web-developer/blob/master/week-6/Odev03/s01.png)

2. **Country tablosunda bulunan country sütunundaki ülke isimlerinden en az 6 karakterden oluşan ve sonu 'n' karakteri ile sonlananları sıralayınız.**

    ```sql
    SELECT country
    FROM country
    WHERE LENGTH(country) >= 6 AND country LIKE '%n';
    ```
    ![Cevap02](https://github.com/mahirozkan/patika-plus-back-end-web-developer/blob/master/week-6/Odev03/s02.png)

3. **Film tablosunda bulunan title sütunundaki film isimlerinden en az 4 adet büyük ya da küçük harf farketmesizin 'T' karakteri içeren film isimlerini sıralayınız.**

    ```sql
    SELECT title
    FROM film
    WHERE title ILIKE '%t%t%t%t%';
    ```
    ![Cevap03](https://github.com/mahirozkan/patika-plus-back-end-web-developer/blob/master/week-6/Odev03/s03.png)

   4. **Film tablosunda bulunan tüm sütunlardaki verilerden title 'C' karakteri ile başlayan ve uzunluğu (length) 90 dan büyük olan ve rental_rate 2.99 olan verileri sıralayınız.**

    ```sql
    SELECT *
    FROM film
    WHERE title LIKE 'C%' AND length > 90 AND rental_rate = 2.99;
    ```
    ![Cevap03](https://github.com/mahirozkan/patika-plus-back-end-web-developer/blob/master/week-6/Odev03/s04.png)
