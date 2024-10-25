namespace PatikaKutuphane
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Kitap kitap1 = new Kitap(); // new anahtar kelimesi ile Kitap sınıfından bir nesne oluşturuyoruz (kitap1), parametresiz constructor kullanılır
            kitap1._kitapAdi = "Bir Kitap"; 
            kitap1._yazarAdi = "Ahmet";
            kitap1._yazarSoyadi = "Yılmaz";
            kitap1._sayfaSayisi = 320;
            kitap1._yayinevi= "Alfa Yayınları";
            kitap1._kayitTarihi=new DateOnly(2023,05,14);

        Kitap kitap2 = new Kitap();
            kitap2._kitapAdi = "Başka Bir Kitap";
            kitap2._yazarAdi = "Ayşe";
            kitap2._yazarSoyadi = "Karan";
            kitap2._sayfaSayisi = 215;
            kitap2._yayinevi = "Beta Yayıncılık";
            kitap2._kayitTarihi = new DateOnly(2023, 06, 20);

        Kitap kitap3 = new Kitap();
            kitap3._kitapAdi = "Daha Başka Kitap";
            kitap3._yazarAdi = "Mehmet";
            kitap3._yazarSoyadi = "Demir";
            kitap3._sayfaSayisi = 450;
            kitap3._yayinevi = "Gamma Yayınları";
            kitap3._kayitTarihi = new DateOnly(2023, 07, 01);

        Kitap kitap4 = new Kitap("Son Kitap", "Elif", "Şahin", 275, "Delta Yayıncılık"); // new anahtar kelimesi ile Kitap sınıfından parametreli bir nesne oluşturuyoruz (kitap4)
            Kitap kitap5 = new Kitap("Örnek Kitap", "Selin", "Yurt", 198, "Epsilon Yayınları");

            kitap1.KitapBilgileri();
            kitap2.KitapBilgileri();
            kitap3.KitapBilgileri();
            kitap4.KitapBilgileri();
            kitap5.KitapBilgileri();
            Console.ReadLine();
        }
    }
}
