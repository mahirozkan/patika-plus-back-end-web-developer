using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqGroupJoin
{
    public class Students // Öğrencileri temsil eden bir sınıf
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int ClassId { get; set; }
    }
    public class Classes // Sınıfları temsil eden bir sınıf
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }
    }
}
