using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlkSinif
{
    public class Person  // Person adında bir sınıf tanımlıyoruz, bu sınıf hem öğrenci hem de öğretmen gibi genel kişileri temsil edecek
    {
        public string Name { get; set; } // Kişinin adı
        public string SurName { get; set; } // Kişinin soyadı
        public DateOnly BirthDate { get; set; } // Kişinin doğum tarihi
        public string Role {  get; set; } // Kişinin rolü (örneğin Öğrenci ya da Öğretmen)

        public void GetDetails()
        {
            Console.WriteLine($"{Name} {SurName} isimli {Role}, {BirthDate} tarihinde doğmuştur."); // Kişinin adı, soyadı, rolü ve doğum tarihi formatlı bir şekilde ekrana yazdırılır
        }

    }
}
