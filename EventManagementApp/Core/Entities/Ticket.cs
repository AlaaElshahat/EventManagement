using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    public class Ticket: BaseEntity
    {
        
        public string TicketName { get; set; }
        public decimal TicketPrice { get; set; }
        public int TicketQuentity { get; set; }
        public string TicketDetails { get; set; }

        public int EventId { get; set; }
        [ForeignKey("EventId")]
        public Event Event { get; set; }

        public virtual ICollection<TicketPurchase> Purchase { get; set; }
    }
}
