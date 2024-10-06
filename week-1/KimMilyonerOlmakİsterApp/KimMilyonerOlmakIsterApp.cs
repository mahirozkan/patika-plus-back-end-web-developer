// Yarışmanın başlangıç kısmı. Oyuncuyu karşılıyoruz.
Console.WriteLine("Merhaba! Yarışmamıza Hoş Geldiniz. Devam etmek için lütfen bir tuşa basın."); 
Console.ReadKey();
Console.WriteLine("----------------------------------------------------------------");
// Kuralları anlatıyoruz.
Console.WriteLine("Şimdi size kurallarımızdan bahsedeyim.");
Console.WriteLine("Yarışmamız 2 şıkka sahip 3 sorudan oluşuyor.");
Console.WriteLine("Eğer 3 sorudan 2'sine doğru cevap verirseniz 1 Milyon TL'lik büyük ödülü kazanacaksınız!");
Console.WriteLine("Kurallarımızı anladıysanız bir tuşa basın ve ilk soru gelsin! Şimdiden başarılar!");
Console.ReadKey();

//1. Soru
Soru1:
Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("Soru 1: Dünyanın en büyük okyanusu hangisidir? ");
Console.WriteLine("A) Atlantik Okyanusu ");
Console.WriteLine("B) Pasifik Okyanusu ");
Console.Write("Doğru olduğunu düşündüğünüz şıkkı giriniz(a/b): ");

// Oyuncunun cevabını alıp küçük harfe çevirerek karşılaştırıyoruz.
string cevap1 = Console.ReadLine().Trim().ToLower();

if (cevap1 == "a")  // Eğer oyuncu A şıkkını seçtiyse yanıtın yanlış olduğunu söylüyoruz.
{
    Console.WriteLine("Yanlış! Doğru cevap Pasifik Okyanusu olacaktı.");
    Console.WriteLine("Pasifik Okyanusu, yaklaşık 63 milyon mil kare " +
        "(165 milyon kilometre kare) alanıyla dünyanın en büyük okyanusudur. " +
        "Bu okyanus, Asya ve Avustralya ile Amerika kıtaları arasında yer alır.");
}
else if (cevap1 == "b")  // Eğer oyuncu B şıkkını seçtiyse doğru cevabı verdiğini belirtiyoruz.
{
    Console.WriteLine("Tebrikler!Bildiniz");
    Console.WriteLine("Pasifik Okyanusu, yaklaşık 63 milyon mil kare " +
        "(165 milyon kilometre kare) alanıyla dünyanın en büyük okyanusudur. " +
        "Bu okyanus, Asya ve Avustralya ile Amerika kıtaları arasında yer alır.");
}
else
{
    Console.WriteLine("Hatalı bir giriş yaptınız!"); // Oyuncu A veya B dışında bir şey yazarsa hatalı giriş yaptığını söylüyoruz.
    Console.ReadKey();
    Console.WriteLine("----------------------------------------------------------------");
    goto Soru1; // Hatalı giriş yapıldığından aynı soruyu tekrar soruyoruz.
}

// Doğru cevap verenlerin sayısını tutan bir değişken oluşturduk. Eğer cevap doğru ise doğru cevap sayısını artırıyoruz.
int dogrular = 0;  
if (cevap1 == "b")
{
     dogrular = dogrular + 1;
}

Console.ReadKey();

Console.WriteLine("----------------------------------------------------------------");

if (dogrular == 1)   // Eğer ilk soruya doğru cevap verdiyse ikinci soruya geçiyoruz.
{
    Console.WriteLine("Sıra ikinci soruda. Hazırsanız bir tuşa basınız.");
}
else     // Eğer yanlış cevap verdiyse ufak bir motivasyonla ikinci soruya geçiyoruz.
    Console.WriteLine("Hiçbir şey bitmiş değil, hala şansınız var. Hazırsanız bir tuşa basın ve ikinci soru gelsin.");
    
Console.ReadKey();
Console.WriteLine("----------------------------------------------------------------");

//2. Soru
Soru2:
Console.WriteLine("Dünyanın en yüksek zirvesi hangisidir?");
Console.WriteLine("A) Everest ");
Console.WriteLine("B) K2 ");
Console.Write("Doğru olduğunu düşündüğünüz şıkkı giriniz(a/b): ");

string cevap2 = Console.ReadLine().Trim().ToLower();

