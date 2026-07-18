// ****************************************************** 1 *******************************************************
// ************************************************** WirteLine *******************************************************
/*
using System;


namespace Course14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("My name is Dana Abu Elaish");
            Console.WriteLine("I'm Learning C#");
            Console.WriteLine("It is an easy language to learn :-)");
            Console.WriteLine("The sum of 10 + 20 = " + (10 + 20));

            Console.ReadKey();
        }
    }
}
*/























// ****************************************************** 2 *******************************************************
// ************************************************** Wirte *******************************************************
/*
using System;


namespace Course14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("My name is Dana Abu Elaish");
            Console.Write("I'm Learning C#");
            Console.Write("It is an easy language to learn :-)");
            Console.Write("The sum of 10 + 20 = " + (10 + 20));
            Console.ReadKey();
        }
    }
}
*/






















// ****************************************************** 3 *******************************************************
// ************************************************** Formatted String *******************************************************
/*
using System;


namespace Course14
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("{0} {1}", "Welcome to", "Programming Advices");
            Console.WriteLine("Hi my name is : {0} I Live in {1}", "Dana", "Palestine");
            Console.ReadKey();
        }
    }
}
*/























// ****************************************************** 4 *******************************************************
// ************************************************** Escape Characters *******************************************************
/*
using System;


namespace Course14
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Useful Escape Characters:\n");

            //NewLine 
            Console.WriteLine("NewLine:");
            Console.WriteLine("Welcome to \n Programming Advices\n");

            //Tab
            Console.WriteLine("Tab: ");
            Console.WriteLine("Welcome to \tProgramming Advices\n");

            //Backspace
            Console.WriteLine("Backspace:");
            Console.WriteLine("Welcome to \bProgramming Advices\n");

            //Single Quote
            Console.WriteLine("Single Quate : ");
            Console.WriteLine("Welcome to \'Programming  Advices\n");

            //Double Quote
            Console.WriteLine("Double Quate : ");
            Console.WriteLine("Welcome to \\Programming  Advices\n");

            //Alert
            Console.WriteLine("Alert : ");
            Console.WriteLine("\a");

            Console.ReadKey();

        }
    }
}
*/






















// ****************************************************** 5 *******************************************************
// *************************************** Single Line/Multiple Lines Comments *******************************************************

//using System;


//namespace Course14
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //This is a single line comment
//            Console.WriteLine("My name is Dana Abu Elaish");

//            /*
//             This is
//            a multiple line
//            comment.
//             */



//        }
//    }
//}






















// ****************************************************** 6 *******************************************************
// ************************************************** Vairables *******************************************************
/*
using System;


namespace Course14
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string myName = "Dana Abu Elaish";
            Console.WriteLine(myName);

            int x=10 ; int y = 20;

            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);

            //This Line Will Give Wrong Answer :-(
            Console.WriteLine("X + Y = " + x + y);

            //This Line Will Give Right Answer :-)
            Console.WriteLine("X + Y = " + (x + y));

            //Other common data types
            double myDouble = 25.89D;
            char myLetter = 'D';
            bool myBool = true;

            Console.ReadKey();

        }
    }
}
*/




















// ****************************************************** 8 *******************************************************
// ***************************************** Implicitly Typed Variables *******************************************

using System;


namespace Course14
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var x = 10;
            var y = 10.5;
            var z = "Dana";

            Console.WriteLine("X = {0} , Y = {1} , Z = {2}", x, y, z);
            
            Console.ReadKey();

        }
    }
}