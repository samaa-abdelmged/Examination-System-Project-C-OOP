public class AnswerList : List<Answer>
{
    public void AddAnswer(string text, bool isCorrect)
    {
        this.Add(new Answer(text, isCorrect));
    }



    public void DisplayAnswers()
    {
        foreach (var answer in this)
        {
            Console.WriteLine(answer);
        }
    }
}
