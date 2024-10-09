#region Soru1
static void SarkiSozu() //Geriye değer döndürmeyen bir void metot oluşturuyoruz
{
    Console.WriteLine("Bir şiir biliyorsun ayakta bira içebilir, bir şiir nereden baksan şairini seçebilir!");
}
SarkiSozu(); //Metotu çağırıyoruz
#endregion

#region Soru2
static int RastgeleTamSayidanKalan() //Geriye Tamsayı Döndüren Bir metot
{
    Random rnd = new Random(); // Random sınıfını kullanarak rastgele bir sayı üretiyoruz
    int sayi = rnd.Next();
    int kalan = sayi % 2; // 2'ye bölümünden kalanı hesaplıyoruz
    return kalan; // Sonucu geri döndürüyoruz
}
int rastgele = RastgeleTamSayidanKalan(); //Metotu çağırarak rastgele bir sayıyı 2'ye bölüyoruz ve kalanı 'rastgele' değişkeni içine yazıyoruz
Console.WriteLine(rastgele); // Kalanı ekrana yazdırıyoruz

#endregion

#region Soru3
static int Carpim(int x, int y) // Parametre olarak alınan x ve y'nin çarpımını geri döndürüyoruz
{ 
    return x * y; 
}

 int sonuc = Carpim(3, 5); // Carpim metodunu çağırıyoruz ve 3 ile 5'in çarpımını hesaplıyoruz
Console.WriteLine("Çarpım: " + sonuc); //Çarpım sonucunu ekrana yazdırıyoruz
#endregion

#region Soru4
static void Karsilama(string isim, string soyisim) // İki string parametre alan bir metot oluşturuyoruz
{ 
    Console.WriteLine($"Hoşgeldiniz "+  isim + " " + soyisim); // Aldığı iki parametreyi ekrana yazdıracağımız mesaj içine yerleştiriyoruz
    
}
Karsilama("Mahir", "Özkan"); // Mahir ve Özkan kelimelerini metot içine yerleştirip ekrana cümle içerisinde yazdırıyoruz
#endregion
Console.ReadKey();
return;
