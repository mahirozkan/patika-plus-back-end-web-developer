int[] tamSayi = new int[10]; // 10 elemanlı bir tamsayı dizisi oluşturuyoruz
for (int i = 0; i < tamSayi.Length; i++)
{
    int sayi = 0; // Girilen sayıyı tutacak değişken
    bool sayiMi; // Sayının geçerli bir tam sayı olup olmadığını kontrol edecek değişken
    do
    {
        Console.Write($"{i + 1}. Elemanı giriniz: "); // Kullanıcıdan dizinin her elemanını girmesini istiyoruz
        string input = Console.ReadLine();
        sayiMi = int.TryParse(input, out sayi); // Girilen değerin tam sayı olup olmadığını kontrol ediyoruz

        if (!sayiMi)
        {
            Console.WriteLine("Hatalı giriş! Lütfen bir tam sayı giriniz."); // Eğer geçerli bir tam sayı değilse hata mesajı gösteriyoruz
        }
    }
    while (!sayiMi); // Geçerli bir tam sayı girilene kadar döngüyü devam ettiriyoruz

    tamSayi[i] = sayi; // Geçerli sayıyı dizinin ilgili elemanına atıyoruz
}
Console.WriteLine("\r\n Dizinin Elemanları\r\n"); // Dizinin elemanlarını ekrana yazdırıyoruz
int kacinci1 = 1;
foreach (int item in tamSayi)
{
    Console.WriteLine($"{kacinci1}. Eleman: {item}");
    kacinci1++;
}

int sayi11 = 0; // 11. elemanı tutacak değişken
bool sayiMi2; // Geçerliliği kontrol edecek değişken
do
{
    Console.Write("\r\n11. elemanı giriniz: "); // Kullanıcıdan 11. elemanı girmesini istiyoruz
    string newEleman = Console.ReadLine();
    sayiMi2 = int.TryParse(newEleman, out sayi11); // Girilen değerin tam sayı olup olmadığını kontrol ediyoruz

    if (!sayiMi2)
    {
        Console.WriteLine("Hatalı giriş! 11. eleman geçerli bir tam sayı olmalıdır."); // Eğer geçerli bir tam sayı değilse hata mesajı gösteriyoruz
    }
} while (!sayiMi2); // Geçerli bir tam sayı girilene kadar döngüyü devam ettiriyoruz


Array.Resize(ref tamSayi, tamSayi.Length + 1); // Dizinin boyutunu bir artırıyoruz ve yeni elemanı ekliyoruz
tamSayi[tamSayi.Length - 1] = sayi11;


int kacinci2 = 1; 
Console.WriteLine("\nGüncellenmiş elemanlar:"); // Güncellenmiş dizinin elemanlarını ekrana yazdırıyoruz
foreach (int item in tamSayi)
{
    Console.WriteLine($"{kacinci2}. Eleman: {item}");
    kacinci2++;
}

Array.Sort(tamSayi); // Diziyi küçükten büyüğe sıralıyoruz
Array.Reverse(tamSayi); // Diziyi ters çevirip büyükten küçüğe sıralıyoruz
int kacinci3 = 1;
Console.WriteLine("\nBüyükten küçüğe sıralanmış elemanlar:"); // Sıralanmış dizinin elemanlarını ekrana yazdırıyoruz
foreach (int item in tamSayi)
{
    Console.WriteLine($"{kacinci3}. Eleman: {item}");
    kacinci3++;
}
Console.ReadLine();
