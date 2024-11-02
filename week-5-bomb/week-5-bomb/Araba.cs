using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_5_bomb
{
    public class Araba // Araba sınıfı, otomobillerin özelliklerini temsil eder.
    {
        public DateTime uretimTarihi { get; private set; } // Üretim tarihi özelliği, dışarıdan erişim engellenmiş (private set).

        // Seri numarası, marka, model ve renk özellikleri, dışarıdan erişilebilir.
        public string seriNo { get; set; }
        public string marka { get; set; }
        public string model { get; set; }
        public string renk { get; set; }

        public int kapiSayisi { get; set; }

        // Yapıcı metod, Araba nesnesi oluşturulurken üretim tarihini ayarlar.
        public Araba()
        {
            uretimTarihi = DateTime.Now; // Üretim tarihi, nesne oluşturulduğu anki tarih olarak ayarlanır.
        }
    }
}


