namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba araba = new Araba(); // Yeni bir Araba nesnesi oluşturuyoruz
            araba.marka = "Ford"; // Arabanın marka, model ve renk özelliklerine değerler atıyoruz
            araba.model = "Mustang";
            araba.renk = "Siyah";
            araba.KapiSayisi = 2; // Kapı sayısını 2 olarak atıyoruz (geçerli bir değer)

            araba.ArabaBilgisi(); // Araba bilgilerini ekrana yazdırıyoruz
            Console.ReadLine();
        }
    }
}
