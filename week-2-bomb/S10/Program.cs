string soru(bool x)
{
    return x ? "Evet" : "Hayır";
}

Console.WriteLine("Yazılımı seviyor muyum?: " + soru(true));
Console.WriteLine("Mantı seviyor muyum?: " + soru(false));

Console.ReadKey();