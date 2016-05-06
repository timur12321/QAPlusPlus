using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write to console
            Console.WriteLine("QA++ Challenge 1");
            Console.WriteLine("================");
            Console.WriteLine("\nThis program will add any two numbers.");

            //Declare variables
            double input1, input2, total;

            //Read from console
            Console.Write("\nEnter a number: ");
            input1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a second number: ");
            input2 = Convert.ToInt32(Console.ReadLine());

            //Calculate total and write to console
            total = input1 + input2;
            Console.WriteLine("TOTAL = " + total);

            //Exit after Enter
            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}
