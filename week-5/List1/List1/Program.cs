namespace List1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> ziyaretci = new List<string>(); // 'ziyaretci' isimli bir string listesi oluşturuyoruz

            ziyaretci.Add("Bülent Ersoy"); // Listeye ziyaretçi isimlerini ekliyoruz
            ziyaretci.Add("Ajda Pekkan");
            ziyaretci.Add("Ebru Gündeş");
            ziyaretci.Add("Hadise");
            ziyaretci.Add("Hande Yener");
            ziyaretci.Add("Tarkan");
            ziyaretci.Add("Funda Arar");
            ziyaretci.Add("Demet Akalın");

            int i = 1; // Sayacımızı başlatıyoruz, böylece her isim sırasıyla numaralandırılacak
            foreach (string item in ziyaretci) // foreach döngüsü ile her bir ismi ve sırasını ekrana yazdırıyoruz
            {
                Console.WriteLine($"{i} - {item}");
                i++; // Her adımda sayacı bir artırıyoruz
            }
            
            Console.ReadLine();
        }
    }
}
