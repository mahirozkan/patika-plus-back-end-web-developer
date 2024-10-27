using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public abstract class BaseGeometrikSekil // Tüm geometrik şekiller için temel soyut sınıf
    {
        public virtual string Ad { get { return "Şekil"; } } // Şeklin adı (varsayılan olarak "Şekil")

        // Şeklin genişlik ve yükseklik özellikleri
        public int Genislik { get; set; }
        public int Yukseklik { get; set; }
        public abstract double Alan(); // Alan hesaplama metodu - her türetilmiş sınıf kendine göre tanımlayacak
        public override string ToString() // Şekli ve boyutlarını döndüren metin temsilini sağlar
        {
            return $"{Ad} ({Genislik}x{Yukseklik})";
        }
    }
    public class Kare : BaseGeometrikSekil // Kare sınıfı - BaseGeometrikSekil'den türetilmiştir
    {
        public override string Ad => "Kare"; // Ad özelliği, "Kare" olarak değiştirildi
        public override double Alan() // Alanı hesaplayan metod, genişlik ve yüksekliğin çarpımı olarak tanımlandı
        {
            return Genislik * Yukseklik;
        }
    }
    public class Dikdortgen : BaseGeometrikSekil // Dikdörtgen sınıfı - BaseGeometrikSekil'den türetilmiştir
    {
        public override string Ad => "Dikdortgen"; // Ad özelliği, "Dikdörtgen" olarak değiştirildi
        public override double Alan() // Alanı hesaplayan metod, genişlik ve yüksekliğin çarpımı olarak tanımlandı
        {
            return Genislik * Yukseklik;
        }
    }
    public class DikUcgen : BaseGeometrikSekil // Dik Üçgen sınıfı - BaseGeometrikSekil'den türetilmiştir
    {
        public override string Ad => "DikUcgen"; // Ad özelliği, "Dik Üçgen" olarak değiştirildi
        public override double Alan()  // Alanı hesaplayan metod, genişlik ve yüksekliğin çarpımının yarısı olarak tanımlandı
        {
            return (Genislik * Yukseklik) / 2;
        }
    }
}
