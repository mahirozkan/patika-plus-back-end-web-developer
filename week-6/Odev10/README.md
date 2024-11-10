1. **City tablosu ile country tablosunda bulunan şehir (city) ve ülke (country) isimlerini birlikte görebileceğimiz LEFT JOIN sorgusunu yazınız.**

    ```sql
    SELECT city, country FROM city
    LEFT JOIN country ON city.country_id = country.country_id;
    ```
    ![Cevap01](https://github.com/mahirozkan/patika-plus-back-end-web-developer/blob/master/week-6/Odev10/s01.png)

2. **Customer tablosu ile payment tablosunda bulunan payment_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceğimiz RIGHT JOIN sorgusunu yazınız.**

    ```sql
    SELECT first_name, last_name, payment_id FROM customer
    RIGHT JOIN payment ON customer.customer_id=payment.customer_id;
    ```
    ![Cevap02](https://github.com/mahirozkan/patika-plus-back-end-web-developer/blob/master/week-6/Odev10/s02.png)

3. **Customer tablosu ile rental tablosunda bulunan rental_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceğimiz FULL JOIN sorgusunu yazınız.**

    ```sql
    SELECT rental_id, first_name, last_name FROM customer
    FULL JOIN rental ON customer.customer_id = rental.customer_id;
    ```
    ![Cevap03](https://github.com/mahirozkan/patika-plus-back-end-web-developer/blob/master/week-6/Odev10/S03.png)
