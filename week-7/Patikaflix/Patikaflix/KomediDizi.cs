using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patikaflix
{
    public class KomediDizi // Komedi dizisinin özellikleri (properties)
    {
        public string Ad { get; set; } // Dizi adı
        public string Tur { get; set; } // Dizi türü
        public string Yonetmen { get; set; } // Dizi yönetmeni

        // Parametreli constructor (yapıcı metod), komedi dizisinin özelliklerini başlatmak için kullanılır
        // Bu metod, ad, tür ve yönetmen bilgilerini alarak yeni bir nesne oluşturur
        public KomediDizi(string ad, string tur,string yonetmen)
        {
            Ad = ad;
            Tur = tur;
            Yonetmen = yonetmen;
        }

        // Varsayılan constructor, boş bir komedi dizisi nesnesi oluşturur
        // Bu metod, parametreler verilmeden de nesne oluşturulabilmesini sağlar
        public KomediDizi() { }


        // ToString metodu, KomediDizi sınıfından türetilen nesnelerin bilgilerini
        // okunabilir bir formatta döndür
        public override string ToString() // Komedi dizisinin bilgilerini formatlı bir şekilde döndürür
        {
            return $"Ad: {Ad,-15}  || Tür: {Tur,-10}  || Yönetmen: {Yonetmen}";
        }
    }
}
