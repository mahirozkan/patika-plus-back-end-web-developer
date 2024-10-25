using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaKutuphane
{
    internal class Kitap  // Kitap sınıfı (Class): Kitap özelliklerini ve davranışlarını tanımlar
    {
        // Özellikler (Properties): Kitabın özelliklerini tutan alanlar
        public string _kitapAdi;
        public string _yazarAdi;
        public string _yazarSoyadi;
        public int _sayfaSayisi;
        public string _yayinevi;
        public DateOnly _kayitTarihi;

        // Parametresiz Constructor: Nesne oluşturulurken varsayılan değerler atar
        public Kitap()
        {
            _kitapAdi = "Bilinmiyor";
            _yazarAdi = "Bilinmiyor";
            _yazarSoyadi = "Bilinmiyor";
            _sayfaSayisi = 0;
            _yayinevi = "Bilinmiyor";
            _kayitTarihi = DateOnly.FromDateTime(DateTime.Now);
        }

        // Parametre alan Constructor: Kitap bilgilerini parametre olarak alır ve özelliklere atar
        public Kitap(string kitapAdi, string yazarAdi, string yazarSoyadi, int sayfaSayisi, string yayinevi)
        {
            _kitapAdi = kitapAdi;
            _yazarAdi = yazarAdi;
            _yazarSoyadi = yazarSoyadi;
            _sayfaSayisi = sayfaSayisi;
            _yayinevi = yayinevi;
            _kayitTarihi= DateOnly.FromDateTime(DateTime.Now);
        }

        // Kitap bilgilerini yazdıran metot
        public void KitapBilgileri()
        {
            Console.WriteLine($"Kitap Adı: {_kitapAdi}\r\n" +
                $"Yazar: {_yazarAdi} {_yazarSoyadi}\r\n" +
                $"Sayfa Sayısı: {_sayfaSayisi}\r\n" +
                $"Yayınevi: {_yayinevi}\r\n" +
                $"Kayıt Tarihi: {_kayitTarihi.ToString("yyyy-MM-dd")}\r\n");
        }
    }
}
