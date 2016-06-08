using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] allnumbers = new int[7] { 2, 7, 17, 32, 3, 8, 10 };
            foreach (int number in allnumbers)

            {
                if (number == 0 || number == 1)
                {
                    Console.WriteLine(number + " is not prime number");
                }
                else
                {
                    bool isNotPrime = false;
                    for (int a = 2; a <= number / 2; a++)
                    {
                        if (number % a == 0)
                        {
                            isNotPrime = true;
                        }
                    }
                    if (isNotPrime)
                    {
                        Console.WriteLine(number + " is not prime number");
                    }
                    else
                    {
                        Console.WriteLine(number + " is prime number");
                    }
                }
            }
        }
    }
}
   
            


   

