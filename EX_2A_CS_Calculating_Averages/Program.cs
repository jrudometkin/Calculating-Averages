using System;

namespace EX_2A_CS_Calculating_Averages
{ 
    class Program
    {
        public static double total { get; private set; }
        public static double avg { get; private set; }
        public static string grade { get; private set; }
        public static int userEnteredNumber { get; private set; }
        static void Main(string[] args)
        {
            int entry;
            /////version 3

            Console.WriteLine("***Calculating Averages***\n");
            Console.WriteLine("Select the cooresponding number of the formula you would like to complete.\n");
            Console.WriteLine("1. Sum of 10 numbers\n\n2. average 10 scores\n\n3. Average user entered number of scores\n\n" +
                "4. Average whatever numbers you enter\n");
            Console.Write("Enter number: ");

            entry = int.Parse(Console.ReadLine());

            switch (entry)
            {
            
            case 1:
                    //1. Sum of numbers- Create a console application that will accept ten numbers between 0 and 100, and report their sum.
                    
                    Console.WriteLine($"Enter 10 numbers(hit return after each number)");
                    total = 0;
                    for (int i = 0; i < 10; i++)
                    {
                       double nextNumber = Double.Parse(Console.ReadLine());
                       total += nextNumber;
                    }
                    Console.WriteLine($"\nThe total of those 10 number is {total }");

                    break;

            case 2:
                    //2. Average ten scores- Create a console application that will accept ten test scores between 0 and 100, average them, 
                    //and report a letter grade for the average based on the usual scale.For example, a teacher will input ten test scores 
                    //and see the average numerical grade and the letter grade.

                    Console.WriteLine($"Enter 10 grades to average(hit return after each number)");
                    total = 0;
                    for (int i = 0; i < 10; i++)
                    {
                        double nextNumber = Double.Parse(Console.ReadLine());
                        total += nextNumber;
                    }
                    avg = total / 10;
                    Console.Write(avg);
                    string grade = calculateGrade(avg);
                    Console.WriteLine($" -- {grade} ");
                    break;
             case 3:
                    //3. Average a specific number of scores-Create a console application that will accept an arbitrary number test 
                    //scores(as specified by the user) between 0 and 100, average them, and report a letter grade for the average 
                    //based on the usual scale.For example, a teacher will input the total number of tests, then input ten test scores 
                    //and see the average numerical grade and the letter grade.

                    Console.Write($"Enter how many grades you would like to average: ");
                    int userEnteredNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Enter {userEnteredNumber} grades: ");
                    total = 0;
                    for (int i = 0; i < userEnteredNumber; i++)
                    {
                        double nextNumber = Double.Parse(Console.ReadLine());
                        total += nextNumber;
                    }
                    avg = total / userEnteredNumber;
                    Console.Write(avg);
                    grade = calculateGrade(avg);
                    Console.WriteLine($" -- {grade} ");
                    break;

                case 4:
                    //4. Average a non-specific number of scores- Create a console application that will accept a number test 
                    //scores(as calculated by the number of scores actually entered) between 0 and 100, average them, and report 
                    //a letter grade for the average based on the usual scale.For example, a teacher will input any number test scores, 
                    //and see the average numerical grade and the letter grade.

                    Console.WriteLine($"Enter grades to average, when you are done entering scores, enter \"e\".");
                    userEnteredNumber = int.Parse(Console.ReadLine());

                    total = 0;
                    for (int i = 0; i < userEnteredNumber; i++)
                    {
                        double nextNumber = Double.Parse(Console.ReadLine());
                        total += nextNumber;
                    }
                    avg = total / userEnteredNumber;
                    Console.Write(avg);
                    grade = calculateGrade(avg);
                    Console.WriteLine($" -- {grade} ");
                    break;
           
                default:
                    Console.WriteLine("Please enter a number between 1 and 4.");
                    break;
            }
            Console.WriteLine("thanks.");
            }

        private static string calculateGrade(double intGrade)
        {
            string letterGrade;
            if (intGrade < 60)
                    {
                letterGrade = "F";
                return letterGrade;
            }
            else if (intGrade >= 60 && intGrade <= 69.99 )
            {
                return  "D";
            }
            else if (intGrade >= 70 && intGrade <= 79.99)
            {
                return "C";
            }
            else if (intGrade >= 80 && intGrade <= 89.99)
            {
                return "B";
            }
            else 
            {
                return "A";
            }
        }
        //static double avgTenScores()
        // {

    }
           // static double avgSpecificNumberOfScores()
           // {

            }
           // static double avgNonspecificNumberOfScores()
           // {

           // }
       // }
   // }
//}

 
