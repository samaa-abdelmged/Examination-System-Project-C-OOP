public class Subject
{
    public string Name { get; set; }   // اسم المادة
    public string Code { get; set; }   // كود المادة (MATH101)

    // Constructor
    public Subject(string name, string code)
    {
        Name = name;
        Code = code;
    }

    public override string ToString()
    {
        return $"{Name} ({Code})";
    }
}
