using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class True_False:Question
    {
        public True_False(string header, string Body, int Mark) : base(header, Body, Mark)
        {

        }
        public override void display()
        {
            Console.WriteLine("===============================");
            base.display();
            Console.WriteLine("1.True\t|\t2.False");
            Console.WriteLine("--------------------------------------");
        }
    }
}
