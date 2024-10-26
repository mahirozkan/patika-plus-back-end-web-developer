using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Base // Base sınıf; tüm bireylerde ortak olacak özellikleri barındırır
    {
        // Her birey için isim ve soyisim özellikleri
        public string ad { get; set; }
        public string soyad { get; set; }
        public void Info() // Bireyin temel bilgilerini ekrana yazdıran metot
        {
            Console.WriteLine($"Ad: {ad}\r\n" +
                $"Soyad: {soyad}");
        }
    }
    public class Ogrenci : Base // Öğrenci sınıfı, Base sınıfından miras alır
    {
        public int ogrenciNumarasi { get; set; } // Öğrenciye özel öğrenci numarası özelliği

        public void OgrenciInfo()  // Öğrencinin tüm bilgilerini ekrana yazdıran metot
        {
            Console.WriteLine($"Ad: {ad}\r\n" +
            $"Soyad: {soyad}\r\n" +
            $"Öğrenci Numarası: {ogrenciNumarasi}");
        }
    }
    public class Ogretmen : Base // Öğretmen sınıfı, Base sınıfından miras alır
    {
        public int maas { get; set; } // Öğretmene özel maaş özelliği

        public void OgretmenInfo() // Öğretmenin tüm bilgilerini ekrana yazdıran metot
        {
            Console.WriteLine($"Ad: {ad}\r\n" +
            $"Soyad: {soyad}\r\n" +
            $"Maaş: {maas} TL");
        }
    }
}

