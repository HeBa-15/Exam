﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exam
{
    internal class Exam
    {
        public int sum = 0;
        public int result = 0;
        string Time { get; set; }
        protected int NumOfQuestion { get; set; }

        public Subject subject { get; set; }



        public Exam(string time, int numOfQuestion, Subject subject)
        {
            Time = time;
            NumOfQuestion = numOfQuestion;
            this.subject = subject;

        }

        public virtual void show()
        {
            Console.WriteLine(" Time: " + Time + ", Questions: " + NumOfQuestion);
        }



    }
}
