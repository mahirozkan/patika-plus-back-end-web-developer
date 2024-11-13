namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {     
                list.Add(random.Next(-20,20));
            }

            Console.WriteLine("*** -20 VE +20 ARASI RASTGELE OLUŞTURULAN SAYILAR");
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\r\n*** ÇİFT SAYILAR ***");
            var evenNumbers = list.Where(sayi => sayi % 2 == 0);
            foreach (int sayi in evenNumbers)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("\r\n*** TEK SAYILAR ***");
            var oddNumbers = list.Where(sayi => sayi % 2 != 0);
            foreach (int sayi in oddNumbers)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("\r\n*** NEGATİF SAYILAR ***");
            var negativeNumbers = list.Where(sayi => sayi < 0);
            foreach (int sayi in negativeNumbers)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("\r\n*** POZİTİF SAYILAR ***");
            var positiveNumbers = list.Where(sayi => sayi > 0);
            foreach (int sayi in positiveNumbers)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("\r\n*** 15'TEN BÜYÜK VE 22'DEN KÜÇÜK SAYILAR ***");
            var filteredNumbers = list.Where(sayi => sayi > 15 && sayi <20);
            foreach (int sayi in filteredNumbers)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("\r\n*** LİSTEDEKİ SAYILARIN KARESİ ***");
            var squaredNumbers = list.Select(sayi => sayi * sayi).ToList();
            foreach (int sayi in squaredNumbers)
            {
                Console.WriteLine(sayi);
            }
        }
    }
}
