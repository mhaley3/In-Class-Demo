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
            public string Description { get; set; }
            // Navigation Properties
            public virtual ICollection<Item> Items { get; set; }
        }
    
}
