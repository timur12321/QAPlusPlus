using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    public class SwitchOperation
    {
        public void EvaluatePerformance(string grade)
        {
            switch (grade)
            {
                case "A":
                    Console.WriteLine("Excellent");
                    break;
                case "B":
                    Console.WriteLine("Good");
                    break;
                case "C":
                    Console.WriteLine("Average");
                    break;
                case "E":
                    Console.WriteLine("Poor");
                    break;
                default:
                    Console.WriteLine("Invalid grade");
                    break;
                    ;
            }
        }
    }
}
