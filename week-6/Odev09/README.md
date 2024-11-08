1. **City tablosu ile country tablosunda bulunan şehir (city) ve ülke (country) isimlerini birlikte görebileceğimiz INNER JOIN sorgusunu yazınız.**

    ```sql
    SELECT city.city, country.country FROM country
    INNER JOIN city ON country.country_id = city.country_id; 
    ```
    ![Cevap01](https://github.com/mahirozkan/patika-plus-back-end-web-developer/blob/master/week-6/Odev09/s01.png)

2. **Customer tablosu ile payment tablosunda bulunan payment_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceğimiz INNER JOIN sorgusunu yazınız.**

    ```sql
    SELECT payment.payment_id, customer.first_name, customer.last_name FROM payment
    INNER JOIN customer ON payment.customer_id = customer.customer_id;
    ```
    ![Cevap02](https://github.com/mahirozkan/patika-plus-back-end-web-developer/blob/master/week-6/Odev09/s02.png)

3. **Customer tablosu ile rental tablosunda bulunan rental_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceğimiz INNER JOIN sorgusunu yazınız.**

    ```sql
    SELECT payment.rental_id, customer.first_name, customer.last_name FROM payment
    INNER JOIN customer ON payment.customer_id = customer.customer_id;
    ```
    ![Cevap03](https://github.com/mahirozkan/patika-plus-back-end-web-developer/blob/master/week-6/Odev09/s03.png)
