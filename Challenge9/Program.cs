using System;

namespace Challenge9
{
    class Program
    {
        private static readonly string WelcomeMessage =
            "QA++ Challenge 9" + Environment.NewLine + "================" + Environment.NewLine + Environment.NewLine +
            "Welcome to the ASOS Rover" + Environment.NewLine;

        private static readonly string HelpMessage =
            "Type commands to make the rover move" + Environment.NewLine +
            "L = Left" + Environment.NewLine +
            "R = Right" + Environment.NewLine +
            "U = Up" + Environment.NewLine +
            "D = Down" + Environment.NewLine +
            "Q = Quit" + Environment.NewLine;

        private static readonly string StartMessage =
            "Press Enter to start";

        private static readonly string InvalidMoveMessage =
            "Invalid move, try again";

        static void Main(string[] args)
        {
            Console.WriteLine(WelcomeMessage);
            Console.WriteLine(HelpMessage);
            Console.WriteLine(StartMessage);

            RetrieveUserInput();

            Console.Clear();
            Rover asosRover = new Rover(5, 5);
            Terrain.Draw(asosRover);

            string userInput = RetrieveUserInput();
            while (userInput != "Q")
            {
                if (!asosRover.Move(userInput))
                {
                    Console.WriteLine(InvalidMoveMessage);
                    userInput = RetrieveUserInput();
                    continue;
                }

                Console.Clear();
                Terrain.Draw(asosRover);
                userInput = RetrieveUserInput();
            }
        }

        static string RetrieveUserInput()
        {
            Console.Write(">");
            return Console.ReadLine().ToUpper();
        }
    }
}