public class Answer
{
    public string Text { get; set; }    // answer's text
    public bool IsCorrect { get; set; }  // mark the right answer

    public Answer(string text, bool isCorrect)
    {
        Text = text;
        IsCorrect = isCorrect;
    }

    public override string ToString()
    {
        return $"{Text} {(IsCorrect ? "(Correct)" : "")}";
    }
}

