using LinqJoin;
using System.Threading.Channels;

namespace LinqJoin
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Yazarları tutan bir liste oluşturuluyor
            List<Authors> authors = new List<Authors>();
            authors.Add(new Authors { AuthorID = 1, Name = "Orhan Pamuk" });
            authors.Add(new Authors { AuthorID = 2, Name = "Elif Şafak" });
            authors.Add(new Authors { AuthorID = 3, Name = "Ahmet Ümit" });

            // Kitapları tutan bir liste oluşturuluyor
            List<Books> books = new List<Books>();
            books.Add(new Books { BookID = 1, Title = "Kar", AuthorID = 1 });
            books.Add(new Books { BookID = 2, Title = "İstanbul", AuthorID = 1 });
            books.Add(new Books { BookID = 3, Title = "10 Minutes 38 Seconds In The Strange World", AuthorID = 2 });
            books.Add(new Books { BookID = 4, Title = "Beyoğlu Rapsodisi", AuthorID = 3 });

            //var authorsList = authors.Join(books, // `authors` listesi ile `books` listesi birleştiriliyor
            //                                author => author.AuthorID, // `author` (yazar) nesnesinin AuthorID özelliği, join işlemi için kullanılıyor
            //                                book => book.AuthorID, book => book.AuthorID, // `book` (kitap) nesnesinin AuthorID özelliği ile eşleştiriliyor
            //                                (author, book) => new // Her iki öğe (yazar ve kitap) birleştirilip yeni bir anonim tip oluşturuluyor
            //                                {
            //                                    BookID = book.BookID, // Kitap ID'si
            //                                    Title = book.Title, // Kitap başlığı
            //                                    Name = author.Name, // Yazar adı
            //                                    AuthorID = author.AuthorID // Yazar ID'si
            //                                }
            //                                );

            // LINQ kullanarak Authors ve Books listelerini AuthorID üzerinden birleştiriyoruz
            var authorList = from author in authors
                             join book in books on author.AuthorID equals book.AuthorID
                             select new
                             {
                                 BookID = book.BookID, // Kitap ID'si
                                 Title = book.Title, // Kitap başlığı
                                 Name = author.Name, // Yazar adı
                                 AuthorID = author.AuthorID // Yazar ID'si
                             };

            foreach (var book in authorList) // Birleştirilen verileri ekrana yazdırıyoruz
            {
                Console.WriteLine($"Kitap ID: {book.BookID,-3}  ||  Kitap Adı: {book.Title,-45}  ||  Yazar Adı: {book.Name,-15}  ||  Yazar ID: {book.AuthorID}");
            }
        }
    }
}

