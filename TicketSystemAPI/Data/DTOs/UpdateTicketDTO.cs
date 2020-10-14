using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TicketSystemAPI.Models;

namespace TicketSystemAPI.Data.DTOs
{
    public class UpdateTicketDTO
    {
        [MaxLength(50)]
        public string Title { get; set; }

        [MaxLength(300)]
        public string Description { get; set; }

        public string CreatedBy { get; set; }

        [MaxLength(45)]
        public string Email { get; set; }

        public string? Assignee { get; set; }
        public Priority? Priority { get; set; }
        public Status? Status { get; set; }
    }
}