namespace DesignPatterns.ObjectRelations.Aggregation; 

internal class AssociationExample1 : Separator
{
    public new void Run()
    {
        Console.WriteLine("This is Bi-directional Association Example");
        var teacher = new Teacher("John Doe");
        var student1 = new Student("Alice", teacher);
        var student2 = new Student("Bob", teacher);
        var student3 = new Student("Charlie", teacher);

        Console.WriteLine("Students of Teacher: " + teacher.Name);
        teacher.Students.ForEach(student => Console.WriteLine($"Student: {student.Name}"));
        // Student: Alice
        // Student: Bob
        // Student: Charlie
        base.Run();
    }
}

/// <summary>
/// Teacher 'has-a' Student 
/// </summary>
public class Teacher
{
    public string Name { get; set; }
    public List<Student> Students { get; set; }

    public Teacher(string name)
    {
        Name = name;
        Students = new List<Student>();
    }
}

/// <summary>
/// Student 'has-a' Teacher
/// </summary>
public class Student
{
    public string Name { get; set; }
    public Teacher Teacher { get; set; }

    public Student(string name, Teacher teacher)
    {
        Name = name;
        Teacher = teacher;
        teacher.Students.Add(this); // This ensures the bidirectional link is established
    }
}
