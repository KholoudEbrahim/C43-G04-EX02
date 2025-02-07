using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_project
{
    public class Subject
    {
        protected int SubjectId { get; set; }
        protected string SubjectName { get; set; }
        protected Exam Exam { get; set; }

        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }

        public void CreateExam(Exam exam)
        {
            Exam = exam;
        }

        public void DisplaySubjectInfo()
        {
            Console.WriteLine($"Subject ID: {SubjectId}, Subject Name: {SubjectName}");
            Exam.ShowExam();
        }
    }
}
