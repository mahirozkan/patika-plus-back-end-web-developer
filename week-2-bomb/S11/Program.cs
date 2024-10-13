int YaslarinEnBuyugu(int y1, int y2, int y3)
{
    return Math.Max(Math.Max(y1, y2), y3);
}

Console.WriteLine(YaslarinEnBuyugu(5, 21, 35));

Console.ReadKey();