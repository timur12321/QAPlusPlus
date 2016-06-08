using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            bool Restart = true;
            while (Restart)
            {
                Restart = false;

                Console.WriteLine("Write your first number");
                int x = 0;
                string line = Console.ReadLine();
                int value;
                bool IsUserWrong = true;
                while (IsUserWrong)
                {
                    if (int.TryParse(line, out value))
                    {

                        x = value;
                        IsUserWrong = false;
                    }
                    else
                    {

                        Console.WriteLine("Please only enter a number! ");
                        line = Console.ReadLine();

                    }
                }
                Console.WriteLine("Write your second number");
                int y = 0;
                string line2 = Console.ReadLine();
                int value1;
                bool isUserRight = true;
                while (isUserRight)
                {
                    if (int.TryParse(line2, out value1)) //Check if the value entered is an Int
                    {

                        y = value1;
                        isUserRight = false;
                    }
                    else
                    {
                        Console.WriteLine("Please only enter a number! ");
                        line2 = Console.ReadLine();

                    }
                }
                bool BadDescision = true;
                while (BadDescision)
                {
                    BadDescision = false;
                    Console.WriteLine("-----------------------");
                    Console.WriteLine(" Choose a option ");
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("1 - Addition");
                    Console.WriteLine("2 - Subtration ");
                    Console.WriteLine("3 - Multification");
                    Console.WriteLine("4 - Division");
                    Console.WriteLine("5 - Restart");

                    string ReadLine = Console.ReadLine();
                    int TheValue;
                    int z = 0;
                    if (int.TryParse(ReadLine, out TheValue)) //Check if the value entered is an Int
                    {
                        z = TheValue;

                        //int z = Convert.ToInt32(Console.ReadLine());
                    }
                    else
                    {
                        BadDescision = true;
                    }
                    switch (z)


                    {
                        case 1:
                            Console.WriteLine("-----------------------");
                            Console.WriteLine(x + " + " + y + " =");
                            Console.WriteLine("-----------------------");
                            Console.WriteLine(x + y);
                            break;
                        case 2:
                            Console.WriteLine("-----------------------");
                            Console.WriteLine(x + " - " + y + " = ");
                            Console.WriteLine("-----------------------");
                            Console.WriteLine(x - y);
                            break;
                        case 3:
                            Console.WriteLine("-----------------------");
                            Console.WriteLine(x + " X " + y + " = ");
                            Console.WriteLine("-----------------------");
                            Console.WriteLine(x*y);
                            break;
                        case 4:
                            Console.WriteLine("-----------------------");
                            Console.WriteLine(x + " / " + y + " = ");
                            Console.WriteLine("-----------------------");
                            Console.WriteLine(x/y);
                            break;
                        case 5:
                            Restart = true;
                            Console.WriteLine("-----------------------");
                            Console.WriteLine("Please press Enter key to restart ");
                            Console.WriteLine("-----------------------");
                            break;
                        case 42:
                            Console.WriteLine("-----------------------");
                            Console.WriteLine("Well done you answered the question to life and everything!");
                            Console.WriteLine("-----------------------");
                            Console.WriteLine("Please Press enter again to choose a different option");
                            Console.WriteLine("-----------------------");
                            System.Diagnostics.Process.Start("https://youtu.be/NnG4lpcn9aM?t=9s");
                            BadDescision = true;
                            break;
                        default:
                            Console.WriteLine("I'm sorry the option you choose is not an option ");
                            Console.WriteLine("-----------------------");
                            Console.WriteLine("Please Press enter again to retry...");
                            Console.WriteLine("-----------------------");
                            BadDescision = true;
                            break;

                    }
                    Console.ReadKey(true);

                }
            }
        }
    }
}
