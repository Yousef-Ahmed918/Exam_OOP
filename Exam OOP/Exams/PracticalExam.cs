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
            for (int i = 0; i < Number; i++)
            {
                questions[i] = new McqQuestion();
                questions[i].HeaderOfTheQuestion();
                questions[i].QuestionMark();
                questions[i].BodyOfTheQuestion();
                Console.Clear();
            }
        }
        public override void ShowQuestion()
        {
            foreach (Question question in questions)
            {
                Console.WriteLine($"{question.Body}\n" +
                    $"Right Answer:{question.RightAnswer.AnswerText}\n");
            }
            Console.WriteLine($"Thank You");
        }
    }
}
