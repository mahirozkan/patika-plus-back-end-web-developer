namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Proje yöneticisi örneği oluşturuluyor
            ProjeYoneticisi projeYoneticisi = new ProjeYoneticisi();
            projeYoneticisi.GetInfo();  // Çıktı: Proje yöneticisi olarak çalışıyorum.

            // Yazılım geliştirici örneği oluşturuluyor
            Calisan yazilimGelistirici = new YazilimGelistirici();
            yazilimGelistirici.GetInfo();  // Çıktı: Yazılım geliştirici olarak çalışıyorum.

            // Satış temsilcisi örneği oluşturuluyor
            Calisan satisTemsilcisi = new SatisTemsilcisi();
            satisTemsilcisi.GetInfo();  // Çıktı: Satış temsilcisi olarak çalışıyorum.

            Console.ReadLine();
        }
    }
}
