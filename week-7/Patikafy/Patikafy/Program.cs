namespace Patikafy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Patikafy> patikafy = new List<Patikafy>() // Patikafy sınıfından oluşan bir liste oluşturuluyor ve bazı sanatçı bilgileri ekleniyor.
            {
                new Patikafy("Ajda Pekkan", "Pop", 1968, 20),
                new Patikafy("Sezen Aksu", "Türk Halk Müziği / Pop", 1971, 10),
                new Patikafy("Funda Arar", "Pop", 1999, 3),
                new Patikafy("Sertab Erener", "Pop", 1994, 5),
                new Patikafy("Sıla", "Pop", 2009, 3),
                new Patikafy("Serdar Ortaç", "Pop", 1994, 10),
                new Patikafy("Tarkan", "Pop", 1992, 40),
                new Patikafy("Hande Yener", "Pop", 1999, 7),
                new Patikafy("Hadise", "Pop", 2005, 5),
                new Patikafy("Gülben Ergen", "Pop / Türk Halk Müziği", 1997, 10),
                new Patikafy("Neşet Ertaş", "Türk Halk Müziği / Türk Sanat Müziği", 1960, 2)
            };
            #region Soru1 
            Console.WriteLine("*** ADI 'S' İLE BAŞLAYAN ŞARKICILAR ***\r\n"); 
            var sIleBaslayan = patikafy.Where(ad => ad._sarkici.StartsWith("S")); // 'S' harfi ile başlayan şarkıcılar filtreleniyor
            foreach (var ad in sIleBaslayan)
            {
                Console.WriteLine(ad);
            }
            #endregion

            #region Soru2
            Console.WriteLine("\r\n*** ALBÜM SATIŞLARI 10 MİLYONUN ÜZERİNDE OLAN ŞARKICILAR ***\r\n");
            var onMilUzeri = patikafy.Where(adet => adet._satis > 10); // Albüm satışları 10 milyonun üzerinde olan şarkıcılar filtreleniyor
            foreach (var adet in onMilUzeri)
            {
                Console.WriteLine(adet);
            }
            #endregion

            #region Soru3
            Console.WriteLine("\r\n*** 2000 ÖNCESİ ÇIKIŞ YAPMIŞ POP MÜZİK SANATÇILARI ***\r\n");
            var ikiBinÖncesi = patikafy.Where(sene => sene._yil < 2000 && sene._tur == "Pop"); // 2000 yılı öncesi çıkış yapan pop müzik sanatçıları filtreleniyor
            foreach (var sene in ikiBinÖncesi)
            {
                Console.WriteLine(sene);
            }
            #endregion

            #region Soru4
            Console.WriteLine("\r\n*** EN ÇOK ALBÜM SATAN SANATÇI ***\r\n");
            var enCokSatis = patikafy.OrderByDescending(satilan => satilan._satis).First(); // En çok albüm satan sanatçı sıralanıp yazdırılıyor
            Console.WriteLine(enCokSatis);
            #endregion

            #region Soru5
            Console.WriteLine("\r\n*** EN YENİ ÇIKIŞ YAPAN SANATÇI ***\r\n");
            var enYeni = patikafy.OrderByDescending(cikis => cikis._yil).First(); // En yeni çıkış yapan sanatçı sıralanıp yazdırılıyor
            Console.WriteLine(enYeni);
            Console.WriteLine("\r\n*** EN ESKİ ÇIKIŞ YAPAN SANATÇI ***\r\n"); // En eski çıkış yapan sanatçı sıralanıp yazdırılıyor
            var enEski = patikafy.OrderByDescending(cikis => cikis._yil).Last();
            Console.WriteLine(enEski);
            #endregion


        }
    }
}
