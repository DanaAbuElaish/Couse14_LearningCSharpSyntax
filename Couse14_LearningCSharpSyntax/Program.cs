using System;


namespace Couse14_LearningCSharpSyntax
{

    interface IFly
    {
        void Fly();
    }

    class Bird : IFly
    {
        public void Fly()
        {
            Console.WriteLine("Flying...");
        }
    }



    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog");
        }
    }

    internal class Program
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

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



            Console.WriteLine(Add(3, 4));


            //Calling dog
            Dog dog = new Dog();
            dog.Speak();


            //Cakking bird
            Bird b = new Bird();
            b.Fly();
        }
    }
}
