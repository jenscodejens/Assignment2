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
            sb.Length = 0;
            sb.Capacity = 0;
            foreach (Ticket ticket in tickets)
            {
                sb.Append(ticket.ToString());

            }
            return sb.ToString().Trim();
        }
    }
}



