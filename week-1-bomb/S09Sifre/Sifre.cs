Console.Write("Şifrenizi Giriniz: ");

string sifre = Console.ReadLine();

switch (sifre)
{
    case "12345":
        Console.WriteLine("Giriş Başarılı");
        break;
    default:
        Console.WriteLine("Giriş Başarısız");
        break;
}

Console.ReadKey();
return;
