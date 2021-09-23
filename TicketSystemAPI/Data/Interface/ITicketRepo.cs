using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using TicketSystemAPI.Models;

namespace TicketSystemAPI.Data.Interface
{
    public interface ITicketRepo
    {
        public Task<IList<Ticket>> GetAllTicketsAsync();

        public Task<Ticket> GetTicketByIdAsync(int id);

        public Task CreateTicketAsync(Ticket ticket);

        public void UpdateTicket(Ticket ticket);

        public Task DeleteTicketAsync(int id);

        public Task<bool> TicketExistsAsync(int id);

        public Task<string> GetTicketNoAsync();
    }
}