1. **Actor ve customer tablolarında bulunan first_name sütunları için tüm verileri sıralayalım.**

    ```sql
    (SELECT first_name FROM actor)
    UNION
    (SELECT first_name FROM customer);
    ```
    ![Cevap01](https://github.com/mahirozkan/patika-plus-back-end-web-developer/blob/master/week-6/Odev11/s01.png)

2. **Actor ve customer tablolarında bulunan first_name sütunları için kesişen verileri sıralayalım.**

    ```sql
    (SELECT first_name FROM actor)
    INTERSECT
    (SELECT first_name FROM customer);
    ```
    ![Cevap02](https://github.com/mahirozkan/patika-plus-back-end-web-developer/blob/master/week-6/Odev11/s02.png)

3. **Actor ve customer tablolarında bulunan first_name sütunları için ilk tabloda bulunan ancak ikinci tabloda bulunmayan verileri sıralayalım.**

    ```sql
    (SELECT first_name FROM actor)
    EXCEPT
    (SELECT first_name FROM customer);
    ```
    ![Cevap03](https://github.com/mahirozkan/patika-plus-back-end-web-developer/blob/master/week-6/Odev11/s03.png)

   4. **İlk 3 sorguyu tekrar eden veriler için de yapalım.**

    ```sql
    (SELECT first_name FROM actor)
    EXCEPT ALL
    (SELECT first_name FROM customer);
    ```
    ![Cevap04](https://github.com/mahirozkan/patika-plus-back-end-web-developer/blob/master/week-6/Odev11/S04.png)
