using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP.Questions
{
    internal abstract class Question
    {
        public string Body;
        public string Header;
        public int Mark;
        public Answers[] Answer { get; set; }= new Answers[3];
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
        //validation
        public virtual void QuestionMark() {
            while (true)
            {
                Console.WriteLine("Enter the Mark of the Question");
                if((int.TryParse(Console.ReadLine(), out int mark) && mark > 0)){
                    Mark=mark;
                    break;
                }
                Console.WriteLine("Enter valid Question Mark");
            }
        }
        public  override string ToString()
        {
            return $"{Header}\t\t{Mark} Marks\n{Body}\n";
        }
    }
}
