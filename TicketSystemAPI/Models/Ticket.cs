using System;
using System.ComponentModel.DataAnnotations;

namespace TicketSystemAPI.Models
{
    public enum Priority
    {
        Low,
        Medium,
        High
    }

    public enum Status
    {
        Open,
        Closed
    }

    public class Ticket
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string TicketNumber { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [MaxLength(300)]
        public string Description { get; set; }

        [Required]
        public string CreatedBy { get; set; } // change to User Entity

        [Required]
        public DateTime DateCreated { get; set; }

        [Required]
        [MaxLength(45)]
        public string Email { get; set; }

        public string? Assignee { get; set; } // User Entity

        public Priority? Priority { get; set; }
        public Status? Status { get; set; }

        //public bool isDeleted { get; set; }
    }
}