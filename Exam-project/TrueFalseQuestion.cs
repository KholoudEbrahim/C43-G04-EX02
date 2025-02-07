using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_project
{
    public class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string header, string body, int mark)
            : base(header, body, mark)
        {
            AnswerList.Add(new Answer(1, "True"));
            AnswerList.Add(new Answer(2, "False"));
        }

        public override void DisplayQuestion()
        {
            Console.WriteLine("True/False Question:");
            Console.WriteLine($"Body: {Body}");
            Console.WriteLine($"Mark: {Mark}");
            foreach (var answer in AnswerList)
            {
                Console.WriteLine($"Answer ID: {answer.AnswerId}, Answer Text: {answer.AnswerText}");
            }
        }
    }
}
