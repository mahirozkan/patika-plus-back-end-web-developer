using LinqGroupJoin;

namespace LinqGroupJoin
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Students> students = new List<Students>(); // Öğrencilerin listesi oluşturuluyor
            students.Add(new Students { StudentId = 1, StudentName = "Ali", ClassId = 1 });
            students.Add(new Students { StudentId = 2, StudentName = "Ayşe", ClassId = 2 });
            students.Add(new Students { StudentId = 3, StudentName = "Mehmet", ClassId = 1 });
            students.Add(new Students { StudentId = 4, StudentName = "Fatma", ClassId = 3 });
            students.Add(new Students { StudentId = 5, StudentName = "Ahmet", ClassId = 2 });

            List<Classes> classes = new List<Classes>(); // Sınıfların listesi oluşturuluyor
            classes.Add(new Classes { ClassId = 1, ClassName = "Matematik" });
            classes.Add(new Classes { ClassId = 2, ClassName = "Türkçe" });
            classes.Add(new Classes { ClassId = 3, ClassName = "Kimya" });

            // LINQ GroupJoin kullanılarak sınıflar ile öğrenciler birleştiriliyor
            var classAndStudents = classes.GroupJoin(students, 
                                                        classItem => classItem.ClassId, // Sınıfın ClassId özelliği
                                                        student => student.ClassId, // Öğrencinin ClassId özelliği
                                                        (classItem, studentsInClass) => new
                                                        {
                                                            ClassName = classItem.ClassName, // Sınıf adı
                                                            Students = studentsInClass.Select(student => student.StudentName) // Öğrencilerin isimleri
                                                        });

            // Her bir sınıf ve o sınıfta bulunan öğrenciler ekrana yazdırılıyor
            foreach (var item in classAndStudents) // Sınıf adı yazdırılıyor
            {
                Console.WriteLine($"Sınıf: {item.ClassName}");

                foreach (var student in item.Students) // Öğrenci isimleri yazdırılıyor
                {
                    Console.WriteLine($" - Öğrenci: {student}");
                }
            }
            Console.WriteLine();
        }
    }
}
