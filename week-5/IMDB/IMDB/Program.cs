using System.Diagnostics.Tracing;

namespace IMDB
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Film> Imdb = new List<Film>(); // Film listesini başlatıyoruz
        Soru:
            Console.Write("Film adını giriniz: ");
            string isim = Console.ReadLine();
            Console.Write("IMDB puanını giriniz: ");
            double puan;
            while (!double.TryParse(Console.ReadLine(), out puan) || puan < 0 || puan > 10) // IMDb puanını doğrulama döngüsü
            {
                Console.WriteLine("Hatalı bir giriş yaptınız!");
                Console.Write("IMDB puanını giriniz: ");
            }
            // Yeni film nesnesi oluşturup listeye ekliyoruz
            Film yeniFilm = new Film(isim, puan);
            Imdb.Add(yeniFilm);
            // Kullanıcıya yeni film eklemek isteyip istemediğini soruyoruz
            Console.Write("Yeni bir film eklemek ister misiniz?(evet/hayır): ");
            string secim = Console.ReadLine().ToLower();
            // Seçime göre yeniden başa dön veya bitir
            switch (secim)
            {
                case "evet":
                    goto Soru;
                case "hayır":
                    break;
                default:
                    Console.WriteLine("Hatalı giriş!");
                    break;
            }
            // Tüm filmleri listele
            Console.WriteLine("\nListedeki Filmler\n");
            foreach (var film in Imdb)
            {
                Console.WriteLine($"Film İsmi: {film._isim} Film Puanı: {film._puan}");
            }
            // IMDb puanı 4 ile 9 arasında olan filmleri listele
            Console.WriteLine("\nIMDb Puanı 4 ile 9 Arasında Olan Filmler\n");
            var filteredByImdb = Imdb.Where(f => f._puan >= 4 && f._puan <= 9).ToList();
            foreach (var film in filteredByImdb)
            {
                Console.WriteLine($"Film: {film._isim}, IMDb Puanı: {film._puan}");
            }
            // İsmi 'A' ile başlayan filmleri listele
            Console.WriteLine("\nİsmi 'A' ile Başlayan Filmler\n");
            var filteredByName = Imdb.Where(f => f._isim.StartsWith("A", StringComparison.OrdinalIgnoreCase)).ToList();
            foreach (var film in filteredByName)
            {
                Console.WriteLine($"Film: {film._isim}, IMDb Puanı: {film._puan}");
            }

            Console.ReadLine();
        }
    }
}