if (cevap2 == "a")  // Eğer oyuncu A şıkkını seçtiyse doğru cevabı verdiğini belirtiyoruz.
{
    Console.WriteLine("Tebrikler!Bildiniz");
    Console.WriteLine("Everest Dağı, 8,848 metre (29,029 feet) yüksekliğiyle dünyanın en yüksek zirvesidir.");
}
else if (cevap2 == "b") // Eğer oyuncu B şıkkını seçtiyse yanlış cevabı verdiğini söylüyoruz.
{
    Console.WriteLine("Yanlış! Doğru cevap Everest olacaktı.");
    Console.WriteLine("Everest Dağı, 8,848 metre (29,029 feet) yüksekliğiyle dünyanın en yüksek zirvesidir.");
}
else
{    
    Console.WriteLine("Hatalı bir giriş yaptınız!");  // Oyuncu A veya B dışında bir şey yazarsa hatalı giriş yaptığını söylüyoruz ve başa dönüyoruz.
    Console.ReadKey();
    Console.WriteLine("----------------------------------------------------------------");
    goto Soru2;  // Hatalı giriş yapıldığından aynı soruyu tekrar soruyoruz.
}

if (cevap2 == "a")  // Eğer doğru cevap ise doğru cevap sayısını artırıyoruz.
{
    dogrular = dogrular + 1;
}

Console.ReadKey();

if (dogrular == 2)  // Eğer iki soruya doğru cevap verdiyse oyuncuya büyük ödülü kazandığını söylüyoruz.
{
    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine("Tebrikler! Her iki soruya da doğru cevap vererek 1 Milyon TL'lik büyük ödülü kazandınız!");
    Console.ReadKey();
    return; // Oyunu sonlandırıyoruz.
}
else if (dogrular == 1)  // Eğer sadece bir soruya doğru cevap verdiyse üçüncü soruya geçiyoruz
{
    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine("Bu soruyu iyi değerlendirin, eğer bilirseniz büyük ödül sizin.");
    Console.ReadKey();
}
else  // Eğer iki soruyu da yanlış cevapladıysa yarışmanın bittiğini söylüyoruz.
{ Console.WriteLine("Maalefes yarışmamızın sonuna geldik!");
    Console.ReadKey();
    return;  // Oyunu sonlandırıyoruz.
}

Console.WriteLine("----------------------------------------------------------------");

//3. Soru
Soru3:
Console.WriteLine("Dünyanın en uzun nehri hangisidir?");
Console.WriteLine("A) Nil Nehri ");
Console.WriteLine("B) Amazon Nehri ");
Console.Write("Doğru olduğunu düşündüğünüz şıkkı giriniz(a/b): ");

string cevap3 = Console.ReadLine().Trim().ToLower();

if (cevap3 == "a") // Eğer oyuncu A şıkkını seçtiyse doğru cevabı verdiğini belirtiyoruz.
{
    Console.WriteLine("Tebrikler!Bildiniz.");
    Console.WriteLine("Nil Nehri, yaklaşık 6,650 kilometre uzunluğuyla dünyanın en uzun nehridir. Afrika kıtasında kuzeyden güneye doğru akar ve Mısır'a hayat veren önemli bir su kaynağıdır.");
}
else if (cevap3 == "b")  // Eğer oyuncu B şıkkını seçtiyse yanlış cevabı verdiğini söylüyoruz.
{
    Console.WriteLine("Yanlış! Doğru cevap Nil Nehri olacaktı.");
    Console.WriteLine("Nil Nehri, yaklaşık 6,650 kilometre uzunluğuyla dünyanın en uzun nehridir. Afrika kıtasında kuzeyden güneye doğru akar ve Mısır'a hayat veren önemli bir su kaynağıdır.");
}
else
{
    Console.WriteLine("Hatalı bir giriş yaptınız!");  // Oyuncu A veya B dışında bir şey yazarsa hatalı giriş yaptığını söylüyoruz ve başa dönüyoruz.
    Console.ReadKey();
    Console.WriteLine("----------------------------------------------------------------");
    goto Soru3;  // Hatalı giriş yapıldığından aynı soruyu tekrar soruyoruz.
}

if (cevap3 == "a") // Doğru cevapladıysa doğru sayısını arttırıyoruz.
{
    dogrular = dogrular + 1;
}

Console.ReadKey();

if (dogrular == 2)  // Eğer bu soruya doğru cevapladıysa oyuncuya büyük ödülü kazandığını söylüyoruz.
{
    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine("Tebrikler! Bu soruya da doğru cevap vererek 1 Milyon TL'lik büyük ödülü kazandınız!");

}
else  // Eğer bu soruya da yanlış cevapladıysa yarışmanın bittiğini söylüyoruz.
{
    Console.WriteLine("Maalefes yarışmamızın sonuna geldik!");
}
    Console.ReadKey();
    return; // Oyunu sonlandırıyoruz.