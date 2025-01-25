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
            Console.WriteLine("True OR False Question");
        }
        //override to string
        public override string ToString()
        {
            return base.ToString() +
                $"(1) For True" +
                $"(2) For False";
        }

    }
}
