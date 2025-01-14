using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public Answer[] answerList { get; set; }
        public Answer RightAnswer { get; set; }


        public Question(string Header, string Body, int Mark)
        {
            Header = Header;
            Body = Body;
            Mark = Mark;
           

        }
        public virtual void display()
        {

            Console.WriteLine(Header + "\t\t " + "Mark : " + Mark);
            Console.WriteLine(Body);


        }
    }
}
