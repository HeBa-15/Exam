using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Subject
    {
        public int id { get; set; }
        public string name { get; set; }
        public Exam ExamOfTheSubject { get; set; }
        public Question[] questions;
        public Subject(int subjectId, string subjectName)
        {
            id = subjectId;
            name = subjectName;
        }

        public void CreateExam()
        {
            Console.Write("Please Enter The Type Of Exam ( 1 For Practical | 2 For Final) : ");
            int examType = int.Parse(Console.ReadLine());



            Console.Write("Please Enter The Time Of Exam in Minutes ( From 30 min To 180 min) : ");
            string timeOfExam = (Console.ReadLine());

            Console.Write("Please Enter The Number Of Question : ");
            int numberOfQuestions = int.Parse(Console.ReadLine());

            questions = new Question[numberOfQuestions];


            if (examType == 1)
            {

                ExamOfTheSubject = new PracticeExam(timeOfExam, numberOfQuestions, this);


                for (int i = 0; i < numberOfQuestions; i++)
                {


                    Console.Clear();

                    Console.WriteLine("MCQ Question :- ");

                    Console.WriteLine("Please Enter Question Body : ");
                    string Body = Console.ReadLine();

                    Console.WriteLine("Please Enter Question Mark : ");
                    int Mark = int.Parse(Console.ReadLine());
                    Answer[] answers = new Answer[4];
                    Console.WriteLine(" Choices of The Question : ");
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write($"Please Enter Choice number {j + 1} : ");
                        answers[j] = new Answer(j + 1, Console.ReadLine());
                    }
                    questions[i] = new MCQ("MCQ Question :- ", Body, Mark, answers);
                    Console.WriteLine("Please Enter the Right answer id : ");

                    questions[i].RightAnswer = int.Parse(Console.ReadLine());


                }

            }
            else if (examType == 2)
            {
               


                ExamOfTheSubject = new FinalExam(timeOfExam, numberOfQuestions, this);





                for (int i = 0; i < numberOfQuestions; i++)
                {
                    Console.Clear();
                    Console.Write($"Please Choose The Type Of Question Number({i + 1}) ( 1 For MCQ || 2 For True_False : )");
                    int questionType = int.Parse(Console.ReadLine());


                    if (questionType == 1)

                    {
                        Console.Clear();
                        Console.WriteLine("MCQ Question :- ");

                        Console.WriteLine("Please Enter Question Body : ");
                        string Body = Console.ReadLine();

                        Console.WriteLine("Please Enter Question Mark : ");
                        int Mark = int.Parse(Console.ReadLine());
                        Answer[] answers = new Answer[4];
                        Console.WriteLine(" Choices of The Question : ");
                        for (int j = 0; j < 4; j++)
                        {
                            Console.Write($"Please Enter Choice number {j + 1} : ");
                            answers[j] = new Answer(j + 1, Console.ReadLine());
                        }
                        questions[i] = new MCQ("MCQ Question :- ", Body, Mark, answers);
                        Console.WriteLine("Please Enter the Right answer id : ");

                        questions[i].RightAnswer = int.Parse(Console.ReadLine());

                    }
                    else if (questionType == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("True | False Question :- ");

                        Console.WriteLine("Please Enter Question Body : ");
                        string Body = Console.ReadLine();

                        Console.WriteLine("Please Enter Question Mark : ");
                        int Mark = int.Parse(Console.ReadLine());
                        questions[i] = new True_False("True | False Question :- ", Body, Mark);
                        Console.WriteLine($"Please Enter The Right Answer Of Question ( 1 For True and 2 For False) : ");
                        questions[i].RightAnswer = int.Parse(Console.ReadLine());
                    }

                }
            }











        }





    }
}
