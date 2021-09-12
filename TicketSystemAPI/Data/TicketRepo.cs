using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TicketSystemAPI.Data.Interface;
using TicketSystemAPI.Models;

namespace TicketSystemAPI.Data
{
    public class TicketRepo : ITicketRepo
    {
        private readonly TicketDBContext _context;

        public TicketRepo(TicketDBContext context)
        {
            _context = context;
        }

        public async Task CreateTicketAsync(Ticket ticket)
        {
            if (ticket == null)
            {
                throw new ArgumentNullException();
            }
            await _context.Tickets.AddAsync(ticket);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTicketAsync(int id)
        {
            Ticket ticket = await GetTicketByIdAsync(id);
            _context.Tickets.Remove(ticket);
        }

        public async Task<IList<Ticket>> GetAllTicketsAsync()
        {
            return await _context.Tickets.ToListAsync();
        }

        public async Task<Ticket> GetTicketByIdAsync(int id)
        {
            return await _context.Tickets.FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<string> GetTicketNoAsync()
        {
            string ticketNo = "T-";
            var ticket = await _context.Tickets.OrderByDescending(t => t.Id).FirstOrDefaultAsync();
            int _no = ticket.Id;
            _no++;
            switch (_no.ToString().Length)
            {
                case 1:
                    ticketNo += "0000" + _no.ToString();
                    break;

                case 2:
                    ticketNo += "000" + _no.ToString();
                    break;

                case 3:
                    ticketNo += "00" + _no.ToString();
                    break;

                case 4:
                    ticketNo += "0" + _no.ToString();
                    break;

                case 5:
                    ticketNo += _no.ToString();
                    break;

                default:
                    ticketNo += "00000";
                    break;
            }
            return ticketNo;
        }

        public async Task<bool> TicketExistsAsync(int id)
        {
            var ticket = await GetTicketByIdAsync(id);
            return (ticket != null) ? true : false;
        }

        public void UpdateTicket(Ticket ticket)
        {
            _context.Update(ticket);
            _context.SaveChanges();
        }
    }
}