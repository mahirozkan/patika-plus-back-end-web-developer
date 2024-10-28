namespace List2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> kahve = new List<string>();  // Kahve isimlerini saklamak için bir liste oluşturuluyor
            for (int i = 1; i < 6; i++) // Kullanıcıdan 5 kahve ismi alınacak
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"Kahve {i}: "); // Kullanıcıdan kahve adı istenirken 'Kahve {i}: ' ifadesi kırmızı renkte yazılıyor
                Console.ForegroundColor = ConsoleColor.Green; // Kullanıcının girdiği kahve ismi yeşil renkte görüntüleniyor
                kahve.Add(Console.ReadLine()); // Kullanıcının girdiği kahve adı listeye ekleniyor
            }
            Console.ForegroundColor = ConsoleColor.White; // Renk varsayılana döndürülüyor ve başlık yazdırılıyor
            Console.WriteLine("\r\nGirilen Kahve İsimleri\r\n");
            foreach (string item in kahve) // Tüm kahve isimleri listeden okunarak ekrana yazdırılıyor
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
