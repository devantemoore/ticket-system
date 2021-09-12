using System;
namespace TicketSystemAPI.Models
{
    public abstract class Auditable
    {
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime DateModified { get; set; }
    }
}
