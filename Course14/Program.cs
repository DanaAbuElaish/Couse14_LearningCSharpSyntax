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
/*
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
*/




















// ****************************************************** 11 *******************************************************
// ***************************************** Numbers Datatypes *******************************************
/*
using System;


namespace Course14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Byte

            byte b1 = 255;
            // byte b2 = -128;    compile-time error: Constant value '-128' cannot be converted to a 'byte'
            sbyte sb1 = -128;
            sbyte sb2 = 127;
            Console.WriteLine("Byte : ");
            Console.WriteLine("Min = {0} , Max = {1} ",Byte.MinValue,Byte.MaxValue);

            Console.WriteLine("\nSByte : ");
            Console.WriteLine("Min = {0} , Max = {1} ",SByte.MinValue,SByte.MaxValue);


            //Short
            short s1 = -23768;
            short s2 = -128;
            // short s3 = 35000; //Compile-time error: Constant value '35000' cannot be converted to a 'short'
            ushort s3 = 65535;
            //  ushort us2 = -32000; //Compile-time error: Constant value '-32000' cannot be converted to a 'ushort'

            Console.WriteLine("\nShort : ");
            Console.WriteLine("Min = {0} , Max {1} = ", Int16.MinValue, Int16.MaxValue);

            Console.WriteLine("\nUShort : ");
            Console.WriteLine("Min = {0} , Max{1} = ", UInt16.MinValue, UInt16.MaxValue);


            //int
            int i = -2147483648;
            int j = 2147483647;
            //  int k = 4294967295; //Compile-time error: Cannot implicitly convert type 'uint' to 'int'.

            uint ui1 = 4294967295;
            // uint ui2 = -1; //Compile-time error: Constant value '-1' cannot be converted to a 'uint'

            Console.WriteLine("\nInt:");
            Console.WriteLine("Min={0} , Max={1}", Int32.MinValue, Int32.MaxValue);

            Console.WriteLine("\nUInt:");
            Console.WriteLine("Min={0} , Max={1}", UInt32.MinValue, UInt32.MaxValue);


            //Long
            long l1 = -9223372036854775808;
            long l2 = 9223372036854775807;

            ulong ul1 = 18223372036854775808ul;
            ulong ul2 = 18223372036854775808UL;

            Console.WriteLine("\nLong:");
            Console.WriteLine("Min={0} , Max={1}", Int64.MinValue, Int64.MaxValue);

            Console.WriteLine("\nULong:");
            Console.WriteLine("Min={0} , Max={1}", UInt64.MinValue, UInt64.MaxValue);


            //Float
            float f1 = 123456.5F;
            float f2 = 1.123456f;

            Console.WriteLine("\nFloat:");
            Console.WriteLine("Min={0} , Max={1}", float.MinValue, float.MaxValue);




            //double
            double d1 = 12345678912345.5d;
            double d2 = 1.123456789123456d;

            Console.WriteLine("\nDouble:");
            Console.WriteLine("Min={0} , Max={1}", double.MinValue, double.MaxValue);


            //Decimal
            //The decimal type has more precision and a smaller range
            //than both float and double,
            //and so it is appropriate for financial and monetary calculations.
            decimal d3 = 123456789123456789123456789.5m;
            decimal d4 = 1.1234567891345679123456789123m;

            Console.WriteLine("\nDecimal:");
            Console.WriteLine("Min={0} , Max={1}", decimal.MinValue, decimal.MaxValue);


            //Scientific Notation
            //Use e or E to indicate the power of 10 
            //as exponent part of scientific notation with float, double or decimal.

            double d = 0.12e2;
            Console.WriteLine(d);  // 12;

            float f = 123.45e-2f;
            Console.WriteLine(f);  // 1.2345

            decimal m = 1.2e6m;
            Console.WriteLine(m);// 1200000


            //hex & Binary
            int hex = 0x2F;
            int binary = 0b_0010_1111;

            Console.WriteLine(hex);
            Console.WriteLine(binary);

            Console.ReadKey();

        }
    }
}
*/






















