using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eRestaraunt.Framework.DAL;
using eRestaraunt.Framework.Entities;
using System.ComponentModel; // needed for [dataobject] and related attribute classes

namespace eRestaraunt.Framework.BLL
{

    //Allows our class to be "discovered by the ObjectDataSource controls in our website
    [DataObject]

    public class RestaurantAdminController
    {
        //ObjectDataSource control will do the background communication for CRUD operations
        //Allows the ObjectDataSource to see the method as something we can select from
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<SpecialEvent> ListAllSpecialEvents()
        {

            //This using statement ensures that our connection to the database is properly "closed" once we are done "using" our DAL object
            using (RestarauntContext context = new RestarauntContext())
            {
                return context.SpecialEvents.ToList();
            }
        }
    }
}
