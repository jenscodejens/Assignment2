using System.Text;

namespace Bio
{

    internal class TicketList
    {

        private List<Ticket> tickets { get; set; }
        public static StringBuilder sb = new StringBuilder();

        public TicketList()
        {
            tickets = new List<Ticket>();
        }

        public void AddTicketToList(string ticketType)
        {
            tickets.Add(new Ticket(ticketType));
        }
        public string GetAllTicketsFromList()
        {
            foreach (Ticket ticket in tickets)
            {
                sb.Length = 0;
                sb.Capacity = 0;
                sb.Append(ticket.ToString());

            }
            return sb.ToString().Trim();
        }
    }
}