// ****************************************************** 12 *******************************************************
// ***************************************** Default Values *******************************************
/*
using System;


namespace Course14
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //get default value using default(type)
            int i = default(int); // 0
            float f = default(float);// 0
            decimal d = default(decimal);// 0
            bool b = default(bool);// false
            char c = default(char);// '\0'

            // C# 7.1 onwards
            //get default value using default
            int i2 = default; // 0
            float f2 = default;// 0
            decimal d2 = default;// 0
            bool b2 = default;// false
            char c2 = default;// '\0'



            Console.ReadKey();

        }
    }
}
*/

























// ****************************************************** 13 *******************************************************
// ***************************************************** Enums *****************************************************
/*
using System;


namespace Course14
{
    internal class Program
    {
        enum enWeekDays
        {
            Monday,   //0
            Tuesday,  //1
            Wednesday,//2
            Thursday, //3
            Friday,   //4
            Saturday, //5
            Sunday    //6
        }
        //if you set a value , it will auto number everything after it.
        enum enCategories
        {
            Electronics,    //0
            Food,           //1
            Automotive = 6, //6
            Arts,           //7
            BeautyCare,     //8
            Fashion         //9
        }

        //Enum can have any numarical data type byte, sbyte, short, ushort, int, uint, long, or ulong
        //but not string

        enum enCategories2 : byte
        {
            Electronics = 1,
            Food = 5,
            Automotive = 6,
            Arts = 10,
            BeautyCare = 11,
            Fashion = 15,
        }
        static void Main(string[] args)
        {

            enWeekDays weekDays;
            weekDays = enWeekDays.Friday;

            Console.ReadKey();

        }
    }
}
*/
























// ****************************************************** 14 *******************************************************
// ***************************************************** Nullable Types *****************************************************
/*
using System;

namespace Main
{
    internal class Program
    {

        static void Main(string[] args)
        {

            //  Nullable<int> can be assigned any value
            //  from -2147483648 to 2147483647, or a null value.

            Nullable<int> i = null;



            Console.ReadKey();

        }
    }
}

*/




















// ****************************************************** 15 *******************************************************
// ***************************************************** Anonymous Type *****************************************************
/*
using System;

namespace Main
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //you dont specify any type here , automatically will be specified
            var student = new { Id = 20, FirstName = "Dana", LastName = "Abu El-aish" };
            Console.WriteLine("\nExample1 : \n");
            Console.WriteLine(student.Id);
            Console.WriteLine(student.FirstName);
            Console.WriteLine(student.LastName);

            Console.WriteLine("\n\n-------------------------\n\n");
            // I can print like this
            Console.WriteLine(student);

            //anonymous types are read-only
            //you cannot change the values of properties as they are read-only.

            //student.Id = 2; //Error , Cannot Change Value
            //student.FirstName = "Ali"; //Error , Cannot Change Value

            //An anonymous type's property can include another anonymous type.

            var student2 = new
            {
                Id = 20,
                FirstName = "Dana",
                LastName = "Abu El-aish",
                Address = new { Id = 1, City = "Gaza", Country = "Palestine" }
            };

            Console.WriteLine("\n\nExample2 : \n");
            Console.WriteLine(student2.Id);
            Console.WriteLine(student2.FirstName);
            Console.WriteLine(student2.LastName);

            Console.WriteLine(student2.Address.Id);
            Console.WriteLine(student2.Address.City);
            Console.WriteLine(student2.Address.Country);
            Console.WriteLine(student2.Address);





            Console.ReadKey();

        }
    }
}
*/






















// ****************************************************** 16 *******************************************************
// ************************************************** Dynamic Type *****************************************************
/*
using System;

namespace Main
{
    internal class Program
    {

        static void Main(string[] args)
        {

            dynamic myDynamicVar = 100;
            Console.WriteLine("Value : {0}, Type : {1}", myDynamicVar, myDynamicVar.GetType());

            myDynamicVar = "Hello World!!";
            Console.WriteLine("Value : {0}, Type : {1}", myDynamicVar, myDynamicVar.GetType());

            myDynamicVar = true;
            Console.WriteLine("Value : {0}, Type : {1}", myDynamicVar, myDynamicVar.GetType());

            myDynamicVar = DateTime.Now;
            Console.WriteLine("Value : {0}, Type : {1}", myDynamicVar, myDynamicVar.GetType());



            Console.ReadKey();
        }
    }
}
*/






















