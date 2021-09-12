using System.ComponentModel.DataAnnotations;

namespace TicketSystemAPI.Models
{

    public class Ticket : Auditable
    {
        [Key]
        public int Id { get; set; }
        public string TicketNumber { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string Assignee { get; set; }
        public Priority? Priority { get; set; }
        public Status? Status { get; set; }
    }
}