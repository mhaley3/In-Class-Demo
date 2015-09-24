using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaraunt.Framework.Entities
{
    public class Reservations
    {
        [Key]
        public int ReservationID { get; set; }
        public string CustomerName { get; set; }
        public DateTime ReservationDate { get; set; }
        public int NumberInParty { get; set; }
        public string ContactPhone { get; set; }
        public string ReservatrionStatus { get; set; }
        public string EventCode { get; set; }

        //Navigation Properties
        public virtual ICollection<Tables> Tables { get; set; }
        public virtual SpecialEvent SpecialEvent { get; set; }
    }
}
