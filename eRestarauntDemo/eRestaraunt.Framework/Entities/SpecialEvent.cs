using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaraunt.Framework.Entities
{
    public class SpecialEvent
    {
        [Key]
        [Required(ErrorMessage = "An event code is RequiredAttribute (one character)")]
        [StringLength(1, ErrorMessage = "Event Codes can only be used as a single character code")]
        public string EventCode { get; set; }

        [Required()]
        [StringLength(30, MinimumLength = 5)]
        public string Description { get; set; }
        public bool Active { get; set; }

        // Navigation Properties
        public virtual ICollection<Reservations> Reservations { get; set; }

        public SpecialEvent()
        {
            // For all new special events, there is a business rule stating they should automatically be set to active. 
            //(Similar to having a Default constraint in a database)
            Active = true;
            // To avoid null reference errors for our navigation property
            Reservations = new HashSet<Reservations>();
        }
    }
        

}
