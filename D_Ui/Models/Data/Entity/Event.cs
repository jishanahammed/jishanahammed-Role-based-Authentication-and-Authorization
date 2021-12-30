using System;
using System.Collections.Generic;

namespace D_Ui.Models.Data.Entity
{
    public class Event:BaseEntity
    {
        public Event()
        {
            EventApplications = new HashSet<EventApplication>();
        }
        public string Name { get; set; }
        public string Driscription { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual ICollection<EventApplication> EventApplications { get; set; }
    }
}
