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
        }
    }
}
