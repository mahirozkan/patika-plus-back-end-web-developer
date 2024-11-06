﻿﻿﻿--S01 - test veritabanınızda employee isimli sütun bilgileri id(INTEGER), name VARCHAR(50), birthday DATE, email VARCHAR(100) olan bir tablo oluşturalım.
CREATE TABLE employee (
	id INTEGER,
	name VARCHAR(50),
	birthday DATE,
	email VARCHAR(100)
);
--S02 - Oluşturduğumuz employee tablosuna 'Mockaroo' servisini kullanarak 50 adet veri ekleyelim.
-- Veri eklemek için : https://www.mockaroo.com/
--S03 - Sütunların her birine göre diğer sütunları güncelleyecek 5 adet UPDATE işlemi yapalım.
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

﻿﻿--S04 - Sütunların her birine göre ilgili satırı silecek 5 adet DELETE işlemi yapalım.
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