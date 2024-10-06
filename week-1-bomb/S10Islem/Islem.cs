Console.WriteLine("Birinci Sayıyı Giriniz: ");
int sayi1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("İkinci Sayıyı Giriniz: ");
int sayi2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Yapmak İstediğiniz İşlemi Giriniz(+, -, *, /): ");
string symbol = Console.ReadLine();

switch(symbol)
{
    case "+":
        Console.WriteLine($"Sonuç: {sayi1 + sayi2}"); 
        break;
    case "-":
        Console.WriteLine($"Sonuç: {sayi1 - sayi2}");
        break;
    case "*":
        Console.WriteLine($"Sonuç: {sayi1 * sayi2}");
        break;
    case "/":
        if (sayi2 != 0)
        {
            Console.WriteLine($"Sonuç: {sayi1 / sayi2}");
        }
        else
        {
            Console.WriteLine("Hata: 0'a bölme yapılamaz!");
        }
        break;
    default:
        Console.WriteLine("Geçersiz İşlem");
        break;
}
Console.ReadKey();
return;

