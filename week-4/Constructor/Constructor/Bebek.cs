using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Constructor
{
    internal class Bebek
    {
        // Bebek sınıfı için isim, soyisim ve doğum tarihi alanlarını tanımlıyoruz
        public string _name;
        public string _surname;
        public DateTime _birthDate;

        // Varsayılan constructor (yapıcı metot)
        public Bebek() 
        {
            // Eğer bebek adı ya da soyadı verilmezse, "Bilinmiyor" olarak ayarlanıyor
            _birthDate = DateTime.Now; // Doğum tarihi şu anki zaman olarak ayarlanıyor
            _name = "Bilinmiyor";
            _surname = "Bilinmiyor";
        }

        // Parametreli constructor (isim ve soyisim verildiğinde çalışır)
        public Bebek(string name, string surname)
        {
            // Bebek ismi ve soyismi dışarıdan gelen parametrelerle ayarlanıyor
            _name = name;
            _surname = surname;
            _birthDate = DateTime.Now;
        }

        // Bebek doğumunu ekrana yazdıran metot
        public void BebekDogum()
        {
            Console.WriteLine($"{_name} {_surname} bebek, {_birthDate} tarihinde doğdu.");
            Console.WriteLine("Ingaaaa!!");
        }
    }
}
