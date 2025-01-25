using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam_OOP.Questions;

namespace Exam_OOP.Exams
{
    internal class PracticalExam :Exam
    {
        //fuction to Create the questions
        public override void CreateQuestion()
        {
            Question question = new McqQuestion();
            question.HeaderOfTheQuestion();
            question.QuestionMark();
            question.BodyOfTheQuestion();
            Console.WriteLine("Enter the Question Answer");
            question.RightAnswer.AnswerText=(Console.ReadLine());

        }
        
        

    }
}
