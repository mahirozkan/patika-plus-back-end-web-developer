Soru:
Console.Write("Yaşınızı giriniz: ");
int yas = Convert.ToInt32(Console.ReadLine());

if (yas >= 18)
{
    Console.WriteLine("+");
}
else
{
    Console.WriteLine("-");
}
Console.ReadKey();