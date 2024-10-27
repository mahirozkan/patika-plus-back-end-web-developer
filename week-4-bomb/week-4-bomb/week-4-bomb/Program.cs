namespace week_4_bomb
{
    public class Program
    {
        static void Main(string[] args)
        {
        Secim1:
            Console.Write("Telefon üretmek için '1'e, Bilgisayar üretmek için '2'ye basınız.");
            int secim;
            while (!int.TryParse(Console.ReadLine(), out secim) || (secim != 1 && secim != 2))
            {
                Console.Write("Lütfen geçerli bir seçim yapın (1 veya 2): ");
            }

            switch (secim)
            {
                case 1:
                    {
                        Telefon telefon = new Telefon();
                        Console.Write("Seçiminiz Telefon.\r\n");
                        Console.Write("Tr Lisansı var mı?(evet/hayır):");
                        string _lisans = Console.ReadLine();
                        telefon.lisans = _lisans;
                        telefon.GetInfo();
                        break;
                    }
                case 2:
                    {
                        Bilgisayar bilgisayar = new Bilgisayar();
                        Console.Write("Seçiminiz Bilgisayar.\r\n");
                        Console.Write("USB girişi sayısı?(2/4): \r\n");
                        int _usbSayisi;
                        while (!int.TryParse(Console.ReadLine(), out _usbSayisi) || (_usbSayisi != 2 && _usbSayisi != 4))
                        {
                            Console.Write("Lütfen geçerli bir seçim yapın (2 veya 4): ");
                        }
                        bilgisayar.usbSayisi = _usbSayisi;
                        Console.Write("Bluetooth var mı?(var/yok): ");
                        string _bluetooth = Console.ReadLine();
                        bilgisayar.bluetooth = _bluetooth;
                        bilgisayar.GetInfo();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Hatalı bir seçim yaptınız!Tekrar seçiniz.");
                        goto Secim1;
                    }
            }

            Console.Write("Başka bir ürün üretmek istiyor musunuz?(evet/hayır): ");

            string secim2 = Console.ReadLine(); 

            switch (secim2)
            {
                case "evet":
                    Console.Clear();
                    goto Secim1;
                default:
                    Console.WriteLine("Çıkış yapılıyor.");
                    return; 
            }
            Console.ReadKey();
        }
    }

}
