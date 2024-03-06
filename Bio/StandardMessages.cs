namespace Bio
{
    internal class StandardMessages
    {
        public const string MenuTagLineString = "TODDLERS & DEMENTIA IMAX\n";
        public const string MenueHelpAndSelectionString = "Press H for help\n" + "\nYour choice: ";
        public const string EnterAge = "Enter your age: ";
        public const string EnterNumTickets = "How many tickets would you like: ";
        public const string RepeatWordsInfo = "REPEAT YOUR PHRASE\n\n" +
                                              "Type a phrase of words. This phrase will then be repeated 10 times.\n\n" +
                                              "Type your phrase:   ";

        public const string TopMenuText = "TODDLERS & DEMENTIA IMAX\n\n" +
                                          "[1]  Cinema ticket prices\n" +
                                          "[2]  Repeat your phrase\n" +
                                          "[3]  The 3rd word\n" +
                                          "[0]  Exits the program";

        public const string TicketSubMenu = "[1]  Ticket for one person\n" +
                                            "[2]  Tickets for more than one person\n" +
                                            "[3]  Back to previous menue\n";

        public static void MenuMessage()
        {
            Console.Clear();
            Console.WriteLine($"{TopMenuText}");
            Console.Write($"{MenueHelpAndSelectionString}");
        }

        public static void TicketSubMenuMessage()
        {
            Console.Clear();
            Console.WriteLine($"{MenuTagLineString}");
            Console.WriteLine($"{TicketSubMenu}");
            Console.Write($"{MenueHelpAndSelectionString}");
        }

        public static void ToPreviousMenu()
        {
            Console.WriteLine("Back to previous menue");
        }
        public static void MenuHelpMessage()
        {
            Console.Write("Enter the number corresponding to menu item you want.");
            Console.ReadLine();
        }

        public static void ErroneousInputMessage()
        {
            Console.Write("Not a valid choice");
            Console.ReadLine();
        }

        public static void QuitProgram()
        {
            Console.Clear();
            Console.WriteLine("\n\t\t>> Bye, hope to see you soon! <<\n                            . .  ,  ,\r\n                            |` \\/ \\/ \\,',\r\n                            ;          ` \\/\\,.\r\n                           :               ` \\,/\r\n                           |                  /\r\n                           ;                 :\r\n                          :                  ;\r\n                          |      ,---.      /\r\n                         :     ,'     `,-._ \\\r\n                         ;    (   o    \\   `'\r\n                       _:      .      ,'  o ;\r\n                      /,.`      `.__,'`-.__,\r\n                      \\_  _               \\\r\n                     ,'  / `,          `.,'\r\n               ___,'`-._ \\_/ `,._        ;\r\n            __;_,'      `-.`-'./ `--.____)\r\n         ,-'           _,--\\^-'\r\n       ,:_____      ,-'     \\\r\n      (,'     `--.  \\;-._    ;\r\n      :    Y      `-/    `,  :\r\n      :    :       :     /_;'\r\n      :    :       |    :\r\n       \\    \\      :    :\r\n        `-._ `-.__, \\    `.\r\n           \\   \\  `. \\     `.\r\n         ,-;    \\---)_\\ ,','/\r\n         \\_ `---'--'\" ,'^-;'\r\n         (_`     ---'\" ,-')\r\n         / `--.__,. ,-'    \\\r\n-hrr-    )-.__,-- ||___,--' `-.\r\n        /._______,|__________,'\\\r\n        `--.____,'|_________,-'");
            Environment.Exit(0);
        }
    }
}

