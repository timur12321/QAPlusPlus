using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write to console
            Console.WriteLine("QA++ Challenge 2");
            Console.WriteLine("================");
            Console.WriteLine("\nThis program will add, subtract, divide or multiply any two numbers (using an if statement).");

            //Read from console
            Console.Write("\nEnter a number: ");
            double number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter an operator (+ - / *): ");
            string operation = Console.ReadLine();
            Console.Write("Enter a second number: ");
            double number2 = Convert.ToInt32(Console.ReadLine());

            //Calculate result
            double result;
            if (operation == "+")
            {
                result = number1 + number2;
            }
            else if (operation == "-")
            {
                result = number1 - number2;
            }
            else if (operation == "/")
            {
                result = number1/number2;
            }
            else if (operation == "*")
            {
                result = number1*number2;
            }
            else
            {
                result = 0;
            }

            //Print result to command line
            Console.WriteLine("RESULT = " + result);

            //Exit after Enter
            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}
