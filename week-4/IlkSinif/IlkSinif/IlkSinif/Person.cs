using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlkSinif
{
    public class Person
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public DateOnly BirthDate { get; set; }
        public string Role {  get; set; }

        public void GetDetails()
        {
            Console.WriteLine($"{Name} {SurName} isimli {Role}, {BirthDate} tarihinde doğmuştur.");
        }

    }
}
