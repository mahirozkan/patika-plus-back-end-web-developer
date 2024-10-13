Random rnd = new Random();
int random = rnd.Next(1,101); //1 ve 100 arasında rastgele sayı üretir
int kalan = random % 3; // Üretilen sayıyı 3'e böler
Console.WriteLine($"Rastgele sayının 3'e bölümünden kalan: " + kalan); // Bölümden kalanı ekrana yazdırır
Console.ReadKey();