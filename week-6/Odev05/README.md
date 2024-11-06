1. **Film tablosunda bulunan ve film ismi (title) 'n' karakteri ile biten en uzun (length) 5 filmi sıralayınız.**

    ```sql
    SELECT * FROM film
    WHERE title LIKE '%n'
    ORDER BY length DESC
    LIMIT 5;
    ```
    ![Cevap01](https://github.com/mahirozkan/patika-plus-back-end-web-developer/blob/master/week-6/Odev05/s01.png)

2. **Film tablosunda bulunan ve film ismi (title) 'n' karakteri ile biten en kısa (length) ikinci(6,7,8,9,10) 5 filmi(6,7,8,9,10) sıralayınız.**

    ```sql
    SELECT * FROM film
    WHERE title LIKE '%n'
    ORDER BY length ASC
    OFFSET 5
    LIMIT 5;
    ```

3. **Customer tablosunda bulunan last_name sütununa göre azalan yapılan sıralamada store_id 1 olmak koşuluyla ilk 4 veriyi sıralayınız.**

    ```sql
    SELECT * FROM customer
    WHERE store_id = 1
    ORDER BY last_name DESC
    LIMIT 4;
    ```
    ![Cevap03](https://github.com/mahirozkan/patika-plus-back-end-web-developer/blob/master/week-6/Odev05/s03.png)
