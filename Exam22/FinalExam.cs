using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam22
{
    public class FinalExam : Exam
    {
        public FinalExam(int time, int numOfQuestions) : base(time, numOfQuestions) { }
        public override void ShowExam()
        {
            Console.WriteLine($"\n--- Final Exam ---\nTime: {Time} min\n");
            int total = 0;
            int qNumber = 1;
            foreach (var q in Questions)
            {
                Console.WriteLine($"Q{qNumber++}: ");
                q.Show();
                Console.Write("Your Answer: ");
                string input = Console.ReadLine();
                if (q.RightAnswer.AnswerId.ToString() == input)
                    total += q.Mark;
            }
            Console.WriteLine($"\nGrade: {total} / {Questions.Count * 10}\n");
        }

    }
}
