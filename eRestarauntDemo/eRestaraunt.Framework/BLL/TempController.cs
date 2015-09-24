using eRestaraunt.Framework.DAL; // Access the DAL class
using eRestaraunt.Framework.Entities; //Access the name space for my entity classes
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaraunt.Framework.BLL
{
    public class TempController
    {
        public List<MenuCategory> ListMenuCategories()
            {
                using(var context = new RestarauntContext())
                {
                    var data = from category in context.MenuCategories
                               select category;
                    return data.ToList();
                }
            }
    }
}
