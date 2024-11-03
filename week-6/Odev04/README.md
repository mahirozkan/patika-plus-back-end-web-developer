1. **Film tablosunda bulunan replacement_cost sütununda bulunan birbirinden farklı değerleri sıralayınız.**

    ```sql
    SELECT DISTINCT replacement_cost FROM film;
    ```
    ![Cevap01](https://github.com/mahirozkan/patika-plus-back-end-web-developer/blob/master/week-6/Odev04/s01.png)

2. **Film tablosunda bulunan replacement_cost sütununda birbirinden farklı kaç tane veri vardır?**

    ```sql
    SELECT COUNT (DISTINCT replacement_cost) FROM film;
    ```
    ![Cevap02](https://github.com/mahirozkan/patika-plus-back-end-web-developer/blob/master/week-6/Odev04/s02.png)

3. **Film tablosunda bulunan film isimlerinde (title) kaç tanesini T karakteri ile başlar ve aynı zamanda rating 'G' ye eşittir?**

    ```sql
    SELECT COUNT (*) FROM film
    WHERE title LIKE 'T%' AND rating = 'G';
    ```
    ![Cevap03](https://github.com/mahirozkan/patika-plus-back-end-web-developer/blob/master/week-6/Odev04/s03.png)

4. **Country tablosunda bulunan ülke isimlerinden (country) kaç tanesi 5 karakterden oluşmaktadır?**

    ```sql
    SELECT COUNT (*) FROM country
    WHERE country ILIKE '_____';
    ```
    ![Cevap04](https://github.com/mahirozkan/patika-plus-back-end-web-developer/blob/master/week-6/Odev04/s04.png)

5. **City tablosundaki şehir isimlerinin kaç tanesi 'R' veya r karakteri ile biter?**

    ```sql
    SELECT COUNT (*) FROM city
    WHERE city ILIKE '%R';
    ```
    ![Cevap05](https://github.com/mahirozkan/patika-plus-back-end-web-developer/blob/master/week-6/Odev04/s05.png)
