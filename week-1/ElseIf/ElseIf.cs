using System;

namespace ElseIfExample
{
    class ElseIf
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayi giriniz:");

            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi > 10)
            {
                Console.WriteLine("Girilen sayi 10'dan büyüktür.");

            }
            else if (sayi < 10)
            {
                Console.WriteLine("Girilen sayi 10'dan kücüktür.");
                
            }
            else
            {
                Console.WriteLine("Girilen sayi 10'a esittir.");

            }

            if (sayi % 2 == 0)
            {
                Console.WriteLine("Girilen sayi cifttir.");
            }
            else
            {
                Console.WriteLine("Girilen sayi tektir.");
            }
        }
    }
}