#region Selamlama
Başlangıç:
Console.WriteLine("\n------------------------------------------------------");
Console.WriteLine("\nMerhaba! Tatil uygulamamıza hoşgeldiniz.");
Console.WriteLine("\n------------------------------------------------------");
#endregion

#region LokasyonBilgisi
Console.WriteLine("\nSize özel tatil lokasyonlarımız ve paket başlangıç fiyatları aşağıdadır:");
Console.WriteLine("Bodrum (Paket başlangıç fiyatı 4000 TL)");
Console.WriteLine("Marmaris (Paket başlangıç fiyatı 3000 TL)");
Console.WriteLine("Çeşme (Paket başlangıç fiyatı 5000 TL)");
Console.WriteLine("\n------------------------------------------------------");
Lokasyon:
Console.Write("\nLütfen tercih ettiğiniz tatil lokasyonunu giriniz(Bodrum / Marmaris / Çeşme): ");
string lokasyon = Console.ReadLine().Trim().ToLower();
int lFiyat = 0;

switch (lokasyon)
{
    case "bodrum":
        Console.WriteLine("\n------------------------------------------------------");
        Console.WriteLine("\nSeçtiğiniz Lokasyon: " + lokasyon.ToUpper());
        Console.WriteLine("\n------------------------------------------------------");
        Console.WriteLine("# Bodrum'da Tatilde Yapılacak Aktiviteler\r\n\r\n" +
            "1. Plajlar ve Denize Girmek**: Gümbet, Bitez ve Yalıkavak gibi popüler plajlarda denize girip güneşlenin.\r\n" +
            "2. Tekne Turları**: Bodrum’un berrak koylarını keşfetmek için tekne turlarına katılın.\r\n" +
            "3. Su Sporları**: Rüzgar sörfü, su kayağı ve dalış gibi su sporlarını deneyimleyin.\r\n" +
            "4. Bodrum Kalesi ve Sualtı Arkeoloji Müzesi**: Tarihi Bodrum Kalesi'ni gezip Sualtı Arkeoloji Müzesi'ni keşfedin.\r\n" +
            "5. Bodrum Antik Tiyatrosu**: Antik Tiyatro'da kültürel etkinliklere katılın veya manzarayı seyredin.\r\n" +
            "6. Barlar Sokağı**: Bodrum'un meşhur Barlar Sokağı'nda gece hayatının tadını çıkarın.\r\n" +
            "7. Ege Mutfağı**: Deniz ürünleri, zeytinyağlılar ve mezeleri deneyebileceğiniz restoranlarda lezzetli yemekler yiyin.\r\n" +
            "8. Mavi Yolculuk**: Ege ve Akdeniz koylarını keşfetmek için mavi yolculuğa çıkın.\r\n");
        lFiyat = 4000;
        lokasyon = "Bodrum";
            Console.WriteLine("\n------------------------------------------------------");
        break;
    case "marmaris":
        Console.WriteLine("\n------------------------------------------------------");
        Console.WriteLine("\nSeçtiğiniz Lokasyon: " + lokasyon.ToUpper());
        Console.WriteLine("\n------------------------------------------------------");
        Console.WriteLine("# Marmaris'te Tatilde Yapılacak Aktiviteler\r\n\r\n" +
            "1. Plajlar ve Denize Girmek**: İçmeler Plajı, Turunç ve Uzunyalı gibi plajlarda denizin ve güneşin tadını çıkarın.\r\n" +
            "2. Tekne Turları**: Marmaris’in koylarını ve çevresindeki adaları keşfetmek için günlük tekne turlarına katılın.\r\n" +
            "3. Dalyan Turu**: Dalyan’daki çamur banyoları, İztuzu Plajı ve antik Likya mezarlarını ziyaret edin.\r\n" +
            "4. Su Sporları**: Jet ski, rüzgar sörfü, parasailing gibi su sporlarını Marmaris'in çeşitli plajlarında deneyin.\r\n" +
            "5. Marmaris Kalesi ve Müzesi**: Marmaris Kalesi'ni gezip tarihe tanıklık edin; kalede bulunan müzeyi ziyaret edin.\r\n" +
            "6. Gece Hayatı**: Marmaris Barlar Sokağı'nda eğlence dolu bir gece geçirin.\r\n" +
            "7. Doğa Yürüyüşleri**: Turgut Şelalesi, Günnücek Milli Parkı ve Bozburun yarımadası gibi doğa alanlarında yürüyüş yapın.\r\n" +
            "8. Marmaris Marina**: Marinada yürüyüş yapın, kafelerde oturun ve lüks yatları izleyin.\r\n" +
            "9. Ege ve Akdeniz Mutfağı**: Deniz ürünleri, zeytinyağlılar ve yerel lezzetleri Marmaris’in sahil restoranlarında tadın.\r\n");
        lFiyat = 3000;
        lokasyon = "Marmaris";
        Console.WriteLine("\n------------------------------------------------------");
        break;
    case "çeşme":
        Console.WriteLine("\n------------------------------------------------------");
        Console.WriteLine("\nSeçtiğiniz Lokasyon: " + lokasyon.ToUpper());
        Console.WriteLine("\n------------------------------------------------------");
        Console.WriteLine("# Çeşme'de Tatilde Yapılacak Aktiviteler\r\n\r\n" +
         "1. Plajlar ve Denize Girmek**: Altınkum, Ilıca ve Pırlanta gibi ünlü plajlarda denize girip güneşlenin.\r\n" +
         "2. Rüzgar Sörfü ve Su Sporları**: Alaçatı ve Çiftlikköy bölgeleri rüzgar sörfü için idealdir.\r\n" +
         "3. Tarihi Yerleri Gezmek**: Çeşme Kalesi ve Erythrai Antik Kenti gibi tarihi yapıları keşfedin.\r\n" +
         "4. Alaçatı'yı Keşfetmek**: Taş evler, dar sokaklar, butik mağazalar ve kafelerde keyifli zaman geçirin.\r\n" +
         "5. Termal Kaplıcalar**: Çeşme’nin şifalı termal kaplıcalarında dinlenin.\r\n" +
         "6. Lezzet Durakları**: Ege mutfağının tadını çıkarabileceğiniz restoranlarda yemek yiyin.\r\n" +
         "7. Gece Hayatı**: Çeşme’nin beach clublarında ve gece kulüplerinde eğlenin.");
        lFiyat = 5000;
        lokasyon = "Çeşme";
        Console.WriteLine("\n------------------------------------------------------");

        break;
    default:
        {
            Console.WriteLine("\n------------------------------------------------------");
            Console.WriteLine("\nHatalı bir giriş yaptınız!");
            Console.WriteLine("\n------------------------------------------------------");
            goto Lokasyon;
        }

}
#endregion

