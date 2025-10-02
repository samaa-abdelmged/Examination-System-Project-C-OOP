public abstract class Exam : ICloneable, IComparable<Exam>
{
    public Subject Subject { get; set; }                     // المادة
    public int Time { get; set; }                            // زمن الامتحان
    public List<Question> Questions { get; set; }            // قائمة الأسئلة
    public Dictionary<Question, Answer> QuestionAnswer { get; set; } // سؤال + إجابته
    public ExamMode Mode { get; set; }                       // حالة الامتحان

    // 1- تعريف الـ Delegate
    public delegate void ExamStartedHandler(string message);

    // 2- تعريف الـ Event
    public event ExamStartedHandler ExamStarted;


    // Constructor
    public Exam(Subject subject, int time)
    {
        Subject = subject;
        Time = time;
        Questions = new List<Question>();
        QuestionAnswer = new Dictionary<Question, Answer>();
        Mode = ExamMode.Queued; // الافتراضي: في قائمة الانتظار
    }


    // 🔹 3- دالة لتشغيل الحدث
    public void StartExam()
    {
        Mode = ExamMode.Starting;
        ExamStarted?.Invoke($"Exam for {Subject.Name} has started! Duration: {Time} minutes");
    }


    // FinalExam or PracticalExam
    public abstract void ShowExam();

    // بيسمح نرتب الامتحانات حسب الوقت 
    public int CompareTo(Exam other) => this.Time.CompareTo(other.Time);

    // copy
    public object Clone() => this.MemberwiseClone();

    // Overrides
    public override string ToString() => $"Exam in {Subject} - Time: {Time} mins";

    // بيولد رقم فريد للامتحان باستخدام subject + الوقت.
    public override int GetHashCode() => Subject.GetHashCode() ^ Time;

    // بيقارن امتحانين: يعتبرهم متساويين لو نفس المادة + نفس الوقت.
    public override bool Equals(object obj) => obj is Exam e && e.Subject == this.Subject && e.Time == this.Time;
}
