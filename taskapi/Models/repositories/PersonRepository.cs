using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using task.DataContext;

namespace task.Model.repositories
{
    public class PersonRepository : ITaskRepository<Person>
    {
        taskDbContext db;
        public PersonRepository(taskDbContext _db)
        {
            db = _db;
        }



        public  Person Add(Person entity)
        {
             db.persons.Add(entity);
             db.SaveChanges();
            return entity;
            
        }

        public  bool Delete(int id)
        {

            var appperson =  Find(id);
            if (appperson != null)
            {
                db.persons.Remove(appperson);
                 db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public  Person Find(int id)
        {
            var query =  db.persons.SingleOrDefault(b => b.Id == id);
            return query;
        }

        public List<Person> List()
        {
            return db.persons.ToList();
        }

        public Person Update(int Id, Person entity)
        {
            var target = Find(Id);
            if (target != null)
            {
                //  db.Entry(entity).State = EntityState.Modified;
                target.Name = entity.Name;
                target.email = entity.email;
                target.phone = entity.phone;
                db.Update(target);
                 db.SaveChanges();
                return entity;
            }
            else return entity;
        }
    }
}
