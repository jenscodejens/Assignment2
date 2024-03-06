namespace Bio
{
    internal class Ticket
    {
        private string ticketType;

        public string TicketType
        {
            get { return ticketType; }
            set
            {
                ticketType = value;
            }
        }

        public Ticket(string ticketType)
        {
            TicketType = ticketType;
        }

        public override string ToString()
        {
            return $"{ticketType}";
        }
    }
}
