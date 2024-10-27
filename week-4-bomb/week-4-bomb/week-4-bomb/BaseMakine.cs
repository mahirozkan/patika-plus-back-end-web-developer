using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_4_bomb
{
    public abstract class BaseMakine // BaseMakine sınıfı, Telefon ve Bilgisayar ürünlerinde ortak özellikleri barındırır
    {
        public DateTime uretimTarihi => DateTime.Now; // Makinenin üretim tarihini şimdiye ayarlıyoruz
        public int seriNo;
        public string ad;
        public string aciklama;
        public string isletimSistemi;

        public virtual void GetInfo() // Bilgileri ekrana yazdıran sanal (override edilebilir) metot
        {
            Console.WriteLine($"Üretim Tarihi: {uretimTarihi}\r\n" +
                $"Seri Numarası: {seriNo}\r\n" +
                $"Ad: {ad}\r\n" +
                $"Açıklama: {aciklama}\r\n" +
                $"İşletim Sistemi: {isletimSistemi}");
        }
    }

    public class Telefon : BaseMakine // Telefon sınıfı, BaseMakine'den türetilmiştir
    {
        private string _lisans; // Telefonun lisans bilgisi, sadece "evet" veya "hayır" kabul edecek şekilde ayarlanmıştır
        public string lisans
        {
            get => _lisans;
            set
            {
                if (value == "evet" || value == "hayır")
                {
                    _lisans = value;
                }
                else
                {
                    Console.WriteLine("Hatalı bir giriş yaptınız!");
                    _lisans = "Lisans yok"; // Geçersiz girişte varsayılan değer
                }
            }
        }
        public override void GetInfo() // Telefon bilgilerini ekrana yazdıran metot, base sınıfın GetInfo() metodunu genişletir
        {
            base.GetInfo(); // Temel bilgileri yazdır
            Console.WriteLine($"Tr Lisans: {_lisans}"); // Lisans bilgisi
            Console.WriteLine($"Telefon başarıyla üretildi.");
        }
    }

    public class Bilgisayar : BaseMakine  // Bilgisayar sınıfı, BaseMakine'den türetilmiştir
    {
        private int _usbSayisi; // USB giriş sayısı, sadece 2 veya 4 olarak ayarlanabilir
        public int usbSayisi
        {
            get => _usbSayisi;
            set
            {
                if (value == 2 || value == 4)
                {
                    _usbSayisi = value;
                }
                else
                {
                    Console.WriteLine("Hatalı seçim yaptınız!");
                    _usbSayisi = -1; // Geçersiz girişte varsayılan değer
                }
            }
        }
        private string _bluetooth; // Bluetooth özelliği, sadece "var" veya "yok" olarak ayarlanabilir
        public string bluetooth
        {
            get => _bluetooth;
            set
            {
                if (value == "var" || value== "yok")
                {
                    _bluetooth = $"Bluetooth {value}";
                }
                else
                {
                    Console.WriteLine("Hatalı bir giriş yaptınız!");
                    _bluetooth = "Bluetooth yok"; // Geçersiz girişte varsayılan değer
                }
            }
        }
        public override void GetInfo() // Bilgisayar bilgilerini ekrana yazdıran metot, base sınıfın GetInfo() metodunu genişletir
        {
            base.GetInfo(); // Temel bilgileri yazdır
            Console.WriteLine($"USB Girişi Sayısı: {_usbSayisi}"); // USB girişi sayısı
            Console.WriteLine($"Bluetooth: {_bluetooth}"); // Bluetooth bilgisi
            Console.WriteLine("Bilgisayar başarıyla üretildi.");
        }

    }
}
