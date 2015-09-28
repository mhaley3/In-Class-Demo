using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaraunt.Framework.Entities
{

        public class MenuCategory
        {
            [Key]//This attribut identifies the MenuCategoryID property as mapping to the PK
            public int MenuCategoryID { get; set; }
            [Required(ErrorMessage = "A Description is required (3-35 characters)")]
            [StringLength(35, MinimumLength = 5, ErrorMessage = "Descriptions must be from 5 to 35 characters in length")]
            public string Description { get; set; }

            // Navigation Properties
            public virtual ICollection<Item> Items { get; set; }
        }
    
}
