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
        #region Manage Special Events
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

        [DataObjectMethod(DataObjectMethodType.Update, false)]
        public void UpdateSpecialEvent(SpecialEvent Item)
        {
            using (RestarauntContext context = new RestarauntContext())
            {
                //first attach the item to the dbContext collection
                var attached = context.SpecialEvents.Attach(Item);
                //second, get the entry for the existing data that should match for this specific special event
                var existing = context.Entry<SpecialEvent>(attached);
                //third, mark that the objects values have changed
                existing.State = System.Data.Entity.EntityState.Modified;
                //lastly, save changes
                context.SaveChanges();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public void DeleteSpecialEvent(SpecialEvent Item)
        {
            using (var context = new RestarauntContext())
            {
                //first get a reference to the actual item in the db
            //find() is a method to lookup an item by its primary key
                var existing = context.SpecialEvents.Find(Item.EventCode);
                //second remove the item from the database context
                context.SpecialEvents.Remove(existing);
                    //lastly, save changes
                context.SaveChanges();
            }
            
        }
        [DataObjectMethod(DataObjectMethodType.Insert, false)]
        public void AddSpecialEvent(SpecialEvent Item)
        {
            using (var context = new RestarauntContext())
            {
                //add item to the dbContext
                var added = context.SpecialEvents.Add(Item);
                //we arent going to do anything with the variable 'added' Just be aware that Add() method will return the newly added object.
                //This can be useful in other situations

                //Save changes to the database
                context.SaveChanges();
            }
        }
    #endregion

        #region Manage Waiters
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Waiters> ListAllWaiters()
        {

            //This using statement ensures that our connection to the database is properly "closed" once we are done "using" our DAL object
            using (RestarauntContext context = new RestarauntContext())
            {
                return context.Waiters.ToList();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Update, false)]
        public void UpdateWaiter(Waiters Item)
        {
            using (RestarauntContext context = new RestarauntContext())
            {
                //first attach the item to the dbContext collection
                var attached = context.Waiters.Attach(Item);
                //second, get the entry for the existing data that should match for this specific special event
                var existing = context.Entry<Waiters>(attached);
                //third, mark that the objects values have changed
                existing.State = System.Data.Entity.EntityState.Modified;
                //lastly, save changes
                context.SaveChanges();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public void DeleteWaiter(Waiters Item)
        {
            using (var context = new RestarauntContext())
            {
                //first get a reference to the actual item in the db
                //find() is a method to lookup an item by its primary key
                var existing = context.Waiters.Find(Item.WaiterID);
                //second remove the item from the database context
                context.Waiters.Remove(existing);
                //lastly, save changes
                context.SaveChanges();
            }

        }

        [DataObjectMethod(DataObjectMethodType.Insert, false)]
        public void AddWaiter(Waiters Item)
        {
            using (var context = new RestarauntContext())
            {
                //add item to the dbContext
                var added = context.Waiters.Add(Item);
                //we arent going to do anything with the variable 'added' Just be aware that Add() method will return the newly added object.
                //This can be useful in other situations

                //Save changes to the database
                context.SaveChanges();
            }
        }


        #endregion
    }
    

    
}
