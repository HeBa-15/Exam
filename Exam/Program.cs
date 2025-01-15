using System.Diagnostics;

namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Subject Sub = new Subject(1, "OOP");
            Sub.CreateExam();

            Console.Clear();

            Console.Write("Do You Want To Start The Exam (Y | N) :  ");

            if (char.Parse(Console.ReadLine().ToUpper()) == 'Y')
            {
                Stopwatch sw = Stopwatch.StartNew();
                sw.Start();
                Sub.ExamOfTheSubject.show();
                Console.WriteLine($"The Elapsed Time = {sw.Elapsed}. ");
            }
            else
            {

                Console.WriteLine("Okey");

            }

        }
    }
}