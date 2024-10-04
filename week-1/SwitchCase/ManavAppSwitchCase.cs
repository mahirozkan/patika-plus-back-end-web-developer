Console.WriteLine("Rüya Manavına Hoş Geldiniz");
Console.WriteLine("Elma = 2 TL");
Console.WriteLine("Armut = 3 TL");
Console.WriteLine("Çilek = 2 TL");
Console.WriteLine("Muz = 2 TL");
Console.WriteLine("Diğer bütün meyveler = 4 TL");

Console.Write("Hangi meyveyi seçmek istersiniz? (Elma/Armut/Çilek/Muz/Diğer) : ");

string meyve = Console.ReadLine().Trim().ToLower();     // Kullanıcıdan aldığımız girdiyi küçük harfe çeviriyoruz ve baştaki/sondaki boşlukları kaldırıyoruz 
                                                        // Hangi meyvenin istendiğini string meyve içine yazdırıyoruz

switch (meyve)  // Meyve için sorgulamayı başlatıyoruz
{
    case "elma":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");  // meyvenin elma olması durumunda fiyat bilgisini kullanıcıya veriyoruz
        break;
    case "armut":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");  // meyvenin armut olması durumunda fiyat bilgisini kullanıcıya veriyoruz
        break;
    case "çilek":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");  // meyvenin çilek olması durumunda fiyat bilgisini kullanıcıya veriyoruz
        break;
    case "muz":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");  // meyvenin muz olması durumunda fiyat bilgisini kullanıcıya veriyoruz
        break;
    case "diğer":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 4 TL");  // diğer olması durumunda fiyat bilgisini kullanıcıya veriyoruz
        break;
    default:
        Console.WriteLine("Hatalı giriş yaptınız!");            // Geçersiz bilgi girişinde kullanıcıyı uyarıyoruz
        break;
}       
Console.ReadKey();  // Programın kendiliğinden kapanmaması için bir giriş yapılmasını bekliyoruz
return;