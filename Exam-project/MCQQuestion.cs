using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_project
{
    public class MCQQuestion : Question
    {
        public MCQQuestion(string header, string body, int mark)
            : base(header, body, mark) { }
      
        public override void DisplayQuestion()
        {
            Console.WriteLine("MCQ Question:");
            Console.WriteLine($"Body: {Body}");
            Console.WriteLine($"Mark: {Mark}");

            foreach (var answer in AnswerList)

             Console.WriteLine($"Answer ID: {answer.AnswerId}, Answer Text: {answer.AnswerText}");
            
        }
    }
}
