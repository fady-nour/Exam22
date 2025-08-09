using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam22
{
    public class PracticalExam : Exam
    {

        public PracticalExam(int time, int numOfQuestions) : base(time, numOfQuestions)


        {



        }
        public override void ShowExam()
        {
            Console.WriteLine($"\n--- Practical Exam ---\nTime: {Time} min\n");
            int qNumber = 1;
            foreach (var q in Questions)
            {
                Console.WriteLine($"Q{qNumber++}: ");
                q.Show();
                Console.WriteLine($"Correct Answer: {q.RightAnswer}\n");
            }
        }

    }
}
