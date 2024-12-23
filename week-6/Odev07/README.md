1. **Film tablosunda bulunan filmleri rating değerlerine göre gruplayınız.**

    ```sql
    SELECT rating, COUNT(*) FROM film
    GROUP BY rating;
    ```
    ![Cevap01](https://github.com/mahirozkan/patika-plus-back-end-web-developer/blob/master/week-6/Odev07/s01.png)

2. **Film tablosunda bulunan filmleri replacement_cost sütununa göre grupladığımızda film sayısı 50 den fazla olan replacement_cost değerini ve karşılık gelen film sayısını sıralayınız.**

    ```sql
    SELECT replacement_cost, COUNT(*) FROM film
    GROUP BY replacement_cost
    HAVING COUNT(*) > 50
    ORDER BY replacement_cost;
    ```
    ![Cevap02](https://github.com/mahirozkan/patika-plus-back-end-web-developer/blob/master/week-6/Odev07/s02.png)

3. **Customer tablosunda bulunan store_id değerlerine karşılık gelen müşteri sayılarını nelerdir?**

    ```sql
    SELECT store_id, COUNT(*) FROM customer
    GROUP BY store_id;
    ```
    ![Cevap03](https://github.com/mahirozkan/patika-plus-back-end-web-developer/blob/master/week-6/Odev07/s03.png)
   
4. **City tablosunda bulunan şehir verilerini country_id sütununa göre gruplandırdıktan sonra en fazla şehir sayısı barındıran country_id bilgisini ve şehir sayısını paylaşınız.**

    ```sql
    SELECT country_id, COUNT(*) FROM city
    GROUP BY country_id
    ORDER BY COUNT(*) DESC
    LIMIT 1;
    ```
    ![Cevap04](https://github.com/mahirozkan/patika-plus-back-end-web-developer/blob/master/week-6/Odev07/s04.png)
