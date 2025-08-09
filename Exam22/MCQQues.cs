using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam22
{
    public class MCQQues : Question
    {
        public MCQQues(string head, string body, int mark, Answer[] answers, Answer rightanswer) : base(head, body, mark, answers, rightanswer)
        {

        }

        public override void Show()
        {

            Console.WriteLine($"[MCQ] {Head} - {Body} ({Mark} Mark)");
            foreach (var ans in AnswerList)
                Console.WriteLine(ans);
        }
    }
}
