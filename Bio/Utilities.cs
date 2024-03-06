namespace Bio
{
    internal class Utilities
    {
        /// <summary>
        /// Functionionaly is decided by a bool input parameter included in the caller method TicketSubMenu();
        /// </summary>
        /// <param name="oneTicketOnly">True for multi ticket purchase. False for single ticket purchase</param>
        /// <returns></returns>
        public static void PurchaseTicket(bool oneTicketOnly)
        {
            var tickets = new TicketList();

            if (oneTicketOnly == true)
            {
                string tc = GetTicketCategory();
                tickets.AddTicketToList(tc);
            }
            else
            {
                int num = GetNumberOfTickets();
                for (int i = 0; i < num; i++)
                {
                    string tc = GetTicketCategory();
                    tickets.AddTicketToList(tc);
                }

            }
            tickets.GetAllTicketsFromList();
            TotalTicketCost();
            Console.ReadLine();
        }

        public static string GetTicketCategory()
        {
            return SetTicketPrice(GetAge());
        }

        private static string SetTicketPrice(int age)
        {
            return age switch
            {
                < 5 => "Free,",
                >= 5 and <= 19 => "Youth,",
                >= 20 and <= 64 => "Regular,",
                >= 65 and <= 100 => "Pensioner,",
                _ when age >= 101 && age <= 120 => "Free,",
                _ => "Free,"
            };
        }

        private static int GetAge()
        {
            Console.Write($"{StandardMessages.EnterAge}");
            do
            {
                string input = Console.ReadLine()!;
                if (int.TryParse(input, out int result) && (result < 120))
                {
                    return result;
                }
                ClearPreviousConsoleLine();
                Console.Write($"{StandardMessages.EnterAge}");
            }
            while (true);
        }

        public static int GetNumberOfTickets()
        {
            Console.Write("Number of tickets: ");
            do
            {
                string input = Console.ReadLine()!;

                if (int.TryParse(input, out int result) && (result >= 2 && result <= 10))
                {
                    return result;
                }
                ClearPreviousConsoleLine();
                Console.Write("Number of tickets: ");
            }
            while (true);
        }

        private static void TotalTicketCost()
        {
            string allTickets = TicketList.sb.ToString();
            string[] words = allTickets.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            int totalCost = 0;

            Dictionary<string, int> ticketPrices = new Dictionary<string, int>
            {
                { "Free", 0 },
                { "Youth", 80 },
                { "Regular", 120 },
                { "Pensioner", 90 }
            };

            foreach (string category in words)
            {
                totalCost += ticketPrices[category];
            }
            Console.WriteLine($"Total cost of tickets: {totalCost} Imperial credits");
        }

        public static void ClearPreviousConsoleLine()
        {
            Console.CursorTop--;
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
    }
}
