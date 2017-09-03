using System;

namespace Problem1c_
{
    class Program
    {
        static void Main(string[] args)
        { // User enters two numbers and show which one is bigger
        //make two vars Number1 and Number2 each =s to 0
        //if statment 
        // if 2 is bigger than one
        // if 1 is bigger than 2
            //Start the program with Clear();
            Console.Clear();
            
            
            //End the program with blank line and instructions
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();
            Console.WriteLine("This program will see what two number is bigger");
            
            Console.WriteLine("Please enter number 1");     //Will convert var to int after user enter 1st value
            var number1 = int.TryParse(Console.ReadLine(), out int input);

            Console.WriteLine("Please enter number 2"); //Will convert var to int after user enter 2st value
            var number2 = int.TryParse(Console.ReadLine(), out int input1);

            if ( input <= input1)  // tell you if number 2 is bigger than Number 1
            {
                Console.WriteLine("Number 2 is bigger than Number 1");

            }
            else if ( input >= input1) // Will tell if Number1 is bigger than number 2
            {
                Console.WriteLine("Number 1 is bigger than Number 2");
            }
            Console.ReadLine();

        }
    }
}
