#region Soru1
string yazi = "Kendime inanıyorum, ben bu yazılım işini hallederim!";

// 10 kere yazıyı ekrana yazdırıyoruz
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"{yazi}");
}
Console.ReadKey();
#endregion

#region Soru2
// 1 ile 20 arasındaki sayıları yazdırıyoruz
for (int i = 1; i <= 20; i++)
{
    Console.WriteLine($"{i}");
}
Console.ReadKey();
#endregion

#region Soru3
// 1 ile 20 arasındaki çift sayıları yazdırıyoruz
for (int i = 1;i <= 20; i++)
    if (i % 2 == 0)
{
    Console.WriteLine(i);
}
Console.ReadKey();
#endregion

#region Soru4 
// 50 ile 150 arasındaki sayıların toplamını hesaplıyoruz
int toplam = 0;
for (int i = 50; i <= 150; i++)
{
    toplam += i;
}
Console.WriteLine(toplam);
Console.ReadKey();
#endregion

#region Soru5
// 1 ile 120 arasındaki tek ve çift sayıların toplamını hesaplıyoruz
int ciftToplam = 0;
int tekToplam = 0;

for (int i = 0; i <= 120; i++)
    if (i % 2 == 0)
    {
        ciftToplam += i;
    }
    else
    if (i % 2 == 1)
    {
        tekToplam += i;
    }
Console.WriteLine($"Çift sayıların toplamı: {ciftToplam} ");
Console.WriteLine($"Tek sayıların toplamı: {tekToplam} ");
Console.ReadKey();
#endregion
