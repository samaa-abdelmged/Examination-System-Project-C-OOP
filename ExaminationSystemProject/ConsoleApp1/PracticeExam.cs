public class PracticeExam : Exam
{
    public PracticeExam(Subject subject, int time)
        : base(subject, time) { }

    public override void ShowExam()
    {
        Console.WriteLine($"Practice Exam - {Subject}");
        foreach (var q in Questions)
        {
            q.Display();
            Console.WriteLine($"Correct Answer: {q.Answers.FirstOrDefault(a => a.IsCorrect)?.Text}");
        }
    }
}
