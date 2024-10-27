using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_4_bomb
{
    public abstract class BaseMakine
    {
        public DateTime uretimTarihi => DateTime.Now;
        public int seriNo;
        public string ad;
        public string aciklama;
        public string isletimSistemi;

        public virtual void GetInfo()
        {
            Console.WriteLine($"Üretim Tarihi: {uretimTarihi}\r\n" +
                $"Seri Numarası: {seriNo}\r\n" +
                $"Ad: {ad}\r\n" +
                $"Açıklama: {aciklama}\r\n" +
                $"İşletim Sistemi: {isletimSistemi}");
        }
    }

    public class Telefon : BaseMakine
    {
        private string _lisans;
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
                    _lisans = "Lisans yok";
                }
            }
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Tr Lisans: {_lisans}");
            Console.WriteLine($"Telefon başarıyla üretildi.");
        }
    }

    public class Bilgisayar : BaseMakine
    {
        private int _usbSayisi;
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
                    _usbSayisi = -1;
                }
            }
        }
        private string _bluetooth;
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
                    _bluetooth = "Bluetooth yok";
                }
            }
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"USB Girişi Sayısı: {_usbSayisi}");
            Console.WriteLine($"Bluetooth: {_bluetooth}");
            Console.WriteLine("Bilgisayar başarıyla üretildi.");
        }

    }
}
