using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Event: BaseEntity
    {
       
        public string EventName { get; set; }
        public string EventDescription { get; set; }
        public DateTime EventDate { get; set; }
        public DateTime EventTime { get; set; }
        public string EventImage { get; set; }

        public int VenueId { get; set; }
        [ForeignKey("VenueId")]
        public EventVenue Venue { get; set; }

        public virtual ICollection<Sponsor> Sponsors { get; set; }
        public virtual ICollection<Speaker> Speakers { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
        public virtual ICollection<Gallary> Gallaries { get; set; }
        public virtual ICollection<EventSchedule> EventSchedules { get; set; }

    }
}
