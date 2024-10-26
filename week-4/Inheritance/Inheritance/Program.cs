using System.Security.Cryptography.X509Certificates;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Yeni bir öğrenci nesnesi oluşturuyoruz ve özelliklerini atıyoruz
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.ad = "Mahir";
            ogrenci.soyad = "Özkan";
            ogrenci.ogrenciNumarasi = 1171601020;

            // Yeni bir öğretmen nesnesi oluşturuyoruz ve özelliklerini atıyoruz
            Ogretmen ogretmen = new Ogretmen();
            ogretmen.ad = "Mesut";
            ogretmen.soyad = "Mike";
            ogretmen.maas = 45000;

            ogrenci.OgrenciInfo(); // Öğrencinin bilgilerini ekrana yazdırıyoruz
            ogretmen.OgretmenInfo(); // Öğretmenin bilgilerini ekrana yazdırıyoruz

            Console.ReadLine();
        }
    }
}