// ****************************************************** 17 ******************************************************
// ********************************************** Set Date & Time *************************************************
/*
using System;

namespace Main
{
    internal class Program
    {

        static void Main(string[] args)
        {

            //assigns default value 01/01/0001 00:00:00
            DateTime dt1 = new DateTime();

            //assigns year, month, day
            DateTime dt2 = new DateTime(2023, 12, 31);

            //assigns year, month, day, hour, min, seconds
            DateTime dt3 = new DateTime(2023, 12, 31, 5, 10, 20);

            //assigns year, month, day, hour, min, seconds, UTC timezone
            DateTime dt4 = new DateTime(2023, 12, 31, 5, 10, 20, DateTimeKind.Utc);

            Console.WriteLine(dt1);
            Console.WriteLine(dt2);
            Console.WriteLine(dt3);
            Console.WriteLine(dt4);

            Console.ReadKey();
        }
    }
}
*/






















// ****************************************************** 18 ******************************************************
// ********************************************** Get Current Datetime *************************************************
/*
using System;

namespace Main
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //assigns default value 01/01/0001 00:00:00
            DateTime dt1 = new DateTime();

            dt1 = DateTime.Now;
            Console.WriteLine(dt1);
            Console.ReadKey();
        }

    }
}
*/






















// ****************************************************** 19 ******************************************************
// ***************************************************** Ticks ****************************************************
/*
using System;

namespace Main
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //number of 100-nanosecond intervals that have elapsed
            //since January 1, 0001, at 00:00:00.000 in the Gregorian calendar. 

            DateTime dt = new DateTime();
            Console.WriteLine(DateTime.MinValue.Ticks);  //min value of ticks
            Console.WriteLine(DateTime.MaxValue.Ticks); // max value of ticks


            Console.ReadKey();
        }
    }
}
*/


















// *********************************************************** 20 ******************************************************
// *********************************************** Datetime Static Fields***********************************************
/*
using System;

namespace Main
{
    internal class Program
    {

        static void Main(string[] args)
        {

            DateTime currentDateTime = DateTime.Now;         //returns current date and time
            DateTime todayDateTime = DateTime.Today;        // returns today's date
            DateTime currentDateTimeUTC = DateTime.UtcNow;  // returns current UTC date and time
            DateTime maxDateTimeValue = DateTime.MaxValue;  // returns max value of DateTime
            DateTime minDateTimeValue = DateTime.MinValue;  // returns min value of DateTime


            Console.WriteLine("Current DateTime : " + currentDateTime);
            Console.WriteLine("Today DateTime : " + todayDateTime);
            Console.WriteLine("Current DateTime UTC : " + currentDateTimeUTC);
            Console.WriteLine("Max DateTime Value : " + maxDateTimeValue);
            Console.WriteLine("Min DateTime Value : " + minDateTimeValue);

            Console.ReadKey();
        }
    }
}
*/




















// *********************************************************** 21 ******************************************************
// ******************************************************* Time Span ***************************************************
/*
using System;

namespace Main
{
    internal class Program
    {

        static void Main(string[] args)
        {

            DateTime dt = new DateTime(2026, 7, 22);

            // Hours, Minutes, Seconds
            TimeSpan ts = new TimeSpan(49, 25, 34);
            Console.WriteLine(ts);
            Console.WriteLine(ts.Days);
            Console.WriteLine(ts.Hours);
            Console.WriteLine(ts.Minutes);
            Console.WriteLine(ts.Seconds);

            //this will add time span to the date.
            DateTime newDate = dt.Add(ts);

            Console.WriteLine(newDate);

            Console.ReadKey();
        }
    }
}
*/




















