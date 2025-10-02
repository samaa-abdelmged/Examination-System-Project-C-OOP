using System.Collections.Generic;

public class ChooseAllQuestion : Question
{
    public List<string> Options { get; set; }

    public ChooseAllQuestion(string header, string body, int marks, List<string> options)
        : base(header, body, marks)
    {
        Options = options;
    }

    public override void Display()
    {
        Console.WriteLine($"{Header}: {Body}  ({Marks} Marks)");
        Console.WriteLine("Select all that apply:");
        for (int i = 0; i < Options.Count; i++)
        {
            Console.WriteLine($"{i + 1}) {Options[i]}");
        }
    }
}
