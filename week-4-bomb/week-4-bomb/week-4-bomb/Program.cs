namespace week_4_bomb
{
    public class Program
    {
        static void Main(string[] args)
        {
        Secim1: // Kullanıcıdan ürün seçimi yapılmasını isteyeceğimiz yere döneceğimiz etiket
            Console.Write("Telefon üretmek için '1'e, Bilgisayar üretmek için '2'ye basınız.");
            int secim;
            while (!int.TryParse(Console.ReadLine(), out secim) || (secim != 1 && secim != 2)) // Kullanıcıdan geçerli bir seçim alana kadar döngüye giriyoruz
            {
                Console.Write("Lütfen geçerli bir seçim yapın (1 veya 2): ");
            }

            switch (secim) // Kullanıcının yaptığı seçime göre işlem yapıyoruz
            {
                case 1: // Kullanıcı telefon seçmişse Telefon nesnesi oluşturuyoruz
                    {
                        Telefon telefon = new Telefon();
                        Console.Write("Seçiminiz Telefon.\r\n");
                        Console.Write("Tr Lisansı var mı?(evet/hayır):"); // Kullanıcıdan lisans bilgisi alıyoruz
                        string _lisans = Console.ReadLine();
                        telefon.lisans = _lisans;
                        telefon.GetInfo(); // Telefon bilgilerini ekrana yazdırıyoruz
                        break;
                    }
                case 2:  // Kullanıcı bilgisayar seçmişse Bilgisayar nesnesi oluşturuyoruz
                    {
                        Bilgisayar bilgisayar = new Bilgisayar();
                        Console.Write("Seçiminiz Bilgisayar.\r\n");
                        Console.Write("USB girişi sayısı?(2/4): \r\n"); // Kullanıcıdan USB girişi sayısını alıyoruz ve geçerli olup olmadığını kontrol ediyoruz
                        int _usbSayisi;
                        while (!int.TryParse(Console.ReadLine(), out _usbSayisi) || (_usbSayisi != 2 && _usbSayisi != 4))
                        {
                            Console.Write("Lütfen geçerli bir seçim yapın (2 veya 4): ");
                        }
                        bilgisayar.usbSayisi = _usbSayisi;
                        Console.Write("Bluetooth var mı?(var/yok): "); // Bluetooth özelliği olup olmadığını kullanıcıdan alıyoruz
                        string _bluetooth = Console.ReadLine();
                        bilgisayar.bluetooth = _bluetooth;
                        bilgisayar.GetInfo(); // Bilgisayar bilgilerini ekrana yazdırıyoruz
                        break;
                    }
                default: // Hatalı seçim durumunda kullanıcıyı bilgilendiriyoruz ve tekrar seçim yaptırıyoruz
                    {
                        Console.WriteLine("Hatalı bir seçim yaptınız!Tekrar seçiniz.");
                        goto Secim1;
                    }
            }

            Console.Write("Başka bir ürün üretmek istiyor musunuz?(evet/hayır): ");  // Kullanıcıya başka bir ürün üretmek isteyip istemediğini soruyoruz

            string secim2 = Console.ReadLine();

            switch (secim2)
            {
                case "evet": // Eğer kullanıcı "evet" derse ekranı temizleyip tekrar seçim yapmasını sağlıyoruz
                    Console.Clear();
                    goto Secim1;
                default: // Kullanıcı "hayır" derse programı sonlandırıyoruz
                    Console.WriteLine("Çıkış yapılıyor."); 
                    return;
            }
        }
    }

}
