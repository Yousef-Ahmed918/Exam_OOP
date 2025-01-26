using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam_OOP.Exams;
using Exam_OOP.Questions;

namespace Exam_OOP
{
    internal class Subject
    {
        int Type;
        //properities For the attrubutes
        public string SubjectName { get; set; }
        public Exam Exam { get; set; }
        public int SubjectId { get; set; }
        //parametirezed constructor
        public Subject(int id,string name)
        { 
            SubjectId = id;
            SubjectName = name;
        }
        //private function to get the type of the exam
        void TypeOfTheExam()
        {
            while (true)
            {
                Console.WriteLine("Enter The Type Of The Exam ((1) For Partial OR (2) For Final)");
                if((int.TryParse(Console.ReadLine(), out int type)) && type >= 1 && type <= 2)
                {
                    Type = type;
                    break;
                }
                Console.WriteLine("Enter valid Choice For the Exam Type");
            }
        }
        //function to Create an exam
        public void CreateExam()
        {
            TypeOfTheExam();
            if (Type == 1)
            {
                Exam = new PracticalExam();
                Exam.TimeOfExam();
                Exam.NumberOfQuestions();
                Console.Clear();
                Exam.CreateQuestion();
                Console.Clear();
                Console.WriteLine("Do you want to start the exam?(Y/N)");
                char start;
                char.TryParse(Console.ReadLine(), out start);
                if (char.ToUpper(start) == 'Y')
                {
                    Exam.TakeExam();
                    Exam.ShowQuestion();
                }
                else
                    return;
            }
            else
            {
                Exam = new FinalExam();
                Exam.TimeOfExam();
                Exam.NumberOfQuestions();
                Console.Clear();
                Exam.CreateQuestion();
                Console.Clear();
                Console.WriteLine("Do you want to start the exam?(Y/N)");
                char start;
                char.TryParse(Console.ReadLine(), out start);
                if (char.ToUpper(start) == 'Y')
                {
                    Exam.TakeExam();
                    Exam.ShowQuestion();
                }
                else
                    return;
            }
        }
    }
}
