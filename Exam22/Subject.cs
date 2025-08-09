using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Exam22.Question;

namespace Exam22
{
    public class Subject
    {
        public int SubId { get; set; }
        public string SubName { get; set; }
        public Exam exam { get; set; }
        public Subject(int subId, string subName)
        {
            SubId = subId;
            SubName = subName;

        }

        public void CreateExam(Exam exam)
        {
            this.exam = exam;
        }

        public override string ToString() => $"Subject: {SubName} (ID: {SubId})";

    }
}
