using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_project
{
    public abstract class Exam
    {
        protected int Time { get; set; }
        protected int NumberOfQuestions { get; set; }
        protected List<Question> Questions { get; set; }



        public Exam(int time, int numberOfQuestions)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
            Questions = new List<Question>();
        }

        public abstract void ShowExam();
    }
}