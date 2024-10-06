Soru:
Console.WriteLine("Bir Sayı Giriniz(1-12): ");
int sayi = Convert.ToInt32(Console.ReadLine());

switch (sayi)
{
    case 1:
        Console.WriteLine("31 Gündür");
        break;
    case 2:
        Console.WriteLine("28 Gündür");
        break;
    case 3:
        Console.WriteLine("31 Gündür");
        break;
    case 4:
        Console.WriteLine("30 Gündür");
        break;
    case 5:
        Console.WriteLine("31 Gündür");
        break;
    case 6:
        Console.WriteLine("30 Gündür");
        break;
    case 7:
        Console.WriteLine("31 Gündür");
        break;
    case 8:
        Console.WriteLine("31 Gündür");
        break;
    case 9:
        Console.WriteLine("30 Gündür");
        break;
    case 10:
        Console.WriteLine("31 Gündür");
        break;
    case 11:
        Console.WriteLine("30 Gündür");
        break;
    case 12:
        Console.WriteLine("31 Gündür");
        break;
    default:
        {
            Console.WriteLine("Hatalı Bir Sayı Girdiniz!");
            goto Soru;
        }
        break;
}
Console.ReadKey();
return;