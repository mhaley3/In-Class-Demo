using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaraunt.Framework.Entities
{
    public class BillItems
    {
        // The database table that this will map to has a composite primary key
        [Key, Column(Order = 1)]
        public int BiilID { get; set; }
        [Key, Column(Order = 2)]
        public int ItemID { get; set; }

        // Quantity must be a minimum of 1 and a maximum of 20
        [Required(), Range(1, 20)]
        public int Quantity { get; set; }

        // Sale price is between $0 and $50 inclusive
        [Required, Range(0.00, 50.00)]
        public decimal SalePrice { get; set; }

        // Unit cost is between 0.01 and 30.00
        [Required, Range(0.01, 50.00)]
        public decimal UnitCost { get; set; }
        public string Notes { get; set; }

        // Navigation Properties

        public virtual Bills Bills { get; set; }
        public virtual Item Items { get; set; }

    }
}
