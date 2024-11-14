using System;
using System.Collections.Generic;
using System.Linq;

namespace Patikaflix
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Dizi> diziler = new List<Dizi>() // Dizi nesnelerinin tutulacağı bir liste oluşturuluyor
            {
            // Listeye başlangıçta birkaç dizi ekleniyor
            new Dizi("Avrupa Yakası", 2004, "Komedi", 2024, "Yüksel Aksu", "Kanal D"),
            new Dizi("Yalan Dünya", 2012, "Komedi", 2012, "Gülseren Buda Başkaya", "Fox TV"),
            new Dizi("Jet Sosyete", 2018, "Komedi", 2018, "Gülseren Buda Başkaya", "TV8"),
            new Dizi("Dadı", 2006, "Komedi", 2006, "Yusuf Pirhasan", "Kanal D"),
            new Dizi("Belalı Baldız", 2007, "Komedi", 2007, "Yüksel Aksu", "Kanal D"),
            new Dizi("Arka Sokaklar", 2004, "Polisiye, Dram", 2004, "Orhan Oğuz", "Kanal D"),
            new Dizi("Aşk-ı Memnu", 2008, "Dram, Romantik", 2008, "Hilal Saral", "Kanal D"),
            new Dizi("Muhteşem Yüzyıl", 2011, "Tarihi, Dram", 2011, "Mercan Çilingiroğlu", "Star TV"),
            new Dizi("Yaprak Dökümü", 2006, "Dram", 2006, "Serdar Akar", "Kanal D")
            };

            Console.WriteLine("Sizin için listede bulunan filmler aşağıdadır;\r\n"); // Başlangıçta mevcut dizileri ekrana yazdırıyoruz

            foreach (Dizi d in diziler)
                Console.WriteLine(d.ToString());

            while (true)
            {
                Console.Write("\r\nYeni dizi eklemek istiyor musunuz?(e/h): "); // Kullanıcıdan yeni dizi eklemek isteyip istemediği soruluyor
                string cevap = Console.ReadLine().Trim().ToLower();

                if (cevap == "h") // Eğer kullanıcı "h" girerse döngü sonlanır
                {
                    break;
                }
                else if (cevap == "e") // Eğer kullanıcı "e" girerse yeni dizi eklenir
                {
                    Dizi yeniDizi = new Dizi(); // Yeni bir Dizi nesnesi oluşturuluyo

                    #region DiziAdı
                    Console.Write("Dizinin Adı: "); // Kullanıcıdan dizinin adı alınır
                    yeniDizi.Ad = Console.ReadLine();
                    #endregion
                    #region YapımYılı
                    // Yapım yılı için geçerli bir değer girilene kadar tekrar soruluyor
                    bool yilMi1 = false;
                    while (!yilMi1)
                    {
                        Console.Write("Yapım Yılı: ");
                        string gecerliYil = Console.ReadLine();

                        if (int.TryParse(gecerliYil, out int yapimYili)) // Geçerli bir yıl olup olmadığı kontrol edilir
                        {
                            yilMi1 = true;
                            yeniDizi.YapimYili = yapimYili;
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz bir giriş yaptınız!\r\n");
                        }
                    }
                    #endregion
                    #region Tür
                    Console.Write("Tür: ");
                    yeniDizi.Tur = Console.ReadLine(); // Kullanıcıdan dizinin türü alınır
                    #endregion
                    #region YayınYılı
                    // Yayın yılı için geçerli bir yıl girilene kadar tekrar soruluyor
                    bool yilMi2 = false;
                    while (!yilMi2)
                    {
                        Console.Write("Yayın Yılı: ");
                        string gecerliYil2 = Console.ReadLine();

                        if (int.TryParse(gecerliYil2, out int yayinYili)) // Geçerli bir yayın yılı olup olmadığı kontrol edilir
                        {
                            yilMi2 = true;
                            yeniDizi.YayinYili = yayinYili;
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz bir giriş yaptınız!\r\n");
                        }
                    }
                    #endregion
                    #region Yönetmenler
                    Console.Write("Yönetmenler: ");
                    yeniDizi.Yonetmen = Console.ReadLine(); // Kullanıcıdan dizinin yönetmeni alınır
                    #endregion
                    #region Platform
                    Console.Write("Yayınlandığı İlk Platform: ");
                    yeniDizi.Platform = Console.ReadLine(); // Kullanıcıdan dizinin yayınlandığı platform alınır
                    #endregion
                    diziler.Add(yeniDizi); // Yeni eklenen dizi listeye dahil edilir
                }
            }
                #region Soru
                List<KomediDizi> komediDiziler = diziler // Komedi türündeki diziler filtrelenir, sıralanır ve ekrana yazdırılır
                .Where(d => d.Tur.Contains("Komedi"))  // Türü "Komedi" olan diziler seçilir
                .Select(d => new KomediDizi(d.Ad, d.Tur, d.Yonetmen)) // Yeni bir KomediDizi nesnesi oluşturulur
                .OrderBy(d => d.Ad) // Diziler adıyla sıralanır
                .ThenBy(d => d.Yonetmen) // Yönetmene göre sıralanır
                .ToList();

                // Komedi dizilerinin bilgileri ekrana yazdırılır
                Console.WriteLine("Komedi Dizileri:");
                foreach (KomediDizi komedi in komediDiziler)
                {
                    Console.WriteLine(komedi.ToString());
                }
                #endregion
            
        }
    }
}