using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel; //for [dataObject]
using eRestaraunt.Framework.DAL; // for RestaurantContext
using eRestaraunt.Framework.Entities; // for DB class entities
using System.Data.Entity;
using eRestaraunt.Framework.Entities.DTO; // for the lambda version of the include() method

namespace eRestaraunt.Framework.BLL
{
    [DataObject]
    public class MenuController
    {
      [DataObjectMethod(DataObjectMethodType.Select, false)]
      public List<CategoryDTO> ListMenuItems()
        {
          using (var context = new RestarauntContext())
          {
              var data = from cat in context.MenuCategories
                         orderby cat.Description
                         select new CategoryDTO() //use the DTO
                         {
                             Description = cat.Description,
                             MenuItems = from item in cat.Items
                                         where item.Active
                                         orderby item.Description
                                         select new MenuItemDTO // use the DTO
                                         {
                                             Description = item.Description,
                                             Price = item.CurrentPrice,
                                             Calories = item.Calories,
                                             Comment = item.Comment
                                         }
                         };
                         return data.ToList();
              //note: to use lambda or method style of include(), you need to have the following namespace reference:
              //use System.Data.Entity;
              //the Include() method on the Dbset<T> class peforms "eager loading" of the data.
              //return context.Items.Include(it => it.MenuCategory).ToList();
          }
        }

    
    }
    
    
}
