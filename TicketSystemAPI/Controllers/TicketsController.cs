using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TicketSystemAPI.Data;
using TicketSystemAPI.Data.DTOs;
using TicketSystemAPI.Data.Interface;
using TicketSystemAPI.Models;

namespace TicketSystemAPI.Controllers
{
    [Route("api/tickets")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly ITicketRepo _context;

        //private readonly TicketRepo _ticket = new TicketRepo();
        public TicketsController(ITicketRepo context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ticket>>> Get()
        {
            var tickets = await _context.GetAllTicketsAsync();
            return Ok(tickets);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Ticket>> Get(int id)
        {
            Ticket ticket = await _context.GetTicketByIdAsync(id);
            return ticket != null ? Ok(ticket) : NotFound();
        }

        [HttpPost]
        public async Task<ActionResult<Ticket>> CreateTicket(CreateTicketDTO ticket)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            string ticketno = await _context.GetTicketNoAsync();
            Ticket _ticket = new Ticket
            {
                TicketNumber = ticketno,
                Title = ticket.Title,
                Description = ticket.Description,
                CreatedBy = ticket.CreatedBy,
                DateCreated = DateTime.Now,
                Email = ticket.Email,
                Priority = ticket.Priority,
                Status = Status.Open
            };

            await _context.CreateTicketAsync(_ticket);
            return Created("api/tickets/" + _ticket.Id.ToString(), ticket);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateTicket(int id, UpdateTicketDTO updateTicket)
        {
            var ticket = await _context.GetTicketByIdAsync(id);
            if (ticket == null) return NotFound();

            ticket.Title = updateTicket.Title ?? ticket.Title;
            ticket.Description = updateTicket.Description ?? ticket.Description;
            ticket.CreatedBy = updateTicket.CreatedBy ?? ticket.CreatedBy;
            ticket.Email = updateTicket.Email ?? ticket.Email;
            ticket.Assignee = updateTicket.Assignee ?? ticket.Assignee;
            ticket.Priority = updateTicket.Priority ?? ticket.Priority;
            ticket.Status = updateTicket.Status ?? ticket.Status;

            _context.UpdateTicket(ticket);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> RemoveTicket(int id)
        { 
            await _context.DeleteTicketAsync(id);
            return NoContent();
        }
    }
}