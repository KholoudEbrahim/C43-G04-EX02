using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_project
{
    public class FinalExam : Exam
    {
        public FinalExam(int time, int numberOfQuestions)
            : base(time, numberOfQuestions)
        { }

        public override void ShowExam()
        {
            int totalMarks = 0;
            int userMarks = 0;

            Console.WriteLine("Final Exam:");
            foreach (var question in Questions)
            {
             question.DisplayQuestion();
                int userAnswer;
                bool isValidInput;

                do
                {
                  Console.WriteLine("Please enter your answer (Answer ID):");
                  isValidInput = int.TryParse(Console.ReadLine(), out userAnswer);

                  if (userAnswer < 1 || !isValidInput|| userAnswer > question.AnswerList.Count)
                    {
                    Console.WriteLine($"Invalid input. Please enter a number between 1 and {question.AnswerList.Count}.");
                    }
                } while (!isValidInput || userAnswer < 1 || userAnswer > question.AnswerList.Count);

                if (userAnswer == question.RightAnswerId)
                {
                    Console.WriteLine("Correct!");
                  userMarks += question.Mark;
                }
                else
                {
                    Console.WriteLine("Incorrect!");
                }


                totalMarks += question.Mark;


            }

            Console.WriteLine($"Your Grade: {userMarks} out of {totalMarks}");
        }

    }
}
