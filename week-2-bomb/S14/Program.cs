bool CiftMi(int sayi) => sayi % 2 == 0; 

Console.Write("Bir sayı giriniz: ");
int sayi = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CiftMi(sayi) ? "Çift" : "Tek");

Console.ReadKey();