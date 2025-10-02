public class FinalExam : Exam
{
    public FinalExam(Subject subject, int time)
        : base(subject, time) { }

    public override void ShowExam()
    {
        Console.WriteLine($"Final Exam - {Subject}");
        foreach (var q in Questions)
        {
            q.Display(); //  بيعرض السؤال والإجابات
        }
    }
}
