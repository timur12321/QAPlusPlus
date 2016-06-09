using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradeSystem
{
    class gradeSystem
    {
        static void Main(string[] args)


        {
            Console.WriteLine("=======================");
            Console.WriteLine("Student Greading System");
            Console.WriteLine("=======================");
            
            Console.WriteLine("Please Enter you Age");
            int age = Convert.ToInt32(Console.ReadLine());
            
            if (age == 3)
            {
                Console.WriteLine("You belong to Nursery stage");
            }

            else if (age == 4)
            {
                Console.WriteLine("You belong to Reception stage");
            }

            else if (age >= 5 & age <= 11)
            {
                Console.WriteLine("You belong to Primary school");
            }

            else if (age >= 12 & age <= 18)
            {
                Console.WriteLine("You belong to Secondary school");
            }

            else if (age > 18)
            {
                Console.WriteLine("You are an adult! You do not qualify");
            }

            else
            {
                Console.WriteLine("You have entered an invalid age");
            }
            Console.WriteLine("Please Enter you Grade");
            char grade = Char.Parse(Console.ReadLine());

            switch (grade)

            {
                case 'A':
                    Console.WriteLine("Well done. You have passed with an 'Outstanding' grade");
                    break;


                case 'B':
                    Console.WriteLine("Well done. You have passed with a 'Good' grade");
                    break;

                case 'C':
                    Console.WriteLine("Well done. You have passed with a 'Satisfactory' grade");
                    break;

                case 'D':
                    Console.WriteLine("You failed. Better luck next time!");
                    break;

                default:
                    Console.WriteLine("You have entered an invalid grade");
                    break;

            }

            Console.ReadLine();

        }

      
    }
}
