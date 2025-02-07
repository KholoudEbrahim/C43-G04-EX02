namespace Exam_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examType;
            bool IsValidInput;


            do
            {
                Console.WriteLine("Please Enter the type of Exam (1 for Practical, 2 for Final):");
                IsValidInput = int.TryParse(Console.ReadLine(), out examType);



                if (!IsValidInput || (examType != 1 && examType != 2))
                {
                    Console.WriteLine("Invalid input. Please enter 1 for Practical or 2 for Final");
                }
            } while (!IsValidInput || (examType != 1 && examType != 2));



            int time;



            do
            {
                Console.WriteLine("Please Enter the Time For Exam (From 30 min to 180 min):");
                IsValidInput = int.TryParse(Console.ReadLine(), out time);

                if (!IsValidInput || time < 30 || time > 180)
                {
                    Console.WriteLine("Invalid input. Please enter a time between 30 and 180 minutes");
                }
            } while (!IsValidInput || time < 30 || time > 180);

            int numberOfQuestions;

            do
            {
                Console.WriteLine("Please Enter the Number of Questions:");
                IsValidInput = int.TryParse(Console.ReadLine(), out numberOfQuestions);

                if (!IsValidInput || numberOfQuestions <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive number");
                }
            } while (!IsValidInput || numberOfQuestions <= 0);


            Exam exam;


            if (examType == 1)
                exam = new PracticalExam(time, numberOfQuestions);
            else
                exam = new FinalExam(time, numberOfQuestions);


            for (int i = 0; i < numberOfQuestions; i++)
            {

                int questionType, mark, rightAnswerId;

                if (exam is PracticalExam) // Parctical accept MCQ only 
                {
                    questionType = 1;
                    Console.WriteLine("Practical Exam accepts only MCQ questions");
                }
                else
                {
                    do
                    {
                        Console.WriteLine("Please Enter the Type of Question (1 for MCQ, 2 for True/False):");
                        IsValidInput = int.TryParse(Console.ReadLine(), out questionType);

                        if (!IsValidInput || (questionType != 1 && questionType != 2))
                            Console.WriteLine("Invalid input. Please enter 1 for MCQ or 2 for True/False");


                    } while (!IsValidInput || (questionType != 1 && questionType != 2));
                }

                Console.WriteLine("Please Enter Question Body:");
                string body = Console.ReadLine()!;


                do
                {
                    Console.WriteLine("Please Enter Question Mark:");
                    IsValidInput = int.TryParse(Console.ReadLine(), out mark);

                    if (!IsValidInput || mark <= 0)
                    Console.WriteLine("Invalid input. Please enter a positive number");
                    
                } while (!IsValidInput || mark <= 0);

                Question question;
                if (questionType == 1)
                {
                    question = new MCQQuestion("MCQ", body, mark);


                    for (int j = 1; j <= 3; j++)
                    {
                        Console.WriteLine($"Please Enter Choice number {j}:");
                        string choice = Console.ReadLine()!;
                        question.AnswerList.Add(new Answer(j, choice));
                    }


                    do
                    {
                        Console.WriteLine("Please Enter the Right Answer ID (1, 2, or 3):");
                        IsValidInput = int.TryParse(Console.ReadLine(), out rightAnswerId);
                        if (!IsValidInput || rightAnswerId < 1 || rightAnswerId > 3)
                        {
                            Console.WriteLine("Invalid input. Please enter 1, 2, or 3");
                        }
                    } while (!IsValidInput || rightAnswerId < 1 || rightAnswerId > 3);

                    question.RightAnswerId = rightAnswerId;
                }
                else
                {
                    question = new TrueFalseQuestion("True/False", body, mark);


                    do
                    {
                        Console.WriteLine("Please Enter the Right Answer ID (1 for True, 2 for False):");
                        IsValidInput = int.TryParse(Console.ReadLine(), out rightAnswerId);
                        if (!IsValidInput || (rightAnswerId != 1 && rightAnswerId != 2))
                        {
                            Console.WriteLine("Invalid input. Please enter 1 for True or 2 for False");
                        }
                    } while (!IsValidInput || (rightAnswerId != 1 && rightAnswerId != 2));

                    question.RightAnswerId = rightAnswerId;
                }

 exam.Questions.Add(question);
            }


            int startExam;

            do
            {
                Console.WriteLine("Do you want to start the exam? (1 for Yes, 2 for No):");
                IsValidInput = int.TryParse(Console.ReadLine(), out startExam);


                if (!IsValidInput || (startExam != 1 && startExam != 2))
                {
                    Console.WriteLine("Invalid input. Please enter 1 for Yes or 2 for No");
                }
            } while (!IsValidInput || (startExam != 1 && startExam != 2));

            if (startExam == 1)
            {
                exam.ShowExam();
            }

            Console.WriteLine("Thank you!");
        }
    }
}
