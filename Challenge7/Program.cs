using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge6
{
    using System.ComponentModel.Design;
    using System.Runtime.Remoting.Messaging;
    using System.Threading;

    enum UserType {Business, Social};

    public class Program
    {
        private const string WelcomeMessage = "QA++ Challenge 7\n================\n\nWelcome to ASOS Chat\n";
        private const string OptionsMessage = "Choose an option or type ? for help\n\n#1 - Start new chat session\n#2 - Set/Change Usernames\n#3 - Switch user\n#9 - Exit";
        private const string Prompt = ">";

        private static string chatHistory;
        private static string[][] users = new string[2][];
        private static int? currentUserId = null;


        public static void Main(string[] args)
        {
            Console.WriteLine(WelcomeMessage);

            while (true)
            {
                ShowHelp();
                while (true)
                {
                    string message = GetUserInput();
                    switch (message)
                    {
                        case "?":
                            ShowHelp();
                            break;
                        case "#1":
                            StartNewChatSession();
                            break;
                        case "#2":
                            SetUsernames();
                            break;
                        case "#3":
                            SwitchUser();
                            break;
                        case "#9":
                            return;
                        default:
                            SendMessage(message);
                            break;
                    }
                }
            }
        }

        private static string GetUserInput()
        {
            string prompt = currentUserId == null
                ? Prompt
                : users[(int)currentUserId][0] + " " + Prompt;

            Console.Write(Environment.NewLine + prompt);
            return Console.ReadLine();
        }

        private static void StartNewChatSession()
        {
            chatHistory = string.Empty;

            if (users[0] == null || users[1] == null)
            {
                SetUsernames();
            }
        }
       
        private static void SwitchUser()
        {
            int userId;
            Console.Write("\nEnter User Id: ");
            try
            {
                userId = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.Write("Invalid User Id");
                return;
            }

            if (userId < 0 || userId > users.Length - 1)
            {
                Console.Write("User " + userId + " does not exist.");
            }

            currentUserId = userId;
        }

        private static void SetUsernames()
        {
            for (int x = 0; x < users.Length; x++)
            {
                users[x] = new string[2];
                Console.Write("\nEnter name of User {0} : ", x);
                users[x][0] = Console.ReadLine();
                users[x][1] = ((UserType)new Random().Next(0, 2)).ToString();
                Console.WriteLine("User type: {0}", users[x][1]);
            }

            currentUserId = 0;
        }

        private static void SendMessage(string message)
        {
            if (currentUserId != null)
            {
                chatHistory = chatHistory 
                              + Environment.NewLine
                              + DateTime.Now.Hour.ToString("00")
                              + ":"
                              + DateTime.Now.Minute.ToString("00")
                              + ":"
                              + DateTime.Now.Second.ToString("00")
                              + " "
                              + users[(int)currentUserId][0]
                              + " - "
                              + message;
                Console.Clear();
                Console.WriteLine(chatHistory);
            }
        }

        private static void ShowHelp()
        {
            Console.WriteLine(OptionsMessage);
        }
    }
}
