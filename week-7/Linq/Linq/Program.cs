namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>(); // Rastgele sayıların saklanacağı listeyi oluşturuyoruz
            Random random = new Random();
            for (int i = 0; i < 10; i++) // Listeye -20 ile 20 arasında rastgele 10 sayı ekliyoruz
            {     
                list.Add(random.Next(-20,20));
            }

            Console.WriteLine("*** -20 VE +20 ARASI RASTGELE OLUŞTURULAN SAYILAR"); // Oluşturulan rastgele sayıları ekrana yazdırıyoruz
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\r\n*** ÇİFT SAYILAR ***"); // Listedeki çift sayıları buluyoruz ve ekrana yazdırıyoruz
            var evenNumbers = list.Where(sayi => sayi % 2 == 0);
            foreach (int sayi in evenNumbers)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("\r\n*** TEK SAYILAR ***"); // Listedeki tek sayıları buluyoruz ve ekrana yazdırıyoruz
            var oddNumbers = list.Where(sayi => sayi % 2 != 0);
            foreach (int sayi in oddNumbers)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("\r\n*** NEGATİF SAYILAR ***"); // Listedeki negatif sayıları buluyoruz ve ekrana yazdırıyoruz
            var negativeNumbers = list.Where(sayi => sayi < 0);
            foreach (int sayi in negativeNumbers)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("\r\n*** POZİTİF SAYILAR ***"); // Listedeki pozitif sayıları buluyoruz ve ekrana yazdırıyoruz
            var positiveNumbers = list.Where(sayi => sayi > 0);
            foreach (int sayi in positiveNumbers)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("\r\n*** 15'TEN BÜYÜK VE 22'DEN KÜÇÜK SAYILAR ***"); // 15'ten büyük ve 20'den küçük sayıları buluyoruz ve ekrana yazdırıyoruz
            var filteredNumbers = list.Where(sayi => sayi > 15 && sayi <20);
            foreach (int sayi in filteredNumbers)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("\r\n*** LİSTEDEKİ SAYILARIN KARESİ ***"); // Listedeki sayıların karesini hesaplayıp ekrana yazdırıyoruz
            var squaredNumbers = list.Select(sayi => sayi * sayi).ToList();
            foreach (int sayi in squaredNumbers)
            {
                Console.WriteLine(sayi);
            }
        }
    }
}
