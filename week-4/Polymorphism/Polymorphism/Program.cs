namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kare, Dikdörtgen ve Dik Üçgen nesneleri oluşturuluyor
            BaseGeometrikSekil sekil1 = new Kare() { Genislik = 10, Yukseklik = 10 };
            BaseGeometrikSekil sekil2 = new Dikdortgen() { Genislik = 10, Yukseklik = 20 };
            BaseGeometrikSekil sekil3 = new DikUcgen() { Genislik = 10, Yukseklik = 10 };

            // Her bir şeklin ToString metodu çağırılarak şekil bilgileri yazdırılıyor
            Console.WriteLine(sekil1);
            Console.WriteLine($"Alanı: {sekil1.Alan()}");
            Console.WriteLine(sekil2);
            Console.WriteLine($"Alanı: {sekil2.Alan()}");
            Console.WriteLine(sekil3);
            Console.WriteLine($"Alanı: {sekil3.Alan()}");

            Console.ReadLine();
        }
    }
}
