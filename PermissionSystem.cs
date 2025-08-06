using Permission_System.Models;

namespace Permission_System
{
    public class PermissionSystem
    {
        public void Start()
        {
            ShowWelcome();
            Console.Clear();
            Login();
        }
        void Login()
        {
            LoginMessage();
            Console.Write("Enter username: ");
            string name = Console.ReadLine();

            Console.Write("Enter password: ");
            string pass = Console.ReadLine();

            User user = User.GetUser(name, pass);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nLogin successful!");
            Console.ResetColor();

            ShowMenu(user);
        }
        void ShowMenu(User user)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== MAIN MENU ===");
                Console.WriteLine($"Hello {user.UserName}");
                Console.WriteLine("What do you want to do:");
                Console.WriteLine();
                Console.WriteLine("1. Read");
                Console.WriteLine("2. Insert");
                Console.WriteLine("3. Update");
                Console.WriteLine("4. Delete");
                Console.WriteLine("E. Exit");
                Console.WriteLine();
                Console.Write("Pick one: ");

                string choice = Console.ReadLine().ToUpper();

                if (choice == "E")
                {
                    Console.WriteLine("\nBye!");
                    Environment.Exit(0);
                }

                DoAction(user, choice);

                Console.WriteLine("\nPress any key...");
                Console.ReadKey();
            }
        }
        void DoAction(User user, string choice)
        {
            Permissions needed = GetPermission(choice);
            string action = GetActionName(choice);

            if (action == null)
            {
                Console.WriteLine("\nBad choice. Pick 1-4 or E.");
                return;
            }

            bool canDo = user.UserPermissions.HasFlag(needed);

            if (canDo)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n{action} done!");
                Console.WriteLine($"You did {action} successfully.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nYou can't do {action}.");
            }
            Console.ResetColor();
        }
        Permissions GetPermission(string choice)
        {
            switch (choice)
            {
                case "1": return Permissions.Read;
                case "2": return Permissions.Insert;
                case "3": return Permissions.Update;
                case "4": return Permissions.Delete;
                default: return Permissions.Read;
            }
        }
        string GetActionName(string choice)
        {
            switch (choice)
            {
                case "1": return "Read";
                case "2": return "Insert";
                case "3": return "Update";
                case "4": return "Delete";
                default: return null;
            }
        }
        void LoginMessage()
        {
            int screenWidth = GetScreenWidth();
            Console.ForegroundColor = ConsoleColor.Yellow;

            string[] loginBoxLines = {
                "┌─────────────────────────────────────────────────────────────────┐",
                "│                        🔐 SECURE LOGIN 🔐                      │",
                "│                                                                 │",
                "│           Welcome to the Permission Management System           │",
                "│                     Please enter your credentials              │",
                "└─────────────────────────────────────────────────────────────────┘"
            };

            Console.WriteLine();
            foreach (string line in loginBoxLines)
            {
                CenterText(line, screenWidth);
            }

            Console.ResetColor();
            Console.WriteLine();
        }
        void ShowWelcome()
        {
            Console.Clear();
            int screenWidth = GetScreenWidth();
            Console.ForegroundColor = ConsoleColor.Green;
            
            string[] logoLines = {
                "╔══════════════════════════════════════════════════════════════════════════════╗",
                "║                                                                              ║",
                "║    ██╗    ██╗███████╗██╗      ██████╗ ██████╗ ███╗   ███╗███████╗            ║",
                "║    ██║    ██║██╔════╝██║     ██╔════╝██╔═══██╗████╗ ████║██╔════╝            ║",
                "║    ██║ █╗ ██║█████╗  ██║     ██║     ██║   ██║██╔████╔██║█████╗              ║",
                "║    ██║███╗██║██╔══╝  ██║     ██║     ██║   ██║██║╚██╔╝██║██╔══╝              ║",
                "║    ╚███╔███╔╝███████╗███████╗╚██████╗╚██████╔╝██║ ╚═╝ ██║███████╗            ║",
                "║     ╚══╝╚══╝ ╚══════╝╚══════╝ ╚═════╝ ╚═════╝ ╚═╝     ╚═╝╚══════╝            ║",
                "║                                                                              ║",
                "║                           ████████╗ ██████╗                                 ║",
                "║                           ╚══██╔══╝██╔═══██╗                                ║",
                "║                              ██║   ██║   ██║                                ║",
                "║                              ██║   ██║   ██║                                ║",
                "║                              ██║   ╚██████╔╝                                ║",
                "║                              ╚═╝    ╚═════╝                                 ║",
                "║                                                                              ║",
                "║               ██████╗ ███████╗██████╗ ███╗   ███╗██╗███████╗                ║",
                "║               ██╔══██╗██╔════╝██╔══██╗████╗ ████║██║██╔════╝                ║",
                "║               ██████╔╝█████╗  ██████╔╝██╔████╔██║██║███████╗                ║",
                "║               ██╔═══╝ ██╔══╝  ██╔══██╗██║╚██╔╝██║██║╚════██║                ║",
                "║               ██║     ███████╗██║  ██║██║ ╚═╝ ██║██║███████║                ║",
                "║               ╚═╝     ╚══════╝╚═╝  ╚═╝╚═╝     ╚═╝╚═╝╚══════╝                ║",
                "║                                                                              ║",
                "╚══════════════════════════════════════════════════════════════════════════════╝"
            };

            Console.WriteLine();
            foreach (string line in logoLines)
            {
                CenterText(line, screenWidth);
            }
            
            Console.ResetColor();
            Console.WriteLine();
            Thread.Sleep(800);
        }
        int GetScreenWidth()
        {
            try
            {
                return Console.WindowWidth;
            }
            catch
            {
                return 120;
            }
        }
        void CenterText(string text, int screenWidth)
        {
            int spaces = (screenWidth - text.Length) / 2;
            if (spaces < 0) spaces = 0;
            
            Console.WriteLine(new string(' ', spaces) + text);
        }
    }
}