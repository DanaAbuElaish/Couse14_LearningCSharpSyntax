using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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

    class Person
    {
        public string Name { get; set; }

        private int age;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= 0)
                {
                    age = value;
                }
            }
        }
    }

    class FileResource : IDisposable
    {
        public FileResource()
        {
            Console.WriteLine("Open file");
        }

        public void Dispose()
        {
            Console.WriteLine("Close file");
        }
    }

    // Generic method that works with different data types
    class Utils
    {
        public static T Max<T>(T a, T b) where T : IComparable
        {
            if (a.CompareTo(b) > 0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }


    // Delegate example for calling methods
    delegate void Printer(int x);


    internal class Program
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        static void Print(int x)
        {
            Console.WriteLine(x);
        }


        // Async method that returns a value after waiting
        static async Task<int> GetValueAsync()
        {
            await Task.Delay(1000);
            return 42;
        }
        
        static async Task Main(string[] args)
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


            //Calling bird
            Bird b = new Bird();
            b.Fly();


            // Calling Person
            Person p = new Person();
            p.Name = "Dana";
            p.Age = 22;

            Console.WriteLine("Name: " + p.Name);
            Console.WriteLine("Age: " + p.Age);


            // Using IDisposable
            using (FileResource f = new FileResource())
            {
                Console.WriteLine("Work with file");
            }


            // Using Collections like List and Dictionary to store and manage data
            List<int> nums = new List<int>() { 1, 2, 3 };
            Dictionary<string, int> ages = new Dictionary<string, int>();



            // Exception handling using try-catch-finally
            try
            {
                throw new Exception("Error!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Done");
            }


            // Using Generics to create reusable methods with different data types
            int maxNumber = Utils.Max(10, 20);
            string maxString = Utils.Max("Apple", "Banana");

            Console.WriteLine("Max Number: " + maxNumber);
            Console.WriteLine("Max String: " + maxString);



            // Using Delegate to call methods dynamically
            Printer printer = new Printer(Print);
            printer(10);


            // Using Async/Await for asynchronous programming
            int result = await GetValueAsync();
            Console.WriteLine(result);
        }
    }
}
