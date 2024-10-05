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

#region Yöntem 2 ElseIf

// Switch-Case'e alternatif If-Else yapısı ile aynı programın kodları aşağı eklenmiştir satır 11'e kadar olan kodlar her iki yöntemde de ortak kullanılabilir 

//if (meyve == "elma") // meyve stringi elmay'a eşit mi diye sorulur
//{
//    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");  // meyvenin elma olması durumunda fiyat bilgisini kullanıcıya veriyoruz
//}
//else if (meyve == "armut") // meyve stringi armut'a eşit mi diye sorulur
//{
//    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");  // meyvenin armut olması durumunda fiyat bilgisini kullanıcıya veriyoruz
//}
//else if (meyve == "çilek") // meyve stringi çilek'e eşit mi diye sorulur
//{
//    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");  // meyvenin çilek olması durumunda fiyat bilgisini kullanıcıya veriyoruz
//}
//else if (meyve == "muz") // meyve stringi muz'a eşit mi diye sorulur
//{
//    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");  // meyvenin muz olması durumunda fiyat bilgisini kullanıcıya veriyoruz
//}
//else if (meyve == "diğer") // meyve stringi diğer'e eşit mi diye sorulur
//{
//    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 4 TL");  // diğer olması durumunda fiyat bilgisini kullanıcıya veriyoruz
//}
//else
//{ 
//        Console.WriteLine("Hatalı giriş yaptınız!");        // Geçersiz bilgi girişinde kullanıcıyı uyarıyoruz
//}
//Console.ReadKey();
//return;
#endregion