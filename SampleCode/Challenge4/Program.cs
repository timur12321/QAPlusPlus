using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Write to console
            Console.WriteLine("QA++ Challenge 4");
            Console.WriteLine("================");
            Console.WriteLine("\nThis program will generate all possible test scenarios for two parameters.");

            while (true)
            {
                // Read parameter values from console
                Console.Write("\nNumber of parameters: ");
                int parameterCount = Convert.ToInt32(Console.ReadLine());

                string[][] parameterArray = new string[parameterCount][];
                for (int x = 0; x < parameterCount; x++)
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

                // Generate test scenarios
                Console.WriteLine("\nPress enter for all test scenarios...");
                Console.ReadLine();
                TestScenarioEngine testScenarioEngine = new TestScenarioEngine();
                int scenarioCount = testScenarioEngine.Print(parameterArray);

                // Print count to command line
                Console.WriteLine("\nSCENARIO COUNT = " + scenarioCount);

                // Exit after Enter
                Console.WriteLine("\n\nPress Enter to repeat or type 'q' to quit...");
                if (Console.ReadLine() == "q")
                    break;
            }
        }
    }

    internal class TestScenarioEngine
    {
        internal int Print(string[][] parameters, int pos = 0, string scenario = "")
        {
            int count = 0;

            foreach (var value in parameters[pos])
            {
                string currentScenario;
                if (pos == 0)
                    currentScenario = value;
                else
                    currentScenario = scenario + " : " + value;
                
                if (pos + 1 == parameters.Length)
                {
                    Console.WriteLine(currentScenario);
                    count++;
                }
                else
                    count += Print(parameters, pos + 1, currentScenario);
            }
            return count;
        }
    }
}