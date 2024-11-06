1. **test veritabanınızda employee isimli sütun bilgileri id(INTEGER), name VARCHAR(50), birthday DATE, email VARCHAR(100) olan bir tablo oluşturalım.**

    ```sql
    CREATE TABLE employee (
	    id INTEGER,
	    name VARCHAR(50),
	    birthday DATE,
	    email VARCHAR(100)
    );
    ```
    ![Cevap01](https://github.com/mahirozkan/patika-plus-back-end-web-developer/blob/master/week-6/Odev08/s01.png)

2. **Oluşturduğumuz employee tablosuna 'Mockaroo' servisini kullanarak 50 adet veri ekleyelim.**

    ![Cevap02-1](https://github.com/mahirozkan/patika-plus-back-end-web-developer/blob/master/week-6/Odev08/s02-1.png)
    ![Cevap02-2](https://github.com/mahirozkan/patika-plus-back-end-web-developer/blob/master/week-6/Odev08/s02-2.png)

3. **Sütunların her birine göre diğer sütunları güncelleyecek 5 adet UPDATE işlemi yapalım.**

    ```sql
    UPDATE employee
    SET email = 'wendeline@asdmail.com'
    WHERE name = 'Wendeline';

    UPDATE employee
    SET birthday = '1985-05-20'
    WHERE id = 4;

    UPDATE employee
    SET email = 'newemail10@example.com'
    WHERE id = 10;

    UPDATE employee
    SET birthday = '1992-03-15'
    WHERE name = 'Linet';

    UPDATE employee
    SET email = 'updated_email@example.com'
    WHERE birthday = '1929-11-19';
    ```
    ![Cevap03](https://github.com/mahirozkan/patika-plus-back-end-web-developer/blob/master/week-6/Odev08/s03.png)
   
4. **Sütunların her birine göre ilgili satırı silecek 5 adet DELETE işlemi yapalım.**

    ```sql
    DELETE FROM employee
    WHERE id = 50;

    DELETE FROM employee
    WHERE name = 'Sherilyn';

    DELETE FROM employee
    WHERE birthday = '1915-08-25';

    DELETE FROM employee
    WHERE email = 'aveldens1a@hp.com';

    DELETE FROM employee
    WHERE name = 'Moe';
    ```
    ![Cevap04](https://github.com/mahirozkan/patika-plus-back-end-web-developer/blob/master/week-6/Odev08/s04.png)
