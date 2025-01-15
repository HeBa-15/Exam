using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class MCQ : Question
    {
       // public Answer[] answerList { get; set; }
        public MCQ(string header, string Body, int Mark, Answer[] answerList) : base(header, Body, Mark)
        {
            this.answerList = answerList;
        }

        public override void display() 
        {
            Console.WriteLine("===============================");
            base.display();
            for (int i = 0; i < answerList.Length; i++)
            {
                Console.WriteLine($"{i + 1} - {answerList[i].answer}");

            }
        }
    }
}
