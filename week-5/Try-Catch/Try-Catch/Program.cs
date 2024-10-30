namespace Try_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // sayiMi değişkeni ile kullanıcıdan geçerli bir sayı alınıp alınmadığını kontrol ediyoruz
            bool sayiMi = false;
            while (!sayiMi) // sayiMi 'false' olduğu sürece döngü çalışmaya devam edecek
            {
                try
                {
                    Console.Write("Bir sayı giriniz: "); // Kullanıcıdan bir sayı girmesini istiyoruz
                    string input = Console.ReadLine(); // Girdiyi 'string' olarak alıyoruz
                    int sayi = Convert.ToInt32(input); // Girdiyi 'int' tipine dönüştürüyoruz

                    sayiMi = true;  // Eğer dönüşüm başarılı olursa, geçerli bir sayı almış oluyoruz ve döngü sonlanıyor

                    Console.WriteLine("Girdiğiniz sayının karesi: " + (sayi * sayi)); // Girilen sayının karesini ekrana yazdırıyoruz.
                }
                catch (Exception)
                {
                    // Eğer dönüştürme sırasında bir hata oluşursa, kullanıcıya geçersiz giriş olduğunu söylüyoruz
                    Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
                }
            }
        }
    }
}
