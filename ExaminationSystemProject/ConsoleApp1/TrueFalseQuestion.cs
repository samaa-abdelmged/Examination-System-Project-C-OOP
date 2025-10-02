public class TrueFalseQuestion : Question
{
    public TrueFalseQuestion(string header, string body, int marks)
        : base(header, body, marks) { }

    public override void Display()
    {
        Console.WriteLine($"{Header}: {Body}  ({Marks} Marks)");
        Console.WriteLine("1) True");
        Console.WriteLine("2) False");
    }
}
