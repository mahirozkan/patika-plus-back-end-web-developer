using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patikafy
{
    public class Patikafy
    {
        public string _sarkici { get; set; } // Şarkıcı adı
        public string _tur { get; set; } // Müzik türü
        public int _yil { get; set; } // Çıkış yılı
        public int _satis { get; set; } // Satış miktarı (milyon olarak)

        public Patikafy(string sarkici, string tur, int yil, int satis) // Parametreli constructor: şarkıcı, tür, yıl ve satış bilgilerini alır
        {
            _sarkici = sarkici;
            _tur = tur;
            _yil = yil;
            _satis = satis;
        }
        public override string ToString() // ToString metodu: objeyi string formatında döndürür
        {
            return $"Şarkıcı: {_sarkici, -15} || Tür: {_tur, -25} || Yıl: {_yil, -8} || Satış: Yaklaşık {_satis} milyon"; // Formatlanmış string döndürülür
        }
    }
}
