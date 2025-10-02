public class QuestionList : List<Question>
{
    private string fileName;

    //Constructor
    public QuestionList(string fileName)
    {
        this.fileName = fileName;
    }

    //Add Question to List of Questions 
    public new void Add(Question question)
    {
        base.Add(question);

        try
        {
            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                writer.WriteLine(question.ToString());
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error writing to file: " + ex.Message);
        }
    }
}
