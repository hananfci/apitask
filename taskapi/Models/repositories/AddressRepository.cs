using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using task.DataContext;
using task.Model;
using task.Model.repositories;

namespace task.Models.repositories
{
    public class AddressRepository : ITaskRepository<Address>
    {
        taskDbContext db;
        public AddressRepository(taskDbContext _db)
        {
            db = _db;
        }



        public Address Add(Address entity)
        {
            db.addresses.Add(entity);
            db.SaveChanges();
            return entity;

        }

        public bool Delete(int id)
        {

            var appAddress = Find(id);
            if (appAddress != null)
            {
                db.addresses.Remove(appAddress);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public Address Find(int id)
        {
            var query = db.addresses.SingleOrDefault(b => b.Id == id);
            return query;
        }

        public List<Address> List()
        {
            return db.addresses.ToList();
        }

        public Address Update(int Id, Address entity)
        {
            var target = Find(Id);
            if (target != null)
            {
                //  db.Entry(entity).State = EntityState.Modified;
                target.streetName = entity.streetName;
                target.personId = entity.personId;
                db.Update(target);
                db.SaveChanges();
                return entity;
            }
            else return entity;
        }

    }
}
