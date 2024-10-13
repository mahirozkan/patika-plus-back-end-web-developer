int EnBuyukSayi()
{
    int i = 1; // Sayaç
    int sayi;
    bool sonuc = true;
    int enBuyuk = int.MinValue;

    Console.WriteLine("Çıkmak için sayı dışında bir değer giriniz!");

    while (sonuc)

    {
        Console.Write($"Sayı {i++}: ");
        string cevap = Console.ReadLine();
        sonuc = int.TryParse(cevap, out sayi);

        if (sonuc)
        {
            enBuyuk = Math.Max(enBuyuk, sayi);
        }
    }

    return enBuyuk;
}
int buyuk = EnBuyukSayi();
Console.WriteLine("En Büyük Sayı: " + buyuk);

Console.ReadKey();