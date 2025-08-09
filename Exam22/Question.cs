using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam22
{
    public abstract class Question : ICloneable, IComparable<Question>
    {
        public string Head { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public Answer[] AnswerList { get; set; }
        public Answer RightAnswer { get; set; }


        public Question(string head, string body, int mark, Answer[] answers, Answer rightanswer)
        {
            Head = head;
            Body = body;
            Mark = mark;
            AnswerList = answers;
            RightAnswer = rightanswer;

        }
        public abstract void Show();

        public int CompareTo(Question? other)
        {
            return Mark.CompareTo(other.Mark);
        }

        public virtual object Clone()
        {
            return MemberwiseClone();
        }
    }
}
