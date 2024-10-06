Sorgu:
Console.Write("Bir sayı giriniz: ");

string sayi1 = Console.ReadLine();

int sayi2;

if (int.TryParse(sayi1, out sayi2))
{
    if (sayi2 % 2 == 0)
        Console.WriteLine("Çift Sayıdır");
    else
        Console.WriteLine("Tek Sayıdır");
}

else
{
    Console.WriteLine("Hatalı bir değer girdiniz!");
    goto Sorgu;
}
Console.ReadLine();
return;