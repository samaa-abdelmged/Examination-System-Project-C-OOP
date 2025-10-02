public abstract class Question
{
    // الخصائص (Properties)
    public string Header { get; set; }
    public string Body { get; set; }
    public int Marks { get; set; }
    public AnswerList Answers { get; set; } // كل سؤال مرتبط بمجموعة إجابات


    // Constructor
    protected Question(string header, string body, int marks)
    {
        Header = header;
        Body = body;
        Marks = marks;
        Answers = new AnswerList(); // نبدأ بقائمة إجابات فارغة

    }

    //Override ToString
    public override string ToString()
    {
        string answersText = "";
        if (Answers != null && Answers.Count > 0)
        {
            foreach (var ans in Answers)
            {
                answersText += $"- {ans.Text} ({(ans.IsCorrect ? "Correct" : "Wrong")})\n";
            }
        }

        return $"[{Header}] {Body} ({Marks} Marks)\nAnswers:\n{answersText}";
    }


    // Abstract Display method
    public abstract void Display();
}
