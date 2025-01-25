using System.Diagnostics.SymbolStore;
using Exam_OOP.Questions;

namespace Exam_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject=new Subject(15,"Arabic");
            subject.CreateExam();
        }
    }
}
