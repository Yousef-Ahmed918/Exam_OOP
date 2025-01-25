using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP.Questions
{
    internal abstract class Question
    {
        string Body;
        string Header;
        int Mark;
        public Answers[] Answer { get; set; }
        public Answers RightAnswer {  get; set; }
        //function to add the header of the question
        public virtual void HeaderOfTheQuestion()
        {
        }
        
        //function to add the body of the question
        public virtual void BodyOfTheQuestion() 
        {
            Console.WriteLine("Enter The Body of The Question");
            Body = Console.ReadLine();
        }
        //function to add the mark of the question
        public virtual void QuestionMark() {
            Console.WriteLine("Enter the Mark of the Question");
            int.TryParse(Console.ReadLine(), out Mark);
        }
        public  override string ToString()
        {
            return $"{Header}           {Mark}" +
                   $"{Body}";
        }
    }
}
