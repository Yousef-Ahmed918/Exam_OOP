using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP.Questions
{
    internal class McqQuestion:Question

    {

        
        //private function to add the question choices
        private void QuestionChoices()
        {
            Console.WriteLine("Enter the Choices of the question");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Please Enter Choice Number{i + 1}");
                Answer[i]= new Answers()
                {
                    AnswerId = i+1,
                    AnswerText = Console.ReadLine()
                };
            }
        }
        //override the Question function 
        public override void HeaderOfTheQuestion()
        {
            Console.WriteLine("MCQ Question");
        }
        //override the Question function to add the questions choices
        public override void BodyOfTheQuestion()
        {
            base.BodyOfTheQuestion();
            QuestionChoices();
        }
        public override string ToString()
        {
            return base.ToString() +
                $"{Answer[0].AnswerText}" +
                $"{Answer[1].AnswerText}" +
                $"{Answer[2].AnswerText}";
        }
    }
}