#region KisiBilgisi
Kişi:
Console.Write("\nTatilinizi kaç kişi ile yapmak istiyorsunuz?: ");


int kisi;
if (!int.TryParse(Console.ReadLine(), out kisi))
{
    Console.WriteLine("\n------------------------------------------------------");
    Console.WriteLine("\nHatalı bir giriş yaptınız!");
    Console.WriteLine("\n------------------------------------------------------");
    goto Kişi;
}
else
{
    Console.WriteLine("\n------------------------------------------------------");
    Console.WriteLine("\nKişi sayınız: " + kisi);
    Console.WriteLine("\n------------------------------------------------------");
}
#endregion

#region Ulasim
Console.WriteLine("\nUlaşım için alternatifleriniz aşağıdadır:");
Console.WriteLine("\n1 - Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL )");
Console.WriteLine("2 - Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)");
Ulaşım:
Console.WriteLine("\n------------------------------------------------------");
Console.Write("\nTatile ne şekilde gitmek istersiniz?( 1 / 2 ):");

int vasita = 0;
int ulasim = 0;
string arac = " ";
if (!int.TryParse(Console.ReadLine(), out vasita))
{
    Console.WriteLine("\n------------------------------------------------------");
    Console.WriteLine("\nHatalı bir giriş yaptınız!");
}

switch (vasita)
{ 
        case 1:
            Console.WriteLine("\n------------------------------------------------------");
            Console.WriteLine("\nSeçiminiz: Kara Yolu");
            ulasim = 1500;
            arac = "Kara Yolu";
            break;
        case 2:
            Console.WriteLine("\n------------------------------------------------------");
            Console.WriteLine("\nSeçiminiz: Hava Yolu");
            ulasim = 4000;
            arac = "Hava Yolu";
        break;
        default:
            {
                Console.WriteLine("\n------------------------------------------------------");
                Console.WriteLine("\nHatalı bir giriş yaptınız!");
            goto Ulaşım;
            }
 }
#endregion

#region Bilgi
Console.WriteLine("\n------------------------------------------------------");
Console.WriteLine($"\n{lokasyon} lokasyonuna olan {kisi} kişilik {arac} ile ulaşımınızın toplam tutarı: " + ((lFiyat +  ulasim ) * kisi) + "TL'dir");
Console.WriteLine("\n------------------------------------------------------");
Console.WriteLine("\nBaşka bir tatil planlamak istiyorsanız lütfen 'Y' tuşuna basınız.Çıkış yapmak için farklı bir tuşa basabilirsiniz.");

char secim = Console.ReadKey().KeyChar;

switch (secim)
{
    case 'y':
        goto Başlangıç;
    default:
         Console.WriteLine("Bizi tercih ettiğiniz için teşekkür ederiz.");
        return;
}
#endregion