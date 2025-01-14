using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Answer
    {
        public int answerId { get; set; }
        public string answer { get; set; }

        public Answer(int answerId, string answer)
        {
            this.answerId = answerId;
            this.answer = answer;
        }

    }
}
