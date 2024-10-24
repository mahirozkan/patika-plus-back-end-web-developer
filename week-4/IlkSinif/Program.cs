namespace IlkSinif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person ogrenci1 = new Person();  // Yeni bir öğrenci nesnesi oluşturuyoruz ve öğrencinin bilgilerini giriyoruz
            ogrenci1.Name = "Mahir";
            ogrenci1.SurName = "Özkan";
            ogrenci1.BirthDate = new DateOnly(1998,07,05);
            ogrenci1.Role = "öğrenci";

            Person ogrenci2 = new Person();  // İkinci öğrenci nesnesi
            ogrenci2.Name = "Selim";
            ogrenci2.SurName = "Yılmaz";
            ogrenci2.BirthDate = new DateOnly(1992, 09, 22);
            ogrenci2.Role = "öğrenci";

            Person ogrenci3 = new Person();  // Üçüncü öğrenci nesnesi
            ogrenci3.Name = "Ayşe";
            ogrenci3.SurName = "Çelik";
            ogrenci3.BirthDate = new DateOnly(1995, 04, 18);
            ogrenci3.Role = "öğrenci";

            Person ogrenci4 = new Person();  // Dördüncü öğrenci nesnesi
            ogrenci4.Name = "Derya";
            ogrenci4.SurName = "Aydın";
            ogrenci4.BirthDate = new DateOnly(1997, 02, 12);
            ogrenci4.Role = "öğrenci";

            Person ogretmen1 = new Person();   // Yeni bir öğretmen nesnesi oluşturuyoruz ve öğretmenin bilgilerini giriyoruz
            ogretmen1.Name = "Zeynep";
            ogretmen1.SurName = "Şahin";
            ogretmen1.BirthDate = new DateOnly(1987, 08, 30);
            ogretmen1.Role = "öğretmen";

            Person ogretmen2 = new Person();  // İkinci öğretmen nesnesi
            ogretmen2.Name = "Emre";
            ogretmen2.SurName = "Kılıç";
            ogretmen2.BirthDate = new DateOnly(1988, 01, 14);
            ogretmen2.Role = "öğretmen";

            // Tüm öğrencilerin ve öğretmenlerin detaylarını ekrana yazdırıyoruz
            ogrenci1.GetDetails();
            ogrenci2.GetDetails();
            ogrenci3.GetDetails();
            ogrenci4.GetDetails();
            ogretmen1.GetDetails();
            ogretmen2.GetDetails();

            Console.ReadKey();
        }
    }
}
