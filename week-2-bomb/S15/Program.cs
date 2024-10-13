double Yol(double hiz, double zaman)
{
    return hiz * zaman;
}

Console.WriteLine("Saatte 120km/h hızı olan bir araç 5 saatte ne kadar yol alır?");
Console.WriteLine(Yol(120, 5) + "km");

Console.ReadKey();