using System;

namespace ComputeAverageApp
{
    class ComputeAverageProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine(  "┌─────────────────────────────────────────────────────┐" +
                              "\n│                 COMPUTE AVERAGE APP                 │" +
                              "\n└─────────────────────────────────────────────────────┘" +
                              "\n - Enter 5 grades separated by new line" +
                              "");
            double sum = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write(" -> ");
                double grade = Convert.ToDouble(Console.ReadLine());
                sum += grade;
            }

            double average = sum / 5;
            double roundAverage = Math.Round(average);


            Console.WriteLine("The average is " + average + " and round off to " + roundAverage);
                                
            Console.WriteLine("\npress any key to exit...");
            Console.ReadKey();

        }
    }
}