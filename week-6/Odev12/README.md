1. **Film tablosunda film uzunluğu length sütununda gösterilmektedir. Uzunluğu ortalama film uzunluğundan fazla kaç tane film vardır?**

    ```sql
    SELECT COUNT(*) FROM film
    WHERE length > (SELECT AVG(length) FROM film);
    ```
    ![Cevap01](https://github.com/mahirozkan/patika-plus-back-end-web-developer/blob/master/week-6/Odev12/s01.png)

2. **Film tablosunda en yüksek rental_rate değerine sahip kaç tane film vardır?**

    ```sql
    SELECT COUNT(*) FROM film
    WHERE rental_rate = (SELECT MAX(rental_rate) FROM film);
    ```
    ![Cevap02](https://github.com/mahirozkan/patika-plus-back-end-web-developer/blob/master/week-6/Odev12/s02.png)

3. **Film tablosunda en düşük rental_rate ve en düşün replacement_cost değerlerine sahip filmleri sıralayınız.**

    ```sql
    SELECT * FROM film
    WHERE rental_rate = (SELECT MIN(rental_rate) FROM film) AND replacement_cost = (SELECT MIN(replacement_cost) FROM film);
    ```
    ![Cevap03](https://github.com/mahirozkan/patika-plus-back-end-web-developer/blob/master/week-6/Odev12/s03.png)

   4. **Payment tablosunda en fazla sayıda alışveriş yapan müşterileri(customer) sıralayınız.**

    ```sql
    SELECT customer_id, COUNT(*) FROM payment
    GROUP BY customer_id;
    ```
    ![Cevap04](https://github.com/mahirozkan/patika-plus-back-end-web-developer/blob/master/week-6/Odev12/s04.png)
