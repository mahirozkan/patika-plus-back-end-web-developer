# Film Sorguları

1. **Film tablosunda bulunan title ve description sütunlarındaki verileri sıralayın.**

    ```sql
    SELECT title, description FROM film;
    ```
    ![Cevap01](https://github.com/mahirozkan/patika-plus-back-end-web-developer/blob/master/week-6/Odev01/s01.png)

2. **Film tablosunda bulunan tüm sütunlardaki verileri, film uzunluğu (length) 60'dan büyük VE 75'ten küçük olma koşullarıyla sıralayın.**

    ```sql
    SELECT * FROM film
    WHERE length > 60 AND length < 75;
    ```
    ![Cevap02](https://github.com/mahirozkan/patika-plus-back-end-web-developer/blob/master/week-6/Odev01/s02.png)

3. **Film tablosunda bulunan tüm sütunlardaki verileri, rental_rate 0.99 VE replacement_cost 12.99 VEYA 28.99 olma koşullarıyla sıralayın.**

    ```sql
    SELECT * FROM film
    WHERE rental_rate = 0.99 AND (replacement_cost = 12.99 OR replacement_cost = 28.99);
    ```
    ![Cevap03](https://github.com/mahirozkan/patika-plus-back-end-web-developer/blob/master/week-6/Odev01/s03.png)

4. **Customer tablosunda bulunan first_name sütunundaki değeri 'Mary' olan müşterinin last_name sütunundaki değeri nedir?**

    ```sql
    SELECT first_name, last_name FROM customer
    WHERE first_name = 'Mary';
    ```
    ![Cevap04](https://github.com/mahirozkan/patika-plus-back-end-web-developer/blob/master/week-6/Odev01/s04.png)

5. **Film tablosundaki uzunluğu (length) 50'den büyük OLMAYIP aynı zamanda rental_rate değeri 2.99 veya 4.99 OLMAYAN verileri sıralayın.**

    ```sql
    SELECT * from film
    WHERE NOT (length > 50 OR rental_rate = 2.99 OR rental_rate = 4.99);
    ```
    ![Cevap05](https://github.com/mahirozkan/patika-plus-back-end-web-developer/blob/master/week-6/Odev01/s05.png)
