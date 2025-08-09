using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam22
{
    public class Answer : ICloneable
    {
        public int AnswerId { get; set; }
        public String AnswerText { get; set; }
        public Answer(int answerId, String answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        }

        public object Clone()
        {
            return new Answer(AnswerId, AnswerText);
        }
        public override string ToString() => $"[{AnswerId}] {AnswerText}";
    }
}
