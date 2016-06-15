using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace QAex2
{
    public class Program
    {
        public static void Main(string[] args)
        { 
            //They can be a single method in a single class, but they must:

            //Accept input from and print out to the console
           //Perform a decision based on the input Using if, else decision statements
            printOutToConsole();
            
        }
        public static void printOutToConsole()
        {  
           Console.Write("What is your name?");//Ask the user to input their name

            var name = Console.ReadLine();
            
            //************Option 1**************************************************
            //if (name == "shyam")//If the name is shyam
            //{
            //    Console.Write("Hello Shyam");//then print "hello shyam"

            //}else if (name == "Tim")
            //{
            //    Console.Write("Hello Tim"); //if the name is Tim then print "Hello Tim"

            //}
            //else
            //{
            //    Console.Write("Hello Stranger"); //else print hello stranger
            //}

            //************Option 2 - Short-Hand**************************************************

            var greeting = name == "shyam" ? "Hello shyam!" :
                           name == "Tim" ? "Hello Tim" :
                           "Hello Stranger";

            Console.WriteLine(greeting);

            //**********************************************************************************

            Console.Read(); 

        }


    }
}





