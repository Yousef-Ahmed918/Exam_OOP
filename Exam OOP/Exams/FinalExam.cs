using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam_OOP.Questions;

namespace Exam_OOP.Exams 
{
    internal class FinalExam :Exam
    {
        int QuestionType;
        //function to set the type of the question
        void TypeOfQuestion()
        {
            while (true)
            {
                Console.WriteLine("Enter the type of the Question ((1) For MCQ OR (2) For True or False)");
             if((int.TryParse(Console.ReadLine(), out int questionType)&&questionType>=1&&questionType<=2))
                    {
                    QuestionType = questionType;
                    break;
                }
            }
        }
        //Function to create final exam question
        public override void CreateQuestion()
        {
            for (int i = 0; i < Number; i++) {
                TypeOfQuestion();
                if (QuestionType == 1)
                {
                    questions[i]= new McqQuestion();
                    questions[i].HeaderOfTheQuestion();
                    questions[i].QuestionMark();
                    questions[i].BodyOfTheQuestion();
                }
                else
                {
                     questions[i] = new TrueOrFalse_Question();
                     questions[i].HeaderOfTheQuestion();
                     questions[i].QuestionMark();
                     questions[i].BodyOfTheQuestion();
                }
                Console.Clear();
            }
        }
        public override void ShowQuestion()
        {
            foreach (Question question in questions)
            {
                Console.WriteLine($"{question.Body}\n" +
                    $"Your Answer:{question.Answer[Answer-1].AnswerText}\n" +
                    $"Right Answer:{question.RightAnswer.AnswerText}");
            }
                Console.WriteLine($"Your Grade is:{Grade} Of {TotalMarks}\nThank You");
        }

    }
}
