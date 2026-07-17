using System;

namespace Couse14_LearningCSharpSyntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            


            int x = 10;
            var y = 20;
            const double PI = 3.14;

            string s = "Hello";
            s = s + " World";
            Console.WriteLine(s);

            Console.Write("Enter number: ");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Value: " + d);


            int n = 5;
            if (n > 0)
            {
                Console.WriteLine("Positive");
            }
            else
            {
                Console.WriteLine("Non-positive");
            }


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
