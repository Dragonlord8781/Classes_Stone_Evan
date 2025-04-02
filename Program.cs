using System;

namespace Classes_Stone_Evan
{
    class Program
    {
        static void Main(string[] args)
        {
            //writes program #
            Console.WriteLine("Program 10");

            //declares and initalizes the greetings object, connecting class Program to class Greetings
            Greetings greetings = new Greetings();
            //Calls the Welcome function
            greetings.Welcome();

            //writes a line askihng for a name
            Console.WriteLine("Please input your name.");
            //Declares the string userName and assignes it the inputted name
            string userName = Console.ReadLine();

            //Calls the Hello function using the userName parameter
            greetings.Hello(userName);
        }
    }
}