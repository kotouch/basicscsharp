using System;
using System.Net.Mail;

namespace basicscsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTypes();

        }

        static void Mystring()
        {
            Console.Write("What year were born?");
            int yearBorn = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is your age?");
            string myName = Console.ReadLine();





            Console.WriteLine($"Your age is: {myName}, and you were born in {yearBorn}");
            // this is a comment.
            /// comment one
            /// comment two
            /// comment three
            /// 

            string Mystring1 = "this is my first string.";
            string theTruth = "the last thing a ninja would do is admit to be a ninja.";
            string TheLie = "I am not a ninja.";
            Console.WriteLine("this is my string. " + Mystring1);
            Console.WriteLine($"here are two truths and a lie. {theTruth}, {TheLie}");

        }

        static void DataTypes()
        {
            int myAge = 99;
            string name = "Bob the Builder";
            bool awesome = true;
            char grade = 'F'; //chars are single charecters so they need single quotes.
            float Altitude = 90.265141f; //float requires f
            double bankBalance = -4000000;
            decimal pi = 3.14159265359M; // decimal requires an M

            ///output
            ///
            Console.WriteLine($"myAge = {myAge}.");
            Console.WriteLine($"string = {name}.");
            Console.WriteLine($"bool = {awesome}.");
            Console.WriteLine($"char = {grade}.");
            Console.WriteLine($"float = {Altitude}.");
            Console.WriteLine($"double = {bankBalance}.");
            Console.WriteLine($"defimal = {pi}.");



        }
    }
}
