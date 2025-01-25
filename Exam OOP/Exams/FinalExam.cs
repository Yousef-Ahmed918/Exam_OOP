using System;
using System.Collections.Generic;
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
            Console.WriteLine("Enter the type of the Question ((1) For MCQ OR (2) For True or False)");
            int.TryParse(Console.ReadLine(), out QuestionType);
        }
        //Function to create final exam question
        public override void CreateQuestion()
        {
            TypeOfQuestion();
            if (QuestionType == 1)
            {
                Question question = new McqQuestion();
                question.HeaderOfTheQuestion();
                question.QuestionMark();
                question.BodyOfTheQuestion();
                Console.WriteLine("Enter the Question Answer");
                question.RightAnswer.AnswerText=Console.ReadLine();
            }
            else
            {
                Question question = new TrueOrFalse_Question();
                question.HeaderOfTheQuestion();
                question.QuestionMark();
                question.BodyOfTheQuestion();
                Console.WriteLine("Enter the Question Answer");
                question.RightAnswer.AnswerText=Console.ReadLine();
            }
        }

    }
}
