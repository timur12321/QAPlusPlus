using System;

namespace Challenge4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("QA++ Challenge 4");
            Console.WriteLine("================");
            Console.WriteLine("\nThis program will generate all possible combinations for any number of parameters.");

            string[][] parameters = RetrieveParameters();

            Console.WriteLine("\nPress enter for all test scenarios...");
            Console.ReadLine();

            TestParameters testParameters = new TestParameters();
            string[] allScenarios = testParameters.ComputeAllCombinations(parameters, 0, string.Empty);

            Print(allScenarios);
        }

        private static string[][] RetrieveParameters()
        {
            Console.Write("\nNumber of parameters: ");
            int parameterCount = Convert.ToInt32(Console.ReadLine());
            string[][] parameters = new string[parameterCount][];

            for (int i = 0; i < parameterCount; i++)
            {
                parameters[i] = RetrieveParameterValues(i);
            }

            return parameters;
        }

        private static string[] RetrieveParameterValues(int parameterNumber)
        {
            Console.Write("\nParameter " + parameterNumber + ". Number of values: ");
            int parameterValuesCount = Convert.ToInt32(Console.ReadLine());
            string[] parameterValues = new string[parameterValuesCount];

            for (int i = 0; i < parameterValuesCount; i++)
            {
                Console.Write("Value " + i + ": ");
                parameterValues[i] = Console.ReadLine();
            }

            return parameterValues;
        }

        private static void Print(string[] allScenarios)
        {
            int scenarioCount = 0;
            foreach (var scenario in allScenarios)
            {
                Console.WriteLine(scenario);
                scenarioCount++;
            }

            Console.WriteLine("\nSCENARIO COUNT = " + scenarioCount);
            Console.ReadLine();
        }
    }

    internal class TestParameters
    {
        internal string[] ComputeAllCombinations(string[][] parameters, int pos, string combination)
        {
            string[] allCombinations = new string[0];
            foreach (var currentParameter in parameters[pos])
            {
                string currentCombination = combination + " " + currentParameter;

                if (pos == parameters.Length - 1)
                {
                    allCombinations = allCombinations.AddElement(currentCombination);
                }
                else
                {
                    allCombinations = allCombinations.Concatente(ComputeAllCombinations(parameters, pos + 1, currentCombination));
                }
            }
            return allCombinations;
        }
    }
}