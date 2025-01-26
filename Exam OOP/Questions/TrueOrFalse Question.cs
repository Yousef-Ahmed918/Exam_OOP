using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP.Questions
{
    internal class TrueOrFalse_Question :Question
    {
        //override the header question function 
        public override void HeaderOfTheQuestion()
        {
            Header="True OR False Question";
            Console.WriteLine("True OR False Question");
        }
        public override void BodyOfTheQuestion()
        {
            base.BodyOfTheQuestion();
            Console.WriteLine("Enter the Question Answer \n(1) For True  \n(2) For False");
            Answer[0]=new Answers() { AnswerId = 1 ,AnswerText="True"};
            Answer[1]=new Answers() { AnswerId = 2 ,AnswerText="False"};
            while (true)
            {
                Console.WriteLine("Enter the Correct Answer For the question");
                if ((int.TryParse(Console.ReadLine(), out int result) && result >= 1 && result <= 2))
                    {
                    RightAnswer = Answer[result - 1];
                    break;
                }
                Console.WriteLine("Enter valid Answer choice From [1:2]");
            }
        }
        //override to string
        public override string ToString()
        {
            return base.ToString() +
               $"{Answer[0].AnswerId}.{Answer[0].AnswerText} \n"+
               $"{Answer[1].AnswerId}.{Answer[1].AnswerText} \n";
        }

    }
}
