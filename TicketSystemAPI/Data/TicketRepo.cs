using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public void CreateTicket(Ticket ticket)
        {
            if (ticket == null)
            {
                throw new ArgumentNullException();
            }
            _context.Tickets.Add(ticket);
            _context.SaveChanges();
        }

        public void DeleteTicket(Ticket ticket)
        {
            _context.Tickets.Remove(ticket);
            _context.SaveChanges();
        }

        public IEnumerable<Ticket> GetAllTickets()
        {
            return _context.Tickets.ToList();
        }

        public Ticket GetTicketById(int id)
        {
            return _context.Tickets.FirstOrDefault(t => t.Id == id);
        }

        public string GetTicketNo()
        {
            string ticketNo = "T-";
            var ticket = _context.Tickets.OrderByDescending(t => t.Id).FirstOrDefault();
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

        public bool TicketExists(int id)
        {
            var ticket = GetTicketById(id);
            return (ticket != null) ? true : false;
        }

        public void UpdateTicket(Ticket ticket)
        {
            _context.SaveChanges();
        }
    }
}