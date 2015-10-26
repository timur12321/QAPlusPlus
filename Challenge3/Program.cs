using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write to console
            Console.WriteLine("QA++ Challenge 3");
            Console.WriteLine("================");
            Console.WriteLine("\nThis program will generate all possible test scenarios for two parameters.");

            while(true)
            {
                //Read parameter values from console
                string[][] parameterArray = new string[2][];
                for (int x = 0; x < 2; x++)
                {
                    Console.Write("\nParameter " + x + ". Number of values: ");
                    int valueCount = Convert.ToInt32(Console.ReadLine());

                    parameterArray[x] = new string[valueCount];
                    for (int y = 0; y < valueCount; y++)
                    {
                        Console.Write("Value " + y + ": ");
                        parameterArray[x][y] = Console.ReadLine();
                    }
                }

                //Generate test scenarios
                Console.WriteLine("\nPress enter for all test scenarios...");
                Console.ReadLine();
                int scenarioCount = 0;
                foreach (var p0Value in parameterArray[0])
                {
                    foreach (var p1Value in parameterArray[1])
                    {
                        Console.WriteLine(p0Value + " : " + p1Value);
                        scenarioCount++;
                    }
                }

                //Print count to command line
                Console.WriteLine("\nSCENARIO COUNT = " + scenarioCount);

                //Exit after Enter
                Console.WriteLine("\n\nPress Enter to repeat or type 'q' to quit...");
                if (Console.ReadLine() == "q")
                    break;
            }
        }
    }
}
