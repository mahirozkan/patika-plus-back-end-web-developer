using System;

namespace IOExample
{
    class VariablesApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lutfen asagidaki bilgileri giriniz:");

            Console.Write("T.C. Kimlik Numarasi:");

            string tcNo = Console.ReadLine();

            Console.Write("Adi:");

            string name = Console.ReadLine();

            Console.Write("Soyadi:");

            string surName = Console.ReadLine();

            Console.Write("Telefon Numarasi:");

            string number = Console.ReadLine(); // Telefon numarası ile herhangi bir sayısal işlem yapmayacağım için string olarak tuttum

            Console.Write("Yas:");

            string age = Console.ReadLine();

            Console.WriteLine("Ilk Aldıgı Urunun Fiyati:");

            string a = Console.ReadLine(); // Fiyat verilerini string veri tipinde aldım sonrasında bu verileri sayısal işlemlerde kullanacağım için Try.Parse ile int veri tipine çevirdim

            int.TryParse(a, out int num1);

            Console.WriteLine("Ikinci Aldigi Urunun Fiyati:");

            string b = Console.ReadLine();

            int.TryParse(b, out int num2);

            Console.WriteLine("-------------------------------------");

            Console.WriteLine($"{tcNo} T.C. Kimlik Numarali {name} {surName} isimli kisi icin kayit olusturulmustur.");
            Console.WriteLine($"{number} telefon numarasina bildirim mesaji gönderilmistir.");
            Console.WriteLine($"{num1 + num2} toplam harcama karsiligi kazanilan %10 patika puan miktari - > {((num1 + num2) / 100 * 10)} TL'dir.");


        }
    }
}