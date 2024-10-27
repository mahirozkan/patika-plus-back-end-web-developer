using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class Calisan // 'Calisan' sınıfı, tüm çalışanlar için ortak özellikleri ve yöntemleri barındırır.
    {
        public string name;
        public string surname;
        public string department;

        public abstract void GetInfo(); // Alt sınıfların kendine özgü bilgilerini göstereceği soyut bir metod.
    }
    public class ProjeYoneticisi : Calisan // Proje yöneticisi sınıfı, 'Calisan' sınıfından türetiliyor.
    {
        public override void GetInfo()  // 'GetInfo' metodunu proje yöneticisine özel bir mesajla uyguluyor.
        {
            Console.WriteLine($"Ad: {name}\r\n" +
                $"Soyad: {surname}\r\n" +
                $"Departman: {department}\r\n" +
                $"Proje yöneticisi olarak çalışıyorum. ");
        }
    }
    public class YazilimGelistirici : Calisan // Yazılım geliştirici sınıfı, 'Calisan' sınıfından türetiliyor.
    {
        public override void GetInfo()
        {
            Console.WriteLine($"Ad: {name}\r\n" +
                $"Soyad: {surname}\r\n" +
                $"Departman: {department}\r\n" +
                $"Yazılım Geliştiricisi olarak çalışıyorum. ");
        }
    }
    public class SatisTemsilcisi : Calisan // Satış temsilcisi sınıfı, 'Calisan' sınıfından türetiliyor.
    {
        public override void GetInfo()
        {
            Console.WriteLine($"Ad: {name}\r\n" +
                $"Soyad: {surname}\r\n" +
                $"Departman: {department}\r\n" +
                $"Satış Temsilcisi olarak çalışıyorum. ");
        }
    }
}
