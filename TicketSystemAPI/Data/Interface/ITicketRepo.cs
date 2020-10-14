using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using TicketSystemAPI.Models;

namespace TicketSystemAPI.Data.Interface
{
    public interface ITicketRepo
    {
        public IEnumerable<Ticket> GetAllTickets();

        public Ticket GetTicketById(int id);

        public void CreateTicket(Ticket ticket);

        public void UpdateTicket(Ticket ticket);

        public void DeleteTicket(Ticket ticket);

        public bool TicketExists(int id);

        public string GetTicketNo();
    }
}