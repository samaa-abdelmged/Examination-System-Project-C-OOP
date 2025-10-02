public class Student
{
    public string Name { get; set; }

    public Student(string name)
    {
        Name = name;
    }

    // 🔹 دالة بتتنفذ لما الامتحان يبدأ
    public void OnExamStarted(string message)
    {
        Console.WriteLine($"[Notification for {Name}]: {message}");
    }
}
