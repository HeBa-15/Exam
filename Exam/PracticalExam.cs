using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exam
{
    internal class PracticeExam : Exam
    {
        public PracticeExam(string time, int numOfQuestion, Subject subject) : base(time, numOfQuestion, subject)
        {

        }


        public override void show()
        {
            Console.Clear();

            base.show();
            for (int i = 0; i < NumOfQuestion; i++)
            {
                subject.questions[i].display();

                int ans = int.Parse(Console.ReadLine());
                if (ans == subject.questions[i].RightAnswer) result += subject.questions[i].Mark;

            }
            Console.Clear();
            for (int i = 0; i < NumOfQuestion; i++)
            {
                subject.questions[i].display();

                Console.WriteLine("The Right Answer is :" + subject.questions[i].RightAnswer);


            }



        }
    }
}
