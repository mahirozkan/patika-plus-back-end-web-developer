using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB
{
    public class Film
    {
        // Film adını ve IMDb puanını saklayan sınıf özellikleri
        public string _isim {get; set;}
        public double _puan {get; set;}

        public Film(string isim, double puan) // Film sınıfı yapıcı metodu, film adı ve puanı alır
        {
            _isim = isim;
            _puan = puan;
        }
    }
}
