internal class Program
{
    private static void Main(string[] args)
    {
        Student[] students =
        {
             new Student(){studentId=1,studentName="Ahmed",Age = 18,City="Cairo"},
             new Student(){studentId=2,studentName="Mohamed",Age = 22, City = "Alexandria"},
             new Student(){studentId=3,studentName="Khaled",Age = 15,City="Cairo"},
             new Student(){studentId=4,studentName="Salma",Age = 19, City = "Alexandria"},
             new Student(){studentId=5,studentName="Omar",Age = 23,City="Cairo"},
             new Student(){studentId=6,studentName="Karim",Age = 10, City = "Alexandria"}
         };

        var cityGroup = students.GroupBy(student => student.City);
        foreach(var group in cityGroup)
        {
            Console.WriteLine($"Students who live in {group.Key}");
            foreach(var student in group)
            {
                Console.WriteLine(student.studentName);
            }
            Console.WriteLine();
        }

        var Adults = students.Where(student => student.Age > 18).Select(student => student.studentName); ;
        Console.WriteLine("Students who older than 18");
        foreach(var student in Adults)
        {
            Console.WriteLine(student);
        }

    }
    public class Student
    {
        public int studentId { get; set; }
        public string studentName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }

}