// *********************************************************** 22 *************************************************************
// ************************************ Subtraction of two dates results in TimeSpan ******************************************
/*
using System;


namespace Main
{
    internal class Program
    {

        static void Main(string[] args)
        {

            DateTime dt1 = new DateTime(2026, 7, 22);
            DateTime dt2 = new DateTime(2026, 7, 26);
            TimeSpan result = dt2.Subtract(dt1);

            Console.WriteLine(result.Days);

            Console.ReadKey();
        }
    }
}
*/




















// *********************************************************** 23 *************************************************************
// ******************************************************* Operators ******************************************
/*
using System;


namespace Main
{
    internal class Program
    {

        static void Main(string[] args)
        {

            DateTime dt1 = new DateTime(2015, 12, 20);
            DateTime dt2 = new DateTime(2016, 12, 31, 5, 10, 20);
            TimeSpan time = new TimeSpan(10, 5, 25, 50);

            Console.WriteLine(dt2 + time);
            Console.WriteLine(dt2 - dt1);
            Console.WriteLine(dt1 == dt2);
            Console.WriteLine(dt1 != dt2);
            Console.WriteLine(dt1 > dt2);
            Console.WriteLine(dt1 < dt2);
            Console.WriteLine(dt1 >= dt2);
            Console.WriteLine(dt1 <= dt2);

            Console.ReadKey();
        }
    }
}
*/



















// *********************************************************** 24 *************************************************************
// *************************************************** Convert String to DateTime *************************************
/*
using System;


namespace Main
{
    internal class Program
    {

        static void Main(string[] args)
        {

            var str = "6/12/2023";
            DateTime dt;

            var isValidDate = DateTime.TryParse(str,out dt);

            if (isValidDate)
            {
                Console.WriteLine(dt);
            }
            else
            {
                Console.WriteLine($"{str} is not a valid date string");

            }


            //invalid string date
            var str2 = "6/65/2023";
            DateTime dt2;

            var isValidDate2 = DateTime.TryParse(str2, out dt2);

            if (isValidDate2)
                Console.WriteLine(dt2);
            else
                Console.WriteLine($"{str2} is not a valid date string");

            Console.ReadKey();
        }
    }
}
*/



















// *********************************************************** 25 *************************************************************
// *************************************************** Quick Overview C# Strings *************************************
/*
using System;



namespace Main
{
    internal class Program
    {

        static void Main(string[] args)
        {

            string S1 = "Dana Abu Elaish";

            Console.WriteLine(S1.Length);

            //this will take 5 characters staring position 2
            Console.WriteLine(S1.Substring(2, 5));
            Console.WriteLine(S1.ToLower());
            Console.WriteLine(S1.ToUpper());
            Console.WriteLine(S1[2]);
            Console.WriteLine(S1.Insert(3, "KKKK"));
            Console.WriteLine(S1.Replace("n", "*"));
            Console.WriteLine(S1.IndexOf("n"));
            Console.WriteLine(S1.Contains("n"));
            Console.WriteLine(S1.Contains("x"));
            Console.WriteLine(S1.LastIndexOf("n"));

            string S2 = "Ali,Ahmed,Khalid";

            string[] NamesList = S2.Split(',');

            Console.WriteLine(NamesList[0]);
            Console.WriteLine(NamesList[1]);
            Console.WriteLine(NamesList[2]);

            string S3 = "  Abu-Elaish  ";
            Console.WriteLine(S3.Trim());
            Console.WriteLine(S3.TrimStart());
            Console.WriteLine(S3.TrimEnd());


            Console.ReadKey();
        }
    }
}
*/





















// *********************************************************** 26 *************************************************************
// *************************************************** String Interpolation *************************************
/*
using System;

namespace Main
{
    internal class Program
    {

        static void Main(string[] args)
        {

            //  String Interpolation

            string firstName = "Dana";
            string lastName = "Abu Elaish";
            string code = "107";

            //You shold use $ to $ to identify an interpolated string 
            string fullName = $"Eng. {firstName} {lastName}, Code :{code}";

            Console.WriteLine(fullName);   

            Console.ReadKey();
        }
    }
}
*/




















