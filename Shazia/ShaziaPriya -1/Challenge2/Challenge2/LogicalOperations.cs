using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    public class LogicalOperations
    {
        public void Compare(int number1, int number2)
        {
            if (number1 > number2)
            {
                Console.WriteLine(string.Format("Number 1 '{0}' is greater than Number 2 '{1}'", number1, number2));
            }
            else if (number1 < number2)
            {
                Console.WriteLine(string.Format("Number 1 '{0}' is less than Number 2 '{1}'", number1, number2));
            }
            else if (number1 == number2)
            {
                Console.WriteLine(string.Format("Number 1 '{0}' is equal to Number 2 '{1}'", number1, number2));
            }
        }
    }
}
