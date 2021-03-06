﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaraunt.Framework.Entities
{
    public class Bills
    {
        [Key]

        public int BillID { get; set; }
        public DateTime BillDate { get; set; }
        public TimeSpan OrderPlaced { get; set; }
        public TimeSpan OrderReady { get; set; }
        public TimeSpan OrderServed { get; set; }
        public TimeSpan OrderPaid { get; set; }
        public int NumberInParty { get; set; }
        public bool PaidStatus { get; set; }
        public int WaiterID { get; set; }
        public int TableID { get; set; }
        public int ReservationID { get; set; }
        public string Comment { get; set; }

        //Navigation Properties
        public virtual ICollection<BillItems> Items { get; set; }
        public virtual Waiters Waiter { get; set; }
        public virtual Tables Table { get; set; }

        public Bills()
        {
            BillDate = DateTime.Now;
        }


    }
}
