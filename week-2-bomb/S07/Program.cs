string isim1 = "Gülse Birsel";
string isim2 = "Demet Evgar";

Console.WriteLine($"Değiştirmeden önce : {isim1} ve {isim2}");
string temp = isim1;
isim1 = isim2;
isim2 = temp;

Console.WriteLine($"Değişimden sonra: {isim1} ve {isim2}");

Console.ReadKey();