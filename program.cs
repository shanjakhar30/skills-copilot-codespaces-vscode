using System;

namespace CopilotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to GitHub Codespaces with Copilot!");
            // Use GitHub Copilot to generate code that calculates the factorial of a number.
            // Start by typing "Factorial" and see what suggestions you get.
            
            int number = 5;
            int result = Factorial(number);
            Console.WriteLine($"Factorial of {number} is {result}");
        }

        // Let GitHub Copilot help you complete this method
        static int Factorial(int n)
        {
            // Copilot should suggest code here!
            if (n <= 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
    }
}
