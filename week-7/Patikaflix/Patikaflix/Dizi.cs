using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patikaflix 
{
    public class Dizi
    {
        // Dizi sınıfının özellikleri (properties)
        public string Ad {  get; set; } // Dizi adı
        public int YapimYili { get; set; } // Yapım yılı
        public string Tur {  get; set; } // Tür
        public int YayinYili { get; set; } // Yayın yılı
        public string Yonetmen { get; set; } // Yönetmen adı
        public string Platform { get; set; } // Yayınlandığı platform

        // Parametreli constructor(yapıcı metod), dizi nesnesini başlatmak için kullanılır
        // Bu metod, sınıfın özelliklerine değer atamak için kullanılır
        public Dizi(string ad, int yapimYili, string tur, int yayinYili, string yonetmen, string platform)
        {
            Ad = ad;
            YapimYili = yapimYili;
            Tur = tur;
            YayinYili = yayinYili;
            Yonetmen = yonetmen;
            Platform = platform;
        }
        public Dizi() { } // Varsayılan constructor, boş bir dizi nesnesi oluşturur
        // Bu metod, dizi nesnesi oluşturulurken parametrelerin verilmediği durumlar için kullanılır


        // ToString metodu, Dizi sınıfından türetilen nesnelerin bilgilerini
        // okunabilir bir formatta döndürür (yazdırılacak veriyi belirler)
        public override string ToString() // Dizi özelliklerini formatlı bir şekilde döndürerek ekrana yazdırılmasını sağlar
        {
            return $"Ad: {Ad, -15}  || Yapım Yılı: {YapimYili, -5}  || Tür: {Tur, -15}  || Yayın Yılı: {YayinYili,-5}  || Yönetmen: {Yonetmen, -25}  || Platform: {Platform}";
        }
    }
}
