using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatement
{
   public class Program
    {
        static void Main(string[] args)
        {
            
           
          
            ProcessQuestion();

        }

       public static void ProcessQuestion()
       {
            //Define a multiple choice question with four options


            //************Option 1**********************************************

            //Console.WriteLine("Which of the following is the largest mammal?");
            //Console.WriteLine();
            //Console.WriteLine("A. Bat ");
            //Console.WriteLine("B. Cat ");
            //Console.WriteLine("C. Whale ");
            //Console.WriteLine("D. Lion ");
            //Console.WriteLine();
            //Console.Write("Answer = ");



            //************Option 2**********************************************

            //Console.WriteLine("Which of the following is the largest mammal? \n \n" +

            //       "A. Bat \n" +
            //       "B. Cat \n" +
            //       "C. Whale \n" +
            //       "D. Lion \n \n");

            //Console.Write("Answer = ");





            //************Option 3**********************************************

            Console.WriteLine(@"Which of the following is the largest mammal? 
 A. Bat  
 B. Cat  
 C. Whale  
 D. Lion ");

            Console.Write("Answer = ");
           


            //Define One correct answer with three incorrect answers (Switch statement)

            var answer = Console.ReadLine().ToUpper();
            Console.Write("\n");

            switch (answer)
           {
                case "A":

                    Console.WriteLine("This answer is Incorrect!");
                    break;

                case "B":

                    Console.WriteLine("This answer is Incorrect!");
                    break;

                case "C":
                    
                    Console.WriteLine("This is the correct answer!");
                    break;

                case "D":

                    Console.WriteLine("This is the incorrect answer!");
                    break;

                default:
                   Console.WriteLine("You did not select a recognised option!"); 
                   break;
               
                    
           }
           
           Console.Read(); //final Execution

            
        }




    }
}
