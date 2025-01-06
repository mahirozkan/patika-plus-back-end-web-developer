using DependencyInjection;

public class Program
{
    public static void Main(string[] args)
    {
        IOgretmen teacher = new Teacher("Mahir", "Özkan");

        ClassRoom classRoom = new ClassRoom(teacher);

        Console.WriteLine(classRoom.GetTeacherInfo());
    }
}