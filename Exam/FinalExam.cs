using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exam
{
    
        internal class FinalExam : Exam
        {
            public FinalExam(string time, int numOfQuestion, Subject subject) : base(time, numOfQuestion, subject)
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
                    sum += subject.questions[i].Mark;
                    if (ans == subject.questions[i].RightAnswer) result += subject.questions[i].Mark;

                }
                Console.Clear();
                for (int i = 0; i < NumOfQuestion; i++)
                {
                    subject.questions[i].display();
                    Console.WriteLine("The Right Answer is :" + subject.questions[i].RightAnswer);

                }

                Console.WriteLine("Grading the final exam...");


                Console.WriteLine($"Your result is {result} from {sum}");

            }



        }
    
}
