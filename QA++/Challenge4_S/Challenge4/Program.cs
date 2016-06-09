using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4
{
    class Program
    {
        static void Main(string[] args)
        {

            String[] countryValues= new string[2];
            Console.WriteLine("===========================================");
            Console.WriteLine("Test Scenario Generator for Eligible Widget ");
            Console.WriteLine("===========================================");

            Console.WriteLine("Select 2 countries for Default Billing Address in 2 Char Format Eg.- US,DE");
            

            for (int i = 0; i < 2; i++)
            {
                
                countryValues[i] =Console.ReadLine();
            }
            

        

        }
        public void ResultsGenarator(string country[n])
        {
            Console.WriteLine("Test Case: Combination of UK and {1}", country[n]);
        Console.WriteLine("Test Case: Combination of UK and {1}", country[n]);
            ResultsGenarator(country[n+1]);
        }

    }
}
