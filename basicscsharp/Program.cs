using System;

namespace basicscsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Mystring();

        }

        static void Mystring()
        {
            Console.Write("What year were born?");
            int yearBorn = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is your age?");
            string myName = Console.ReadLine();

            Console.WriteLine($"Your age is: {myName}, and you were born in {yearBorn}");


            string Mystring1 = "this is my first string.";
            string theTruth = "the last thing a ninja would do is admit to be a ninja.";
            string TheLie = "I am not a ninja.";
            Console.WriteLine("this is my string. " + Mystring1);
            Console.WriteLine($"here are two truths and a lie. {theTruth}, {TheLie}");

        }
    }
}