// *********************************************************** 28 *************************************************************
// *************************************************** Implicit Casting *************************************
/*
using System;

namespace Main
{
    internal class Program
    {

        static void Main(string[] args)
        {

            int myInt = 17;
            double myDouble = myInt;         // Automatic casting: int to double


            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);

            Console.ReadKey();
        }
    }
}
*/




















// *********************************************************** 29 *************************************************************
// *************************************************** Explicit Casting *************************************
/*
using System;

namespace Main
{
    internal class Program
    {

        static void Main(string[] args)
        {


            double myDouble = 17.58;         
            int myInt = (int) myDouble;  // Manual casting: double to int

            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);

            Console.ReadKey();
        }
    }
}
*/























// *********************************************************** 30 *************************************************************
// *************************************************** Type Conversion Methods ***********************************
/*
using System;

namespace Main
{
    internal class Program
    {

        static void Main(string[] args)
        {

            int myInt = 20;
            double myDouble = 7.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));
            Console.WriteLine(Convert.ToDouble(myInt));
            Console.WriteLine(Convert.ToInt32(myDouble));
            Console.WriteLine(Convert.ToString(myBool));
           

            Console.ReadKey();
        }
    }
}
*/






















// *********************************************************** 31 *************************************************************
// ******************************************************* Casting Enums ***********************************
/*
using System;

namespace Main
{
    internal class Program
    {

        enum enWeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {

            Console.WriteLine(enWeekDays.Friday);
            int day = (int)enWeekDays.Friday;
            Console.WriteLine(day);

            var wd = (enWeekDays)5;
            Console.WriteLine(wd);

            Console.ReadKey();
        }
    }
}
*/


















// *********************************************************** 32 *************************************************************
// ******************************************************** ReadLine(); ***********************************
/*
using System;

namespace Main
{
    internal class Program
    {

        static void Main(string[] args)
        {


            // Type your username and press enter

            Console.WriteLine("Enter username : ");
            string username = Console.ReadLine();

            Console.WriteLine("Username is : " + username);

            Console.ReadKey();
        }
    }
}
*/






















// *********************************************************** 33 *************************************************************
// ***************************************************** User Input and Numbers ***********************************
/*
using System;

namespace Main
{
    internal class Program
    {

        static void Main(string[] args)
        {


            // Type your username and press enter

            Console.WriteLine("Enter Your Age : ");
           int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your age is : " + age);

            Console.ReadKey();
        }
    }
}
*/























// *********************************************************** 38 *************************************************************
// ***************************************************** Unary Operators ***********************************
/*
using System;

namespace Main
{
    internal class Program
    {

        static void Main(string[] args)
        {


            int number = 10, result;
            bool flag = true;

            result = +number;
            Console.WriteLine("+number = " + result);

            result = -number;
            Console.WriteLine("-number = " + result);

            result = ++number;
            Console.WriteLine("++number = " + result);

            result = --number;
            Console.WriteLine("--number = " + result);

            Console.WriteLine("!flag = " + (!flag));

            Console.WriteLine((number++));
            Console.WriteLine((number));

            Console.WriteLine((++number));
            Console.WriteLine((number));


            Console.ReadKey();
        }
    }
}
*/























// *********************************************************** 39 *************************************************************
// ***************************************************** Ternary Operators ***********************************
/*
using System;

namespace Main
{
    internal class Program
    {

        static void Main(string[] args)
        {


            int number = 12;
            string result;

            result = (number % 2 == 0) ? "Even Number" : "Odd Number";
            Console.WriteLine("{0} is {1}", number, result);


            Console.ReadKey();
        }
    }
}
*/























// *********************************************************** 41 *************************************************************
// ***************************************************** if, if...else, if...else if and Nested if Statement ***********************************
/*
using System;

namespace Main
{
    internal class Program
    {

        static void Main(string[] args)
        {


            int x = 10; int y = 20;

            //if then statement
            if (x == 10 && y <= 20)
            {
                Console.WriteLine("yes x = 10 and y<=20");
            }



            //if then else statement
            if (x == 11)
            {
                Console.WriteLine("yes x = 11 ");
            }
            else
            {
                Console.WriteLine("yes x != 11 ");
            }


            //if else if statement
            int number = 12;

            if (number < 5)
            {
                Console.WriteLine("{0} is less than 5", number);
            }
            else if (number > 5)
            {
                Console.WriteLine("{0} is greater than 5", number);
            }
            else
            {
                Console.WriteLine("{0} is equal to 5");
            }

            Console.ReadKey();
        }
    }
}
*/

















