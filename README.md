📘 Examination System Project
=================================

👤 Client: ITI Organization  
📝 Project Type: Examination Management System  

---------------------------------

📌 Project Overview:
---------------------
The Examination System allows the organization to create, manage, and conduct exams with multiple types of questions.

✨ Features:
- ✅ Support for multiple question types (True/False, Choose One, Choose All)  
- 🗂️ Answer and AnswerList classes to represent possible answers  
- 📝 Exam base class with two derived types: Practice Exam and Final Exam  
- 📂 Question logging into files using QuestionList  
- ⚙️ OOP features: Inheritance, Polymorphism, Generics  
- 🔗 Interfaces implemented: ICloneable, IComparable  
- 🎯 Overrides for: ToString(), Equals(), GetHashCode()  
- 🔔 Events & Delegates: Notify students when exams start  

---------------------------------

🏷️ Class Structure:
---------------------

1️- Question Hierarchy  
------------------
🔹 Abstract Class: Question
   - Properties: Header, Body, Marks, AnswerList Answers  
   - Method: abstract void Display()  

🔹 Derived Classes:  
   - TrueFalseQuestion : Question  
   - ChooseOneQuestion : Question  
   - ChooseAllQuestion : Question  

---------------------------------

2️- Answer Hierarchy  
------------------
🔹 Class: Answer 
   - Properties: Text, IsCorrect  
   - Overrides: ToString() 
🔹 Class: AnswerList (inherits List)
   - Methods:  
     ➕ AddAnswer(string text, bool isCorrect)  
     👀 DisplayAnswers()  

---------------------------------

3️- QuestionList  
------------------
🔹 Class: QuestionList (inherits List)  
   - Constructor: (string fileName) → File used for logging  
   - Method: Add(Question question) → Adds question + logs to file  

---------------------------------

4️- Exam Hierarchy  
------------------
🔹 Abstract Class: Exam (Generic)  
   - Implements: ICloneable, IComparable<Exam>  
   - Properties:  
     📚 Subject  
     ⏱️ Time  
     ❓ List<Question> Questions  
     🗂️ Dictionary<Question, Answer> QuestionAnswer  
     🚦 ExamMode Mode  

   - Methods:  
     🖥️ abstract void ShowExam()  
     🔄 CompareTo(Exam<T>)  
     📑 Clone()  
     ✍️ ToString()  
     🧩 GetHashCode()  
     ⚖️ Equals(object obj)  

🔹 Derived Classes:  
   - PracticeExam : Exam → Shows questions + correct answers  
   - FinalExam : Exam → Shows only questions & answers  

---------------------------------

5️- Supporting Classes  
------------------
🔹 Class: Subject  
   - Properties: Name, Code  
   - Overrides: ToString()  

🔹 Class: Student 
   - Properties: Name  
   - Method: Notify() → Triggered when exam starts  

🔹 Enum: ExamMode  
   - Values: Starting, Queued, Finished  

---------------------------------

▶️ Main Program Flow:  
------------------
1. Create Subject object  
2. Create PracticeExam & FinalExam objects  
3. Add questions (True/False, Choose One, Choose All)  
4. Link each question with AnswerList  
5. User selects exam type  
6. If Practice → show questions & correct answers  
   If Final → show only questions  
7. When exam starts → notify students  

---------------------------------

📂 File Logging:
------------------
- Each QuestionList logs questions into a file (e.g., MathQuestionsLog.txt).  
- Logging handled via StreamWriter in overridden Add() method.  

---------------------------------
📂 File Structure
/ExaminationSystemProject/ConsoleApp
├── Program.cs              # Entry point (Main method)
├── Question.cs             # Abstract base class for questions
├── TrueFalseQuestion.cs    # Derived question type
├── ChooseOneQuestion.cs    # Derived question type
├── ChooseAllQuestion.cs    # Derived question type
├── Answer.cs               # Represents a single answer
├── AnswerList.cs           # Represents list of answers
├── QuestionList.cs         # Custom List<Question> with file logging
├── Subject.cs              # Represents subject details
├── Exam.cs                 # Abstract base exam
├── PracticeExam.cs         # Derived exam type
├── FinalExam.cs            # Derived exam type
├── ExamMode.cs             # Enum for exam states
├── Student.cs              # notify Student that Exam is starting

---------------------------------

⚙️ Example Run
Choose Exam Type: 1- Practice  2- Final
> 1

Exam: Practice Exam
Q1: 2 + 2 = 4
   - True
   - False
Correct Answer: True

Q2: Capital of France?
   - Berlin
   - Paris
   - Madrid
Correct Answer: Paris
----------------------------

🚀 Technologies Used
Language: C#
Framework: .NET Console Application
Concepts: OOP (inheritance, polymorphism, abstraction), Generics, Interfaces, Events, File Handling
--------------------

👩‍💻 Author:
------------------
👩 Name: Samaa Abdelmged Roshdy 
📱 Number: 01014504030  
✉️ Email: samaaabdelmged55@gmail.com  
🌐 Freelance Profile: https://www.freelanceyard.com/en/freelancers/samaa-abdelmged  
