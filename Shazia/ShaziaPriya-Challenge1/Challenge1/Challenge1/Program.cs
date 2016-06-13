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

            int variable1 = 25;
            int variable2 = new int();
            int res = new int();
            Console.WriteLine("==================================");
            Console.WriteLine("Numeric operations");
            Console.WriteLine("==================================");
            Console.WriteLine("Enter a value for a custom integer");
            variable2 = Convert.ToInt32(Console.ReadLine());
            res = multiplyCustomerwithDefault(variable1, variable2);
            Console.WriteLine("The product of custom variable multiplied by default variable is " + res);

            Console.WriteLine("==================================");
            Console.WriteLine("Char & String operations");
            Console.WriteLine("==================================");
            Console.WriteLine("Enter a character");
            Console.WriteLine();
            char char1 = new char();

           char1=Console.ReadKey().KeyChar;
           
            String string1 = "DefaultText";
            String concatResult = concatCharAndString(char1, string1);
            Console.WriteLine("The result of concatenation is" + concatResult);
            Console.WriteLine("==================================");
            Console.WriteLine("Boolean operation");
            Console.WriteLine("==================================");
            Console.WriteLine("Enter a value for a integer to compare");
            int compareVariable1 = Convert.ToInt32(Console.ReadLine());
            int compareVariable2 = 100;
            if (compareVariable1==compareVariable2)
            {
                Console.WriteLine("The number you have entered is same as the default number");
            }

            else
            {
                Console.WriteLine("The number you have entered is different from default number");
            }

            String wait = Console.ReadLine();

        }

        static int multiplyCustomerwithDefault(int var1, int var2)
        {
            int result = var1 * var2;
            return result;
        }

        static String concatCharAndString(char char1, String string1)
        {
            String result = String.Concat(char1, string1);
            return result;
        }
    }

}
