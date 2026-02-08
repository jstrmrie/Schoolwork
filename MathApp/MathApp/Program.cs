using System;

namespace MathApp
{
    class MathProgram
    {
        static void Main(string[] args)
        {
            Console.Write("┌─────────────────────────────────────────────────────┐" +
                          "\n│                 COMPUTE AVERAGE APP                 │" +
                          "\n└─────────────────────────────────────────────────────┘" +
            "\nChoose a Math Class method: " +
            "\n [1] MIN/MAX " +
            "\n [2] SQRT " +
            "\n [3] ABS " +
            "\n [4] POW " +
            "\n [5] ROUND " +
            "\n -> ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {

                Console.Write("Enter the first number: ");
                double firstNum = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double secondNum = Convert.ToDouble(Console.ReadLine());

                double lowest = Math.Min(firstNum, secondNum);
                double highest = Math.Max(firstNum, secondNum);

                Console.WriteLine(lowest + " is the smaller value and " + highest + " is the larger value between the two numbers.");

            }

            else if (choice == 2)
            {
                Console.Write("Enter a number: ");
                double firstNum = Convert.ToDouble(Console.ReadLine());

                double sqRoot = Math.Sqrt(firstNum);

                Console.WriteLine("The square root of " + firstNum + " is " + sqRoot);
            }

            else if (choice == 3)
            {
                Console.Write("Enter a number: ");
                double firstNum = Convert.ToDouble(Console.ReadLine());

                double absValue = Math.Abs(firstNum);

                Console.WriteLine("The absolute value of " + firstNum + " is " + absValue);
            }

            else if (choice == 4)
            {
                Console.Write("Enter the base value: ");
                double firstNum = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the power value: ");
                double secondNum = Convert.ToDouble(Console.ReadLine());

                double powValue = Math.Pow(firstNum, secondNum);

                Console.WriteLine(firstNum + " raised to the power of " + secondNum + " = " + powValue);

            }

            else if (choice == 5)
            {
                Console.Write("Enter a number: ");
                double firstNum = Convert.ToDouble(Console.ReadLine());

                double roundValue = Math.Round(firstNum);

                Console.WriteLine("The round off value of " + firstNum + " is " + roundValue);


            }

            else
            {
                Console.WriteLine("Please enter only choices above.");
            }

                Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();

        }
    }
}