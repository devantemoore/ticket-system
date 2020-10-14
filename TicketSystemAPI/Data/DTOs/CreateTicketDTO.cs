using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TicketSystemAPI.Models;

namespace TicketSystemAPI.Data.DTOs
{
    public class CreateTicketDTO
    {
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [MaxLength(300)]
        public string Description { get; set; }

        [Required]
        public string CreatedBy { get; set; }

        [Required]
        [MaxLength(45)]
        public string Email { get; set; }

        public Priority? Priority { get; set; }
    }
}