using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqJoin
{
    public class Authors // Yazar sınıfı
    { 
        public int AuthorID { get; set; }
        public string Name { get; set; }
    }
    public class Books // Kitap sınıfı
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public int AuthorID { get; set; }
    }
}
