using System.Reflection.PortableExecutable;
using static Exam22.Question;

namespace Exam22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter subject name: ");
            string subjectName = Console.ReadLine();
            Subject subject = new Subject(1, subjectName);

            Console.Write("Enter exam  Final = 1,  Practical = 2 ");
            int examType = int.Parse(Console.ReadLine());

            Console.Write("Enter exam time minutes ");
            int time = int.Parse(Console.ReadLine());

            Console.Write("Enter number of questions: ");
            int numOfQuestions = int.Parse(Console.ReadLine());

            Exam exam = examType == 1
                ? new FinalExam(time, numOfQuestions)
                : new PracticalExam(time, numOfQuestions);

            for (int i = 0; i < numOfQuestions; i++)
            {
                Console.WriteLine($"\nEnter info for Question {i + 1}");

                Console.Write("Enter question type  MCQ =1, TFalse =2: ");
                int qType = int.Parse(Console.ReadLine());

                Console.Write("Header: ");
                string header = Console.ReadLine();

                Console.Write("Body: ");
                string body = Console.ReadLine();

                Console.Write("Mark: ");
                int mark = int.Parse(Console.ReadLine());

                List<Answer> answerList = new List<Answer>();
                int numAnswers = (qType == 1) ? 3 : 2;

                for (int j = 0; j < numAnswers; j++)
                {
                    Console.Write($"Enter Answer {j + 1} Text: ");
                    string aText = Console.ReadLine();
                    answerList.Add(new Answer(j + 1, aText));
                }

                Console.Write("Enter correct answer number (1, 2, ...): ");
                int correctIndex = int.Parse(Console.ReadLine());
                Answer correctAnswer = answerList[correctIndex - 1];

                Question question = (qType == 1)
                    ? new MCQQues(header, body, mark, answerList.ToArray(), correctAnswer)
                    : new TFQues(header, body, mark, answerList.ToArray(), correctAnswer);

                exam.Questions.Add(question);
            }

            subject.CreateExam(exam);

            Console.WriteLine(subject);
            subject.exam.ShowExam();
        }
    }
   
  }   
