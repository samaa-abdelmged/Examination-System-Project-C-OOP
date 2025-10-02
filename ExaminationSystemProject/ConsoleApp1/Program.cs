class Program
{
    static void Main()
    {
        QuestionList mathQuestions = new QuestionList("MathQuestionsLog.txt");

        // مادة
        Subject math = new Subject("Mathematics", "math023054");

        // امتحانات
        Exam practiceExam = new PracticeExam(math, 30);
        Exam finalExam = new FinalExam(math, 60);

        // طلاب
        Student s1 = new Student("Ahmed");
        Student s2 = new Student("Sara");

        // الطلاب يسمعوا الحدث
        practiceExam.ExamStarted += s1.OnExamStarted;
        practiceExam.ExamStarted += s2.OnExamStarted;

        finalExam.ExamStarted += s1.OnExamStarted;
        finalExam.ExamStarted += s2.OnExamStarted;

        // أسئلة
        var q1 = new TrueFalseQuestion("Q1", "2 + 2 = 4", 2);
        q1.Answers.AddAnswer("True", true);
        q1.Answers.AddAnswer("False", false);

        var q2 = new ChooseOneQuestion("Q2", "Capital of France?", 3,
            new List<string> { "Berlin", "Paris", "Madrid" });
        q2.Answers.AddAnswer("Berlin", false);
        q2.Answers.AddAnswer("Paris", true);
        q2.Answers.AddAnswer("Madrid", false);

        practiceExam.Questions.Add(q1);
        practiceExam.Questions.Add(q2);

        finalExam.Questions.Add(q1);
        finalExam.Questions.Add(q2);

        mathQuestions.Add(q1);
        mathQuestions.Add(q2);

        // اختيار نوع الامتحان
        Console.WriteLine("Choose Exam Type: 1- Practice  2- Final");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            practiceExam.StartExam(); // هيولع الـ Event
            practiceExam.ShowExam();
        }
        else
        {
            finalExam.StartExam(); // هيولع الـ Event
            finalExam.ShowExam();
        }

        Console.ReadLine();
    }
}
