using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        { 
            
            // Create a Test Scenario Generator,It can be a single method in a single class, but it must:
            
            //**Test Scenario**// - string calculator that accepts an input testing the addition for two numbers
            
            Console.WriteLine("Please specify how many numbers you would like to double?");

            int howManyNumbers = int.Parse(Console.ReadLine());
            
            int[] numberList = new int[howManyNumbers];
            int incrementCount = 0;

            //Use at least two different looping mechanisms
            foreach (int i in numberList)
            {
                Console.WriteLine("What numbers do you want to assign to the array?");

                numberList[incrementCount] = int.Parse(Console.ReadLine());

                incrementCount++;

            }

            //PrintConsoleResults(howManyNumbers, numberList);

            PrintConsoleResultsWithRecursion(howManyNumbers, numberList);
            //Calculate the total number of test scenarios
            Console.Write("The Total Number of Test Scenarios are: {0}",  howManyNumbers);
            
            // - Print out to the console

            Console.Read();



        }

        private static void PrintConsoleResultsWithRecursion(int howManyNumbers, int[] numberList)
        {

            if (howManyNumbers > 0)
            { 
                //Generate all possible test scenarios and print to the console
                int indexOfNumberList = howManyNumbers-1;
                int currentNumber = numberList[indexOfNumberList];
                int doubleCurrentNumber = numberList[indexOfNumberList]*2;

                Console.WriteLine($"{currentNumber} X 2 is equal to {doubleCurrentNumber}");
                //Call Recursion
                //At the end so is a Tail Recursion 
                PrintConsoleResults(indexOfNumberList, numberList);
            }
        }

        private static void PrintConsoleResults(int howManyNumbers, int[] numberList)
        {
            //Generate all possible test scenarios and print to the console
            for (int i = 0; i < howManyNumbers; i++)
            {
                Console.WriteLine("{0} X 2 is equal to {1}", numberList[i], numberList[i] * 2);
            }
        }
    }
}

