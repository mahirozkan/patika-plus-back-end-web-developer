Console.Write("Bir Sıcaklık Değeri Giriniz: ");
int sicaklik = Convert.ToInt32(Console.ReadLine());

if (sicaklik < 0)
{
    Console.WriteLine("Donuyor");
}
else if ( sicaklik >= 0 && sicaklik <= 30 )
{
    Console.WriteLine("Normal");
}
else
    Console.WriteLine("Sıcak");

Console.ReadKey();
return;