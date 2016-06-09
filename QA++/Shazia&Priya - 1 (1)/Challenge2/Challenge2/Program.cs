using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    using System.Net.NetworkInformation;

    class Program
    {
        static void Main(string[] args)
        {
            DoLogicalOperation();
            DoSwitchOperation();
        }

        public static void DoSwitchOperation()
        {
            List<string> validGrades = new List<string>() {"A", "B", "C", "D", "E"};
            SwitchOperation switchOperation = new SwitchOperation();
            Console.WriteLine("Enter value of grade");
            var grade = Console.ReadLine();
            if (validGrades.Contains(grade.ToUpper()))
            {
                switchOperation.EvaluatePerformance(grade.ToUpper());
            }
            else
            {
                Console.WriteLine("Please enter valid grade");
            }
        }

        public static void DoLogicalOperation()
        {
            LogicalOperations logicalOperations = new LogicalOperations();
            int y = 10; int x = 0;
            Console.WriteLine(string.Format("Enter the value number to be compared against {0}", y));
            var input = Console.ReadLine();
            bool isInt = Int32.TryParse(input, out x);
            if (isInt)
            {
                logicalOperations.Compare(x, y);
            }
            else
            {
                Console.WriteLine("Please check the number that you have inputted");
            }
        }
    }
}