// *********************************************************** 42 *************************************************************
// ***************************************************** Switch Statement ***********************************
/*
using System;


namespace Main
{
    internal class Program
    {

        static void Main(string[] args)
        {

            //switch statement with grouped cases

            char ch;
            Console.WriteLine("Enter a letter");
            ch = Convert.ToChar(Console.ReadLine());

            switch (Char.ToLower(ch))
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Not a vowel");
                    break;
            }


            //switch statement with Break
            char ch2;
            Console.WriteLine("Enter a letter?");
            ch2 = Convert.ToChar(Console.ReadLine());

            switch (Char.ToLower(ch2))
            {
                case 'a':
                    Console.WriteLine("Vowel");
                    break;
                case 'e':
                    Console.WriteLine("Vowel");
                    break;
                case 'i':
                    Console.WriteLine("Vowel");
                    break;
                case 'o':
                    Console.WriteLine("Vowel");
                    break;
                case 'u':
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Not a vowel");
                    break;
            }




            // Simple Calculator

            char op;
            double firstNumber, secondNumber, result;

            Console.WriteLine("Enter First Number : ");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Second Number : ");
            secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Operator : [+,-,/,*] : ");
            op = Convert.ToChar(Console.ReadLine());


            switch (op)
            {
                case '+':
                    {
                        result = firstNumber + secondNumber;
                        Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, result);
                        break;
                    }

                case '-':
                    {
                        result = firstNumber - secondNumber;
                        Console.WriteLine("{0} - {1} = {2}", firstNumber, secondNumber, result);
                        break;
                    }

                case '/':
                    {
                        result = firstNumber / secondNumber;
                        Console.WriteLine("{0} / {1} = {2}", firstNumber, secondNumber, result);
                        break;
                    }

                case '*':
                    {
                        result = firstNumber * secondNumber;
                        Console.WriteLine("{0} * {1} = {2}", firstNumber, secondNumber, result);
                        break;
                    }

                default:
                    { 
                    Console.WriteLine("Invalid Operator");
                    break;
            } 
            }


            string name = "Dana";

            switch (name.ToLower())
            {
                case "dana":
                    {
                        Console.WriteLine("Yes Dana");
                        break;
                    }

                case "ali":
                    {
                        Console.WriteLine("Yes Ali");
                        break;
                    }

                default: 
                    {
                        Console.WriteLine("No Name Matched!");
                        break;
                    }
            }



            Console.ReadKey();
        }
    }
}
*/





















// *********************************************************** 44 *************************************************************
// ***************************************************** for loop ***********************************
/*
using System;


namespace Main
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Forward Loop : ");

            //Forward Loop
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }



            Console.WriteLine("Backward Loop : ");

            //Back Loop
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Nested Loops : ");
            //Forward Loop
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("i = {0} and j = {1}", i, j);
                }
            }

            Console.ReadKey();

        }
    }
}
*/





















// *********************************************************** 45 *************************************************************
// ***************************************************** while loop ***********************************
/*
using System;


namespace Main
{
    internal class Program
    {

        static void Main(string[] args)
        {

            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine("C# while Loop: Iteration {0}", i);
                i++;
            }

            Console.ReadKey();

        }
    }
}
*/
















// *********************************************************** 46 *************************************************************
// ***************************************************** do while loop ***********************************
/*
using System;


namespace Main
{
    internal class Program
    {

        static void Main(string[] args)
        {

            int i = 1;
            do
            {
                Console.WriteLine("C# do-while Loop: Iteration {0}", i);
                i++;

            } while (i <= 5);


            Console.ReadKey();

        }
    }
}
*/
























