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
            for (int i = 0; i < Answer.Length; i++)
            {
                Console.WriteLine($"Please Enter Choice Number{i + 1}");
                Answer[i]= new Answers()
                {
                    AnswerId = i+1,
                    AnswerText = Console.ReadLine()
                };
            }
            while (true)
            {
                Console.WriteLine("Enter the Correct Answer For the question");
                if ((int.TryParse(Console.ReadLine(), out int result) && result >= 1 && result <= 3))
                {
                    RightAnswer = Answer[result - 1];
                    break;
                }
                Console.WriteLine("Enter valid Answer choice From [1:3]");
            }
            }
        //override the Question function 
        public override void HeaderOfTheQuestion()
        {
            Header="MCQ Question";
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
                $"{Answer[0].AnswerId}.{Answer[0].AnswerText}\n" +
                $"{Answer[1].AnswerId}.{Answer[1].AnswerText}\n" +
                $"{Answer[2].AnswerId}.{Answer[2].AnswerText}\n";
        }
    }
}
