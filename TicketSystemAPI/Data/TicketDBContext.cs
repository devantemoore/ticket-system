using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketSystemAPI.Models;

namespace TicketSystemAPI.Data
{
    public class TicketDBContext : DbContext
    {
        public TicketDBContext(DbContextOptions<TicketDBContext> options) : base(options)
        {
        }

        public DbSet<Ticket> Tickets { get; set; }
    }
}