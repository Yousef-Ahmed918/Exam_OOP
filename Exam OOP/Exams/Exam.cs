using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Exam_OOP.Questions;

namespace Exam_OOP.Exams
{
    internal abstract class  Exam
    {
       
        public int Number;
        int Time;
        public Question[] questions {  get; set; }
        //function to set the time of the exam
        public virtual void TimeOfExam()
        {
            Console.WriteLine("Enter the Time For The Exam (From [30 : 180] Min)");
            int.TryParse(Console.ReadLine(), out Time);
        }
        //function to set the number of the question
        public virtual void NumberOfQuestions()
        {
            Console.WriteLine("Enter The Number Of Questions");
            int.TryParse(Console.ReadLine(),out Number);
        }
        //function to create the questions

        public virtual  void CreateQuestion()
        {
            
        }
        public virtual void ShowQuestion()
        {
            foreach (Question question in questions)
            {
                questions.ToString();
            }
        }

    }
}
