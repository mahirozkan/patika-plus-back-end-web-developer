double Alan(double cap)
{
    return 3.14 * cap * cap;
}

Console.Write("Yarıçap: ");
double r = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Alan: " + Alan(r));

Console.ReadKey();