// *********************************************************** 47 *************************************************************
// ***************************************************** break Statement ******************************************************
/*
using System;


namespace Main
{
    internal class Program
    {

        static void Main(string[] args)
        {

            int i = 1;
            do
            {
                Console.WriteLine("C# do-while Loop: Iteration {0}", i);

                if (i == 3)
                {
                    break;
                }
                i++;

            } while (i <= 5);


            Console.ReadKey();

        }
    }
}
*/





















// *********************************************************** 48 *************************************************************
// ***************************************************** continue Statement ******************************************************
/*
using System;


namespace Main
{
    internal class Program
    {

        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; ++i)
            {

                if (i == 3)
                {
                    continue;
                }

                Console.WriteLine(i);
            }

            Console.ReadKey();

        }
    }
}
*/




















// *********************************************************** 52 *************************************************************
// *********************************************** Access Array Elements ******************************************************
/*
using System;


namespace Main
{
    internal class Program
    {

        static void Main(string[] args)
        {

            int[] numbers = { 1, 2, 3 };
            //access first element
            Console.WriteLine("Element in the first index : " + numbers[0]);
            //access second element
            Console.WriteLine("Element in the second index : " + numbers[1]);
            //access third element
            Console.WriteLine("Element in third index : " + numbers[2]);

            //Through loop
            Console.WriteLine("\nAccess array using loop : ");
            for (short i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Elements in index {0} : {1} ", i, numbers[i]);
            }

            Console.ReadKey();

        }
    }
}
*/



















// *********************************************************** 54 *************************************************************
// ************************************************* 2 Dimensional Array ******************************************************
/*
using System;


namespace Main
{
    internal class Program
    {

        static void Main(string[] args)
        {

            //initializing 2D array
            int[,] numbers = { { 12, 13 }, { 55, 77 } };

            // access first element from the first row
            Console.WriteLine("Elements at index [0,0] : " + numbers[0, 0]);

            // access first element from second row
            Console.WriteLine("Element at index [1,0] : " + numbers[1, 0]);

            Console.ReadKey();

        }
    }
}
*/


















// *********************************************************** 55 *************************************************************
// ************************************************* Syntax of foreach loop ******************************************************
/*
using System;


namespace Main
{
    internal class Program
    {

        static void Main(string[] args)
        {


            char[] myArray = { 'H', 'e', 'l', 'l', 'o' };

            foreach (char c in myArray)
            {
                Console.WriteLine(c);
            }








            char[] gender = { 'm', 'f', 'm', 'm', 'm', 'f', 'f', 'm', 'm', 'f' };
            int male = 0, female = 0;

            foreach (char g in gender)
            {
                {
                    if (g == 'm')
                    {
                        male++;
                    }else if (g == 'f')
                    {
                        female++;
                    }

                    }
                }
            Console.WriteLine("Number of male   = {0}", male);
            Console.WriteLine("Number of Female = {0}", female);


            Console.ReadKey();

        }
    }
}
*/





















// *********************************************************** 56 *************************************************************
// ****************************** Find Minimum and Maximum Element Using System.Linq *******************************************
/*
using System;


// provides us various methods to use in an array
using System.Linq;

namespace Main
{
    internal class Program
    {

        static void Main(string[] args)
        {

            // Note that we used System.Linq above.
            int[] numbers = { 51, -1, 2, 14, 18, 40, 178 };

            // get the minimum element
            Console.WriteLine("Smallest Element : " + numbers.Min());
            // Max() returns the largest number in array
            Console.WriteLine("Largest Element  : " + numbers.Max());


            Console.ReadKey();

        }
    }
}
*/



















// *********************************************************** 57 *************************************************************
// ************************************** Count , Sum And Average Using System.Linq *******************************************
/*
using System;


// provides us various methods to use in an array
using System.Linq;

namespace Main
{
    internal class Program
    {

        static void Main(string[] args)
        {

            // Note that we used System.Linq above.
            int[] numbers = { 20, 22, 19, 18, 1 };

            // compute count
            Console.WriteLine("Count     : " + numbers.Count());
            // compute sum
            Console.WriteLine("Sum       : " + numbers.Sum());
            // compute Average
            Console.WriteLine("Average   : " + numbers.Average());



            Console.ReadKey();

        }
    }
}
*/





















