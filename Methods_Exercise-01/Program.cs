using System;

namespace Methods_Exercise_01_Answers
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: For each method call the AddSpaces() method to separate the answers!

            // TODO: Call the PrintGreeting() method
            PrintGreeting();
            AddSpaces();
            // TODO: Call the SayHello() method
            SayHello("Mr", " Bond");
            AddSpaces();
            // TODO: Call the GreetUser() method
            GreeUser();
            AddSpaces();
            // TODO: Call the Exponentiate() method and store the returned value in a variable called result
            // TODO: Write result out to the console (display the result creatively)
            Exponentiate(); //solution print out to console is in the method already
            AddSpaces();
            // TODO: Call the IsPrime() method and write out the result to the console
            // TODO: Creatively display the information to the console window
            IsPrime();
        }

        // TODO: Create a public static method called AddSpaces() which creates 2 blank lines when called
        // and does NOT **return** anything
        public static void AddSpaces()
        {
            Console.WriteLine();
            Console.WriteLine();
        }


        // TODO: Create a public static method called PrintGreeting() with a return type of void that takes no parameters,
        // and writes to the console "Hello World!"
        public static void PrintGreeting()
        {
            Console.WriteLine("Hello World!");
        }


        // TODO: Create a public static method called SayHello() with a return type of void which takes 2 parameters firstName & lastName,
        // and concatenates them into a sentence Ex: "Hello, John Smith!" then writes them to the console
        public static void SayHello(string firstName, string lastName)
        {
            Console.WriteLine("Hello, " + firstName + "" + lastName + "!");
        }


        // TODO: Create a method called GreetUser() that asks the user for their name
        // then greets them with that name to the console (don't forget to prompt the user to enter their name!)
        public static void GreeUser()
        {
            Console.WriteLine("Hello, what is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine($"Hello, {yourName}.");
        }


        // TODO: Create a method called Exponentiate() that asks the user for a number and a powerOF
        // and then calculates the result of raising the first to the second (don't forget to prompt the user to enter the 2 numbers!)
        public static void Exponentiate()
        {
            Console.WriteLine("Please pick a number.");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please choose a second number for the exponent.");
            int exponent = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your first number of {firstNumber}, raised to the power of \nyour second number of {exponent}, equals {Math.Pow(firstNumber, exponent)}.");
        }


        // TODO: Create a method called IsPrime() that asks the user for a number then returns true if the number is prime or false otherwise
        // (don't forget to prompt the user to enter the number!)
        public static void IsPrime()
        {
            Console.WriteLine("Give me a number and I will tell you if it's prime.");
            int primeGuess = int.Parse(Console.ReadLine());

            if (primeGuess % 2 == 0 && primeGuess > 2)
            {
                Console.WriteLine("Nope, it's not."); ;
            }
            else
            {
                Console.WriteLine("I'm thinkin' it is."); ;
            }
        }
    }
}
