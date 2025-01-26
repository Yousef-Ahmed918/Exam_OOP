using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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
        public int Grade=0;
        public int TotalMarks=0;
        public int Answer;
        public Question[] questions {  get; set; }
        //function to set the time of the exam
        public virtual void TimeOfExam()
        {
            while (true)
            {
                Console.WriteLine("Enter the Time For The Exam (From [30 : 180] Min)");
                if((int.TryParse(Console.ReadLine(), out int time) && time >= 30 && time <= 180)){
                       Time = time;
                break;
                }
                Console.WriteLine("Enter valid Exam Time\nThe Exam Time From 30 Min To 180 Min ");
            }
        }
        //function to set the number of the question
        public virtual void NumberOfQuestions()
        {
            while (true)
            {
                Console.WriteLine("Enter The Number Of Questions");
                if((int.TryParse(Console.ReadLine(), out int number) && number > 0)){
                    Number = number;
                questions = new Question[Number];
                break;
                }
                Console.WriteLine("Enter valid positive Questions Number");
            }
        }
        //function to create the questions

        public abstract void CreateQuestion();
        
        public virtual void ShowQuestion()
        {
        }
        public virtual void TakeExam()
        {
            foreach (Question question in questions)
            {
                Console.WriteLine(question);
                Console.WriteLine("Enter the Question Answer ID");
                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out int answer) && answer >= 0 && answer <= 3)
                    {
                        Answer = answer;
                        break;
                    }
                    Console.WriteLine("Enter valid Answer Id (From 1:3))");
                }
                if (question.RightAnswer.AnswerId == Answer)
                {
                    Grade += question.Mark;
                }
                TotalMarks += question.Mark;
                Console.Clear();
            }
        }

    }

    }
