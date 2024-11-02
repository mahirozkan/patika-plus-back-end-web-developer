namespace week_5_bomb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Arabaları saklayacağımız bir liste oluşturuyoruz.
            List<Araba> arabalar = new List<Araba>();

            // Sonsuz döngü ile kullanıcıdan araba üretme isteği alıyoruz.
            while (true)
            {
                Console.WriteLine("\r\nAraba üretmek istiyor musunuz?(e/h): ");
                string cevap = Console.ReadLine().Trim().ToLower();

                if (cevap == "h") // Kullanıcı "h" cevabı verirse döngüden çıkıyoruz.
                {
                    break;
                }
                else if (cevap == "e") // Kullanıcı "e" cevabı verirse yeni bir araba oluşturuyoruz.
                {
                    Araba yeniAraba = new Araba(); // Yeni Araba nesnesi oluşturuluyor.

                    // Kullanıcıdan araba bilgilerini alıyoruz.
                    Console.Write("Seri Numarası: ");
                    yeniAraba.seriNo = Console.ReadLine();
                    Console.Write("Marka: ");
                    yeniAraba.marka = Console.ReadLine();
                    Console.Write("Model: ");
                    yeniAraba.model = Console.ReadLine();
                    Console.Write("Renk: ");
                    yeniAraba.renk = Console.ReadLine();
                KapıSayısı:
                    // Kullanıcıdan kapı sayısını alıyoruz ve geçerli bir giriş olup olmadığını kontrol ediyoruz.
                    Console.Write("Kapı Sayısı: ");
                    string kapiSayisiMi = Console.ReadLine();

                    if (int.TryParse(kapiSayisiMi, out int kapiSayisi)) // Kullanıcıdan alınan değeri int'e dönüştürmeye çalışıyoruz.
                    {
                        if (kapiSayisi == 2 || kapiSayisi == 4) // Kapı sayısı yalnızca 2 veya 4 olmalıdır.
                        {
                            yeniAraba.kapiSayisi = kapiSayisi; // Geçerli kapı sayısını atıyoruz.
                        }
                        else // Geçersiz kapı sayısı durumu.
                        {
                            Console.WriteLine("Geçersiz bir giriş yaptınız!\r\n");
                            goto KapıSayısı; // Kullanıcıdan tekrar kapı sayısını girmesini istiyoruz.
                        }
                    }
                    else // Geçersiz giriş durumu.
                    {
                        Console.WriteLine("Geçersiz bir giriş yaptınız!\r\n"); // Kullanıcıdan tekrar kapı sayısını girmesini istiyoruz.
                        goto KapıSayısı;
                    }
                    arabalar.Add(yeniAraba); // Yeni arabayı listeye ekliyoruz.
                }
                else // Geçersiz cevap durumu.
                {
                    Console.WriteLine("Geçersiz bir giriş yaptınız!\r\n");
                }
            }

            foreach (var araba in arabalar) // Tüm arabaların seri numarası ve markasını listelemek için döngü.
            {
                Console.WriteLine($"Seri Numarası: {araba.seriNo} Marka: {araba.marka}");
            }
        }
    }
}
