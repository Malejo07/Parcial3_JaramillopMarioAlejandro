namespace TicketingSystemLaBichota.DAL
{
    public class SeederDB
    {
        private readonly DataBaseContext _context;

        public SeederDB(DataBaseContext context)
        {
            _context = context;            
        }

        public async Task SeederAsync() 
        {
            await _context.Database.EnsureCreatedAsync();

            PopulateTickets();

            await _context.SaveChangesAsync();
        }

        private void PopulateTickets()
        {
            if (!_context.Tickets.Any()) 
            {
                for (int i = 1; i <= 1000; i++) 
                {
                    _context.Tickets.Add(new Entities.Ticket
                    {
                        TicketId = i,
                        UseDate = null,
                        IsUsed = false,
                        EntranceGate = null,
                        CreatedDate = DateTime.Now,
                    });
                }

            }
        }
    }
}
