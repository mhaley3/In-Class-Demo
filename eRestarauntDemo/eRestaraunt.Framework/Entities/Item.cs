using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaraunt.Framework.Entities
{
    public class Item
    {
        [Key]
        public int ItemID { get; set; }
        [Required()]
        [StringLength(35, MinimumLength = 5)]

        public string Description { get; set; }

        //use decimal for the sql money data type
        [Range(.01, 50)]
        public decimal CurrentPrice { get; set; }

        [Range(.01, 30)]
        public decimal CurrentCost { get; set; }
        public bool Active { get; set; }

        [Range(0, int.MaxValue)]
        public int? Calories { get; set; }
        public string Comment { get; set; }
        public int MenuCategoryID { get; set; }

        // Navigation Properties
        public virtual MenuCategory MenuCategory { get; set; }

        public Item()
        {
            Active = true;
        }

    }
}
