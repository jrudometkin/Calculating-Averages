using System;

namespace EX_2A_CS_Calculating_Averages
{
    //1. Sum of numbers- Create a console application that will accept ten numbers between 0 and 100, and report their sum.

    //2. Average ten scores- Create a console application that will accept ten test scores between 0 and 100, average them, 
    //and report a letter grade for the average based on the usual scale.For example, a teacher will input ten test scores 
    //and see the average numerical grade and the letter grade.

    //3. Average a specific number of scores-Create a console application that will accept an arbitrary number test 
    //scores(as specified by the user) between 0 and 100, average them, and report a letter grade for the average 
    //based on the usual scale.For example, a teacher will input the total number of tests, then input ten test scores 
    //and see the average numerical grade and the letter grade.

    //4. Average a non-specific number of scores- Create a console application that will accept a number test 
    //scores(as calculated by the number of scores actually entered) between 0 and 100, average them, and report 
    //a letter grade for the average based on the usual scale.For example, a teacher will input any number test scores, 
    //and see the average numerical grade and the letter grade.

    class Program
    {
        static void Main(string[] args)
        {
            int entry;

            Console.WriteLine("***Calculating Averages***");
            Console.WriteLine("");
            Console.WriteLine("Select the cooresponding number of the formula you would like to complete.");
            Console.WriteLine("");
            Console.WriteLine("1. Sum of 10 numbers");
            Console.WriteLine("");
            Console.WriteLine("2. average 10 scores");
            Console.WriteLine("");
            Console.WriteLine("3. Average user entered number of scores");
            Console.WriteLine("");
            Console.WriteLine("4. Average whatever numbers you enter");
            Console.WriteLine("");
            Console.Write("Enter number: ");

            entry = int.Parse(Console.ReadLine());

            switch (entry)
            {
            
            case 1:

                    static void sumOfNumbers(); 


                break;

            case 2:

                Console.WriteLine($"Enter 10 numbers(hit return after each number)");
                Console.ReadLine();
                break;

            case 3:

                Console.WriteLine($"Enter 10 numbers(hit return after each number)");
                Console.ReadLine();
                break;

            case 4:

                Console.WriteLine($"Enter 10 numbers(hit return after each number)");
                Console.ReadLine();
                break;

                default:
                break;
            }

            sumOfNumbers()
                { 
            Console.WriteLine($"Enter 10 numbers(hit return after each number)");
            Console.Write("Enter 1st value: ");
            int firstNumber = Int32.Parse(Console.ReadLine());

            Console.Write("Enter 2nd value: ");
            int secondNumber = Int32.Parse(Console.ReadLine());

            Console.Write("Enter 3rd value: ");
            int thirdNumber = Int32.Parse(Console.ReadLine());

            Console.Write("Enter 4th value: ");
            int fourthNumber = Int32.Parse(Console.ReadLine());

            Console.Write("Enter 5th value: ");
            int fifthNumber = Int32.Parse(Console.ReadLine());

            Console.Write("Enter 6th value: ");
            int sixthNumber = Int32.Parse(Console.ReadLine());

            Console.Write("Enter 7th value: ");
            int seventhNumber = Int32.Parse(Console.ReadLine());

            Console.Write("Enter 8th value: ");
            int eighthNumber = Int32.Parse(Console.ReadLine());

            Console.Write("Enter 9th value: ");
            int ninthNumber = Int32.Parse(Console.ReadLine());

            Console.Write("Enter 10th valu: ");
            int tenthNumber = Int32.Parse(Console.ReadLine());

            static double sumOfNumbers()
                {
                //1. Sum of numbers- Create a console application that will accept ten numbers between 0 and 100, and report their sum.
               // Console.Write("Input 10 numbers to add : ");
               // {
                    

                   // return answer;
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

 
