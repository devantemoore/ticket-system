using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketSystemAPI.Data.Interface;
using TicketSystemAPI.Models;

namespace TicketSystemAPI.Data
{
    public class MockTicketRepo : ITicketRepo
    {
        public void CreateTicket(Ticket ticket)
        {
            throw new NotImplementedException();
        }

        public void CreateTicketAsync(Ticket ticket)
        {
            throw new NotImplementedException();
        }

        public void DeleteTicket(Ticket ticket)
        {
            throw new NotImplementedException();
        }

        public void DeleteTicketAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Ticket> GetAllTickets()
        {
            var tickets = new List<Ticket>{
                new Ticket { Id = 1, TicketNumber = "T-00001", Title = "First Ticket", Description = "Some description", Priority = Priority.Low,
                    Status = Status.Open, Email = "djm@yea.com", CreatedBy = "Alex", Assignee = "DeVante", DateCreated = DateTime.Now },
                new Ticket { Id = 2, TicketNumber = "T-00002", Title = "Second Ticket", Description = "Some description", Priority = Priority.Low,
                    Status = Status.Open, Email = "djm@yea.com", CreatedBy = "Alex", Assignee = "DeVante", DateCreated = DateTime.Now },
                new Ticket { Id = 3, TicketNumber = "T-00003", Title = "Third Ticket", Description = "Some description", Priority = Priority.Low,
                    Status = Status.Open, Email = "djm@yea.com", CreatedBy = "Alex", Assignee = "DeVante", DateCreated = DateTime.Now },
                new Ticket { Id = 4, TicketNumber = "T-00004", Title = "Fourth Ticket", Description = "Some description", Priority = Priority.Low,
                    Status = Status.Open, Email = "djm@yea.com", CreatedBy = "Alex", Assignee = "DeVante", DateCreated = DateTime.Now },
                new Ticket { Id = 5, TicketNumber = "T-00005", Title = "Fifth Ticket", Description = "Some description", Priority = Priority.Low,
                    Status = Status.Open, Email = "djm@yea.com", CreatedBy = "Alex", Assignee = "DeVante", DateCreated = DateTime.Now }
            };
            return tickets;
        }

        public Task<IList<Ticket>> GetAllTicketsAsync()
        {
            throw new NotImplementedException();
        }

        public Ticket GetTicketById(int id)
        {
            return new Ticket
            {
                Id = 1,
                TicketNumber = "T-00001",
                Title = "First Ticket",
                Description = "Some description",
                Priority = Priority.Low,
                Status = Status.Open,
                Email = "djm@yea.com",
                CreatedBy = "Alex",
                Assignee = "DeVante",
                DateCreated = DateTime.Now
            };
        }

        public Task<Ticket> GetTicketByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public string GetTicketNo()
        {
            throw new NotImplementedException();
        }

        public Task<string> GetTicketNoAsync()
        {
            throw new NotImplementedException();
        }

        public bool TicketExists(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> TicketExistsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateTicket(Ticket ticket)
        {
            throw new NotImplementedException();
        }

        Task ITicketRepo.CreateTicketAsync(Ticket ticket)
        {
            throw new NotImplementedException();
        }

        Task ITicketRepo.DeleteTicketAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}