// *********************************************************** 58 *************************************************************
// ********************************************************* C# Math **********************************************************
/*
using System;

namespace Main
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Max of 5,10 is                       : {0}", Math.Max(5, 10));
            Console.WriteLine("Min of 5,10 is                       : {0}", Math.Min(5, 10));
            Console.WriteLine("Squir root of 64 is                  : {0}", Math.Sqrt(64));
            Console.WriteLine("Absolute (positive) value of -4.7 is : {0}", Math.Abs(-4.7));
            Console.WriteLine("Round of 9.99 is                     : {0}", Math.Round(9.99));

            Console.ReadKey();

        }
    }
}
*/





















// *********************************************************** 59 *************************************************************
// ********************************************************* C# Methods **********************************************************
/*
using System;

namespace Main
{
    internal class Program
    {

        static void funcPrintMyName()
        {
            Console.WriteLine("Dana Khaled Abu Elaish");
        }
        static void Main(string[] args)
        {

            funcPrintMyName();

            Console.ReadKey();

        }
    }
}
*/















// *********************************************************** 60 *************************************************************
// **************************************************** Method Parameters **********************************************************
/*
using System;

namespace Main
{
    internal class Program
    {

        static void funcPrintMyInfo(string name , byte age)
        {
            Console.WriteLine("Name : {0} , Age : {1}", name, age);
        }
        
        static void Main(string[] args)
        {

            funcPrintMyInfo("Dana Khaled Abu El-aish", 22);

            Console.ReadKey();

        }
    }
}
*/




















// *********************************************************** 61 *************************************************************
// *********************************************** Default Parameter Value **********************************************************
/*
using System;

namespace Main
{
    internal class Program
    {

        static void funcPrintMyInfo(string name , byte age , string address = "No Address")
        {
            Console.WriteLine("Name : {0} , Age : {1} , Address : {2}", name, age, address);
        }
        
        static void Main(string[] args)
        {

            funcPrintMyInfo("Dana Khaled Abu El-aish", 22);
            funcPrintMyInfo("Dana Khaled Abu El-aish", 22, "Gaza-Palestine");

            Console.ReadKey();

        }
    }
}
*/





















// *********************************************************** 62 ************************************************************
// ******************************************************* Return Values **********************************************************
/*
using System;

namespace Main
{
    internal class Program
    {

        static string funcGetMyName()
        {
            return "Dana Khaled Abu El-aish";
        }
        
        static void Main(string[] args)
        {

            Console.WriteLine("My Name is : {0}", funcGetMyName());

            Console.ReadKey();

        }
    }
}
*/





















// *********************************************************** 63 ************************************************************
// ***************************************************** Named Arguments **********************************************************
/*
using System;

namespace Main
{
    internal class Program
    {

        static void funcMyMethod(string child1 , string child2 , string child3)
        {
            Console.WriteLine("The Youngest child is : " + child3);
        }
        
        static void Main(string[] args)
        {

            //see the order of sending parameters is not important.
            funcMyMethod(child3: "Hala", child1: "Dana", child2: "Salma");

            Console.ReadKey();

        }
    }
}
*/





















// *********************************************************** 64 ************************************************************
// ***************************************************** Method Overloading **********************************************************
/*
using System;

namespace Main
{
    internal class Program
    {

        static int Sum(int Num1, int Num2)

        {
            return Num1 + Num2;
        }

        static int Sum(int Num1, int Num2, int Num3)

        {
            return Num1 + Num2 + Num3;
        }
        static int Sum(int Num1, int Num2, int Num3, int Num4)

        {
            return Num1 + Num2 + Num3 + Num4;
        }


        static void Main(string[] args)
        {
            //we have 3 diffrent methods but with the same name.
            Console.WriteLine(Sum(10, 20));
            Console.WriteLine(Sum(10, 20, 30));
            Console.WriteLine(Sum(10, 20, 30, 40));
            Console.ReadKey();

        }
    }
}
*/