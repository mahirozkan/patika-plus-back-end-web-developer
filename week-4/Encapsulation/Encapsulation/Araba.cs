using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Araba
    {
        public string marka {  get; set; } // Arabanın markasını tutacak özellik
        public string model { get; set; } // Arabanın modelini tutacak özellik
        public string renk { get; set; } // Arabanın rengini tutacak özellik
        private int kapiSayisi; // Kapı sayısı yalnızca sınıf içinde erişilebilir, doğrudan atanamıyor

        public int KapiSayisi // Kapı sayısına dışarıdan erişimi sağlayan özellik
        {
            get { return kapiSayisi; }
            set
            {
                if (value == 2 || value == 4)  // Kapı sayısı 2 veya 4 olduğunda geçerli bir değer olarak kabul ediyoruz
                {
                    kapiSayisi = value;
                }
                else
                {
                    Console.WriteLine("Yanlış bir kapı sayısı girdiniz!"); // Geçersiz bir değer girildiğinde uyarı verip varsayılan bir değer atıyoruz
                    kapiSayisi = -1;
                }
                
            }
        }

        public void ArabaBilgisi() // Arabanın bilgilerini ekrana yazdıran metod
        {
            Console.WriteLine($"Marka: {marka}\r\n" +
                $"Model: {model}\r\n" +
                $"Renk: {renk}\r\n" +
                $"Kapı Sayısı: {kapiSayisi}");
        }
    }
}

