using System.ComponentModel.Design;

Soru:
Console.Write("Notunuzu Giriniz: ");
int not = Convert.ToInt32(Console.ReadLine());

if (not >= 81 && not <= 100)
{
    Console.WriteLine("Başarılı");
}
else if (not >= 61 && not <= 80)
{
    Console.WriteLine("Orta");
}
else if (not >= 0 && not <= 60)
{
    Console.WriteLine("Başarısız");
}
else
{
    Console.WriteLine("Hatalı Bir Giriş Yaptınız!");
    goto Soru;
}
Console.ReadKey();
return;