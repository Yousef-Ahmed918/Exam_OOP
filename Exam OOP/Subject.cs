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
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        //parametirezed constructor
        public Subject(int id,string name)
        { 
            SubjectId = id;
            SubjectName = name;
        }
        public Exam Exam { get; set; }
        //private function to get the type of the exam
        void TypeOfTheExam()
        {
            Console.WriteLine("Enter The Type Of The Exam ((1) For Partial OR (2) For Final)");
            int.TryParse(Console.ReadLine(), out Type);
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
                
                for (int i = 0; i < Exam.Number; i++)
                {
                    Exam.CreateQuestion();
                }
                
            }
            else
            {

                Exam = new FinalExam();
                Exam.TimeOfExam();
                Exam.NumberOfQuestions();
                for (int i = 0; i < Exam.Number; i++)
                {
                    Exam.CreateQuestion();
                }
            }
        }
    }
}
