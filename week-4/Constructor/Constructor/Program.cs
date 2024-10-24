namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Varsayılan constructor ile bir Bebek nesnesi oluşturuyoruz
            Bebek bebek1 = new Bebek();
            bebek1._name = "Mahir";
            bebek1._surname = "Özkan";
            bebek1.BebekDogum();

            // Parametreli constructor kullanarak bir Bebek nesnesi oluşturuyoruz
            Bebek bebek2 = new Bebek("Melek", "Özkan");
            bebek2.BebekDogum();

            Console.ReadLine();
        }
    }
}
