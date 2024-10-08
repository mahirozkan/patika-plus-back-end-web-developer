#region While

#endregion
Console.WriteLine("Bir sayı giriniz: ");
int limit = Convert.ToInt32(Console.ReadLine());
int sayac1 = 0;

while (sayac1 < limit)
{
        Console.WriteLine("Ben bir Patika'lıyım");
        sayac1++;
}
Console.ReadKey();

Console.WriteLine("---------------------------------------");

#region DoWhile
int sayac2 = 0;
do
{
    Console.WriteLine("Ben bir Patika'lıyım");
    sayac2++;
}while (sayac2 < limit);
Console.ReadKey();
#endregion


/*
- While döngüsü, koşulu kontrol ederek başlar. Eğer koşul baştan sağlanmazsa (örn: limit -5 ise), döngü hiç çalışmaz.
- Bu yüzden negatif limitler gibi durumlarda, while döngüsü kullanıcıya çıktı vermez.
- Do-while döngüsü en az bir kez çalışır, çünkü döngü bloğu ilk çalıştırıldığında koşul kontrol edilmeden yürütülür.
*/