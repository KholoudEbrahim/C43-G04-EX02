using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_project
{
    public class Question : ICloneable, IComparable<Question>
    {
        protected string Header { get; set; }
        protected string Body { get; set; }
        protected int Mark { get; set; }
        protected List<Answer> AnswerList { get; set; }
        protected int RightAnswerId { get; set; }

        protected Question(string header, string body, int mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
            AnswerList = new List<Answer>();
        }

        public virtual void DisplayQuestion()
        {
            Console.WriteLine($"Header: {Header}");
            Console.WriteLine($"Body: {Body}");
            Console.WriteLine($"Mark: {Mark}");

            foreach (var answer in AnswerList)
             Console.WriteLine($"Answer ID: {answer.AnswerId}, Answer Text: {answer.AnswerText}");
            
        }
       

        public object Clone()
        {
            return new Question(Header, Body, Mark);
        }

        public int CompareTo(Question other)
        {
            return Mark.CompareTo(other.Mark);
        }

        public override string ToString()
        {
            return $"Header: {Header}, Body: {Body}, Mark: {Mark}";
        }

    }
}
