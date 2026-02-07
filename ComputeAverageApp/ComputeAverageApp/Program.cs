using System;

namespace ComputeAverageApp
{
    class ComputeAverageProgram
    {
        static void Main(string[] args)
        {
            double firstGrade, secondGrade, thirdGrade, fourthGrade, fifthGrade;

            Console.WriteLine("Enter 5 grades separated by new line");
            firstGrade = Convert.ToDouble(Console.ReadLine());
            secondGrade = Convert.ToDouble(Console.ReadLine());
            thirdGrade = Convert.ToDouble(Console.ReadLine());
            fourthGrade = Convert.ToDouble(Console.ReadLine());
            fifthGrade = Convert.ToDouble(Console.ReadLine());

            double average = (firstGrade + secondGrade + thirdGrade + fourthGrade + fifthGrade) / 5;

            double roundAverage = Math.Round(average);

            Console.WriteLine("The average is " + average + " and round off to " + roundAverage);

            Console.WriteLine("\npress any key to exit...");
            Console.ReadKey();

        }
    }
}