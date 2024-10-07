#region Soru1
// 10 kere yazıyı ekrana yazdırıyoruz
int sayac1 = 0;
while(sayac1 < 10)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
    sayac1++;
}
Console.ReadKey();
#endregion

#region Soru2
// 1 ile 20 arasındaki sayıları yazdırıyoruz
int sayac2 = 1;
while(sayac2 <= 20)
{
    Console.WriteLine($"{sayac2}");
    sayac2++;
}
Console.ReadKey();
#endregion

#region Soru3
// 1 ile 20 arasındaki çift sayıları yazdırıyoruz
int sayac3 = 1;
while (sayac3 <= 20)
{
    if (sayac3 % 2 == 0)
    {
        Console.WriteLine($"{sayac3}");
    }
    sayac3++;
}

Console.ReadKey();
#endregion

#region Soru4 
// 50 ile 150 arasındaki sayıların toplamını hesaplıyoruz
int sayac4 = 50;
int toplam = 0;
while (sayac4 <= 150)
{
    toplam += sayac4;
    sayac4++;
}
Console.WriteLine(toplam);
Console.ReadKey();
#endregion

#region Soru5
// 1 ile 120 arasındaki tek ve çift sayıların toplamını hesaplıyoruz
int ciftToplam = 0;
int tekToplam = 0;
int sayac5 = 1;

while (sayac5 <=120)
    if (sayac5 % 2 == 0)
    {
        ciftToplam += sayac5;
        sayac5++;
    }
    else
    if (sayac5 % 2 == 1)
    {
        tekToplam += sayac5;
        sayac5++;
    }
Console.WriteLine($"Çift sayıların toplamı: {ciftToplam} ");
Console.WriteLine($"Tek sayıların toplamı: {tekToplam} ");
Console.ReadKey();
#endregion
