using System;

namespace Challenge8
{
    class Program
    {
        private static readonly string WelcomeMessage =
            "QA++ Challenge 8" + Environment.NewLine + "================" + Environment.NewLine + Environment.NewLine +
            "Linked List" + Environment.NewLine;

        private static readonly string HelpMessage =
            "Type commands to work with the list" + Environment.NewLine +
            "A = Add node to list" + Environment.NewLine +
            "R = Remove first node from list" + Environment.NewLine +
            "P = Print all nodes in the list" + Environment.NewLine +
            "C = Count the nodes in the list" + Environment.NewLine +
            "Q = Quit" + Environment.NewLine;

        private static readonly string StartMessage =
            "Press Enter to start";

        private static readonly string InvalidCommandMessage =
            "Invalid command, try again";

        private static Node _head = null;
        static void Main(string[] args)
        {
            Console.WriteLine(WelcomeMessage);
            Console.WriteLine(HelpMessage);
            Console.Write(StartMessage);
            Console.ReadLine();

            string userInput = RetrieveUserInput().ToUpper();
            while (userInput != "Q")
            {
                switch (userInput)
                {
                    case "A":
                        AddNode();
                        break;
                    case "R":
                        RemoveFirstNode();
                        break;
                    case "P":
                        PrintAllNodes();
                        break;
                    case "C":
                        CountAllNodes();
                        break;
                    default:
                        Console.WriteLine(InvalidCommandMessage);
                        break;
                }

                userInput = RetrieveUserInput().ToUpper();
            }
        }

        private static void CountAllNodes()
        {
            if (_head != null)
            {
                Console.WriteLine("Nodes count: " + _head.CountAllNodes());
            }
            else
            {
                Console.WriteLine("No nodes to count.");
            }
        }

        private static void PrintAllNodes()
        {
            if (_head != null)
            {
                _head.PrintAllNodes();
            }
            else
            {
                Console.WriteLine("No nodes to print.");
            }
        }

        private static void RemoveFirstNode()
        {
            if (_head != null)
            {
                _head = _head.Delete();
                Console.WriteLine("Node removed.");
            }
            else
            {
                Console.WriteLine("No nodes to remove.");
            }
        }

        private static void AddNode()
        {
            Console.WriteLine("Enter data for new node:");
            _head = new Node(RetrieveUserInput(), _head);
            Console.WriteLine("New node added.");
        }

        static string RetrieveUserInput()
        {
            Console.Write(Environment.NewLine + ">");
            return Console.ReadLine();
        }
    }
}
