using System;

namespace ConvertActivitesFromCPPToCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Factorial
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            int fact = 1;
            for(int i = 2; i<= number; i++)
            {                
                    fact = fact * i;
            }
            Console.Write("Factorial for " + number + " = " + fact);


            // Conditional Statements
            int n = 5;
            if (n > 0)
            {
                Console.WriteLine("\nPositive");
            }
            else
            {
                Console.WriteLine("\nNegaitve");
            }



            //Loops
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        }

    }
}
